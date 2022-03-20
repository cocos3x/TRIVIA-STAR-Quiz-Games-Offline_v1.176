using UnityEngine;
private sealed class WordQuizUIController.<>c__DisplayClass21_1
{
    // Fields
    public SLC.Minigames.WordQuiz.WordQuizLetterTile tile;
    public SLC.Minigames.WordQuiz.WordQuizUIController <>4__this;
    
    // Methods
    public WordQuizUIController.<>c__DisplayClass21_1()
    {
    
    }
    internal void <InitializeLevel>b__1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(ShouldShowFTUX() != false)
        {
                return;
        }
        
        this.<>4__this.OnTileDeselected(tile:  this.tile, fromHint:  false);
        this.tile.SetHiddenState(hidden:  true);
    }

}
