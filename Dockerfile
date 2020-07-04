#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Corona_Data_API/Corona_Data_API.csproj", "Corona_Data_API/"]
RUN dotnet restore "Corona_Data_API/Corona_Data_API.csproj"
COPY . .
WORKDIR "/src/Corona_Data_API"
RUN dotnet build "Corona_Data_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Corona_Data_API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Corona_Data_API.dll"]