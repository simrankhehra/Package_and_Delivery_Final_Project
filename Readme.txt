1. Open the Solution in Visual Studio
2. Build the project 
3. Navigate to tools ans select Nuget Package manager -> Package Manager Console (PMC)
4. On the console execute the following command
 Update-Database -Context Package_and_Delivery_IdentityContext


5. On the console execute the following command

 Update-Database -Context Package_and_Delivery_Context



6. After migration is successful Run the project 

7 if you login as admin  from the following credentials will be able to see the Senders,  
Couriers  and Packages Links. Onnly admin can Add delete and update Couriers , Packages and senders

User : admin@package.com
Password: 1qaz2wsX@

8. Also you can login with the following credentials to visit the site as a Sender
 Can Place Package delivery requests. You can also register a sender with Sign up as a sender link

 User : greg@package.com
Password: 1qaz2wsX@



9 if you need to create another  admin login with the admin credentials on step 7 above and
Click in "REGISTER Delivery admin" register a new admin 





The identity  authentication code used in the project were obtained by following URLS

Introduction to Identity on ASP.NET Core
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-3.0&tabs=visual-studio
