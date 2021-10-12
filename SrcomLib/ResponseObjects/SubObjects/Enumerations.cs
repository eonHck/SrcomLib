namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Category Type Enumeration
    /// </summary>
    public enum CategoryType
    {
        PerGame,
        PerLevel
    }

    /// <summary>
    /// Moderator Type Enumeration
    /// </summary>
    public enum ModeratorType
    {
        Moderator,
        SuperModerator
    }

    /// <summary>
    /// Players Type Enumeration for number of players
    /// </summary>
    public enum PlayersType
    {
        Exactly,
        UpTo
    }

    /// <summary>
    /// Variable Scope Type Enumeration
    /// </summary>
    public enum ScopeType
    {
        Global,
        FullGame,
        AllLevels,
        SingleLevel
    }

    /// <summary>
    /// Run Status Enumeration
    /// </summary>
    public enum RunStatus
    {
        New,
        Verified,
        Rejected
    }

    /// <summary>
    /// User Role Enumeration
    /// </summary>
    public enum UserRole
    {
        Banned,
        User,
        Trusted,
        Moderator,
        Admin,
        Programmer
    }

    /// <summary>
    /// Run Timing Method Enumeration
    /// </summary>
    public enum TimingMethod
    {
        InGameTime,
        RealTime,
        RealTimeWithouLoads
    }
}