using UnityEngine;
public class TriviaPursuitCategory
{
    // Fields
    private const string KEY_CATEGORY = "category";
    private const string KEY_PROGRESS = "progress";
    public string CategoryName;
    public int Progress;
    
    // Methods
    public bool IsCompleted()
    {
        float val_1 = this.GetProgress();
        if()
        {
                0 = 1;
        }
        
        return true;
    }
    public float GetProgress()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        float val_2 = (float)mem[1152921512476916388] + 8;
        val_2 = (float)this.Progress / val_2;
        return (float)val_2;
    }
    public string GetProgressText()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_2 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    public void Parse(string data)
    {
        string val_9 = data;
        if((System.String.IsNullOrEmpty(value:  val_9 = data)) == true)
        {
                return;
        }
        
        object val_2 = MiniJSON.Json.Deserialize(json:  val_9);
        val_9 = "category";
        if((0.ContainsKey(key:  -490682048)) != false)
        {
                string val_4 = 0.Item[-490682048];
            val_9 = 0;
            this.CategoryName = val_9;
        }
        
        if((0.ContainsKey(key:  -1545439648)) == false)
        {
                return;
        }
        
        string val_6 = 0.Item[-1545439648];
        bool val_8 = System.Int32.TryParse(s:  null, result: out  this.Progress);
    }
    public override string ToString()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -490682048, value:  this.CategoryName);
        Add(key:  -1545439648, value:  13152256);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
    }
    public TriviaPursuitCategory()
    {
    
    }

}
