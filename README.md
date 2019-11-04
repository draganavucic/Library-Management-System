# Library Management System

The desktop application is developed in C# and it is used as administration part in the library. Administrators use it for managing users and books in the library.

The web application is developed as MVC C# application and users use it for viewing available books and information about them in the library.

Both applications are using the same database which is Neo4j in this case.

Folder *ELibraryDesktopApp* contains Visual Studio source code for desktop application and *ELibraryWebApp* folder contains source code for the web application. The database can be found in *default.graphdb* folder.

## Database

Neo4j is a graph database and after configuration is done, it can be accessed by browser:
```sh
127.0.0.1:7474
```
![alt tag](https://imgur.com/cEZYqnh.png)

### Desktop application

A small preview of desktop application where an administrator is searching for library users is shown below.

![alt tag](https://imgur.com/qXGywCY.png)

### Web application

In the next image, the Web application is running and the user is searching for books and checking ratings and users' comments on the chosen book.

![alt tag](https://imgur.com/9yJNHML.png)

License
----

© 2019 Dragana Vučić, Faculty of Electronic Engineering, University of Niš
