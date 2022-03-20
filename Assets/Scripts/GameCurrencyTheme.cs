using UnityEngine;
[Serializable]
public class GameCurrencyTheme : ScriptableObject
{
    // Fields
    private string mainCurrencyPrettyName;
    
    // Properties
    public string MainCurrencyPrettyName { get; }
    
    // Methods
    public string get_MainCurrencyPrettyName()
    {
        if((System.String.IsNullOrEmpty(value:  this.mainCurrencyPrettyName)) == false)
        {
                return;
        }
        
        this.mainCurrencyPrettyName = "Credits";
    }
    public GameCurrencyTheme()
    {
        this.mainCurrencyPrettyName = "";
    }

}
