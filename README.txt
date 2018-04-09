
# PartyInvites
An ASP.NET class project


# Notes & Reference
~USING a database isn't required in the assignment, you can use a defaultConnection <connectionstring> and no DAL folder since we're passing data by strongly-typed views.

He still wants us to make it though

                                                         #Creating a context file for database
                                                         
>Create a DAL Folder in the directory
>Create a NAME_OF_CONTEXT_FILE.cs file in DAL

~Generic Example
  ~
  using MVC_APP.Models;
  using System.Data.Entity;
  namespace MVC_APP.DAL{
        public class YourContextClass:DbContext{  //YourContext class inherits from ASP.NET DbContext
          public DbSet<Model_Object_0> ModelObjects0 { get; set; }
          public DbSet<Model_Object_1> ModelObjects1 { get; set; }
        }
  }
  
~Party Invites
  ~
  using PartyInvitesSheilferZepeda.Models; //create a db based off models you select
  using System.Data.Entity;
  namespace PartyInvitesSheilferZepeda.DAL{
        public class InviteContext:DbContext{  //YourContext class inherits from ASP.NET DbContext
          public DbSet<GuestResponse> GuestResponses { get; set; }

        }
  }
  


                                            #Creating Connection String for database context
                                                        
~Generic Example 
  ~ 
  <connectionStrings
    <add name="defaultConnection"
     connectionString = "DataSource = (LocalDB)\MSSQLLocalDB;
     AttachDbFilename=|DataDirectory|\NAME_OF_MVC_APP.mdf;
     Initial Catalog=NAME_OF_MVC_APP;
     Integrated Security=True" providerName="System.Data.SqlClient" />
  </connectionStrings>
  
 ~Party Invites 
  ~
   <connectionStrings
    <add name="InviteContext"
     connectionString = "DataSource = (LocalDB)\MSSQLLocalDB;
     AttachDbFilename=|DataDirectory|\PartyInvitesSheilferZepeda.mdf;
     Initial Catalog=PartyInvitesSheilferZepeda;
     Integrated Security=True" providerName="System.Data.SqlClient" />
  </connectionStrings>



         
         #Adding migration updates to database
         https://msdn.microsoft.com/en-us/library/jj591621(v=vs.113).aspx

Install the Entity Framework from the NuGet Package Manager
Project -> Manage NuGet Packages

>Tools -> NuGet Package Manager -> console
>Type this into Package Manager Console 

  enable-migrations
  add-migration initialcreate
  
  >create a new file
  
  add-migration AddNewFile
  Update-Database
  
  

                                                      
                                                      
                                                      
