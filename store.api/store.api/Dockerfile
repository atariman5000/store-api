FROM mcr.microsoft.com/dotnet/core/sdk:3.1

ENV DOTNET_USE_POLLING_FILE_WATCHER 1

WORKDIR /app
COPY . .
ENTRYPOINT dotnet watch run  --urls=https://+:5001 --project store.api.csproj