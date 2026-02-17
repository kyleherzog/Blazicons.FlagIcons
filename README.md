# Blazicons.FlagIcons
Provides the Flag Icons library packaged as [Blazicons](https://github.com/kyleherzog/Blazicons), SVG icon components for Blazor.

Check out the [Demo Site](http://blazicons.com).

![Nuget](https://img.shields.io/nuget/v/Blazicons.FlagIcons)

[![Build Status](https://dev.azure.com/kyleherzog/Blazicons/_apis/build/status%2Fkyleherzog.Blazicons.FlagIcons?branchName=main)](https://dev.azure.com/kyleherzog/Blazicons/_build/latest?definitionId=35&branchName=main)

## Getting Started
To get started using the Flag Icons Blazicons, just install the Blazicons.FlagIcons NuGet package.

Next add the Blazicons reference to the `_Imports.razor` file in the Blazor project.

```csharp
@using Blazicons
```

Finally, add the Blazicon component to your Blazor pages/components.
```html
<Blazicon Svg="FlagIcon4x3.Us"></Blazicon>
<Blazicon Svg="FlagIcon1x1.Us"></Blazicon>
```

## Parameters & Styling
See the [Blazicons](https://github.com/kyleherzog/Blazicons) documentation for details on parameters and styling.

## Credits
Thanks to the creators of [Flag Icons](https://github.com/lipis/flag-icons)