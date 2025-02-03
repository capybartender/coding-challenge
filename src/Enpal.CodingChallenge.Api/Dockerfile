FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Enpal.CodingChallenge.Api/Enpal.CodingChallenge.Api.csproj", "src/Enpal.CodingChallenge.Api/"]
RUN dotnet restore "src/Enpal.CodingChallenge.Api/Enpal.CodingChallenge.Api.csproj"
COPY . .
WORKDIR "/src/src/Enpal.CodingChallenge.Api"
RUN dotnet build "Enpal.CodingChallenge.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Enpal.CodingChallenge.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Enpal.CodingChallenge.Api.dll"]
