FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
ENV DOTNET_ENVIRONMENT=Docker
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["lawyer.api.lawyers.webapi/lawyer.api.lawyers.webapi.csproj", "lawyer.api.lawyers.webapi/"]
COPY ["lawyer.api.lawyers.application/lawyer.api.lawyers.application.csproj", "lawyer.api.lawyers.application/"]
COPY ["lawyer.api.lawyers.domain/lawyer.api.lawyers.domain.csproj", "lawyer.api.lawyers.domain/"]
COPY ["lawyer.api.lawyers.datastore.mssql/lawyer.api.lawyers.datastore.mssql.csproj", "lawyer.api.lawyers.datastore.mssql/"]
RUN dotnet restore "lawyer.api.lawyers.webapi/lawyer.api.lawyers.webapi.csproj"
COPY . .
WORKDIR "/src/lawyer.api.lawyers.webapi"
RUN dotnet build "./lawyer.api.lawyers.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./lawyer.api.lawyers.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lawyer.api.lawyers.webapi.dll"]
