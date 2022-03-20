using UnityEngine;
[Serializable]
private sealed class ChapterRef.<>c
{
    // Fields
    public static readonly BlockPuzzleMagic.ChapterRef.<>c <>9;
    public static System.Comparison<BlockPuzzleMagic.LevelRef> <>9__7_0;
    
    // Methods
    private static ChapterRef.<>c()
    {
        ChapterRef.<>c.<>9 = new System.Object();
    }
    public ChapterRef.<>c()
    {
    
    }
    internal int <Sort>b__7_0(BlockPuzzleMagic.LevelRef x, BlockPuzzleMagic.LevelRef y)
    {
        if(y != 0)
        {
                return x.levelId.CompareTo(value:  y.levelId);
        }
        
        return x.levelId.CompareTo(value:  y.levelId);
    }

}
