# Mapbox Maps SDK for Xamarin.iOS

[![Build Status](https://dev.azure.com/SofteqDevelopment/mapbox-xamarin/_apis/build/status/mapbox-xamarin-ios-dev?branchName=master)](https://dev.azure.com/SofteqDevelopment/mapbox-xamarin/_build/latest?definitionId=58&branchName=master) [![Softeq.Mapbox.iOS](https://buildstats.info/nuget/Softeq.Mapbox.iOS?includePreReleases=true)](https://www.nuget.org/packages/Softeq.Mapbox.iOS)

Xamarin binding library for [Mapbox GL Native](https://github.com/mapbox/mapbox-gl-native-ios) library v6.2.1.

![](https://docs.mapbox.com/ios/maps/api/6.2.1/img/screenshot.png)

## Installation

You can either add the NuGet package:
```
Install-Package Naxam.Mapbox.iOS
```

## Usage

If you haven’t acquired an access token for Mapbox, you can create a free account and grab a token to insert into your info.plist file. Or if you preferer adding via code or changing it later, you may use:

```cs
MGLAccountManager.AccessToken = "<Your Mapbox access token>";
```
> see `ViewController.cs`

## Basic Examples

See our [demo project](/sample) for examples.

Mapbox resources:
- [Examples](https://docs.mapbox.com/ios/maps/examples/)
- [Tutorials](https://docs.mapbox.com/help/tutorials/#mobile-apps)
- [API Documentation](https://docs.mapbox.com/ios/api/maps/6.2.1/)

## About

This project is maintained by [Softeq Development Corp.](https://www.softeq.com/)

We specialize in developing mobile applications using Xamarin and native technology stack.

 - [Facebook](https://web.facebook.com/Softeq.by/)
 - [Instagram](https://www.instagram.com/softeq/)
 - [Twitter](https://twitter.com/Softeq)
 - [Vk](https://vk.com/club21079655)


## License

Mapbox Maps SDK for Xamarin.iOS is released under the MIT license. See [LICENSE](LICENSE) for details.
