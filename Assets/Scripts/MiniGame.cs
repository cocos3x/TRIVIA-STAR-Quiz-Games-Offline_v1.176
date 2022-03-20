using UnityEngine;
[Serializable]
public class MiniGame
{
    // Fields
    public string id;
    public string name;
    public string scene;
    public string sprite;
    public int unlockLevel;
    public string dlcPack;
    public int deeplinkIndex;
    public bool enabled;
    
    // Properties
    public int UnlockLevel { get; }
    
    // Methods
    public int get_UnlockLevel()
    {
        int val_7;
        GameEcon val_1 = App.getGameEcon;
        if((1233 != 0) && (1233.Count >= 1))
        {
                if((1233.ContainsKey(key:  this.id)) != false)
        {
                string val_4 = 1233.Item[this.id];
            bool val_6 = System.Int32.TryParse(s:  1233, result: out  int val_5 = -1744447524);
            if(0 <= 1)
        {
                val_7 = this.unlockLevel;
        }
        
            return val_7;
        }
        
        }
        
        val_7 = this.unlockLevel;
        return val_7;
    }
    public MiniGame()
    {
        this.enabled = true;
    }

}
