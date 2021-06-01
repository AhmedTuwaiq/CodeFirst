FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CodeFirst/CodeFirst.csproj", "CodeFirst/"]
RUN dotnet restore "CodeFirst/CodeFirst.csproj"
COPY . .
WORKDIR "/src/CodeFirst"
RUN dotnet build "CodeFirst.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodeFirst.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeFirst.dll"]
