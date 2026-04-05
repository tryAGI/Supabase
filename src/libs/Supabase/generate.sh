dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/supabase/supabase/master/apps/docs/spec/api_v1_openapi.json

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
