FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["store.api/store.api.csproj", "store.api/"]
COPY ["store.dal/store.dal.csproj", "store.dal/"]
RUN dotnet restore "store.api/store.api.csproj"
COPY . .
WORKDIR "/src/store.api"
ENTRYPOINT dotnet watch run  --urls=https://+:5001 --project store.api.csproj
# RUN dotnet build "store.api.csproj" -c Release -o /app/build