FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
ENV DOTNET_ENVIRONMENT=Docker
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["lawyer.api.shared.webapi/lawyer.api.shared.webapi.csproj", "lawyer.api.shared.webapi/"]
COPY ["lawyer.api.shared.application/lawyer.api.shared.application.csproj", "lawyer.api.shared.application/"]
COPY ["lawyer.api.shared.domain/lawyer.api.shared.domain.csproj", "lawyer.api.shared.domain/"]
COPY ["lawyer.api.shared.datastore.mssql/lawyer.api.shared.datastore.mssql.csproj", "lawyer.api.shared.datastore.mssql/"]
RUN dotnet restore "lawyer.api.shared.webapi/lawyer.api.shared.webapi.csproj"
COPY . .
WORKDIR "/src/lawyer.api.shared.webapi"
RUN dotnet build "./lawyer.api.shared.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./lawyer.api.shared.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lawyer.api.shared.webapi.dll"]
