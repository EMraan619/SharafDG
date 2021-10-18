#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["test/SharafDG.API.IntegrationTests/SharafDG.API.IntegrationTests.csproj", "test/SharafDG.API.IntegrationTests/"]
COPY ["src/Infrastructure/SharafDG.Persistence/SharafDG.Persistence.csproj", "src/Infrastructure/SharafDG.Persistence/"]
COPY ["src/Core/SharafDG.Application/SharafDG.Application.csproj", "src/Core/SharafDG.Application/"]
COPY ["src/Core/SharafDG.Domain/SharafDG.Domain.csproj", "src/Core/SharafDG.Domain/"]
COPY ["src/API/SharafDG.Api/SharafDG.Api.csproj", "src/API/SharafDG.Api/"]
COPY ["src/Infrastructure/SharafDG.Infrastructure/SharafDG.Infrastructure.csproj", "src/Infrastructure/SharafDG.Infrastructure/"]
COPY ["src/Infrastructure/SharafDG.Identity/SharafDG.Identity.csproj", "src/Infrastructure/SharafDG.Identity/"]
RUN dotnet restore "test/SharafDG.API.IntegrationTests/SharafDG.API.IntegrationTests.csproj"
COPY . .
WORKDIR "/src/test/SharafDG.API.IntegrationTests"
RUN dotnet build "SharafDG.API.IntegrationTests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SharafDG.API.IntegrationTests.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SharafDG.API.IntegrationTests.dll"]
