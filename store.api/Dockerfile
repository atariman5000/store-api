FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build

WORKDIR /src
COPY ["store.api/store.api.csproj", "store.api/"]
COPY ["../store.dal/store.dal.csproj", "store.dal/"]
COPY ["../store.models/store.models.csproj", "store.models/"]

COPY . .
WORKDIR "/src/store.api"
ENTRYPOINT dotnet watch run  --urls=https://+:5001 --project store.api.csproj