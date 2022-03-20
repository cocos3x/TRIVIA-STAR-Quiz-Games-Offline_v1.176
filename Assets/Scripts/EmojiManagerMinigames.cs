using UnityEngine;
public class EmojiManagerMinigames : MonoSingleton<EmojiManagerMinigames>
{
    // Fields
    private UnityEngine.TextAsset emojiLookupData;
    private System.Collections.Generic.Dictionary<string, object> emojiLookup;
    private System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> prefabLookup;
    private UnityEngine.GameObject[] prefabs;
    
    // Methods
    public void BuildEmojiLookup()
    {
        var val_5;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6;
        var val_7;
        val_5 = 0;
        string val_1 = this.emojiLookupData.text;
        object val_2 = MiniJSON.Json.Deserialize(json:  this.emojiLookupData);
        val_6 = 0;
        if(this.emojiLookupData != 0)
        {
                val_6 = 0;
            if(((UnityEngine.TextAsset.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                this.emojiLookupData = 0;
        }
        
            val_6 = this.emojiLookupData;
        }
        
        this.emojiLookup = val_6;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.prefabLookup = null;
        goto label_4;
        label_9:
        string val_4 = 1152921507209181152.name;
        val_7 = 1152921507209181152;
        this.prefabLookup.Add(key:  -1692633120, value:  -1692633120);
        val_5 = 1;
        label_4:
        if(val_5 < this.prefabLookup)
        {
            goto label_9;
        }
    
    }
    public UnityEngine.GameObject GetEmojiPrefab(string key)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_12;
        var val_13;
        var val_14;
        string val_1 = key.Trim();
        val_12 = this.emojiLookup;
        val_13 = "";
        string val_2 = key.ToUpper();
        if((val_12.ContainsKey(key:  key)) != false)
        {
                string val_4 = key.ToUpper();
            object val_5 = this.emojiLookup.Item[key];
            string val_6 = this.emojiLookup.ToString();
            string val_7 = this.emojiLookup.ToLower();
            val_13 = this.emojiLookup;
        }
        else
        {
                string val_8 = -1749705808(-1749705808) + key;
            val_12 = "no translated key value for ";
            UnityEngine.Debug.LogError(message:  -1749705808);
        }
        
        if((this.prefabLookup.ContainsKey(key:  1098586544)) != false)
        {
                UnityEngine.GameObject val_10 = this.prefabLookup.Item[1098586544];
            val_14 = this.prefabLookup;
            return;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "trying to get an emoji with key of ";
        typeof(System.String[]).__il2cppRuntimeField_14 = val_13;
        typeof(System.String[]).__il2cppRuntimeField_18 = " and name of ";
        typeof(System.String[]).__il2cppRuntimeField_1C = key;
        typeof(System.String[]).__il2cppRuntimeField_20 = " but we don\'t have a prefab for it";
        val_14 = 0;
        string val_11 = +477709520;
        UnityEngine.Debug.LogError(message:  477709520);
    }
    public EmojiManagerMinigames()
    {
    
    }

}
