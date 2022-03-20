using UnityEngine;
public class StarTiers
{
    // Fields
    public System.Collections.Generic.List<StarTier> Tiers;
    
    // Methods
    public StarTiers(System.Collections.Generic.List<object> sourceData)
    {
        var val_4;
        var val_9;
        var val_10;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.Tiers = null;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_9 = 0;
        if(val_4 != 0)
        {
                if(((val_4 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_4 = 0;
        }
        
            val_9 = val_4;
        }
        
        object val_5 = new System.Object();
        string val_6 = val_9.Item[-1605531600];
        typeof(StarTier).__il2cppRuntimeField_8 = System.Int32.Parse(s:  null);
        string val_8 = val_9.Item[-345827600];
        val_10 = 0;
        if(val_9 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_9 = 0;
        }
        
            val_10 = val_9;
        }
        
        Decode(sourceData:  0);
        this.Tiers.Add(item:  370552832);
        goto label_12;
        label_2:
        Dispose();
    }

}
