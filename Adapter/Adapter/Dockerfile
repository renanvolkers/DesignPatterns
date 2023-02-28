#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Adapter/Adapter.csproj", "Adapter/"]
RUN dotnet restore "Adapter/Adapter.csproj"
COPY . .
WORKDIR "/src/Adapter"
RUN dotnet build "Adapter.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Adapter.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Adapter.dll"]