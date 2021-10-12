# SrcomLib.
A .Net Standard library for using and interacting with the [Speedrun.com api](https://github.com/speedruncomorg/api) with a fluent syntax.  Currently SrcomLib only supports GET endpoints, but support for POST, PUT, and DELETE on the Runs endpoint is planned for a future release.

Simple Usage:

```cs
var client = new SrcomClient();
var games = await client.Games.WithSearch(GameSerachField.Name, "Zelda").ExecuteSearchAsync();
```

SrcomLib allows access for the following objects from the Speedrun.com api:
* Categories
* Developers
* Engines
* Games
* GameTypes
* Genres
* Guests
* Leaderboards
* Levels
* Platforms
* Publishers
* Regions
* Runs
* Series
* Users
* Variables
