# Car Maintenance Tracker (.NET MAUI)

A small .NET Multi-platform App UI (MAUI) app for iPhone and Android to manage car oil change activities.

## Features
- Add oil change activity entries (date, odometer, notes).
- Mark entries as completed/pending.
- Delete entries.
- Shows next suggested oil change mileage based on the latest completed activity (+5,000 mi default interval).

## Project structure
- `CarMaintenanceApp/` - MAUI application source.

## Build prerequisites
Install the .NET SDK with MAUI workloads:

```bash
dotnet workload install maui
```

## Run on iOS/Android
```bash
cd CarMaintenanceApp
dotnet build -f net8.0-android
dotnet build -f net8.0-ios
```

> In this execution environment, `dotnet` is not installed, so build commands were not executed here.
