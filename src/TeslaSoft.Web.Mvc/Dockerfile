FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/TeslaSoft.Web.Mvc/TeslaSoft.Web.Mvc.csproj", "src/TeslaSoft.Web.Mvc/"]
COPY ["src/TeslaSoft.Web.Core/TeslaSoft.Web.Core.csproj", "src/TeslaSoft.Web.Core/"]
COPY ["src/TeslaSoft.Application/TeslaSoft.Application.csproj", "src/TeslaSoft.Application/"]
COPY ["src/TeslaSoft.Core/TeslaSoft.Core.csproj", "src/TeslaSoft.Core/"]
COPY ["src/TeslaSoft.EntityFrameworkCore/TeslaSoft.EntityFrameworkCore.csproj", "src/TeslaSoft.EntityFrameworkCore/"]
WORKDIR "/src/src/TeslaSoft.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TeslaSoft.Web.Mvc", "src/TeslaSoft.Web.Mvc"]
COPY ["src/TeslaSoft.Web.Core", "src/TeslaSoft.Web.Core"]
COPY ["src/TeslaSoft.Application", "src/TeslaSoft.Application"]
COPY ["src/TeslaSoft.Core", "src/TeslaSoft.Core"]
COPY ["src/TeslaSoft.EntityFrameworkCore", "src/TeslaSoft.EntityFrameworkCore"]
WORKDIR "/src/src/TeslaSoft.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TeslaSoft.Web.Mvc.dll"]
