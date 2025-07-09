#!/bin/bash
set -e

# Example script for turning the current solution into a template
# 1. Replace namespaces/project names
find . -type f -name '*.cs' -o -name '*.csproj' -o -name '*.sln' \
  | xargs sed -i "s/lawyer\.api\.lawyers/${SolutionName}/g"

# 2. Rename folders and csproj files
mv lawyer.api.lawyers.application "${SolutionName}.Application"
mv lawyer.api.lawyers.domain "${SolutionName}.Domain"
mv lawyer.api.lawyers.datastore.mssql "${SolutionName}.Infrastructure"
mv lawyer.api.lawyers.webapi "${SolutionName}.WebApi"

mv "${SolutionName}.Application"/lawyer.api.lawyers.application.csproj "${SolutionName}.Application/${SolutionName}.Application.csproj"
mv "${SolutionName}.Domain"/lawyer.api.lawyers.domain.csproj "${SolutionName}.Domain/${SolutionName}.Domain.csproj"
mv "${SolutionName}.Infrastructure"/lawyer.api.lawyers.datastore.mssql.csproj "${SolutionName}.Infrastructure/${SolutionName}.Infrastructure.csproj"
mv "${SolutionName}.WebApi"/lawyer.api.lawyers.webapi.csproj "${SolutionName}.WebApi/${SolutionName}.WebApi.csproj"

# 3. Update assembly names and root namespaces
grep -rl '<TargetFramework>' *.csproj | while read file; do
  project="$(basename "$file" .csproj)"
  sed -i "0,/<PropertyGroup>/a\    <AssemblyName>${project}</AssemblyName>\n    <RootNamespace>${project}</RootNamespace>" "$file"
done

# 4. Inject tokens into the solution file
sed -i "s/lawyer\.api\.lawyers/${SolutionName}/g" lawyer.api.lawyers.sln
mv lawyer.api.lawyers.sln "${SolutionName}.sln"

# 5. Package as nupkg (zip)
zip -r cleanarch.nupkg . -x '*.git*'
