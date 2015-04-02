# Pushlink - Monodroid - Sample

## Usage

Clone and run *(tested with Xamarin Studio)*

## Updating to a new version

1 - Delete old jar and dll
2 - Download new jar and dll and paste it side-by-side 
3 - **Rename** the dll to PushLinkMono.dll (needed)
4 - Update the new jar reference into the project

## Code Sample

```csharp
//C# for MonoDroid

using Com.Pushlink.Android;
...
PushLink.Start(this, Resource.Drawable.Icon, "yourApiKey", "yourDeviceID");
```

## Help & Support

Always feel free to drop a line to support at pushlink dot com or visit our [support](https://www.pushlink.com/support.xhtml).
