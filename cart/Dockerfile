FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5004
ENV ASPNETCORE_URLS=http://+:5004

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["cart.csproj", "./"]
RUN dotnet restore "cart.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "cart.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cart.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cart.dll"]

# Build dockerfile
# Mở Đăng ký trong Azure Container trên portal
# Đăng ký Azure Container
# Push docker lên azure
# Run lệnh: az aks create --resource-group readit-app-rg --name cart-aks --node-count 1 --generate-ssh-keys --attach-acr readitacrlionhuynh --node-vm-size Standard_B2ms
# az aks install-cli
