using UnityEngine;
public class TheLibraryBookProgressDisplay : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<TheLibraryBookProgressElement> chapterDisplay;
    private UnityEngine.UI.Image image_chapter_background;
    private UnityEngine.Color color_chapter_background_darkened;
    private int displayedBookIndex;
    private System.Action<int, int> OnChapterItemClicked;
    
    // Methods
    public void Setup(int bookIndex, TheLibrary.ProgressState state, System.Action<int, int> onChapterItemClicked)
    {
        this.displayedBookIndex = bookIndex;
        this.OnChapterItemClicked = onChapterItemClicked;
        if(state == 0)
        {
            goto label_0;
        }
        
        if(state == 2)
        {
            goto label_1;
        }
        
        if(state != 1)
        {
                return;
        }
        
        this.SetupElementsForCurrentBook();
        return;
        label_0:
        this.SetupElementsForCompletedBook(bookIndex:  bookIndex);
        return;
        label_1:
        this.SetupElementsForFutureBook(bookIndex:  bookIndex);
    }
    public void ToggleChapterSelected(int chapter)
    {
        var val_3 = 0;
        goto label_1;
        label_6:
        if(true <= val_3)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        chapter = ((chapter - 1) - val_3) >> 5;
        (0 + 0) + 16.ToggleChapterSelected(isOn:  chapter, dimOthers:  true);
        val_3 = 1;
        label_1:
        if(val_3 < ((0 + 0) + 16))
        {
            goto label_6;
        }
    
    }
    private void SetupElementsForCurrentBook()
    {
        int val_13;
        var val_14;
        var val_15;
        Player val_1 = App.Player;
        val_13 = 0;
        val_14 = ChapterBookLogic.GetChaptersPerBook(playerLevel:  0);
        val_15 = ChapterBookLogic.GetLevelsPerChapter(playerLevel:  0);
        int val_5 = ChapterBookLogic.GetFirstLevelOfChapter(playerLevel:  0);
        if(val_14 >= 1)
        {
                val_5 = val_13 - val_5;
            int val_6 = (ChapterBookLogic.GetCurrentChapter(playerLevel:  0)) - 1;
            do
        {
            if(val_6 <= 0)
        {
                1f = 0;
        }
        
            if(val_5 <= 0)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_13 = val_13 + 0;
            UnityEngine.GameObject val_8 = (0 + 0) + 16.gameObject;
            var val_14 = 1;
            (0 + 0) + 16.SetActive(value:  true);
            if(val_6 == 0)
        {
                2 = 1;
        }
        
            if(0 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_14 = val_14 + 0;
            val_15 = mem[(1 + 0) + 16];
            val_15 = (1 + 0) + 16;
            System.Action<System.Int32> val_9 = new System.Action<System.Int32>(object:  -1679865472, method:  new IntPtr(2615056320));
            val_13 = 0 + 1;
            val_15.Setup(chapter:  val_13, completeProgress:  0 = (float)val_5 / (float)val_15, lastChapterInBook:  1f, state:  -2100862560, interactable:  false, chapterClickAction:  1);
        }
        while(val_14 != val_13);
        
        }
        
        if(val_15 > val_14)
        {
            goto label_16;
        }
        
        goto label_17;
        label_23:
        if(val_15 <= val_14)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + (val_14 << 2);
        UnityEngine.GameObject val_10 = (0 + (val_2) << 2) + 16.gameObject;
        (0 + (val_2) << 2) + 16.SetActive(value:  false);
        val_14 = val_14 + 1;
        label_16:
        if(val_14 < ((0 + (val_2) << 2) + 16))
        {
            goto label_23;
        }
        
        label_17:
        if(this.image_chapter_background == 0)
        {
                return;
        }
        
        UnityEngine.Color val_12 = UnityEngine.Color.white;
        this.image_chapter_background.color = new UnityEngine.Color() {a = ???};
    }
    private void SetupElementsForFutureBook(int bookIndex)
    {
        var val_7;
        var val_8;
        var val_9;
        float val_10;
        System.Collections.Generic.List<TheLibraryBookProgressElement> val_11;
        float val_12;
        int val_2 = ChapterBookLogic.GetChaptersFromBook(bookNum:  bookIndex + 1);
        val_7 = val_2;
        val_8 = 4;
        val_9 = 2;
        val_10 = 1152921511095919008;
        goto label_3;
        label_11:
        if(val_2 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_3 = R6 + 8 + 16.gameObject;
        R6 + 8 + 16.SetActive(value:  true);
        if((R6 + 8 + 16) <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Action<System.Int32> val_4 = new System.Action<System.Int32>(object:  -1679700224, method:  new IntPtr(2615056320));
        16787456.Setup(chapter:  1, completeProgress:  null, lastChapterInBook:  0, state:  -2100862560, interactable:  true, chapterClickAction:  0);
        val_8 = 5;
        label_3:
        val_11 = this.chapterDisplay;
        val_12 = val_8 - 4;
        if(val_12 < val_7)
        {
            goto label_11;
        }
        
        if(16787456 > val_7)
        {
            goto label_12;
        }
        
        goto label_13;
        label_19:
        if(16787456 <= val_7)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (val_7 << 2);
        UnityEngine.GameObject val_5 = (0 + (val_2) << 2) + 16.gameObject;
        val_11 = (0 + (val_2) << 2) + 16;
        val_11.SetActive(value:  false);
        val_7 = val_7 + 1;
        label_12:
        if(val_7 < val_11)
        {
            goto label_19;
        }
        
        label_13:
        if(this.image_chapter_background == 0)
        {
                return;
        }
        
        val_10 = this.color_chapter_background_darkened;
        this.image_chapter_background.color = new UnityEngine.Color() {r = val_10, g = val_12, b = 2.802597E-45f, a = this.chapterDisplay};
    }
    private void SetupElementsForCompletedBook(int bookIndex)
    {
        var val_8;
        var val_9;
        System.Collections.Generic.List<TheLibraryBookProgressElement> val_10;
        var val_11;
        int val_2 = ChapterBookLogic.GetChaptersFromBook(bookNum:  bookIndex + 1);
        val_8 = val_2;
        val_9 = 4;
        goto label_3;
        label_11:
        if(val_2 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_3 = R6 + 8 + 16.gameObject;
        R6 + 8 + 16.SetActive(value:  true);
        if((R6 + 8 + 16) <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Action<System.Int32> val_4 = new System.Action<System.Int32>(object:  -1679539072, method:  new IntPtr(2615056320));
        16787456.Setup(chapter:  1, completeProgress:  null, lastChapterInBook:  1065353216, state:  -2100862560, interactable:  false, chapterClickAction:  1);
        val_9 = 5;
        label_3:
        val_10 = this.chapterDisplay;
        val_11 = val_9 - 4;
        if(val_11 < val_8)
        {
            goto label_11;
        }
        
        if(16787456 > val_8)
        {
            goto label_12;
        }
        
        goto label_13;
        label_19:
        if(16787456 <= val_8)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (val_8 << 2);
        UnityEngine.GameObject val_5 = (0 + (val_2) << 2) + 16.gameObject;
        val_10 = (0 + (val_2) << 2) + 16;
        val_10.SetActive(value:  false);
        val_8 = val_8 + 1;
        label_12:
        if(val_8 < val_10)
        {
            goto label_19;
        }
        
        label_13:
        if(this.image_chapter_background == 0)
        {
                return;
        }
        
        UnityEngine.Color val_7 = UnityEngine.Color.white;
        this.image_chapter_background.color = new UnityEngine.Color() {a = ???};
    }
    private void OnElementClicked(int elementChapter)
    {
        if(this.OnChapterItemClicked == 0)
        {
                return;
        }
        
        this.OnChapterItemClicked.Invoke(arg1:  this.displayedBookIndex, arg2:  elementChapter);
    }
    public TheLibraryBookProgressDisplay()
    {
        this.displayedBookIndex = 0;
    }

}
