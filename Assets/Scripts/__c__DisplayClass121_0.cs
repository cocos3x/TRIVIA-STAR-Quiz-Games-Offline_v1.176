using UnityEngine;
private sealed class WPTGameUIController.<>c__DisplayClass121_0
{
    // Fields
    public WordPets.WPTGameUIController <>4__this;
    public System.Action onDeselectComplete;
    
    // Methods
    public WPTGameUIController.<>c__DisplayClass121_0()
    {
    
    }
    internal void <DeselectTile>b__0()
    {
        this.<>4__this.processingPetAnimation = false;
        this.<>4__this.CheckWord();
    }
    internal void <DeselectTile>b__1()
    {
        this.onDeselectComplete.Invoke();
    }

}
