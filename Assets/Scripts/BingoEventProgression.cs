using UnityEngine;
public class BingoEventProgression : EventProgression
{
    // Fields
    private const string BingoEventPrefKey = "BINGO_EVENT_PROGRESSION";
    public int currentEventId;
    public int ballsCount;
    public int keyWordIndex;
    public int cellIndex;
    public int lastProgressTimestamp;
    public int[,] currentCard;
    public System.Collections.Generic.List<int> balls;
    public int bingoCalls;
    
    // Methods
    public override void LoadFromJSON()
    {
        var val_20;
        var val_21;
        var val_22;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1524043056)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1524043056, defaultValue:  -2040381152);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1524043056);
        if("BINGO_EVENT_PROGRESSION" != 0)
        {
                if(null == null)
        {
            goto label_32;
        }
        
        }
        
        label_32:
        string val_4 = 0.Item[1642388960];
        bool val_6 = System.Int32.TryParse(s:  null, result: out  int val_5 = -1524018456);
        string val_7 = 0.Item[-1524042928];
        bool val_9 = System.Int32.TryParse(s:  null, result: out  int val_8 = -1524018452);
        string val_10 = 0.Item[-1524042832];
        bool val_12 = System.Int32.TryParse(s:  null, result: out  int val_11 = -1524018440);
        string val_13 = 0.Item[-1524042720];
        val_20 = 0;
        mem[1152921511672763140] = System.Int32.Parse(s:  null);
        string val_15 = 0.Item[-1524042624];
        if(0 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_20 = 0;
        }
        
        System.Collections.Generic.List<System.Int32> val_16 = new System.Collections.Generic.List<System.Int32>();
        val_21 = 0;
        mem[1152921511672763136] = null;
        goto label_15;
        label_20:
        if(this <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_21 = 0;
        val_21 = val_21 + 0;
        Add(item:  System.Int32.Parse(s:  (0 + 0) + 16));
        val_21 = 1;
        label_15:
        if(val_21 < 0)
        {
            goto label_20;
        }
        
        string val_18 = 0.Item[-1524042544];
        var val_24 = 0;
        val_22 = 0;
        if(0 != 0)
        {
                val_22 = 0;
            if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_22 = 0;
        }
        
        var val_25 = 0;
        mem[1152921511672763132] = null;
        do
        {
            var val_23 = 0;
            do
        {
            if(0 <= (val_25 + val_23))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_22 = 0;
            val_22 = val_22 + 16;
            val_23 = val_23 + 1;
            mem2[0] = System.Int32.Parse(s:  (0 + 16) + 0);
        }
        while(val_23 != 5);
        
            val_24 = val_24 + 1;
            val_25 = val_25 + 5;
        }
        while(val_24 != 5);
    
    }
    public override void SaveToJSON()
    {
        var val_6 = 0;
        do
        {
            var val_5 = 0;
            do
        {
            Add(item:  this.currentCard[new System.Collections.Generic.List<System.Int32>()]);
            val_5 = val_5 + 1;
        }
        while(val_5 != 5);
        
            val_6 = val_6 + 1;
        }
        while(val_6 != 5);
        
        if((new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>()) != 0)
        {
                Add(key:  1642388960, value:  13152256);
        }
        else
        {
                Add(key:  1642388960, value:  13152256);
        }
        
        Add(key:  -1524042544, value:  80883712);
        Add(key:  -1524042624, value:  this.balls);
        Add(key:  -1524042928, value:  13152256);
        Add(key:  -1524042720, value:  13152256);
        Add(key:  -1524042832, value:  13152256);
        string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1524043056, value:  78753792);
    }
    public override void Delete()
    {
        this.DeleteKey(key:  -1524043056);
    }
    public BingoEventProgression()
    {
        this.keyWordIndex = 0;
        this.cellIndex = 0;
    }

}
