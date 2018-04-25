# Getting started

API for Airlines

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (GlobalMilesAirlineAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Global%20Miles%20Airline%20API-CSharp&workspaceName=GlobalMilesAirlineAPI&projectName=GlobalMilesAirlineAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the GlobalMilesAirlineAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Global%20Miles%20Airline%20API-CSharp&workspaceName=GlobalMilesAirlineAPI&projectName=GlobalMilesAirlineAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Global%20Miles%20Airline%20API-CSharp&workspaceName=GlobalMilesAirlineAPI&projectName=GlobalMilesAirlineAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Global%20Miles%20Airline%20API-CSharp&workspaceName=GlobalMilesAirlineAPI&projectName=GlobalMilesAirlineAPI.Standard)

### 3. Add reference of the library project

In order to use the GlobalMilesAirlineAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Global%20Miles%20Airline%20API-CSharp&workspaceName=GlobalMilesAirlineAPI&projectName=GlobalMilesAirlineAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` GlobalMilesAirlineAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```GlobalMilesAirlineAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Global%20Miles%20Airline%20API-CSharp&workspaceName=GlobalMilesAirlineAPI&projectName=GlobalMilesAirlineAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Global%20Miles%20Airline%20API-CSharp&workspaceName=GlobalMilesAirlineAPI&projectName=GlobalMilesAirlineAPI.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

GlobalMilesAirlineAPIClient client = new GlobalMilesAirlineAPIClient();
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [MembersController](#members_controller)
* [FlightsController](#flights_controller)

## <a name="members_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesAirlineAPI.Standard.Controllers.MembersController") MembersController

### Get singleton instance

The singleton instance of the ``` MembersController ``` class can be accessed from the API Client.

```csharp
MembersController members = client.Members;
```

### <a name="create_recommend_a_new_member"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesAirlineAPI.Standard.Controllers.MembersController.CreateRecommendANewMember") CreateRecommendANewMember

> This endpoint allows to recommend a new member to airlines.


```csharp
Task<Models.NewMemberResponse> CreateRecommendANewMember(Models.NewMemberRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.NewMemberRequest();

Models.NewMemberResponse result = await members.CreateRecommendANewMember(body);

```


### <a name="create_member_search"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesAirlineAPI.Standard.Controllers.MembersController.CreateMemberSearch") CreateMemberSearch

> This endpoint allows to search a member on the airline system.


```csharp
Task<Models.MemberSearchResponse> CreateMemberSearch(Models.MemberSearchRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.MemberSearchRequest();

Models.MemberSearchResponse result = await members.CreateMemberSearch(body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="flights_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMilesAirlineAPI.Standard.Controllers.FlightsController") FlightsController

### Get singleton instance

The singleton instance of the ``` FlightsController ``` class can be accessed from the API Client.

```csharp
FlightsController flights = client.Flights;
```

### <a name="create_flight_status"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesAirlineAPI.Standard.Controllers.FlightsController.CreateFlightStatus") CreateFlightStatus

> This endpoint allows to search the status of flight.


```csharp
Task<Models.FlightStatusResponse> CreateFlightStatus(Models.FlightStatusRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.FlightStatusRequest();

Models.FlightStatusResponse result = await flights.CreateFlightStatus(body);

```


### <a name="create_flight_creation"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMilesAirlineAPI.Standard.Controllers.FlightsController.CreateFlightCreation") CreateFlightCreation

> This endpoint allows to create a flight on the system and defines the mileage rules for the passenger.


```csharp
Task<Models.Response> CreateFlightCreation(Models.FlightCreateRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.FlightCreateRequest();

Models.Response result = await flights.CreateFlightCreation(body);

```


[Back to List of Controllers](#list_of_controllers)



