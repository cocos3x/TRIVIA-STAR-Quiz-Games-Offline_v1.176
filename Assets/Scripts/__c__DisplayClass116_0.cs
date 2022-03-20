using UnityEngine;
private sealed class WADataParser.<>c__DisplayClass116_0
{
    // Fields
    public string lang;
    public string bucket;
    
    // Methods
    public WADataParser.<>c__DisplayClass116_0()
    {
    
    }
    internal bool <GetLevelCurveFromList>b__0(WADataParser.LevelCurve p)
    {
        if((System.String.op_Equality(a:  p.Language, b:  this.lang)) == false)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  p.Bucket, b:  this.bucket);
    }

}
