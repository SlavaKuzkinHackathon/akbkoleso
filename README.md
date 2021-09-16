  # akbkoleso
dotnet ef migrations add Initial --context AppIdentityDbContext  
dotnet ef migrations add Initial --context akbkolesoContext  
dotnet ef migrations add Initial --context akbkolesoCatalogContext  


dotnet ef database update --context AppIdentityDbContext  
dotnet ef database update --context akbkolesoContext  
dotnet ef database update --context akbkolesoCatalogContext  

dotnet ef database drop --context AppIdentityDbContext  
dotnet ef database drop --context akbkolesoContext  
dotnet ef database drop --context akbkolesoCatalogContext  

avtogradshina@mail.ru  
Aquafresh$123  
 
