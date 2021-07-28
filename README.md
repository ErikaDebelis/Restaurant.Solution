# (Application Name)

(Brief Description of Application)

#### Authored by Erika Debelis

## Technologies Used

* _C#_
* _MySQL_
*_MySQL Workbench_
*_.NET 5 SDK_
* _Git BASH_
* _ASP .NET CORE MVC_

## Setup/Installation Requirements

1. Download or clone the https://github.com/ErikaDebelis/(PROJECT NAME) to your local machine
2. Open git BASH terminal and navigate to the (CODE FOLDER NAME) of the directory
3. Run "dotnet restore" in the git BASH terminal to install dependencies
    ``$ dotnet restore``
4. CREATE APPSETTINGS.JSON FILE IN THE ROOT DIRECTORY AND ADD THE FOLLOWING CODE: 
``{``
  ``"ConnectionStrings": {``
      ``"DefaultConnection": "Server=localhost;Port=3306;database={YOUR_SCHEMA_NAME};uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"``
  ``}``
}``
REMOVE AND FILL IN YOUR SCHEMA, USERNAME, AND PASSWORD- (DO NOT INCLUDE THE CURLY BRACKETS)

5. CREATE DATABASE USING MYSQL WORKBENCH BY IMPORTING .SQL FILE FROM REPO

6. Run "dotnet run" in the git BASH terminal to  minify the code, and run the project in the terminal.
    ``$ dotnet watch run``
7. View the website by visiting localhost:5000/ in a new web browser( such as google chrome) tab!

## Bugs

_no known bugs at this time_

## License

_MIT_

_Copyright (c) 2021 Erika Debelis_

if any issues are discovered while navigating the site, please let me know! It will help me learn and grow!

## Contact Information

Erika Debelis _erika.debelis@gmail.com_