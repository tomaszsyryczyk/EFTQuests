#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["EFT_Hud/EFT_Hud.csproj", "EFT_Hud/"]
COPY ["Quests/EFT_Hud.Quests.Services/EFT_Hud.Quests.Services.csproj", "Quests/EFT_Hud.Quests.Services/"]
COPY ["DAL/EFT_Hud.DAL.Entities/EFT_Hud.DAL.Entities.csproj", "DAL/EFT_Hud.DAL.Entities/"]
COPY ["Quests/EFT_Hud.Quests.Interfaces/EFT_Hud.Quests.Interfaces.csproj", "Quests/EFT_Hud.Quests.Interfaces/"]
COPY ["Merchants/EFT_Hud.Merchants.Services/EFT_Hud.Merchants.Services.csproj", "Merchants/EFT_Hud.Merchants.Services/"]
COPY ["Merchants/EFT_Hud.Merchants.Interfaces/EFT_Hud.Merchants.Interfaces.csproj", "Merchants/EFT_Hud.Merchants.Interfaces/"]
COPY ["DAL/EFT_Hud.DAL/EFT_Hud.DAL.csproj", "DAL/EFT_Hud.DAL/"]
COPY ["Locations/EFT_Hud.Locations.Interfaces/EFT_Hud.Locations.Interfaces.csproj", "Locations/EFT_Hud.Locations.Interfaces/"]
COPY ["Locations/EFT_Hud.Locations.Services/EFT_Hud.Locations.Services.csproj", "Locations/EFT_Hud.Locations.Services/"]
RUN dotnet restore "EFT_Hud/EFT_Hud.csproj"
COPY . .
WORKDIR "/src/EFT_Hud"
RUN dotnet build "EFT_Hud.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EFT_Hud.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EFT_Hud.dll"]