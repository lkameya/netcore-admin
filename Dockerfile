FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy and build
COPY . ./
RUN dotnet publish -c Release -o out

# Image build
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /.
COPY --from=build-env /app/out .

ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000

ENTRYPOINT ["dotnet", "netcore-admin.dll"]