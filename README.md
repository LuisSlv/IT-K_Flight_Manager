# IT-K_Flight_Manager
This repo is a website built with Visual Studio and based on ASP.NET MVC.
It's a team project for building a website for an airplane company.
Selling tickets, view flights and flight times. Also, there is an Admin role that
is given to the first user created on the site. Every other user has a lesser role than the admin.
Every role besides guests has a panel with which they can do certain actions

Admin privliges:
Can view and C.R.U.D Flights and Users

User privileges:
Can only look and book flights.

The project uses an SQL database.
The specifics of which are:
Users:
Every user has its password Hashed
And The role part is binary.

Flights:
Every flight has a: Capitan, takeoff and landing time also value for passenger seats(first and business class)
Those Values can be changed from the Admin role, from its panel.

Because the project is ASP.NET MVC based, two-factor authentication can functionality can also be added.
