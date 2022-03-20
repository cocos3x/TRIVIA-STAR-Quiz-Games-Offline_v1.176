using UnityEngine;
private sealed class LeaguesDataController.<>c__DisplayClass40_0
{
    // Fields
    public int points;
    public SLC.Social.Leagues.LeaguesDataController <>4__this;
    
    // Methods
    public LeaguesDataController.<>c__DisplayClass40_0()
    {
    
    }
    internal void <ContributePoints>b__0(System.Collections.Generic.Dictionary<string, object> responseObject)
    {
        int val_5 = this.points;
        SLC.Social.Leagues.LeaguesTracker.AddLeaguePointsContributionFromSlots(leaguePoints:  val_5 = this.points);
        SLC.Social.Leagues.LeaguesManager.RemoveCachedGC();
        if((responseObject.ContainsKey(key:  -1470584448)) == false)
        {
                return;
        }
        
        val_5 = this.<>4__this;
        object val_2 = responseObject.Item[-1470584448];
        string val_3 = responseObject.ToString();
        decimal val_4 = System.Decimal.Parse(s:  813333248);
    }

}
