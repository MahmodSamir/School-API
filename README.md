# School .NET API 
  This is a simple School .NET Web API that provides Student, Departments, and Subjects.

## Architecture & Design Pattern:

  - Clean Architecture  
  - CQRS Design Pattern  
  - Generic Repository Design Pattern  
  - Mediator Design Pattern
  - Entity FrameWork

## using  

  - AutoMapper  
  - Localization  
  - Custom ControllerBase
  - Custom Routing
  - Status Code Objects

 ## Illustrations
   - Clean Architecture
       divide project into 5 projects referncing to each other starting from API ending with DATA
     ![CA](https://github.com/MahmodSamir/School-API/assets/63668000/1b0138cc-8597-4c0c-84cb-00f379268158)

   - CQRS Design Pattern
       organizing models structure into two main categories QUERY for read data drom database and COMMAND to write data into it.
      ![cqrs](https://github.com/MahmodSamir/School-API/assets/63668000/10c64def-fa09-4845-937b-da45205b1e38)

  - Generinc Repository Design Pattern
      having all standardized methods in a Igeneric repo interface implementing by generic repo and each specific model inherits both with its specific methods.
    ![Generic](https://github.com/MahmodSamir/School-API/assets/63668000/13673d74-e442-44d8-b287-e834643a45eb)

  - Mediator Design Pattern
      organizor to handle which request for which service 
    ![Mediator](https://github.com/MahmodSamir/School-API/assets/63668000/e82b6df8-176b-45b9-811a-bbba1745d07c)
  
