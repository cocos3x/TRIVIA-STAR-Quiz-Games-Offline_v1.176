using UnityEngine;
public class ChapterBookProgressBar : MonoBehaviour
{
    // Fields
    private ChapterBookProgressElement progressChapterElementPrefab;
    private UnityEngine.Transform elementGrid;
    private UnityEngine.Transform elementDividerGrid;
    private UnityEngine.Transform elementCoinGrid;
    private System.Collections.Generic.List<ChapterBookProgressElement> elementInstances;
    private System.Collections.Generic.List<ChapterBookProgressElement> elementDividerInstances;
    private System.Collections.Generic.List<ChapterBookProgressElement> elementCoinInstances;
    
    // Methods
    public void Setup(int playerLevel = -1, bool showIncomplete = False)
    {
        System.Collections.Generic.List<ChapterBookProgressElement> val_20;
        int val_21;
        bool val_22;
        var val_23;
        float val_24;
        val_20 = playerLevel;
        if(val_20 == 1)
        {
                Player val_1 = App.Player;
            val_20 = 0;
        }
        
        val_21 = val_20 - 1;
        val_22 = ChapterBookLogic.GetChaptersPerBook(playerLevel:  val_21);
        val_23 = ChapterBookLogic.GetCurrentChapter(playerLevel:  val_21);
        int val_5 = ChapterBookLogic.GetFirstLevelOfChapter(playerLevel:  val_21);
        if(val_22 >= 1)
        {
                val_5 = val_20 - val_5;
            val_21 = val_23 - 1;
            do
        {
            val_24 = 1f;
            if(val_21 <= 0)
        {
                if(showIncomplete == true)
        {
                (float)val_5 / ((float)ChapterBookLogic.GetLevelsPerChapter(playerLevel:  val_21)) = 0;
        }
        
            if(val_21 != 0)
        {
                val_24 = 0;
        }
        
        }
        
            if(0 >= showIncomplete)
        {
                object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  this.progressChapterElementPrefab, parent:  this.elementGrid);
            this.elementInstances.Add(item:  this.progressChapterElementPrefab);
            val_21 = val_21;
        }
        
            if(this.elementInstances <= 0)
        {
                var val_20 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_20 = val_20 + 0;
            UnityEngine.GameObject val_9 = (0 + 0) + 16.gameObject;
            (0 + 0) + 16.SetActive(value:  true);
            if(((0 + 0) + 16) <= 0)
        {
                var val_21 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_21 = val_21 + 0;
            val_20 = 0;
            int val_10 = 0 + 1;
            (0 + 0) + 16.Setup(chapter:  val_10, completeProgress:  (float)ChapterBookLogic.GetLevelsPerChapter(playerLevel:  val_21), lastChapterInBook:  0, isCurrentChapter:  val_22);
            if(0 >= ((0 + 0) + 16))
        {
                object val_11 = UnityEngine.Object.Instantiate<System.Object>(original:  this.progressChapterElementPrefab, parent:  this.elementCoinGrid);
            this.elementCoinInstances.Add(item:  this.progressChapterElementPrefab);
            val_21 = val_21;
        }
        
            if(this.elementCoinInstances <= 0)
        {
                var val_22 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_22 = val_22 + 0;
            UnityEngine.GameObject val_12 = (0 + 0) + 16.gameObject;
            (0 + 0) + 16.SetActive(value:  true);
            if(((0 + 0) + 16) <= 0)
        {
                var val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_23 = val_23 + 0;
            int val_13 = val_21 - 0;
            val_13 = val_13 >> 5;
            (0 + 0) + 16.SetupAsCoin(chapter:  val_10, completeProgress:  (float)ChapterBookLogic.GetLevelsPerChapter(playerLevel:  val_21), lastChapterInBook:  0, isCurrentChapter:  val_22);
            if(0 >= ((0 + 0) + 16))
        {
                object val_14 = UnityEngine.Object.Instantiate<System.Object>(original:  this.progressChapterElementPrefab, parent:  this.elementDividerGrid);
            val_20 = this.elementDividerInstances;
            val_20.Add(item:  this.progressChapterElementPrefab);
        }
        
            if(val_20 <= 0)
        {
                var val_24 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_24 = val_24 + 0;
            UnityEngine.GameObject val_15 = (0 + 0) + 16.gameObject;
            (0 + 0) + 16.SetActive(value:  true);
            if(((0 + 0) + 16) <= 0)
        {
                var val_25 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_25 = val_25 + 0;
            int val_26 = val_22 - 1;
            val_26 = val_26 - 0;
            (0 + 0) + 16.SetupAsDivider(lastElement:  val_26 >> 5);
            val_23 = val_10;
        }
        while(val_22 != val_10);
        
        }
        
        if(((0 + 0) + 16) <= val_22)
        {
            goto label_48;
        }
        
        val_20 = val_22;
        goto label_49;
        label_55:
        if(((0 + 0) + 16) <= val_20)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_27 = val_27 + (val_20 << 2);
        UnityEngine.GameObject val_17 = (0 + (val_2) << 2) + 16.gameObject;
        (0 + (val_2) << 2) + 16.SetActive(value:  false);
        val_20 = val_20 + 1;
        label_49:
        if(val_20 < ((0 + (val_2) << 2) + 16))
        {
            goto label_55;
        }
        
        label_48:
        if(((0 + (val_2) << 2) + 16) <= val_22)
        {
            goto label_57;
        }
        
        val_20 = val_22;
        goto label_58;
        label_64:
        if(((0 + (val_2) << 2) + 16) <= val_20)
        {
                var val_28 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + (val_20 << 2);
        UnityEngine.GameObject val_18 = (0 + (val_2) << 2) + 16.gameObject;
        (0 + (val_2) << 2) + 16.SetActive(value:  false);
        val_20 = val_20 + 1;
        label_58:
        if(val_20 < ((0 + (val_2) << 2) + 16))
        {
            goto label_64;
        }
        
        label_57:
        if(((0 + (val_2) << 2) + 16) > val_22)
        {
            goto label_66;
        }
        
        return;
        label_73:
        if(((0 + (val_2) << 2) + 16) <= val_22)
        {
                var val_29 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_29 = val_29 + (val_22 << 2);
        UnityEngine.GameObject val_19 = (0 + (val_2) << 2) + 16.gameObject;
        (0 + (val_2) << 2) + 16.SetActive(value:  false);
        val_22 = val_22 + 1;
        label_66:
        if(val_22 < ((0 + (val_2) << 2) + 16))
        {
            goto label_73;
        }
    
    }
    public ChapterBookProgressBar()
    {
        this.elementInstances = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.elementDividerInstances = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.elementCoinInstances = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }

}
