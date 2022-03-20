using UnityEngine;
public class DailyChallengeDefinition : EncodableModel
{
    // Fields
    public int MinRequiredLength;
    public int CoinReward;
    public System.Collections.Generic.List<object> GoldenRewards;
    public System.Collections.Generic.List<object> StarThresholds;
    public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> LettersWordCount;
    public int LettersLength;
    public int MaxRequiredWordsAmount;
    public int MinRequiredWordsAmount;
    
    // Properties
    public decimal GetReward { get; }
    
    // Methods
    public DailyChallengeDefinition(System.Collections.Generic.Dictionary<string, object> sourceData)
    {
        this.Decode(jasonObject:  sourceData, sourceModel:  0);
        this.DecodeLettersWordsCount(sourceData:  sourceData);
    }
    public decimal get_GetReward()
    {
        decimal val_1 = System.Convert.ToDecimal(value:  -346042048);
        return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
    }
    private void DecodeLettersWordsCount(System.Collections.Generic.Dictionary<string, object> sourceData)
    {
        string val_11;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_13 = "letters_word_count";
        if((sourceData.ContainsKey(key:  -345949952)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_2 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        mem[1152921512850856776] = null;
        object val_3 = sourceData.Item[-345949952];
        val_13 = 1152921504685600768;
        val_14 = 0;
        Dictionary.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        var val_13 = 0;
        val_15 = -345936944;
        label_25:
        if(0.MoveNext() == false)
        {
            goto label_10;
        }
        
        System.Collections.Generic.List<System.Int32> val_8 = new System.Collections.Generic.List<System.Int32>();
        if( != 0)
        {
                val_16 = null;
        }
        
        if( != 0)
        {
                val_16 = null;
            val_17 = 0;
            val_15 = -345936944;
            if(((mem[1768188873] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_16)
        {
                 = 0;
        }
        
            val_17 = ;
        }
        else
        {
                val_17 = 0;
        }
        
        List.Enumerator<T> val_9 = GetEnumerator();
        label_20:
        if(MoveNext() == false)
        {
            goto label_17;
        }
        
        Add(item:  System.Int32.Parse(s:  val_11, style:  511));
        goto label_20;
        label_17:
        val_13 = val_13 + 1;
        mem2[0] = 161;
        Dispose();
        if(val_13 != 1)
        {
                var val_14 = val_15 + ((0 + 1)) << 2;
            if(val_13 > 1)
        {
                0 = 1;
        }
        
            val_14 = val_14 - 161;
            val_14 = val_14 >> 5;
            val_14 = 1 & val_14;
            val_13 = val_13 - val_14;
        }
        
        Add(key:  System.Int32.Parse(s:  1179403647, style:  511), value:  80883712);
        goto label_25;
        label_10:
        0.Dispose();
    }

}
