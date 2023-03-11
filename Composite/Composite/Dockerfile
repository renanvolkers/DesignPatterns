#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Composite/Composite.csproj", "Composite/"]
RUN dotnet restore "Composite/Composite.csproj"
COPY . .
WORKDIR "/src/Composite"
RUN dotnet build "Composite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Composite.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Composite.dll"]