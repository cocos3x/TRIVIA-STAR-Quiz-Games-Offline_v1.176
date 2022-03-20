using UnityEngine;
public class TheLibraryBookProgressPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button_close;
    private UnityEngine.UI.LoopScrollRect loopScrollRect;
    private TheLibraryBooksEarnedGridItem book_progress_display;
    private int currentBookIndex;
    private int currentChapterNumber;
    private int curr_total;
    private System.Action OnClosedCallback;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1677348144, method:  new IntPtr(2617594128));
        this.button_close.m_OnClick.AddListener(call:  162246656);
    }
    public void DisplayBookProgress(int bookIndex, int chapterNumber, System.Action onClosedCallback)
    {
        this.OnClosedCallback = onClosedCallback;
        this.currentBookIndex = bookIndex;
        this.currentChapterNumber = chapterNumber;
        int val_2 = ChapterBookLogic.GetLevelsPerChapter(book:  bookIndex + 1, chapter:  chapterNumber);
        this.curr_total = val_2;
        this.loopScrollRect.totalCount = val_2;
        this.loopScrollRect.RefillCells(offset:  0);
        System.Action<System.Int32, System.Int32> val_3 = new System.Action<System.Int32, System.Int32>(object:  -1677205424, method:  new IntPtr(2617731728));
        this.book_progress_display.SetupGridItem(bookIndex:  bookIndex, onClickedGridItem:  7507968);
        this.book_progress_display.ToggleChapterSelected(chapter:  chapterNumber);
    }
    public void SetupGridItem(WGChapterSelectLevelItem gridItem, int i)
    {
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = i;
        if(this.curr_total > val_9)
        {
                int val_2 = ChapterBookLogic.GetCumulativeLevelFromBookAndChapter(book:  this.currentBookIndex + 1, chapter:  this.currentChapterNumber, levelInChapterIndex:  val_9);
            WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_10 = 0;
            if(val_2 <= MaxPredefinedLevels)
        {
                WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            GameLevel val_6 = GetGameLevelForPlayerLevelFromChapter(playerLevel:  val_2, checkLevelSkip:  true);
            val_10 = public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance();
        }
        
            Player val_7 = App.Player;
            val_9 = null;
            val_9 = new System.Action<System.Int32>(object:  -1677067824, method:  new IntPtr(2617874448));
            val_11 = val_2;
            val_12 = 0;
            val_13 = public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance().__il2cppRuntimeField_30;
        }
        else
        {
                val_11 = 0;
            val_12 = 0;
            val_13 = "";
        }
        
        gridItem.Setup(levelName:  0, currentLevel:  0, levelWord:  1098586544, playLevelCallback:  0);
    }
    private void OnPlayLevelClicked(int level)
    {
        var val_10;
        TheLibraryUI.ForceTheLibraryClose();
        GameBehavior val_1 = App.getBehavior;
        if(0 == 2)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != true)
        {
                if(CategoryPacksManager.IsPlaying == false)
        {
            goto label_12;
        }
        
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayingChallenge = false;
        var val_10 = 27279775;
        val_10 = 8346016 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 60;
        GameBehavior val_6 = App.getBehavior;
        label_12:
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowingWindow<WordHuntPopup>()) != false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseCurrentWindow();
    }
    private void OnChapterClicked(int bookIndex, int chapter)
    {
        this.DisplayBookProgress(bookIndex:  bookIndex, chapterNumber:  chapter, onClosedCallback:  this.OnClosedCallback);
    }
    private void OnCloseClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1676713392, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(this.OnClosedCallback == 0)
        {
                return;
        }
        
        this.OnClosedCallback.Invoke();
    }
    public TheLibraryBookProgressPopup()
    {
        this.currentBookIndex = 0;
        this.currentChapterNumber = 0;
    }

}
