using UnityEngine;
public class DailyChallengeEconomy
{
    // Fields
    public int RequiredMonthlyStars;
    public int RequiredWeeklyStars;
    public DailyChallenge_RetryCosts RetryCosts;
    public DailyChallengeDefinition ChallengeDefinition;
    public StarTiers StarTiers;
    public DailyChallengeV5_ZooTiles ZooTiles;
    
    // Methods
    public DailyChallengeEconomy(System.Collections.Generic.Dictionary<string, object> sourceData)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = sourceData;
        this.RetryCosts = new EncodableModel();
        this.ZooTiles = new DailyChallengeV5_ZooTiles();
        val_3 = new System.Object();
        val_20 = "retry_costs";
        if((val_3.ContainsKey(key:  -345216992)) != false)
        {
                object val_5 = val_3.Item[-345216992];
            val_21 = 0;
            if(val_3 != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_3 = 0;
        }
        
            val_21 = val_3;
        }
        
            this.RetryCosts.Decode(jasonObject:  0, sourceModel:  0);
        }
        
        if((val_3.ContainsKey(key:  -345212800)) != false)
        {
                object val_7 = val_3.Item[-345212800];
            string val_8 = val_3.ToString();
            this.RequiredMonthlyStars = System.Int32.Parse(s:  val_3);
        }
        
        if((val_3.ContainsKey(key:  -345212688)) != false)
        {
                object val_11 = val_3.Item[-345212688];
            string val_12 = val_3.ToString();
            this.RequiredWeeklyStars = System.Int32.Parse(s:  val_3);
        }
        
        if((val_3.ContainsKey(key:  -345212576)) != false)
        {
                object val_15 = val_3.Item[-345212576];
            val_20 = val_3;
            val_22 = 0;
            if(val_20 != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_20 = 0;
        }
        
            val_22 = val_20;
        }
        
            DailyChallengeDefinition val_16 = new DailyChallengeDefinition(sourceData:  0);
            this.ChallengeDefinition = null;
        }
        
        val_23 = "star_tiers";
        if((val_3.ContainsKey(key:  -345212464)) == false)
        {
                return;
        }
        
        object val_18 = val_3.Item[-345212464];
        val_23 = val_3;
        val_24 = 0;
        if(val_23 != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_23 = 0;
        }
        
            val_24 = val_23;
        }
        
        StarTiers val_19 = new StarTiers(sourceData:  0);
        this.StarTiers = null;
    }

}
