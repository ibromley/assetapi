# Asset API

> A back-end web API built by 4 Informatics students at the University of Washington in partnership with Seattle Department of Transportation.

> This project aims to use data sources and take inspiration from Seattle [DOT's Asset Management Status and Condition Report](http://www.seattle.gov/Documents/Departments/SDOT/About/SDOT2015SCReportFinal12-7-2015.pdf) to create a public-facing tool for viewing and exploring this information.

## Team
- Patrick Smith, Project Manager
- Linh Tran, UX/UI Designer
- Iain Bromley, Developer
- Ryker Schwartzenberger, Developer

## Nuget Packages
- `Json.NET` - [Newtonsoft.Json](https://www.newtonsoft.com/json) package for high performance JSON manipulation

## Project Structure
- `/Controllers` - contains all routing
    - `AssetController.cs` - sets up API routes for given HTTP requests
- `/DataSources` - contains all static `.json` files
    - `asset-info.json` - current use case in client application
    - `test.json` - use in creating test json objects
- `/Models` - contains data models for all the objects
    - `AssetContext.cs` - provides global context for all helper methods
    - `AssetItem.cs` - defines objects (e.g. `AssetItem`, `DataPoint`) for json population
- `Program.cs` - first executed at runtime
- `Seeder.cs` - performs server-side logic of populating in memory objects from `.json` files
- `Startup.cs` - runs initial project configuration, and reads in `.json` files from disk

## Build Setup

You must have the .NET Core Runtime or SDK to build this project.
- [.NET Core 2.0.0 SDK](https://www.microsoft.com/net/core) or later 

### Development

``` bash
# Restore dependencies
dotnet restore

# Compiles and executes the .NET project
dotnet run

Hosting environment: Development
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

Sample API Call:

[http://localhost:5000/api/asset](http://localhost:5000/api/asset)

## API Reference

Base URL: `/api`

### All Assets

Lists all the assets in the system.

#### Request

> `GET /asset`

#### Response

```
[
    {"id":1,
    "name":"bike",
    "projectiondata":null,
    "assettitle":"Bike / Pedestrian System",
    "maintext":"This is the Bike asset lorum ipsum ...",
    "splashimage":null
    }
]
```
