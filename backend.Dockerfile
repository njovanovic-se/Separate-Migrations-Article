FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BLD_CONFIG=Release
WORKDIR /src
COPY . .
RUN dotnet build ./Article.API/Article.API.csproj -c $BLD_CONFIG -o /app/build && \
    dotnet publish ./Article.API/Article.API.csproj -c $BLD_CONFIG -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT [ "dotnet", "Article.API.dll" ]