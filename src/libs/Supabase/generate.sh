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
