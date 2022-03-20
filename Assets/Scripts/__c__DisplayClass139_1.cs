using UnityEngine;
private sealed class WGDailyChallengeManager.<>c__DisplayClass139_1
{
    // Fields
    public int i;
    
    // Methods
    public WGDailyChallengeManager.<>c__DisplayClass139_1()
    {
    
    }
    internal bool <GetMatchingDayDistance>b__4(System.Collections.Generic.KeyValuePair<string, DailyChallenge_DayProgress> x)
    {
        string val_1 = this.i.ToString();
        return System.String.op_Equality(a:  x.Value, b:  this.i);
    }

}
