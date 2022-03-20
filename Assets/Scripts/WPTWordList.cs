using UnityEngine;
public class WPTWordList : MonoSingleton<WPTWordList>
{
    // Fields
    private UnityEngine.TextAsset[] commonWordsSources;
    private UnityEngine.TextAsset[] uncommonWordsSources;
    private UnityEngine.TextAsset[] rareWordsSources;
    private System.Collections.Generic.List<System.Collections.Generic.List<string>> generativeWordLists;
    private System.Collections.Generic.List<System.Collections.Generic.List<string>> uncommonWordsLists;
    private System.Collections.Generic.List<System.Collections.Generic.List<string>> rareWordsLists;
    private bool generativeWordsInitialized;
    
    // Methods
    private void Start()
    {
        System.Collections.IEnumerator val_1 = this.LoadGenerativeWordLists();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  114444128);
    }
    public bool IsWord(string wordToCheck)
    {
        System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_6;
        System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_7;
        var val_8;
        int val_6 = wordToCheck.m_stringLength;
        int val_1 = val_6 - 3;
        if(val_1 < 0)
        {
            goto label_2;
        }
        
        val_6 = this;
        val_7 = this.generativeWordLists;
        val_6 = val_6 - 1;
        if(val_1 <= val_6)
        {
            goto label_4;
        }
        
        label_2:
        string val_2 = 114540496 + wordToCheck + 114540320;
        UnityEngine.Debug.LogError(message:  114540496);
        val_6 = this.generativeWordLists;
        label_4:
        if((mem[this.generativeWordLists.SyncRoot + 12]) <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = mem[this.generativeWordLists.SyncRoot + 8];
        val_7 = val_7 + (val_1 << 2);
        bool val_3 = (mem[this.generativeWordLists.SyncRoot + 8] + ((wordToCheck.m_stringLength - 3)) << 2) + 16.Contains(item:  wordToCheck);
        val_8 = 1;
        if(val_3 == true)
        {
                return (bool)val_8;
        }
        
        if(val_1 < val_3)
        {
                if(val_3 <= val_1)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_8 = val_8 + (val_1 << 2);
            val_7 = mem[(0 + ((wordToCheck.m_stringLength - 3)) << 2) + 16];
            val_7 = (0 + ((wordToCheck.m_stringLength - 3)) << 2) + 16;
            bool val_4 = val_7.Contains(item:  wordToCheck);
            if(val_4 == true)
        {
                return (bool)val_8;
        }
        
        }
        
        val_7 = this.rareWordsLists;
        if(val_1 < val_4)
        {
                val_7 = this.rareWordsLists;
            if(val_4 <= val_1)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_9 = val_9 + (val_1 << 2);
            if(((0 + ((wordToCheck.m_stringLength - 3)) << 2) + 16.Contains(item:  wordToCheck)) == false)
        {
                val_8 = 0;
        }
        
            return (bool)val_8;
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    private System.Collections.IEnumerator LoadGenerativeWordLists()
    {
        object val_1 = new System.Object();
        typeof(WPTWordList.<LoadGenerativeWordLists>d__9).__il2cppRuntimeField_8 = 0;
        typeof(WPTWordList.<LoadGenerativeWordLists>d__9).__il2cppRuntimeField_10 = this;
    }
    public string TryWordHint(int[] charCountPlayerSelected, int[] charCountEntirePool)
    {
        WPTWordList val_14;
        System.Int32[] val_15;
        System.Int32[] val_16;
        var val_17;
        var val_18;
        float val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_24;
        var val_25;
        var val_26;
        val_14 = this;
        val_15 = charCountEntirePool;
        val_16 = charCountPlayerSelected;
        System.Int32[] val_13 = val_16[16];
        val_17 = 0;
        label_48:
        if(val_17 >= 0)
        {
            goto label_2;
        }
        
        val_18 = 0;
        goto label_3;
        label_46:
        if(0 <= val_17)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + 0;
        if(((0 + 0) + 16 + 12) <= val_18)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = (0 + 0) + 16 + 8;
        val_15 = val_15 + 0;
        val_19 = mem[((0 + 0) + 16 + 8 + 0) + 16];
        val_19 = ((0 + 0) + 16 + 8 + 0) + 16;
        val_16 = null;
        var val_16 = 0;
        label_15:
        if(val_16 >= (((0 + 0) + 16 + 8 + 0) + 16 + 8))
        {
            goto label_9;
        }
        
        char val_2 = val_19.Chars[0] - 65;
        var val_3 = val_16 + (val_2 << 2);
        val_20 = ((val_16 + ((val_1 - 65)) << 2) + 16) + 1;
        mem2[0] = val_20;
        val_20 = mem[(val_16 + ((val_1 - 65)) << 2) + 16];
        val_20 = (val_16 + ((val_1 - 65)) << 2) + 16;
        val_16 = val_16 + 1;
        if(val_20 <= val_15[val_2])
        {
            goto label_15;
        }
        
        label_37:
        val_14 = val_14;
        val_21 = val_17;
        goto label_16;
        label_9:
        val_22 = null;
        if((charCountPlayerSelected + 12) > 0)
        {
                var val_18 = 0;
            do
        {
            System.Int32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = charCountPlayerSelected[0x10] + 0;
            val_18 = val_18 + 1;
        }
        while(val_18 < (charCountPlayerSelected + 12));
        
        }
        
        val_16 = 0;
        goto label_24;
        label_32:
        var val_6 = val_22 + ((val_19.Chars[0] - 65) << 2);
        val_24 = mem[(val_22 + ((val_4 - 65)) << 2) + 16];
        val_24 = (val_22 + ((val_4 - 65)) << 2) + 16;
        if(val_24 > 0)
        {
                0 = 1;
        }
        
        val_24 = mem[(val_22 + ((val_4 - 65)) << 2) + 16];
        val_24 = (val_22 + ((val_4 - 65)) << 2) + 16;
        val_16 = 1;
        mem2[0] = UnityEngine.Mathf.Max(a:  val_24 - 1, b:  0);
        val_15 = val_15;
        val_22 = val_22;
        label_24:
        if(val_16 < (((0 + 0) + 16 + 8 + 0) + 16 + 8))
        {
            goto label_32;
        }
        
        val_18 = 0;
        val_18 = val_18 + 1;
        if(0 < 1)
        {
            goto label_37;
        }
        
        val_21 = val_17;
        if(0 > 0)
        {
            
        }
        else
        {
                if(0 == 0)
        {
                val_25 = val_19;
            if(val_25 == 0)
        {
                val_25 = val_19;
        }
        
            if((((0 + 0) + 16 + 8 + 0) + 16 + 8) < (((0 + 0) + 16 + 8 + 0) + 16 + 8))
        {
                val_25 = val_19;
        }
        
        }
        
        }
        
        val_14 = val_14;
        label_16:
        val_18 = val_18 + 1;
        label_3:
        if((((0 + 0) + 16 + 8 + 0) + 16 + 8) <= val_21)
        {
                var val_19 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = val_19 + 0;
        if(val_18 < ((0 + 0) + 16 + 12))
        {
            goto label_46;
        }
        
        val_19 = 0f;
        val_26 =  + 1;
        if((System.String.IsNullOrEmpty(value:  val_19)) == true)
        {
            goto label_48;
        }
        
        goto label_49;
        label_2:
        val_19 = 0f;
        label_49:
        if((System.String.IsNullOrEmpty(value:  null)) == false)
        {
                val_25 = val_19;
        }
        
        bool val_11 = System.String.IsNullOrEmpty(value:  null);
        if((System.String.IsNullOrEmpty(value:  null)) == false)
        {
                return;
        }
        
        return this.TryFormWord(charCount:  val_15, requiredChar:  null);
    }
    public string TryFormWord(int[] charCount, int[] requiredChar)
    {
        WPTWordList val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_7 = this;
        System.Int32[] val_5 = requiredChar[16];
        val_8 = 0;
        goto label_1;
        label_31:
        val_9 = 0;
        goto label_2;
        label_29:
        if(requiredChar[16] <= val_8)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 0;
        if(((0 + 0) + 16 + 12) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = (0 + 0) + 16 + 8;
        val_7 = val_7 + 0;
        val_7 = null;
        val_10 = 0;
        System.Char[] val_1 = ((0 + 0) + 16 + 8 + 0) + 16.ToCharArray();
        val_9 = ((0 + 0) + 16 + 8 + 0) + 16;
        val_11 = (((0 + 0) + 16 + 8 + 0) + 16) + 16;
        label_16:
        if(val_10 >= (((0 + 0) + 16 + 8 + 0) + 16 + 12))
        {
            goto label_9;
        }
        
        var val_2 = val_11 - 65;
        var val_3 = val_7 + (val_2 << 2);
        val_12 = ((val_7 + (((((0 + 0) + 16 + 8 + 0) + 16 + 16) - 65)) << 2) + 16) + 1;
        mem2[0] = val_12;
        val_12 = mem[(val_7 + (((((0 + 0) + 16 + 8 + 0) + 16 + 16) - 65)) << 2) + 16];
        val_12 = (val_7 + (((((0 + 0) + 16 + 8 + 0) + 16 + 16) - 65)) << 2) + 16;
        System.Int32[] val_4 = charCount + (val_2 << 2);
        val_11 = val_11 + 2;
        val_10 = val_10 + 1;
        if(val_12 <= ((charCount + (((((0 + 0) + 16 + 8 + 0) + 16 + 16) - 65)) << 2) + 16))
        {
            goto label_16;
        }
        
        goto label_23;
        label_9:
        if((requiredChar == null) || ((requiredChar + 12) < 1))
        {
                return;
        }
        
        val_10 = 1152921505085149952;
        var val_8 = 0;
        do
        {
            val_9 = mem[requiredChar[0x10] + 0];
            val_9 = requiredChar[0x10] + 0;
            val_8 = val_8 + 1;
        }
        while(val_8 < (requiredChar + 12));
        
        return;
        label_23:
        val_7 = val_7;
        val_9 = val_9 + 1;
        label_2:
        if(((charCount + (((((0 + 0) + 16 + 8 + 0) + 16 + 16) - 65)) << 2) + 16) <= val_8)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + 0;
        if(val_9 < ((0 + 0) + 16 + 12))
        {
            goto label_29;
        }
        
        val_8 = val_8 + 1;
        label_1:
        if(val_8 < ((0 + 0) + 16 + 12))
        {
            goto label_31;
        }
    
    }
    private int GetUpperCharIndex(char character)
    {
        return (int)character - 65;
    }
    public WPTWordList()
    {
    
    }

}
