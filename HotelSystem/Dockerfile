FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HotelSystem/HotelSystem.csproj", "HotelSystem/"]
RUN dotnet restore "HotelSystem/HotelSystem.csproj"
COPY . .
WORKDIR "/src/HotelSystem"
RUN dotnet build "HotelSystem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HotelSystem.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HotelSystem.dll"]
