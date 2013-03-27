MediaPortal.OnlineLibraries
===========================

[hp]: http://www.team-mediaportal.com/
[mp2-git]: https://github.com/MediaPortal/MediaPortal-2

This project aims to be a .NET library to access various web services with minimal dependencies
to other binaries and projects.
The project is initiated by [Team MediaPortal][hp] and also be used within the [MediaPortal 2][mp2-git],
but the libraries itself are completely independent and can be reused by any other software.

> *Please be aware that branches, except __master__ might be rebased during the time.*

Common code base
----------------
    MediaPortal.OnlineLibraries
The project [MediaPortal.OnlineLibraries](MediaPortal.OnlineLibraries#readme) contains the common code base like downloading and caching lookup request, as
well as error handling and other utility methods used by the various webservice implementations.

WebService implementations
--------------------------
Each webservice is encapsulated within it's own namespace following a defined naming scheme.
```
MediaPortal.OnlineLibraries.[WebService]
```
 - API wrapper
 - (optional) configuration class
 - (optional) 'Consts' class for defining constants

```
MediaPortal.OnlineLibraries.[WebService].Data
```
 - data structures

```
MediaPortal.OnlineLibraries.[WebService].Helpers
```
 - other classes and enums related to the API

Current webservices
-------------------
 - [MediaPortal.OnlineLibraries.TheMovieDb](MediaPortal.OnlineLibraries.TheMovieDb#readme)
 - [MediaPortal.OnlineLibraries.TheTvDb](MediaPortal.OnlineLibraries.TheTvDb#readme)

Planned webservices
-------------------
We also would like to add support for some of the following webservices. If you would like to help, feel free to
contact us in [our forums](http://forum.team-mediaportal.com/forums/general.529/) or fork the repository and create a pull request.
 - MediaPortal.OnlineLibraries.AcoustId
 - MediaPortal.OnlineLibraries.CoverArtArchive
 - MediaPortal.OnlineLibraries.EchoNest
 - MediaPortal.OnlineLibraries.FanartTv
 - MediaPortal.OnlineLibraries.FollowIt
 - MediaPortal.OnlineLibraries.LastFm
 - MediaPortal.OnlineLibraries.MusicBrainz
 - MediaPortal.OnlineLibraries.TheAudioDb
 - MediaPortal.OnlineLibraries.TheGamesDb
 - MediaPortal.OnlineLibraries.Trakt
 - MediaPortal.OnlineLibraries.WorldWeatherOnline
