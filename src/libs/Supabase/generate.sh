install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://raw.githubusercontent.com/supabase/supabase/master/apps/docs/spec/api_v1_openapi.json

# Fix: Add base server URL (spec has empty servers array)
python3 -c "
import json
with open('openapi.yaml') as f:
    spec = json.load(f)

# The upstream OpenAPI 3.0 spec uses the OpenAPI 3.1 numeric form for
# exclusive bounds. Normalize those schemas before Microsoft.OpenApi reads them.
def normalize_exclusive_bounds(value):
    if isinstance(value, dict):
        for keyword, bound in (('exclusiveMinimum', 'minimum'), ('exclusiveMaximum', 'maximum')):
            exclusive_bound = value.get(keyword)
            if isinstance(exclusive_bound, (int, float)) and not isinstance(exclusive_bound, bool):
                value[bound] = exclusive_bound
                value[keyword] = True
        for child in value.values():
            normalize_exclusive_bounds(child)
    elif isinstance(value, list):
        for child in value:
            normalize_exclusive_bounds(child)

normalize_exclusive_bounds(spec)
spec['servers'] = [{'url': 'https://api.supabase.com'}]
with open('openapi.yaml', 'w') as f:
    json.dump(spec, f, indent=2)
"

autosdk generate openapi.yaml \
  --namespace Supabase \
  --clientClassName SupabaseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
