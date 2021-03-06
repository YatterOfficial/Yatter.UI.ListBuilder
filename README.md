

## Alpha Alert!

We are progressively building this solution from a custom ListView pattern that we already use in Xamarin Forms, and as you can't read our mind, you wont know from one week to another where we are going on this. So beware. We are, however, developing on various branches, and commiting approved updates to the master branch, so the master branch can be considered to have better form than the development branches. It's a winding road to Camelot!

# Yatter.UI.ListBuilder

<a href="https://www.nuget.org/packages/Yatter.UI.ListBuilder/" target="_blank" rel="noreferrer noopener"><img alt="Nuget" src="https://img.shields.io/nuget/v/Yatter.UI.ListBuilder?color=blue&style=for-the-badge"></a>

![GitHub](https://img.shields.io/github/license/yatterofficial/Yatter.UI.ListBuilder?style=for-the-badge)

[![Yatter.UI.ListBuilder on fuget.org](https://www.fuget.org/packages/Yatter.UI.ListBuilder/badge.svg)](https://www.fuget.org/packages/Yatter.UI.ListBuilder)

This library is a collection of lightweight List ```Description``` objects that allows JSON or XML list descritions to be generated or consumed, which when used in conjunction with a renderer that is designed to render such a list on a specific platform, will allow rapid list creation without needing to know much about the underlying technologies of the specific platform that the render is used upon.

To date, a single renderer has been created for Blazor, and that allows lightweight lists to be generated on the following devices:

- Website, using Blazor, on any server or device where Blazor can be deployed.
- iOS, using .Net Maui Blazor
- Android, using .Net Maui Blazor
- MacOS, using .Net Maui Blazor
- Windows, using .Net Maui Blazor

The Blazor component that will render the output of the ListBuilder herein is at [Yatter.UI.Blazor.Components](https://github.com/YatterOfficial/Yatter.UI.Blazor.Components)

The Demo that integrates both of these Libraries, is at [Yatter API](https://github.com/HarrisonOfTheNorth/Yatter)

This demo also uses our ResponsiveHttpClient at [https://github.com/YatterOfficial/Yatter.Http](https://github.com/YatterOfficial/Yatter.Http)

y@R and You-At-A-Resource are trademarks of Count Anthony Harrison, operating from the United Kingdom
