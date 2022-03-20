using UnityEngine;
public class TheLibraryBooksEarnedScreen : MonoBehaviour
{
    // Fields
    public int startingBookIndex;
    private UnityEngine.UI.Button button_close;
    private UnityEngine.UI.Button button_library;
    private UnityEngine.UI.LoopVerticalScrollRect loopScrollRect;
    private int booksBeyondEarned;
    private int curr_total;
    private System.Action OnCloseCallback;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1675324720, method:  new IntPtr(2619608336));
        this.button_close.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1675324720, method:  new IntPtr(2619617552));
        this.button_library.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        TheLibraryUI.HideMainUICanvas();
        System.Collections.Generic.List<System.String> val_2 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        int val_11 = this.booksBeyondEarned;
        this.startingBookIndex = (val_1 + TheLibraryLogic.__il2cppRuntimeField_namespaze);
        val_11 = 1152921507228252609 + val_11;
        this.curr_total = val_11;
        System.Collections.Generic.List<System.String> val_4 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        string val_5 = PrettyPrint.printJSON(obj:  299999232, types:  false, singleLineOutput:  false);
        string val_6 = -1675220336(-1675220336) + 299999232;
        SLCDebug.Log(logMessage:  -1675220336, colorHash:  -1835139200, isError:  false);
        char* val_7 = 1152921507228252609 - (ChapterBookLogic.GetCurrentBook(playerLevel:  0));
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        val_7 = val_7 >> 5;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = null;
        string val_8 = System.String.Format(format:  -1675220240, args:  472754880);
        SLCDebug.Log(logMessage:  -1675220240, colorHash:  -1835139200, isError:  false);
        mem2[0] = this.curr_total;
        System.Collections.IEnumerator val_9 = this.WaitAndCenterGrid();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -1675191760);
    }
    private void OnDisable()
    {
        TheLibraryUI.ShowMainUICanvas();
    }
    public void DisplayBooksEarned(System.Action onCloseCallback)
    {
        if(onCloseCallback != 0)
        {
                this.OnCloseCallback = onCloseCallback;
        }
    
    }
    public void OnGridItemBookClicked(int bookIndex, int chapter)
    {
        if((bookIndex + 1) > (ChapterBookLogic.GetCurrentBook(playerLevel:  0)))
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1674841424, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        GameBehavior val_4 = App.getBehavior;
        System.Action val_6 = new System.Action(object:  -1674841424, method:  new IntPtr(2620100848));
        0.DisplayBookProgress(bookIndex:  bookIndex, chapterNumber:  chapter, onClosedCallback:  7454720);
    }
    private System.Collections.IEnumerator WaitAndCenterGrid()
    {
        object val_1 = new System.Object();
        typeof(TheLibraryBooksEarnedScreen.<WaitAndCenterGrid>d__12).__il2cppRuntimeField_8 = 0;
        typeof(TheLibraryBooksEarnedScreen.<WaitAndCenterGrid>d__12).__il2cppRuntimeField_10 = this;
    }
    private void CenterGrid()
    {
        this.loopScrollRect.RefillCells(offset:  this.curr_total + (~this.booksBeyondEarned));
    }
    private void OnBackClicked()
    {
        if(this.OnCloseCallback != 0)
        {
                this.OnCloseCallback.Invoke();
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1674493136, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnLibraryClicked()
    {
        var val_5;
        var val_5 = 25460511;
        val_5 = 10165280 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 59;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1685569840) == 0)
        {
                System.Action val_3 = new System.Action(object:  -1674376016, method:  new IntPtr(2620566256));
            TheLibraryUI.ShowTheLibrary(onCloseAction:  7454720);
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1674376016, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1674264016, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TheLibraryBooksEarnedScreen()
    {
        this.booksBeyondEarned = 6;
    }
    private void <OnGridItemBookClicked>b__11_0()
    {
        GameBehavior val_1 = App.getBehavior;
        if(this.OnCloseCallback != 0)
        {
                mem[36] = this.OnCloseCallback;
        }
    
    }
    private void <OnLibraryClicked>b__15_0()
    {
        GameBehavior val_1 = App.getBehavior;
        if(this.OnCloseCallback != 0)
        {
                mem[36] = this.OnCloseCallback;
        }
    
    }

}
