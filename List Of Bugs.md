#Bugs you may encounter


#enable-migrations

-place the config section above the connection string in the config file

#add-migration initialcreate

-add a space in "Data Source" in web config connection string
-add [key] above your fields in your model if you're storing it in your DbContext. Then import Annotations.
