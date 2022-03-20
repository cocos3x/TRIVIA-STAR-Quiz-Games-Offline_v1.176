using UnityEngine;
private sealed class LeaguesDataController.<>c__DisplayClass42_0
{
    // Fields
    public int multiplierOption;
    public decimal multiplierCost;
    public System.Action<bool> resultAction;
    
    // Methods
    public LeaguesDataController.<>c__DisplayClass42_0()
    {
    
    }
    internal void <ContributeMultiplier>b__0(System.Collections.Generic.Dictionary<string, object> responseObject)
    {
        int val_9;
        object val_1 = responseObject.Item[815423520];
        string val_2 = responseObject.ToString();
        decimal val_3 = System.Decimal.Parse(s:  815439920);
        SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_5 = MyGuild;
        string val_6 = System.String.Format(format:  815423632, arg0:  13152256);
        Player val_7 = App.Player;
        decimal val_8 = System.Decimal.op_UnaryNegation(d:  new System.Decimal() {flags = 815439900, hi = mem[this.multiplierCost + (0)], lo = mem[this.multiplierCost + (4)], mid = mem[this.multiplierCost + (8)]});
        0.AddCredits(amount:  new System.Decimal() {mid = val_9}, source:  "Leagues Multiplier Option {0}", subSource:  0, externalParams:  0, doTrack:  true);
        this.resultAction.Invoke(obj:  true);
        SLC.Social.Leagues.LeaguesTracker.AddDirectCreditContribution(contribution:  new System.Decimal() {flags = mem[this.multiplierCost + (0)], hi = mem[this.multiplierCost + (4)], lo = mem[this.multiplierCost + (8)], mid = 815451968}, source:  "Leagues Multiplier");
    }
    internal void <ContributeMultiplier>b__1(System.Collections.Generic.Dictionary<string, object> responseObject)
    {
        object val_1 = responseObject.Item[815423520];
        string val_2 = responseObject.ToString();
        decimal val_3 = System.Decimal.Parse(s:  815568304);
        SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_5 = MyGuild;
        string val_6 = System.String.Format(format:  815423632, arg0:  13152256);
        Player val_7 = App.Player;
        0.AddGems(amount:  0 - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.multiplierCost + (0)], hi = mem[this.multiplierCost + (4)], lo = mem[this.multiplierCost + (8)], mid = mem[this.multiplierCost + (12)]})), source:  815423632, subsource:  null);
        this.resultAction.Invoke(obj:  true);
        SLC.Social.Leagues.LeaguesTracker.AddDirectGemContribution(contribution:  new System.Decimal() {flags = mem[this.multiplierCost + (0)], hi = mem[this.multiplierCost + (4)], lo = mem[this.multiplierCost + (8)], mid = 815580352}, source:  "Leagues Multiplier");
    }

}
