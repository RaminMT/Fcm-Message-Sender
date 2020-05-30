# Fcm Message Sender
A simple and basic .net core console app that eases sending FCM push notifications

# Usage
To use this app:
1. Grab a published binary from [release](https://github.com/RaminMT/Fcm-Message-Sender/releases).
2. Modify `appdata.json` file.
```
{
  "FcmKey": null, // string, FCM push notification sending token/key.
  "Message": {
    "To": null, // string, DeviceId of notification receiver.
    "RegistrationIds": [], // string[], List/Array of DeviceIds.
    "Condition": null, // string
    "CollapseKey": null, //string
    "Priority": 0, // int, 0 for normal priority and 1 for high priority
    "ContentAvailable": null, // nullable bool
    "TimeToLive": null, // nullable byte
    "RestrictedPackageName": null, // string
    "DryRun": null, // nullable bool
    "Data": {}, // mixed, Additional data
    "Notification": {
      "Title": null, // string
      "Body": null, // string
      "Icon": null, // string
      "ClickAction": null, // string
      "Sound": null, // string
      "Badge": null, // string
      "Color": null, // string
      "Tag": null, // string
      "BodyLocalizationKey": null, // string
      "BodyLocalizationArguments": [], // string[]
      "TitleLocalizationKey": null, // string
      "TitleLocalizationArguments": [] // string[]
    }
  }
}
```

3. Run!

# Build
To build the source code follow the steps:
1. Clone the repo.
2. Restore Nuget packages (`dotnet restore`).
3. Build & run (`dotnet build`).
 