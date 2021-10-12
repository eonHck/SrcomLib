using System;
using System.Collections.Generic;
using res = SrcomLib.ResponseObjects;
using resSub = SrcomLib.ResponseObjects.SubObjects;
using api = SrcomLib.ApiObjects;
using apiSub = SrcomLib.ApiObjects.SubObjects;
using AutoMapper;
using SrcomLib.Mapping.Converters;

namespace SrcomLib.Mapping
{
    internal class ObjectMapping
    {
        private static Mapper _mapper;

        public static Mapper Mapper
        {
            get
            {
                if (_mapper is null)
                {
                    new ObjectMapping();
                }
                return _mapper;
            }
        }

        private ObjectMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;

                cfg.CreateMap<api.Category, res.Category>();
                cfg.CreateMap<api.Developer, res.Developer>();
                cfg.CreateMap<api.Engine, res.Engine>();
                cfg.CreateMap<api.Game, res.Game>()
                    .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Names.International))
                    .ForMember(d => d.JapaneseName, opt => opt.MapFrom(src => src.Names.Japanese))
                    .ForMember(d => d.IsRomhack, opt => opt.MapFrom(src => src.Romhack));
                cfg.CreateMap<api.GameType, res.GameType>();
                cfg.CreateMap<api.Genre, res.Genre>();
                cfg.CreateMap<api.Guest, res.Guest>();
                cfg.CreateMap<api.Leaderboard, res.Leaderboard>();
                cfg.CreateMap<api.Level, res.Level>();
                cfg.CreateMap<api.PersonalBests, res.PersonalBests>();
                cfg.CreateMap<api.Platform, res.Platform>();
                cfg.CreateMap<api.Publisher, res.Publisher>();
                cfg.CreateMap<api.Region, res.Region>();
                cfg.CreateMap<api.Run, res.Run>();
                cfg.CreateMap<api.Series, res.Series>()
                    .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Names.International))
                    .ForMember(d => d.JapaneseName, opt => opt.MapFrom(src => src.Names.Japanese));
                cfg.CreateMap<api.User, res.User>()
                    .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Names.International))
                    .ForMember(d => d.JapaneseName, opt => opt.MapFrom(src => src.Names.Japanese));
                cfg.CreateMap<api.Variable, res.Variable>().ConvertUsing<VariableConverter>();

                cfg.CreateMap<apiSub.Assets, resSub.Assets>();
                cfg.CreateMap<apiSub.BasicLink, Uri>().ConvertUsing<UriBasicLinkConverter>();
                cfg.CreateMap<apiSub.ColorInfo, resSub.ColorInfo>();
                cfg.CreateMap<apiSub.Country, resSub.Country>()
                    .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Names.International))
                    .ForMember(d => d.JapaneseName, opt => opt.MapFrom(src => src.Names.Japanese));
                cfg.CreateMap<apiSub.Link, resSub.Link>();
                cfg.CreateMap<apiSub.Location, resSub.Location>();
                cfg.CreateMap<apiSub.NameStyle, resSub.NameStyle>();
                cfg.CreateMap<apiSub.Player, resSub.Player>();
                cfg.CreateMap<apiSub.Players, resSub.Players>();
                cfg.CreateMap<apiSub.Ruleset, resSub.Ruleset>()
                    .ForMember(d => d.TimingMethods, opt => opt.MapFrom(src => src.RunTimes))
                    .ForMember(d => d.DefaultTimingMethod, opt => opt.MapFrom(src => src.DefaultTime));
                cfg.CreateMap<apiSub.RunRank, resSub.RunRank>();
                cfg.CreateMap<apiSub.Status, resSub.Status>();
                cfg.CreateMap<apiSub.GameSystem, resSub.GameSystem>();
                cfg.CreateMap<apiSub.Times, resSub.Times>().ConvertUsing<TimesConverter>();
                cfg.CreateMap<apiSub.UserAssets, resSub.UserAssets>();
                cfg.CreateMap<apiSub.Videos, IReadOnlyList<Uri>>().ConvertUsing<VideosConverter>();

                cfg.CreateMap<string, Uri>().ConvertUsing<UriStringConverter>();
                cfg.CreateMap<string, resSub.CategoryType>().ConvertUsing<CategoryTypeConverter>();
                cfg.CreateMap<string, resSub.PlayersType>().ConvertUsing<PlayersTypeConverter>();
                cfg.CreateMap<string, resSub.RunStatus>().ConvertUsing<RunStatusConverter>();
                cfg.CreateMap<string, resSub.ScopeType>().ConvertUsing<ScopeTypeConverter>();
                cfg.CreateMap<string, resSub.TimingMethod>().ConvertUsing<TimingMethodConverter>();
                cfg.CreateMap<string, resSub.UserRole>().ConvertUsing<UserRoleConverter>();
                cfg.CreateMap<List<apiSub.Link>, IReadOnlyList<resSub.Link>>().ConvertUsing<LinkListConverter>();
                cfg.CreateMap<List<api.Variable>, IReadOnlyList<res.Variable>>().ConvertUsing<VariableListConverter>();
                cfg.CreateMap<List<api.Category>, IReadOnlyList<res.Category>>().ConvertUsing<CategoryListConverter>();
                cfg.CreateMap<Dictionary<string, string>, IReadOnlyList<resSub.Moderator>>().ConvertUsing<ModeratorsConverter>();
                cfg.CreateMap<Dictionary<string, string>, IReadOnlyList<resSub.RunVariableValue>>().ConvertUsing<RunVariableValuesConverter>();
                cfg.CreateMap<List<Embed>, List<string>>().ConvertUsing<EmbedListStringConverter>();
                cfg.CreateMap<List<KeyValuePair<ApiObject, Embed>>, List<(string, string)>>().ConvertUsing<NestedEmbedListConverter>();
                cfg.CreateMap<IDictionary<SearchField, string>, IDictionary<string, string>>().ConvertUsing<SearchDictionaryConverter>();
            });

            _mapper = new Mapper(config);
        }
    }
}