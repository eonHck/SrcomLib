namespace SrcomLib
{
    /// <summary>
    /// Api Objects that requests can be made for
    /// </summary>
    public enum ApiObject
    {
        Category,
        Developer,
        Engine,
        Game,
        GameType,
        Genre,
        Guest,
        Leaderboard,
        Level,
        PersonalBests,
        Platform,
        Publisher,
        Region,
        Run,
        Series,
        User,
        Variable
    };

    /// <summary>
    /// Valid embeds across the system
    /// </summary>
    internal enum Embed
    {
        Categories,
        Category,
        Developers,
        Engines,
        Game,
        GameTypes,
        Genres,
        Level,
        Levels,
        Moderators,
        Platform,
        Platforms,
        Players,
        Publishers,
        Region,
        Regions,
        Variables,
    }

    /// <summary>
    /// Valid search fields across the system
    /// </summary>
    internal enum SearchField
    {
        Abbreviation,
        BulkAccess,
        CategoryId,
        Date,
        DeveloperId,
        Emulated,
        Emulators,
        EngineId,
        ExaminerId,
        GameId,
        GameTypeId,
        GenreId,
        Guest,
        Hitbox,
        LevelId,
        LookUp,
        Miscellaneous,
        ModeratorId,
        Name,
        PlatformId,
        PublisherId,
        RegionId,
        ReleaseYear,
        SeriesId,
        SkipEmpty,
        SpeedRunsLive,
        Status,
        Timing,
        Top,
        Twitch,
        Twitter,
        UserId,
        Variable,
        VideoOnly
    }

    /// <summary>
    /// Valid sort fields across the system
    /// </summary>
    internal enum SortField
    {
        Abbreviation,
        Category,
        Created,
        Date,
        Emulated,
        Game,
        InternationalName,
        JapaneseName,
        Level,
        Mandatory,
        Miscellaneous,
        Name,
        Platform,
        Pos,
        Region,
        Released,
        Role,
        SignUp,
        Similarity,
        Status,
        Submitted,
        UserDefined,
        VerifyDate
    }

    /// <summary>
    /// Valid embeds for Category requests
    /// </summary>
    public enum CategoryEmbed
    {
        Game = Embed.Game,
        Variables = Embed.Variables
    }

    /// <summary>
    /// Valid embeds for Game requests
    /// </summary>
    public enum GameEmbed
    {
        Categories = Embed.Categories,
        Developers = Embed.Developers,
        Engines = Embed.Engines,
        GameTypes = Embed.GameTypes,
        Genres = Embed.Genres,
        Levels = Embed.Levels,
        Moderators = Embed.Moderators,
        Platforms = Embed.Platforms,
        Publishers = Embed.Publishers,
        Regions = Embed.Regions,
        Variables = Embed.Variables
    }

    /// <summary>
    /// Valid embeds for Leaderboard requests
    /// </summary>
    public enum LeaderboardEmbed
    {
        Category = Embed.Category,
        Game = Embed.Game,
        Level = Embed.Level,
        Platforms = Embed.Platforms,
        Players = Embed.Players,
        Regions = Embed.Regions,
        Variables = Embed.Variables
    }

    /// <summary>
    /// Valid embeds for Level requests
    /// </summary>
    public enum LevelEmbed
    {
        Categories = Embed.Categories,
        Variables = Embed.Variables
    }

    /// <summary>
    /// Valid embeds for Personal Best requests
    /// </summary>
    public enum PersonalBestsEmbed
    {
        Category = Embed.Category,
        Game = Embed.Game,
        Level = Embed.Level,
        Platform = Embed.Platform,
        Players = Embed.Players,
        Region = Embed.Region
    }

    /// <summary>
    /// Valid embeds for Run requests
    /// </summary>
    public enum RunEmbed
    {
        Category = Embed.Category,
        Game = Embed.Game,
        Level = Embed.Level,
        Platform = Embed.Platform,
        Players = Embed.Players,
        Region = Embed.Region
    }

    /// <summary>
    /// Valid embeds for Series requests
    /// </summary>
    public enum SeriesEmbed
    {
        Moderators = Embed.Moderators
    }

    /// <summary>
    /// Valid search fields for Category search requests
    /// </summary>
    public enum CategorySearchField
    {
        Miscellaneous = SearchField.Miscellaneous,
        SkipEmpty = SearchField.SkipEmpty,
        Top = SearchField.Top
    }

    /// <summary>
    /// Valid search fields for Game search requests
    /// </summary>
    public enum GameSearchField
    {
        Abbreviation = SearchField.Abbreviation,
        BulkAccess = SearchField.BulkAccess,
        DeveloperId = SearchField.DeveloperId,
        EngineId = SearchField.EngineId,
        GameTypeId = SearchField.GameTypeId,
        GenreId = SearchField.GenreId,
        ModeratorId = SearchField.ModeratorId,
        Name = SearchField.Name,
        PlatformId = SearchField.PlatformId,
        RegionId = SearchField.RegionId,
        ReleaseYear = SearchField.ReleaseYear
    }

    /// <summary>
    /// Valid search fields for Leaderboard search requests
    /// </summary>
    public enum LeaderboardSearchField
    {
        Date = SearchField.Date,
        Emulators = SearchField.Emulators,
        PlatformId = SearchField.PlatformId,
        RegionId = SearchField.RegionId,
        Timing = SearchField.Timing,
        Top = SearchField.Top,
        Variable = SearchField.Variable,
        VideoOnly = SearchField.VideoOnly
    }

    /// <summary>
    /// Valid search fields for Level search requests
    /// </summary>
    public enum LevelSearchField
    {
        Miscellaneous = SearchField.Miscellaneous
    }

    /// <summary>
    /// Valid search fields for Personal Bests search requests
    /// </summary>
    public enum PersonalBestsSearchField
    {
        GameId = SearchField.GameId,
        SeriesId = SearchField.SeriesId,
        Top = SearchField.Top
    }

    /// <summary>
    /// Valid search fields for Run search requests
    /// </summary>
    public enum RunSearchField
    {
        CategoryId = SearchField.CategoryId,
        Emulated = SearchField.Emulated,
        ExaminerId = SearchField.ExaminerId,
        GameId = SearchField.GameId,
        Guest = SearchField.Guest,
        LevelId = SearchField.LevelId,
        PlatformId = SearchField.PlatformId,
        RegionId = SearchField.RegionId,
        Status = SearchField.Status,
        UserId = SearchField.UserId
    }

    /// <summary>
    /// Valid search fields for Series search requests
    /// </summary>
    public enum SeriesSearchField
    {
        Abbreviation = SearchField.Abbreviation,
        ModeratorId = SearchField.ModeratorId,
        Name = SearchField.Name
    }

    /// <summary>
    /// Valid search fields for User search requests
    /// </summary>
    public enum UserSearchField
    {
        Hitbox = SearchField.Hitbox,
        LookUp = SearchField.LookUp,
        Name = SearchField.Name,
        SpeedRunsLive = SearchField.SpeedRunsLive,
        Twitch = SearchField.Twitch,
        Twitter = SearchField.Twitter
    }

    /// <summary>
    /// Valid sort fields for Category search requests
    /// </summary>
    public enum CategorySortField
    {
        Name = SortField.Name,
        Mandatory = SortField.Mandatory,
        UserDefined = SortField.UserDefined,
        Pos = SortField.Pos
    }

    /// <summary>
    /// Valid sort fields for Developer search requests
    /// </summary>
    public enum DeveloperSortField
    {
        Name = SortField.Name
    }

    /// <summary>
    /// Valid sort fields for Engine search requests
    /// </summary>
    public enum EngineSortField
    {
        Name = SortField.Name
    }

    /// <summary>
    /// Valid sort fields for Game search requests
    /// </summary>
    public enum GameSortField
    {
        Abbreviation = SortField.Abbreviation,
        Created = SortField.Created,
        InternationalName = SortField.InternationalName,
        JapaneseName = SortField.JapaneseName,
        Released = SortField.Released,
        Similarity = SortField.Similarity
    }

    /// <summary>
    /// Valid sort fields for Game Type search requests
    /// </summary>
    public enum GameTypeSortField
    {
        Name = SortField.Name
    }

    /// <summary>
    /// Valid sort fields for Genre search requests
    /// </summary>
    public enum GenreSortField
    {
        Name = SortField.Name
    }

    /// <summary>
    /// Valid sort fields for Level search requests
    /// </summary>
    public enum LevelSortField
    {
        Miscellaneous = SortField.Miscellaneous,
        Name = SortField.Name,
        Pos = SortField.Pos
    }

    /// <summary>
    /// Valid sort fields for Platform search requests
    /// </summary>
    public enum PlatformSortField
    {
        Name = SortField.Name,
        Released = SortField.Released
    }

    /// <summary>
    /// Valid sort fields for Publisher search requests
    /// </summary>
    public enum PublisherSortField
    {
        Name = SortField.Name
    }

    /// <summary>
    /// Valid sort fields for Region search requests
    /// </summary>
    public enum RegionSortField
    {
        Name = SortField.Name
    }

    /// <summary>
    /// Valid sort fields for Run search requests
    /// </summary>
    public enum RunSortField
    {
        Category = SortField.Category,
        Date = SortField.Date,
        Emulated = SortField.Emulated,
        Game = SortField.Game,
        Level = SortField.Level,
        Platform = SortField.Platform,
        Region = SortField.Region,
        Status = SortField.Status,
        Submitted = SortField.Submitted,
        VerifyDate = SortField.VerifyDate
    }

    /// <summary>
    /// Valid sort fields for Series search requests
    /// </summary>
    public enum SeriesSortField
    {
        Abbreviation = SortField.Abbreviation,
        Created = SortField.Created,
        InternationalName = SortField.InternationalName,
        JapaneseName = SortField.JapaneseName
    }

    /// <summary>
    /// Valid sort fields for User search requests
    /// </summary>
    public enum UserSortField
    {
        InternationalName = SortField.InternationalName,
        JapaneseName = SortField.JapaneseName,
        Role = SortField.Role,
        SignUp = SortField.SignUp
    }
}