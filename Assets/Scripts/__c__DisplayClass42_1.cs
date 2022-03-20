using UnityEngine;
private sealed class WADChapterManager.<>c__DisplayClass42_1
{
    // Fields
    public System.Collections.Generic.List<GameLevel> levelSkipLevels;
    public int levelSkipStartIndex;
    
    // Methods
    public WADChapterManager.<>c__DisplayClass42_1()
    {
    
    }
    internal bool <GetGameLevelForPlayerLevelFromChapter>b__4(SkippedLevel skippedLevel)
    {
        if(true <= this.levelSkipStartIndex)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (this.levelSkipStartIndex << 2);
        if(skippedLevel.word != null)
        {
                return skippedLevel.word.Equals(value:  (0 + (this.levelSkipStartIndex) << 2) + 16 + 48);
        }
        
        return skippedLevel.word.Equals(value:  (0 + (this.levelSkipStartIndex) << 2) + 16 + 48);
    }

}
