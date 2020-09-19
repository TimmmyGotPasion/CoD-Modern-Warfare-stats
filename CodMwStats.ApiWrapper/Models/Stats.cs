using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CodMwStats.ApiWrapper.Models
{
    public class Stats
    {
        [JsonProperty("kDRatio")]
        public Information KdRatio { get; set; }

        [JsonProperty("kills")]
        public Information Kills { get; set; }

        [JsonProperty("deaths")]
        public Information Deaths { get; set; }

        [JsonProperty("timePlayedTotal")]
        public Information TimePlayedTotal { get; set; }

        [JsonProperty("timePlayed")]
        public Information TimePlayed { get; set; }

        [JsonProperty("totalGamesPlayed")]
        public Information TotalGamesPlayed { get; set; }

        [JsonProperty("gamesPlayed")]
        public Information GamesPlayed { get; set; }

        [JsonProperty("level")]
        public Information Level { get; set; }

        [JsonProperty("levelProgression")]
        public Information LevelProgression { get; set; }

        [JsonProperty("wlratio")]
        public Information WlRatio { get; set; }

        [JsonProperty("wins")]
        public Information Wins { get; set; }

        [JsonProperty("losses")]
        public Information Losses { get; set; }

        [JsonProperty("ties")]
        public Information Ties { get; set; }

        [JsonProperty("longestKillstreak")]
        public Information LongestKillstreak { get; set; }

        [JsonProperty("averageLife")]
        public Information AverageLife { get; set; }

        [JsonProperty("assists")]
        public Information Assists { get; set; }

        [JsonProperty("scorePerMinute")]
        public Information ScorePerMinute { get; set; }

        [JsonProperty("scorePerGame")]
        public Information ScorePerGame { get; set; }

        [JsonProperty("careerScore")]
        public Information CareerScore { get; set; }

        [JsonProperty("score")]
        public Information Score { get; set; }

        [JsonProperty("accuracy")]
        public Information Accuracy { get; set; }

        [JsonProperty("headshotPercentage")]
        public Information HeadshotPercentage { get; set; }

        [JsonProperty("downs")]
        public Information Downs { get; set; }

        [JsonProperty("top5")]
        public Information TopFive { get; set; }

        [JsonProperty("top10")]
        public Information TopTen { get; set; }

        [JsonProperty("contracts")]
        public Information Contracts { get; set; }
    }
}
