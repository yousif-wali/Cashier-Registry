# Cashier-Registry

This Mini Project is made for mini markets.

It helps cashiers to check out their customers by scanning or entering the item id which is located on a database.
The app relies on REST APIs to communicate with the database. Thats being said, you will need some sort of database
either (Mysql, SQLServer, PostgreSQL) and you will need to make APIs based on your database credentials.
This app uses PHP-Mysql Database for its RESTApi system, but you can use other methods as well.

As this app works with Restfullness of Apis, you do not need to worry about exploiting your database credentials,
as long as you practice good database modeling.

The app is styleless, and open sourced, so feel free to add/remove/alter any functionalities or styles from this app.

Contents:

All main components rely in the MainPage.cs. It might seem to be lengthy, but no worries, I will show you what you need to alter
in order to make it your own. """ I have tried my best to practice DRY-coding, so bear with me """ Ponds intended.

Most of the codes are related to the GUI/designs of the main form.

Search Functionality and Updating Information is on line 170-187

Add Item Functionality is on line 209-237

Function to clear all inputs is on line 238-245

UpdateOutput function is on line 246-262

Delete Function is on line 273-292

You will need to know about these functions as you develop this app. They rely on Item class which is present in the app.
You have to change some of the properties if your database contains different elements.




Database:
to change the database direction to another source or API, you will need to configure variable "apiUrl" which is in Database.cs line 13
and you have to change class Item's property so it matches your API.


That's it 🥇😃
Have Fun!
