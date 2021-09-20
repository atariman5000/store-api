FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build

WORKDIR /src
COPY ["store.api/Store.API.csproj", "store.api/"]
COPY ["../store.dal/Store.DAL.csproj", "store.dal/"]
COPY ["../store.models/Store.Models.csproj", "store.models/"]

COPY . .
WORKDIR "/src/store.api"

# RUN dotnet tool install --global dotnet-ef
# ENV PATH="${PATH}:/root/.dotnet/tools"
# RUN dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.19
# RUN dotnet ef database update

ENTRYPOINT dotnet watch run  --urls=https://+:5001 --project store.api.csproj