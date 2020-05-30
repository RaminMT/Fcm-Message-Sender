# Fcm Message Sender
A simple and basic .net core console app that eases sending FCM push notifications

# Usage
To use this app:
1. Grab a published binary from [release](https://github.com/RaminMT/Fcm-Message-Sender/releases).
2. Modify `runtimeconfig.json` and add your FCM key/token to `FcmKey` property.
3. Fill `Message` property with your desired message model properties.
4. Run!

# Build
To build the source code follow the steps:
1. Clone the repo.
2. Restore Nuget packages (`dotnet restore`).
3. Build & run (`dotnet run`).