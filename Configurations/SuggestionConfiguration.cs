﻿using Dexter.Abstractions;
using System.Collections.Generic;

namespace Dexter.Configurations {
    public class SuggestionConfiguration : JSONConfiguration {
        
        public ulong SuggestionGuild { get; set; }

        public ulong SuggestionsChannel { get; set; }

        public ulong StaffSuggestionsChannel { get; set; }

        public ulong EmojiStorageGuild { get; set; }

        public int TrackerLength { get; set; }

        public Dictionary<string, ulong> Emoji { get; set; }

        public List<string> SuggestionEmoji { get; set; }

        public List<string> StaffSuggestionEmoji { get; set; }

        public int ReactionPass { get; set; }

    }
}
