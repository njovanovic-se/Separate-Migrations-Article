ARG DOTNET_RUNTIME=mcr.microsoft.com/dotnet/sdk:9.0
ARG BUILD_CONFIGURATION=Release

FROM ${DOTNET_RUNTIME} AS base
WORKDIR /app

COPY . .
RUN dotnet restore
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"
ENTRYPOINT dotnet ef database update --project Article.Migrations --startup-project Article.API