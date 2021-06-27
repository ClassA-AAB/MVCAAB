FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["GithubLab/GithubLab.csproj", "GithubLab/"]
RUN dotnet restore "GithubLab/GithubLab.csproj"
COPY . .
WORKDIR "/src/GithubLab"
RUN dotnet build "GithubLab.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GithubLab.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GithubLab.dll"]
