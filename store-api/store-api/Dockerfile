#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_URLS=https://+:443;http://+:80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["store-api.csproj", ""]
RUN dotnet restore "store-api.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "store-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet dev-certs https
RUN dotnet publish "store-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "store-api.dll"]