# Use the .NET 8.0 runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the .NET 8.0 SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Lab1.csproj", "Lab1/"]
RUN dotnet restore "Lab1.csproj"
COPY Lab1/. Lab1/
WORKDIR "/src/Lab1"
RUN dotnet build "Lab1.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "Lab1.csproj" -c Release -o /app/publish

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab1.dll"]
