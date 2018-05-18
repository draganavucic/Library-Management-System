# Library Management System

Desktop application is developed in C# and it is used as administration part in the library. Administrators use it for managing users and books in the library.

Web application is developed as MVC C# application and users use it for viewing available books and information about them in the library.

Both applications are using the same database which is Neo4j in this case.

Folder *ELibraryDesktopApp* contains Visual Studio source code for desktop application and *ELibraryWebApp* folder contains source code for web application. Database can be found in *default.graphdb* folder.

## Database

Neo4j is a graph database and after configuration it can be accessed by browser:
```sh
127.0.0.1:7474
```
![alt tag](https://imgur.com/cEZYqnh.png)

### Desktop application

Small preview of desktop application where administrator is searching for library users is shown below.

![alt tag](https://imgur.com/qXGywCY.png)

### Web application

On the next image Web application is running and user is searching for books and checking rating and users's comments on chosen book.

![alt tag](https://imgur.com/9yJNHML.png)

License
----

Dragana Vučić, Faculty of Electronic Engineering, University of Niš

**Contact or feedback on: dragana.vucic@live.com**
