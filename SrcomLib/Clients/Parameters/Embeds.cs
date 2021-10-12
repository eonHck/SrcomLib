using System;
using System.Collections.Generic;

namespace SrcomLib.Clients.Parameters
{
    internal class Embeds<TApiObject>
    {
        private readonly List<string> _embeds;
        private readonly Type _type;

        public string EmbedUriPart => (_embeds.Count > 0) ? $"embed={string.Join(",", _embeds)}" : string.Empty;

        public Embeds()
        {
            _embeds = new List<string>();
            _type = typeof(TApiObject);
        }

        public void Clear()
        {
            _embeds.Clear();
        }

        public void Add(string embed)
        {
            if (!EmbedSupported(embed)) return;
            _embeds.AddUnique(embed, StringComparison.OrdinalIgnoreCase);
        }

        public void AddNestedEmbed(string apiObject, string embed)
        {
            if (!EmbedSupported(apiObject, embed)) return;
            _embeds.AddUnique($"{apiObject}.{embed}", StringComparison.OrdinalIgnoreCase);
        }

        public void AddRange(IEnumerable<string> embeds)
        {
            foreach (var embed in embeds)
            {
                Add(embed);
            }
        }

        public void AddNestedRange(IEnumerable<(string, string)> nestedEmbeds)
        {
            foreach (var (apiObject, embed) in nestedEmbeds)
            {
                AddNestedEmbed(apiObject, embed);
            }
        }

        private bool EmbedSupported(string embed)
        {
            return Constants.SupportedEmbeds.ContainsElement(_type, embed, StringComparison.OrdinalIgnoreCase);
        }

        private bool EmbedSupported(string apiObject, string embed)
        {
            var type = Constants.Endpoints.TryGetKeyFromValue(apiObject, StringComparison.OrdinalIgnoreCase);
            if (type is null) return false;

            return Constants.SupportedEmbeds.ContainsElement(type, embed, StringComparison.OrdinalIgnoreCase);
        }
    }
}