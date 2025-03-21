FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/TeslaSoft.Web.Host/TeslaSoft.Web.Host.csproj", "src/TeslaSoft.Web.Host/"]
COPY ["src/TeslaSoft.Web.Core/TeslaSoft.Web.Core.csproj", "src/TeslaSoft.Web.Core/"]
COPY ["src/TeslaSoft.Application/TeslaSoft.Application.csproj", "src/TeslaSoft.Application/"]
COPY ["src/TeslaSoft.Core/TeslaSoft.Core.csproj", "src/TeslaSoft.Core/"]
COPY ["src/TeslaSoft.EntityFrameworkCore/TeslaSoft.EntityFrameworkCore.csproj", "src/TeslaSoft.EntityFrameworkCore/"]
WORKDIR "/src/src/TeslaSoft.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TeslaSoft.Web.Host", "src/TeslaSoft.Web.Host"]
COPY ["src/TeslaSoft.Web.Core", "src/TeslaSoft.Web.Core"]
COPY ["src/TeslaSoft.Application", "src/TeslaSoft.Application"]
COPY ["src/TeslaSoft.Core", "src/TeslaSoft.Core"]
COPY ["src/TeslaSoft.EntityFrameworkCore", "src/TeslaSoft.EntityFrameworkCore"]
WORKDIR "/src/src/TeslaSoft.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TeslaSoft.Web.Host.dll"]
