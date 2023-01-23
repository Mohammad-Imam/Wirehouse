FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/Warehouse.Web.Host/Warehouse.Web.Host.csproj", "src/Warehouse.Web.Host/"]
COPY ["src/Warehouse.Web.Core/Warehouse.Web.Core.csproj", "src/Warehouse.Web.Core/"]
COPY ["src/Warehouse.Application/Warehouse.Application.csproj", "src/Warehouse.Application/"]
COPY ["src/Warehouse.Core/Warehouse.Core.csproj", "src/Warehouse.Core/"]
COPY ["src/Warehouse.EntityFrameworkCore/Warehouse.EntityFrameworkCore.csproj", "src/Warehouse.EntityFrameworkCore/"]
WORKDIR "/src/src/Warehouse.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Warehouse.Web.Host", "src/Warehouse.Web.Host"]
COPY ["src/Warehouse.Web.Core", "src/Warehouse.Web.Core"]
COPY ["src/Warehouse.Application", "src/Warehouse.Application"]
COPY ["src/Warehouse.Core", "src/Warehouse.Core"]
COPY ["src/Warehouse.EntityFrameworkCore", "src/Warehouse.EntityFrameworkCore"]
WORKDIR "/src/src/Warehouse.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Warehouse.Web.Host.dll"]
