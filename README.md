## Table of contents  
1. [Project description](#1-Project-description)  
2. [Entity-relationship diagram](#2-Entity-relationship-diagram)   
3. [Internal specification](#3-Internal-specification)  
* 3.1. [Client-side application](#31-Client-side-spplication)
  * 3.1.1. [Frameworks](#311-Frameworks)  
  * 3.1.2. [Libraries](#312-Libraries)  
* 3.2. [Server-side application](#32-Server-side-spplication)
  * 3.2.1. [Frameworks](#321-Frameworks)  
  * 3.2.2. [Libraries](#322-Libraries)  
  * 3.2.3. [Database](#322-Database)  
4. [External specification](#4-External-specification)  
* 4.1. [Screenshots](#41-Screenshots)  
* 4.2. [GIFs](#42-GIFs)

## Table of contents  
1. [Project description](#1-Project-description)  
2. [Entity-relationship diagram](#2-Entity-relationship-diagram)   
3. [Internal specification](#3-Internal-specification)  
  3.1. [Client-side application](#31-Client-side-spplication)
    3.1.1. [Frameworks](#311-Frameworks)  
    3.1.2. [Libraries](#312-Libraries)  
  3.2. [Server-side application](#32-Server-side-spplication)
    3.2.1. [Frameworks](#321-Frameworks)  
    3.2.2. [Libraries](#322-Libraries)  
    3.2.3. [Database](#322-Database)  
4. [External specification](#4-External-specification)  
  4.1. [Screenshots](#41-Screenshots)  
  4.2. [GIFs](#42-GIFs)

# 1. Project description  
The project involved creating an application that would serve as an online database for movies, TV shows, and the actors starring in them. Being aware of the existence of similar solutions on the market, it was decided to take inspiration from the Polish website [Filmweb](https://www.filmweb.pl/), which is the second-largest film and cinema-related website in the world. The primary objectives during the project were: enabling user login and registration, allowing users to browse movies, TV shows, and the actors featured in them, allowing logged-in users to rate and write reviews, as well as creating new threads on the discussion forum and responding to them. Additionally, the project required the use of three technologies related to the .NET platform developed by Microsoft.

# 2. Entity-relationship diagram
![ERD](https://github.com/user-attachments/assets/c54c751f-f7f5-4a92-b46b-422aea4db957)

# 3. Internal specification

## 3.1. Client-side application

### 3.1.1. Frameworks
- **Vue.js** – An open-source framework based on the MVVM (Model-View-ViewModel) architectural pattern, enabling the creation of web applications compliant with the SPA (Single Page Application) model.
- **TailwindCSS** – An open-source CSS framework that facilitates styling HTML elements by providing a set of predefined classes.

### 3.1.2. Libraries
- **Axios** – An open-source JavaScript library based on the Promise object, allowing for asynchronous HTTP requests.
- **Vuex** – An open-source programming library that serves as the official extension to the Vue.js framework, facilitating state management in applications.

## 3.2. Server-side application

### 3.2.1. Frameworks
- **ASP.NET Core** – An open-source, cross-platform framework used for building web applications.

### 3.2.2. Libraries
- **Entity Framework Core** – An open-source, cross-platform object-relational mapping (ORM) tool.
- **ASP.NET Core Identity** – An open-source, cross-platform library for managing user identities, facilitating the implementation of authentication and authorization processes in web applications.
- **Microsoft.AspNetCore.Authentication.JwtBearer** – A library providing authentication and authorization mechanisms based on JWT (JSON Web Token).

### 3.2.3. Database
- **MySQL** – An open-source relational database management system currently developed by Oracle.

# 4. External specification

## 4.1. Screenshots
![login_view](https://github.com/user-attachments/assets/638d9ea5-51d8-40cd-9a00-d00fb6fb3b50)
![signup_view](https://github.com/user-attachments/assets/466042fd-63c4-40d0-971e-f4ce5c696a30)
![movie_list_view](https://github.com/user-attachments/assets/c39720eb-8f6a-4cc8-a420-f36ec7d49fbf)
![movie_view](https://github.com/user-attachments/assets/60bb70ae-90f0-4753-b81b-78b6a6cd48cf)
![review_dialog](https://github.com/user-attachments/assets/24322b99-58e5-42d4-a531-45098846b341)
![forum_list_view](https://github.com/user-attachments/assets/f6654569-e22b-4db0-ac4a-d7c3f13c4614)
![forum_view](https://github.com/user-attachments/assets/d68c4318-ede0-427d-a815-7a038181204d)

## 4.2. GIFs
> [!WARNING]
> The speed of GIF animations may not correspond to the actual speed of the application.

![logging_into_account](https://github.com/user-attachments/assets/05d94535-0c15-4baf-aa4e-3f316244f65e)
![signing_up](https://github.com/user-attachments/assets/ca34fd48-4b8c-4f11-94b0-a872b458cb51)
![poster_animation](https://github.com/user-attachments/assets/58adb7c7-3785-4ea2-8257-9053c11a5810)
![picture_slider](https://github.com/user-attachments/assets/d8408c6d-6c73-4526-a4b8-6d8038e89754)
![browsing_forum_list](https://github.com/user-attachments/assets/99bfd8ee-fa9d-4fe2-9781-1172797e564c)
