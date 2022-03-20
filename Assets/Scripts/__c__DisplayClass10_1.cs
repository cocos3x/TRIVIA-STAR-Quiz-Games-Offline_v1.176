using UnityEngine;
private sealed class WPTBoulderActor.<>c__DisplayClass10_1
{
    // Fields
    public WordPets.WPTGameTile currTile;
    public WordPets.WPTBoulderActor.<>c__DisplayClass10_0 CS$<>8__locals1;
    
    // Methods
    public WPTBoulderActor.<>c__DisplayClass10_1()
    {
    
    }
    internal void <ExecuteAction>b__1()
    {
        if((this.CS$<>8__locals1.onTileCollide) == 0)
        {
                return;
        }
        
        this.CS$<>8__locals1.onTileCollide.Invoke(obj:  this.currTile);
    }

}
