#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Clients/NotesApp.WebClient/NotesApp.WebClient.csproj", "Clients/NotesApp.WebClient/"]
RUN dotnet restore "Clients/NotesApp.WebClient/NotesApp.WebClient.csproj"
COPY . .
WORKDIR "/src/Clients/NotesApp.WebClient"
RUN dotnet build "NotesApp.WebClient.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NotesApp.WebClient.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NotesApp.WebClient.dll"]