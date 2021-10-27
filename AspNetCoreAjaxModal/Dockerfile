FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["AspNetCoreAjaxModal/AspNetCoreAjaxModal.csproj", "AspNetCoreAjaxModal/"]
RUN dotnet restore "AspNetCoreAjaxModal/AspNetCoreAjaxModal.csproj"
COPY . .
WORKDIR "/src/AspNetCoreAjaxModal"
RUN dotnet build "AspNetCoreAjaxModal.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AspNetCoreAjaxModal.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AspNetCoreAjaxModal.dll"]