# Store API

This project is built to use docker out of the box. The project is designed to use the following technologies...

- Angular
- @NgRx/Data
- .NET Core 3.x
- EF Core 3.x
- EF Code First

## Ports Used

The store project uses several ports [^1] based on services. The following is a list of those ports.

| Port Number | Service             |
| :---------: | :------------------ |
|    8000     | Web App (Angular)   |
|    5000     | Web API (.NET Core) |
|    15592    | SQL Server          |

These ports are are external ports used to allow interaction for the development of the application. In a production environment, SQL Server would not be exposed externally.

## Getting Started

To get started, simply run the following commands...

### Web Project

Before attempting to run the project, you will want to be sure to rum the "npm i" command in the store.web project folder.

### Get Your Motor Running

To run the Docker project, simply run the following command from PowerShell...

```powershell
docker-compose up -d
```

The '-d' flag will detach the Docker container from the terminal window. You can use the following command to shutdown the container.

```powershell
docker-compose down
```

### Final Instructions

When running the web project, you will need to set in the browser to accept the API project's self signed certificate. This can be done by opening the API url (https://localhost:5000/api/product/) in a browser tab and click the button to accept the certificate as is. Once this is done, you should be able to navigate to the web application and add/remove products as needed. Be sure to check your browser dev tools network tab for any possible errors.

[^1]: These are external facing ports. Docker uses internal ports and networking for communication. These can be seen by inspecting the Docker files. You can also observe these settings from the Docker manager window in Windows.
