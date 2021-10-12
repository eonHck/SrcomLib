using SrcomLib.Clients.Interfaces;

namespace SrcomLib.Clients
{
    internal class ObjectClients
    {
        private readonly SrcomClient _srcomClient;
        private readonly uint _defaultMaxSearchRecords;

        private CategoriesClient _categoriesClient;
        private DevelopersClient _developersClient;
        private EnginesClient _enginesClient;
        private GamesClient _gamesClient;
        private GameTypesClient _gameTypesClient;
        private GenresClient _genresClient;
        private GuestsClient _guestsClient;
        private LeaderboardClient _leaderboardClient;
        private LevelsClient _levelsClient;
        private PlatformsClient _platformsClient;
        private PublishersClient _publishersClient;
        private RegionsClient _regionsClient;
        private RunsClient _runsClient;
        private SeriesClient _seriesClient;
        private UsersClient _usersClient;
        private VariablesClient _variablesClient;

        public ICategoriesClient Categories => _categoriesClient?.Clear() ?? (_categoriesClient = new CategoriesClient(_srcomClient, _defaultMaxSearchRecords));

        public IDevelopersClient Developers => _developersClient?.Clear()?? (_developersClient = new DevelopersClient(_srcomClient, _defaultMaxSearchRecords));

        public IEnginesClient Engines => _enginesClient?.Clear() ?? (_enginesClient = new EnginesClient(_srcomClient, _defaultMaxSearchRecords));

        public IGamesClient Games => _gamesClient?.Clear() ?? (_gamesClient = new GamesClient(_srcomClient, _defaultMaxSearchRecords));

        public IGameTypesClient GameTypes => _gameTypesClient?.Clear() ?? (_gameTypesClient = new GameTypesClient(_srcomClient, _defaultMaxSearchRecords));

        public IGenresClient Genres => _genresClient?.Clear() ?? (_genresClient = new GenresClient(_srcomClient, _defaultMaxSearchRecords));

        public IGuestsClient Guests => _guestsClient?.Clear() ?? (_guestsClient = new GuestsClient(_srcomClient, _defaultMaxSearchRecords));

        public ILeaderboardClient Leaderboards
        {
            get
            {
                if (_leaderboardClient is null)
                {
                    _leaderboardClient = new LeaderboardClient(_srcomClient, _defaultMaxSearchRecords);
                }

                return _leaderboardClient.Clear();
            }
        }

        public ILevelsClient Levels => _levelsClient?.Clear() ?? (_levelsClient = new LevelsClient(_srcomClient, _defaultMaxSearchRecords));

        public IPlatformsClient Platforms => _platformsClient?.Clear() ?? (_platformsClient = new PlatformsClient(_srcomClient, _defaultMaxSearchRecords));

        public IPublishersClient Publishers => _publishersClient?.Clear() ?? (_publishersClient = new PublishersClient(_srcomClient, _defaultMaxSearchRecords));

        public IRegionsClient Regions => _regionsClient?.Clear() ?? (_regionsClient = new RegionsClient(_srcomClient, _defaultMaxSearchRecords));

        public IRunsClient Runs => _runsClient?.Clear() ?? (_runsClient = new RunsClient(_srcomClient, _defaultMaxSearchRecords));

        public ISeriesClient Series => _seriesClient?.Clear() ?? (_seriesClient = new SeriesClient(_srcomClient, _defaultMaxSearchRecords));
        
        public IUsersClient Users => _usersClient?.Clear() ?? (_usersClient = new UsersClient(_srcomClient, _defaultMaxSearchRecords));
        
        public IVariablesClient Variables => _variablesClient?.Clear() ?? (_variablesClient = new VariablesClient(_srcomClient, _defaultMaxSearchRecords));

        public ObjectClients(SrcomClient srcomClient, uint maxSearchRecords)
        {
            _srcomClient = srcomClient;
            _defaultMaxSearchRecords = maxSearchRecords;
        }
    }
}