FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
ENV DOTNET_ENVIRONMENT=Docker
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["${SolutionName}.WebApi/${SolutionName}.WebApi.csproj", "${SolutionName}.WebApi/"]
COPY ["${SolutionName}.Application/${SolutionName}.Application.csproj", "${SolutionName}.Application/"]
COPY ["${SolutionName}.Domain/${SolutionName}.Domain.csproj", "${SolutionName}.Domain/"]
COPY ["${SolutionName}.Infrastructure/${SolutionName}.Infrastructure.csproj", "${SolutionName}.Infrastructure/"]
RUN dotnet restore "${SolutionName}.WebApi/${SolutionName}.WebApi.csproj"
COPY . .
WORKDIR "/src/${SolutionName}.WebApi"
RUN dotnet build "./${SolutionName}.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./${SolutionName}.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "${SolutionName}.WebApi.dll"]
