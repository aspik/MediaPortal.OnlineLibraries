MediaPortal.OnlineLibraries.TheTvDb
===================================

allows pulling information through the [api][api] provided by [TheTvDb.com](http://thetvdb.com/).

It is based on the [tvdblib][tvdblib]. Thanks @DieBagger for developing and contributing it.
[tvdblib]: https://code.google.com/p/tvdblib/
[api]: http://thetvdb.com/wiki/index.php?title=Programmers_API
Features
--------
 - series information
 - episode information
 - caching of downloaded data
   - save to xml files
   - save to serialized files
 - updating of cached data
 - banners (including thumbnails)
   - series
   - season
   - episode
   - fanart
   - poster
   - actors
 - add/remove user favorites
 - user ratings
 - actors information
 - zipped downloading

Dependencies
------------
 - [MediaPortal.OnlineLibraries](../MediaPortal.OnlineLibraries#readme)
 - SharpZipLib ([Homepage][zip-hp] | [GitHub][zip-git] | [NuGet][zip-nu])
[zip-hp]: http://www.icsharpcode.net/opensource/sharpziplib/
[zip-git]: https://github.com/icsharpcode/SharpZipLib
[zip-nu]: https://nuget.org/packages/SharpZipLib/

Changelog
---------

###Version x.y (2013-xx-yy)
 - moved from [GoogleCode][tvdblib] to [MediaPortal.OnlineLibraries](../) at GitHub

###Version 0.8 (2010-07-22)
A new version of the tvdblib but since there hasn't been much progress on thetvdb site, this version contains mostly bug fixes and only a few new features.
 - Improved updating algorithm
 - Support for series lookup by imdb id
 - Improvements in language handling
One of the main problems at the moment is that the api of thetvdb.com has some serious flaws/bugs, but noone there seems to care to fix or even comment on them. This is why updating of cached content might result in inconsistent data. For more information see: http://forums.thetvdb.com/viewtopic.php?f=8&t=3994 and http://forums.thetvdb.com/viewtopic.php?f=8&t=3993

###Version 0.7 (2009-06-18)
Because of a few open bugs I decided on releasing a new version, even though no major new features have been added. The most noticable changes are:
 - fixed all known bugs
 - Sorting of episodes (aired, dvd, absolute)
 - Running Updates can be aborted
 - A few new properties (e.g. ContainsSeriesName at TvdbFanartBanner)

###Version 0.6 (2009-02-14)
The version 0.6 offers a heavily redone update and caching mechanism and a differentiation between TvdbDownloader and TvdbHandler.
 - Redone caching mechanism: Improved performance and much lower memory consumption
 - TvdbDownloader: Only download informations from http://thetvdb.com
 - TvdbHandler: Download and handle (cache, update, etc.) the downloaded data
 - Improved update mechanism
 - All banners (except actors) support thumbnails
 - You can download the new version from here

###Version 0.5
This version adds the new api features to get all rated series for a user, get all rated items from a series and the episode lookup using the air-date.

A few minor bugfixes where made and the TvBrowser app now has the ability to store the user identifier.

###Version 0.4
Version 0.4 implements all features offered by the API. It also fixes a lot of bugs of the previous versions. Language handling is much improved now as well as downloading updates for cached content.
