# DragonFruit Link API
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/29b1309caa754a5798dbba699ffab631)](https://app.codacy.com/gh/dragonfruitnetwork/link?utm_source=github.com&utm_medium=referral&utm_content=dragonfruitnetwork/Link&utm_campaign=Badge_Grade_Dashboard) [![NuGet](https://img.shields.io/nuget/v/DragonFruit.Link.svg?style=popout)](https://www.nuget.org/packages/DragonFruit.Link/)
[![DragonFruit Discord](https://img.shields.io/discord/482528405292843018?label=Discord&style=popout)](https://discord.gg/VA26u5Z)

## Overview
DragonFruit Link is a Steam API library aimed at making it easier to utilise the facilities Steam provide (and document *really* badly). Licensed under MIT, the library is completely free to use. 

## Structure
The codebase adopts a structure that is easy to follow and makes sense. Each of the API's "function" is categorised into one of 7 Categories:

- Economy (Trades)
- News
- Game (Overall)
- User (Profiles, Stats, Badges, etc.)
- Servers (Server Creation/Maintenance)
- Store (Steam Store Frontend API)
- Library (User Games, Shared Games and User Recents)

Each of these categories has their own folder in the codebase and have a set of subfolders/categories:

- Requests*
- Extensions*
- Responses (Usually object containers because of Steam...)
- Objects

Starred categories (*) means that all the "Steam functions" require one of these. What each of these do should be self-explanatory based on their name. (Hint: They all start with `Steam`, Requests end in `Request`, Responses end in `Response` and Extensions end in `Extensions`)

## How To Use

Before we get into the mechanics, you'll need to grab a copy from NuGet (when it's available)

All requests need an `ApiClient`. This is the DragonFruit standard that allows requests to be made quickly and easily whilst allowing API designers to customise how the request is built and handled. Some Steam API functions require an API key. We've built a `SteamApiClient` with the functionality to be able to see when the key is needed and automatically inject it, so you don't need to. You can also customise it too, with custom headers and User Agents.

First, decide if you're going to use the functions that need API keys, then choose the API client that best suits you:

1. `ApiClient` - For client apps that don't need an API key
2. `SteamApiClient` - For Server apps that will be able to execute functions that need an API key

Next, depending on your program's structure create a single instance of the client you picked and store it either as a `static` variable or as a `Singleton<T>()` (if you're using dependency injection). If you picked `SteamApiClient`, you need to store it as a `SteamApiClient` and not as an `ApiClient` otherwise functionality will be reduced.

After storing the client, you can use the extension methods available to perform requests. Remember: the functions you can access depend on the client you picked. See below for the functions

## Functions
> In this `client` refers to what we call a "service" client, one that is generic and can be used for any requests
> A `steamClient` is referring to an instance of the `SteamApiClient`

> Note: this is only a section of the most common functions, use IntelliSense to get the full list (and their overloads)

Category|Action|Function|
|--|--|--|
|**News**|Get Steam News|`client.GetAppNews(uint appId)`|
|**Store**|Get Steam App Store Listing|`client.GetStoreListing(uint appId)`|
|Store|Get Steam Store Featured Apps|`client.GetFeaturedAppListing()`|
|**User**|Get User Info|`steamClient.GetUserProfile(ulong steamId)`|
|User|Resolve a User's custom URL|`steamClient.ResolveVanityUrl(string linkSegment)`|
|User|Get User VAC, Community, Trade and Game Bans|`steamClient.GetUserRestrictions(ulong steamId)`|
|User|Get User's friend list (if public)|`steamClient.GetUserFriends(ulong steamId)`|
|User|Get User's Game Stats|`steamClient.GetUserGameStats(uint appId, ulong steamId)`|
|User|Get User Level|`steamClient.GetUserLevel(ulong steamId)`|
|**Library**|Get User's Game Library|`steamClient.GetUserAppLibrary(ulong steamId)`|
|Library|Get User's Recently Played Games/Apps|`steamClient.GetUserRecentApps(ulong steamId)`|
|**Servers**|List Created Game Servers (incl. keys)|`steamClient.GetGameServers()`|
|Servers|Create a Game Server|`steamClient.CreateGameServer(uint appId, string memo)`|
|Servers|Delete a Game Server|`steamClient.DeleteGameServer(ulong serverId)`|

## Contributing

To make the total length of the document more manageable, we've put how to contribute in the contributing.md file in this repo. People who do contribute in a positive way are entitled to the contributor role on the DragonFruit Discord and a verified Profile on the Dragon6 Site (if you play Rainbow Six). Join the [DragonFruit Discord](https://discord.gg/VA26u5Z) and DM a member of `Team DragonFruit` to request the promotion
