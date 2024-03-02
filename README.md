# Sample Windows Service

This repository contains the source code for a sample Windows Service created using .NET 8. The service demonstrates how to set up a basic worker service, integrate with the Windows Service Control Manager (SCM), and implement logging using Serilog.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

1. Clone the repository

```bash
git clone https://github.com/tivole/sample-windows-service.git
```

2. Navigate to the project directory

```bash
cd sample-windows-service
```

3. Build the project

```bash
dotnet build
```

4. Publish the project

```bash
dotnet publish -o ./publish -c Release -p:PublishSingleFile=true
```

## Deploying the Service

1. Install the service using `sc.exe`:

```bash
sc create SampleService binPath= "C:\\path\\to\\publish\\SampleService.exe"
```

2. Start the service:

```bash
sc start "SampleService"
```

3. Stop the service:

```bash
sc stop "SampleService"
```

## Testing the Service

Check the `sample-service.log` file in the `publish` folder for log entries indicating the service is running.

## Acknowledgements

- [Create Windows Services using .NET 8.0 (Worker Service)](https://medium.com/@tivole/create-windows-services-using-net-8-0-worker-service-ea6b8f1f20a1)
