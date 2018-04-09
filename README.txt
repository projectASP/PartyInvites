
# PartyInvites
An ASP.NET class project


# Notes & Reference



                                                         #Creating a context file for database
                                                         
>Create a DAL Folder in the directory
>Create a NAME_OF_CONTEXT_FILE.csto file in DAL

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
          public DbSet<Name> Names { get; set; }
          public DbSet<Phone> Phones { get; set; }
        }
  }
  
                                                         #Creating Connection String for database context
                                                        
~Generic Example 
  ~ 
  <connectionStrings
    <add name="NAME_OF_CONTEXT_FILE"
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
                                                      
                                                      
                                                      
