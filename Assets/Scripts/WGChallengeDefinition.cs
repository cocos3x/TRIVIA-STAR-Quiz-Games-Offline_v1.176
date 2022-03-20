using UnityEngine;
public class WGChallengeDefinition : ScriptableObject
{
    // Fields
    private System.Collections.Generic.List<WGChallengeDefinition.PerChallengeInfo> info;
    
    // Methods
    public WGChallengeDefinition.PerChallengeInfo getInfoForType(ChallengeType cType)
    {
        object val_1 = new System.Object();
        typeof(WGChallengeDefinition.<>c__DisplayClass1_0).__il2cppRuntimeField_8 = cType;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_2 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  305750016, method:  new IntPtr(2694921744));
        return System.Linq.Enumerable.First<System.Object>(source:  this.info, predicate:  7720960);
    }
    public WGChallengeDefinition()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.info = null;
    }

}
