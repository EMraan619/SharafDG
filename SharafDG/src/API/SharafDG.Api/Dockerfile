#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/API/SharafDG.Api/SharafDG.Api.csproj", "src/API/SharafDG.Api/"]
COPY ["src/Infrastructure/SharafDG.Infrastructure/SharafDG.Infrastructure.csproj", "src/Infrastructure/SharafDG.Infrastructure/"]
COPY ["src/Core/SharafDG.Application/SharafDG.Application.csproj", "src/Core/SharafDG.Application/"]
COPY ["src/Core/SharafDG.Domain/SharafDG.Domain.csproj", "src/Core/SharafDG.Domain/"]
COPY ["src/Infrastructure/SharafDG.Identity/SharafDG.Identity.csproj", "src/Infrastructure/SharafDG.Identity/"]
COPY ["src/Infrastructure/SharafDG.Persistence/SharafDG.Persistence.csproj", "src/Infrastructure/SharafDG.Persistence/"]
RUN dotnet restore "src/API/SharafDG.Api/SharafDG.Api.csproj"
COPY . .
WORKDIR "/src/src/API/SharafDG.Api"
RUN dotnet build "SharafDG.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SharafDG.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SharafDG.Api.dll"]
