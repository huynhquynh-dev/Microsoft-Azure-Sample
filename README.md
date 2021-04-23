# Tutorial project

## Catalog
    Build project -> publish
    Đăng ký VM
    Tắt firewall
    Copy source vào folder C:\catalog
    Cấu hình web trong server management

## inventory
    Đăng ký VM linux
    Git clone source code repository
    install nodejs, npm ( sudo apt install and update)
    Run: cd node-module and npm start

## Cart
    Build dockerfile
    Mở Đăng ký trong Azure Container trên portal
    Đăng ký Azure Container
    Push docker lên azure
    Run lệnh: 
        az aks create --resource-group readit-app-rg --name cart-aks --node-count 1 --generate-ssh-keys --attach-acr readitacrlionhuynh --node-vm-size Standard_B2ms
        az aks install-cli
        az aks create --resource-group readit-app-rg --name cart-aks --node-count 1 --generate-ssh-keys --attach-acr readitacrlionhuynh --node-vm-size Standard_B2s
        az aks install-cli
        set PATH=%PATH%;"C:\Users\huynh\.azure-kubectl"
        az aks get-credentials --resource-group readit-app-rg --name cart-aks
        kubectl get nodes

        Change name image in file deployment.yaml
        kubectl apply -f deployment.yaml

## Order
    dotnet restore
    
    Create function app on azure:
        az storage account create --name readitfunstoragelion --location southeastasia --resource-group readit-app-rg --sku Standard_LRS
    
        az functionapp create --name readitfunclion --storage-account readitfunstoragelion --consumption-plan-location southeastasia --resource-group readit-app-rg --functions-version 3

    deploy function from local to azure function
    upload settings