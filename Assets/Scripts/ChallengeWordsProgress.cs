using UnityEngine;
public class WGChallengeWordsManager.ChallengeWordsProgress
{
    // Fields
    private const string LEVEL_KEY = "Words_Level_Key";
    private const string WORD_INDEX_KEY = "Word_Index_Key";
    private int _level;
    private int _wordIndex;
    private bool inited;
    
    // Properties
    public int Level { get; set; }
    public int WordIndex { get; set; }
    
    // Methods
    public int get_Level()
    {
        if(this.inited == false)
        {
                this.inited = this;
            this.InitProgress();
        }
        
        return (int)this._level;
    }
    public void set_Level(int value)
    {
        this._level = value;
        this.SaveProgress();
    }
    public int get_WordIndex()
    {
        if(this.inited == false)
        {
                this.inited = this;
            this.InitProgress();
        }
        
        return (int)this._wordIndex;
    }
    public void set_WordIndex(int value)
    {
        this._wordIndex = value;
        this.SaveProgress();
    }
    private void SaveProgress()
    {
        var val_5;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1477174656, value:  13152256);
        Add(key:  -1477174544, value:  13152256);
        var val_5 = 28881523;
        val_5 = 6744264 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        string val_2 = -1477174448(-1477174448) + 295313408;
        string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1477174448, value:  78753792);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void InitProgress()
    {
        var val_13;
        var val_14;
        var val_13 = 28882387;
        val_13 = 6743400 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        string val_1 = -1477174448(-1477174448) + 295313408;
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1477174448);
        val_14 = "ChallengeWordsProgress";
        if((System.String.IsNullOrEmpty(value:  -1477174448)) == true)
        {
                return;
        }
        
        object val_4 = MiniJSON.Json.Deserialize(json:  -1477174448);
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_17;
        }
        
        }
        
        label_17:
        val_14 = "Words_Level_Key";
        if((0.ContainsKey(key:  -1477174656)) != false)
        {
                string val_6 = 0.Item[-1477174656];
            val_14 = 0;
            bool val_8 = System.Int32.TryParse(s:  null, result: out  this._level);
        }
        
        if((0.ContainsKey(key:  -1477174544)) != false)
        {
                string val_10 = 0.Item[-1477174544];
            bool val_12 = System.Int32.TryParse(s:  null, result: out  this._wordIndex);
        }
        
        this.inited = true;
    }
    public WGChallengeWordsManager.ChallengeWordsProgress()
    {
        this._wordIndex = 0;
    }

}
