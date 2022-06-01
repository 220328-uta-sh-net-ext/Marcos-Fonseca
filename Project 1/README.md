# Restaurant Review

## Overview
- The restaurant review application is a software that lets customers leave reviews for restaurants. Designed with functionality that would help choosing the next restaurant to eat at much easier! 

### Functionality 

- add a new user 
- ability to search user as admin
- display details of a restaurant for user
- add reviews to a restaurant as a user
- view details of restaurants as a user
- view reviews of restaurants as a user
- calculate reviews’ average rating for each restaurant 
- search restaurant (by name, rating, zip code, etc.) 
* server-side validation
* exception handling
* persistent data
* logging of exceptions

### Design

* ADO.Net for middleware either with connected or disconnected approach
* Azure SQL DB in third normal form; include a database diagram and the script to generate Db and tables.

### core / domain / business logic
* class library
* contains all business logic
* contains domain classes (restaurant/review/user)

### data access
* class library
* contains ADO.Net code
* contains data access logic but no business logic
* Repository pattern for separation of concerns


### Tech Stack 
- C# 
- Xunit or NUnit
- SQLServer DB 
- ADO.Net
- Asp.Net Core Web Api
- Azure App Service
- Serilog or Nlog (or any other logging frameworks) 
