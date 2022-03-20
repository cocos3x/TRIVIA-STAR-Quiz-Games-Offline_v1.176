using UnityEngine;
private sealed class MinigameManager.<>c__DisplayClass64_0
{
    // Fields
    public SLC.Minigames.MinigameManager <>4__this;
    public SLC.Minigames.MinigameLevelRank currentRank;
    
    // Methods
    public MinigameManager.<>c__DisplayClass64_0()
    {
    
    }
    internal bool <HandleLevelComplete>b__0(int x)
    {
        x = this.currentRank.rankLevel + x;
        if((this.<>4__this.currentPlayerLevel) >= x)
        {
                0 = 1;
        }
        
        return true;
    }
    internal bool <HandleLevelComplete>b__1(SLC.Minigames.MinigameLevelRank x)
    {
        if((this.<>4__this.currentPlayerLevel) >= x.rankLevel)
        {
                0 = 1;
        }
        
        return true;
    }

}
