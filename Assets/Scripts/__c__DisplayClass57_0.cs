using UnityEngine;
private sealed class SweepstakesSDK.<>c__DisplayClass57_0
{
    // Fields
    public twelvegigs.sweepstakes.SweepstakesSDK <>4__this;
    public System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction;
    
    // Methods
    public SweepstakesSDK.<>c__DisplayClass57_0()
    {
    
    }
    internal void <DoPost>b__0(string method, System.Collections.Generic.Dictionary<string, object> data)
    {
        string val_1 = 1136521952 + method + 1136521872;
        UnityEngine.Debug.LogError(message:  1136521952);
        string val_2 = PrettyPrint.printJSON(obj:  data, types:  false, singleLineOutput:  false);
        UnityEngine.Debug.LogError(message:  data);
        this.<>4__this.OnSweepstakesResponse(method:  null, data:  data, onCompleteFunction:  this.onCompleteFunction);
    }

}
