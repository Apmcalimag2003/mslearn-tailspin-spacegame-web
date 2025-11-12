using System.Collections.Generic;

namespace TailSpin.SpaceGame.Web.Models
{
    public class LeaderboardViewModel
    {
        public IEnumerable<ScoreProfile> Scores { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalResults { get; set; }
        public string SelectedMode { get; set; }
        public string SelectedRegion { get; set; }
        public IEnumerable<string> GameModes { get; set; }
        public IEnumerable<string> GameRegions { get; set; }
        public string PrevLink { get; set; }
        public string NextLink { get; set; }
    }

    public class ScoreProfile
    {
        public Score Score { get; set; }
        public Profile Profile { get; set; }
    }
}
