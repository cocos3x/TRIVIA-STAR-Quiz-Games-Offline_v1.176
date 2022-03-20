using UnityEngine;
private sealed class WPTLetterTile.<>c__DisplayClass54_0
{
    // Fields
    public WordPets.WPTLetterTile <>4__this;
    public bool state;
    
    // Methods
    public WPTLetterTile.<>c__DisplayClass54_0()
    {
    
    }
    internal void <ToggleSpiderWeb>b__0()
    {
        if(this.state == true)
        {
                this.state = 1;
        }
        
        this.<>4__this.spiderWeb.enabled = this.<>4__this.spiderWeb.enabled;
    }

}
