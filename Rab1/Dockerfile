FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Rab1.csproj", "./"]
RUN dotnet restore "Rab1.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "Rab1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rab1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rab1.dll"]
