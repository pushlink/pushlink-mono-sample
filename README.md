# Pushlink - Monodroid - Sample

## Usage

Clone and run *(tested with Xamarin Studio)*

## Updating to a new version

1. [Download](https://www.pushlink.com/docs.xhtml#monodroid) the latest `PushLinkMono-x.x.x.dll` and paste it in the PushLinkMonoSample folder. (side-by-side the old PushLinkMono.dll)
2. Delete the old `PushLinkMono.dll`
3. **Rename** `PushLinkMono-x.x.x.dll` to `PushLinkMono.dll` (needed)
4. Change the `yourApiKey` and `yourDeviceId` in `MainActivity.cs`

## Code Sample

```csharp
//C# for MonoDroid

using Com.Pushlink.Android;
...
PushLink.Start(this, Resource.Drawable.Icon, "yourApiKey", "yourDeviceID");
```

## Help & Support

Always feel free to drop a line to support at pushlink dot com or visit our [support](https://www.pushlink.com/support.xhtml).
