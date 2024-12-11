# Use the official .NET SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory inside the container
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["UwaziTech.csproj", "./"]
RUN dotnet restore

# Copy the rest of the application files
COPY . .

# Build the application in Release mode
RUN dotnet publish -c Release -o /app

# Use a smaller runtime image for deployment
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory for the runtime
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app .

# Expose the port on which the app will run
EXPOSE 80
EXPOSE 443

# Set the entry point for the container
ENTRYPOINT ["dotnet", "UwaziTech.dll"]
