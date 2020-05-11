# Contributing to DragonFruit Link API

So you want to contribute? That's Great! A few things to mention before going too in-depth:

- You'll **require** an API key from Steam. We don't need it, but you will to run the tests.
- Split changes into manageable PRs - don't try to completely rewrite large chunks without asking. We don't want you to get annoyed because your PR was closed and you spent the last 5 hours writing it. We'd feel bad and you'd feel worse.
- If we've missed something, add it (or let us know). We only know so much, the more thorough the better the product will be
- Because of API keys and how CI works, we have a somewhat interesting way of dealing with PRs (see below)
- If you successfully contribute, we'll give you the contributor role on our Discord and a verified account on Dragon6
- One more thing - please don't leave your API key in the code. The tests are configured to pick the key from the `steam` variable (if you're on windows set it as a user variable)

## Pull Request Checklist
After making your edits please check you've completed the steps below:

### Common
- All unused `using` statements have been deleted
- All files have the common header (pick another file & copy/paste it)
- All files are named in a sense that makes it easy to find and unambiguous compared to other files
- You've added/modified the tests (`DragonFruit.Link.Tests`) and they pass successfully
- You've put them into the correct folders and the namespaces are correct

### Requests
- All requests **must** inherit either `SteamApiRequest` or a higher-inheritor (like `SteamStoreApiRequest`)
- There shouldn't be any methods inside the Request. If there is then you're probably doing something wrong
- The file layout follows the following layout:

```
    public class Steam[ThingYouAreDoing]Request : SteamApiRequest (IForSteamApp | IForSteamUser | IHasOptionalLanguage)
    {
	    //ApiRequest overrides (if not GET)
        public override Methods Method => Methods.Post;
        public override DataTypes DataType => DataTypes.Encoded;

		//SteamApiRequest "interface" overrides
        public override string Interface => "ISteamThing";
        public override string InterfaceMethod => "SteamFunction";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

		//Constructor(s)
        public Steam[ThingYouAreDoing]Request(string requiredParam)
        {
		    RequiredParam = requiredParam
        }

        [FormParameter("PostFormParam")]
        public uint RequiredParam { get; set; }

		#nullable enable

        [QueryParameter("QueryStringParam")]
        public string? OptionalParam { get; set; }
        
		#nullable restore
    }

```

### Responses
- All Response bases must inherit `ISteamApiResponse` and end in `Response` - it is purely a style and validation thing
- If it's a container for another container (i.e. `{ "response" : "players" : [...] }`), then nest the container underneath the `Response`
- Objects should **not** be in the response, they should have their own class in the `Objects` folder.
- Responses should not have a constructor

### Objects
- Objects should not have a constructor
- Properties should be publically available and be decorated with the Json.Net property attribute (`[JsonProperty("property_json")]`)
- If there is a DateTime field, it's a UTC epoch. See things like SteamUserProfile#L53-70 for how to deal with this

### Extensions
- If it doesn't need an API key, use the `ApiClient` instead of `SteamApiClient`
- Extensions must be `public static`
- All extensions must use overloads instead of defaults (`bool x = false`) to comply with code quality
- All XMLDoc default-generated fields must be filled out in a way that is brief and easy to understand

### Tests
- Tests should aim for 100% coverage. The best way to do this is to test the extension created
- Tests must inherit `SteamApiTest` which gives access to an array of `Users` and a SteamApiClient, called `Client`. Use these.
- User-based tests must test all users in the array it applies to. Use a LINQ `Users.Where()` to filter candidates out

## Opening the PR

Once you're confident it's time to open the PR. This has 3 stages

1. Open the PR to merge into the `latest` branch. This will complete a code quality check and automatically suggest edits based on what you have done. We'll check and locally test it and also make suggestions. Once this is done we'll merge it
2. Our CI will then perform all the Unit tests (as we can now access the API key) and if they pass update the `staging` branch. This will cause the CI to build and publish a pre-release package.
3. Once we're really happy we'll merge into `production` which'll produce another package that's considered stable

TL;DR Please create the PR to target the `latest` branch