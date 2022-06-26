# 👩‍💻 Animal Game Store
Console Application utilizing the Animal Crossing Web API.

## Introduction
The application is a Console Application running GET requests to the Animal Crossing API endpoints.

The project/solution consists of the following structure:

* AnimalGameStore
	* Contains the application files
* AnimalGameStoreTests
	* Contains the tests for the application

The API features which the Console application makes use of is:
* Get a single Fossil using the name as parameter.

The application has the flow:

* ask the user to input a name for a fossil to search 
* send the request with param to the API
* return the relevant JSON result to the console window

### Pre-Requisites
- C# / .NET 6
- NuGet

### Technologies & Dependencies
- .NET Core Console Application
- ASP.NET Core MVC 6
- NUnit testing framework
- Moq

### How to Get Started
- Fork this repo to your Github and then clone the forked version of this repo.

### Main Entry Point
- The Main Entry Point for the application is: [Program.cs](./BookManagerApi/Program.cs)

### Running the Unit Tests
- You can run the unit tests in Visual Studio, or you can go to your terminal and inside the root of this directory, run:

`dotnet test`

### Running the Application
- You can run the application in Visual Studio, or you can go to your terminal and inside the root of this directory, run:

`dotnet run`