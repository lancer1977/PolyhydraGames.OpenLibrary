#!/usr/bin/env bash
set -euo pipefail

repo_root="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
solution_projects=(
  "$repo_root/PolyhydraGames.OpenLibrary.Test/PolyhydraGames.OpenLibrary.Test.csproj"
  "$repo_root/PolyhydraGames.OpenLibrary/PolyhydraGames.OpenLibrary.csproj"
  "$repo_root/PolyhydraGames.OpenLibrary.Data.Dapper/PolyhydraGames.OpenLibrary.Data.Dapper.csproj"
)

dotnet restore "${solution_projects[@]}"
dotnet test "$repo_root/PolyhydraGames.OpenLibrary.Test/PolyhydraGames.OpenLibrary.Test.csproj" --no-restore
dotnet pack "$repo_root/PolyhydraGames.OpenLibrary/PolyhydraGames.OpenLibrary.csproj" -c Release --no-restore -o "$repo_root/artifacts"
dotnet pack "$repo_root/PolyhydraGames.OpenLibrary.Data.Dapper/PolyhydraGames.OpenLibrary.Data.Dapper.csproj" -c Release --no-restore -o "$repo_root/artifacts"

if [[ "${PUBLISH_NUGETORG:-false}" == "true" || "${PUBLISH_NUGETORG:-0}" == "1" ]]; then
  for package in "$repo_root"/artifacts/*.nupkg; do
    dotnet nuget push "$package" --source https://api.nuget.org/v3/index.json --api-key "${NUGET_API_KEY:?Set NUGET_API_KEY to publish to nuget.org}"
  done
else
  for package in "$repo_root"/artifacts/*.nupkg; do
    dotnet nuget push "$package" --source "https://nuget.pkg.github.com/${GITHUB_REPOSITORY_OWNER:-lancer1977}/index.json" --api-key "${GITHUB_TOKEN:?Set GITHUB_TOKEN to publish to GitHub Packages}"
  done
fi
