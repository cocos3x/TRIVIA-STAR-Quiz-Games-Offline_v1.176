using UnityEngine;
public class AdSegmentation : MonoSingleton<AdSegmentation>
{
    // Fields
    public const string HIGHVAL = "highval";
    public const string MEDIUMVAL = "mediumval";
    public const string LOWVAL = "lowval";
    public const string ORGANIC = "organic";
    public const string UNKNOWN = "unknown";
    
    // Properties
    public static string Segment { get; }
    public static bool IsOrganic { get; }
    
    // Methods
    public static string get_Segment()
    {
        Player val_1 = App.Player;
        if(0 > 0)
        {
                Player val_2 = App.Player;
        }
        
        Player val_3 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public static bool get_IsOrganic()
    {
        bool val_2 = static_value_021FBFFD;
        if(val_2 != true)
        {
                val_2 = true;
        }
        
        string val_1 = AdSegmentation.Segment;
        if(val_2 != 0)
        {
                return val_2.Equals(value:  -905475184);
        }
        
        return val_2.Equals(value:  -905475184);
    }
    public static object GetSegementedConfig(string key, System.Collections.Generic.Dictionary<string, object> knobs, bool addSegment = True)
    {
        string val_13;
        var val_14;
        var val_15;
        var val_16;
        string val_17;
        val_13 = key;
        if(addSegment != false)
        {
                string val_1 = key + -366187456(-366187456);
            val_13 = key;
        }
        
        if((knobs.ContainsKey(key:  val_13)) == false)
        {
            goto label_11;
        }
        
        val_14 = knobs;
        object val_3 = val_14.Item[val_13];
        val_13 = 0;
        if(val_14 != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_14 = 0;
        }
        
            val_13 = val_14;
        }
        
        string val_4 = AdSegmentation.Segment;
        bool val_5 = System.String.IsNullOrEmpty(value:  null);
        if(val_5 != false)
        {
                val_15 = "m";
        }
        else
        {
                string val_6 = AdSegmentation.Segment;
            string val_8 = val_5.Chars[0].ToString();
            val_15;
        }
        
        if((System.String.op_Equality(a:  -366175318, b:  -366187360)) == false)
        {
                "m" = val_15;
        }
        
        if((val_13.ContainsKey(key:  -366175318)) == false)
        {
            goto label_11;
        }
        
        val_16 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        val_17 = "m";
        goto label_13;
        label_11:
        if((knobs.ContainsKey(key:  key)) == false)
        {
                return;
        }
        
        val_17 = key;
        val_16 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        label_13:
        object val_12 = knobs.Item[val_17];
    }
    private void OnApplicationPause(bool pause)
    {
        if(pause == true)
        {
                return;
        }
        
        this.ConsumeAdjustData();
    }
    private void ConsumeAdjustData()
    {
        var val_2;
        var val_3;
        var val_2 = 24734557;
        val_2 = 10901020 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if((System.String.IsNullOrEmpty(value:  AdjustPlugin.<Attribution_campaign>k__BackingField)) == true)
        {
                return;
        }
        
        if(R5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = mem[R4];
        val_3 = R4;
        if((((R4 + 187) & 2) == 0) && ((R4 + 116) == 0))
        {
                val_3 = mem[R4];
            val_3 = R4;
        }
        
        R4 + 92.SetupAdSegementation(campaign:  R4 + 92 + 16);
    }
    private void SetupAdSegementation(string campaign)
    {
        var val_13;
        var val_14;
        Player val_1 = App.Player;
        if((System.String.IsNullOrEmpty(value:  static_value_00280188)) == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  campaign)) == false)
        {
            goto label_6;
        }
        
        Player val_4 = App.Player;
        val_13 = 2621448;
        val_14 = "unknown";
        goto label_30;
        label_6:
        val_14 = "highval";
        if((campaign.Contains(value:  -905811568)) == true)
        {
            goto label_17;
        }
        
        val_14 = "lowval";
        if((campaign.Contains(value:  -905587264)) == false)
        {
            goto label_14;
        }
        
        goto label_17;
        label_14:
        string val_7 = campaign.ToLower();
        val_14 = "organic";
        if((campaign.Contains(value:  -905475184)) == false)
        {
            goto label_20;
        }
        
        label_17:
        Player val_10 = App.Player;
        val_13 = 2621448;
        label_30:
        Player val_11 = App.Player;
        0.SaveState();
        return;
        label_20:
        Player val_12 = App.Player;
        if(0 != 0)
        {
            goto label_30;
        }
        
        goto label_30;
    }
    public AdSegmentation()
    {
    
    }

}
