FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/ProCarlosV1.Web.Host/ProCarlosV1.Web.Host.csproj", "src/ProCarlosV1.Web.Host/"]
COPY ["src/ProCarlosV1.Web.Core/ProCarlosV1.Web.Core.csproj", "src/ProCarlosV1.Web.Core/"]
COPY ["src/ProCarlosV1.Application/ProCarlosV1.Application.csproj", "src/ProCarlosV1.Application/"]
COPY ["src/ProCarlosV1.Core/ProCarlosV1.Core.csproj", "src/ProCarlosV1.Core/"]
COPY ["src/ProCarlosV1.EntityFrameworkCore/ProCarlosV1.EntityFrameworkCore.csproj", "src/ProCarlosV1.EntityFrameworkCore/"]
WORKDIR "/src/src/ProCarlosV1.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ProCarlosV1.Web.Host", "src/ProCarlosV1.Web.Host"]
COPY ["src/ProCarlosV1.Web.Core", "src/ProCarlosV1.Web.Core"]
COPY ["src/ProCarlosV1.Application", "src/ProCarlosV1.Application"]
COPY ["src/ProCarlosV1.Core", "src/ProCarlosV1.Core"]
COPY ["src/ProCarlosV1.EntityFrameworkCore", "src/ProCarlosV1.EntityFrameworkCore"]
WORKDIR "/src/src/ProCarlosV1.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ProCarlosV1.Web.Host.dll"]
