using UnityEngine;
public class KeyToRichesEventHandler.EventProgress
{
    // Fields
    public int id;
    public int keyCount;
    public int levelsCounter;
    public bool collected;
    public bool skipped;
    public int keyWordIndex;
    public int cellIndex;
    public bool keyFtuxShown;
    public bool eventButtonFtuxShown;
    
    // Methods
    public KeyToRichesEventHandler.EventProgress()
    {
        this.keyWordIndex = 0;
        this.cellIndex = 0;
    }

}
