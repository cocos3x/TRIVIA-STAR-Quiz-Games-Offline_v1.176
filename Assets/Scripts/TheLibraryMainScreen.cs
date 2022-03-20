using UnityEngine;
public class TheLibraryMainScreen : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button_back;
    private UnityEngine.UI.Button button_info;
    private UnityEngine.UI.Button button_new_books;
    private UnityEngine.UI.Button button_free_books;
    private UnityEngine.GameObject object_new_books_count;
    private UnityEngine.UI.Text text_new_books_count;
    private UnityEngine.UI.Text text_total_score;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UnityEngine.Transform xfm_content_group;
    private LibraryCollectionDisplay prefab_collection_display;
    private System.Collections.Generic.List<LibraryCollectionDisplay> collectionDisplayInstances;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1683236992, method:  new IntPtr(2611677632));
        this.button_back.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1683236992, method:  new IntPtr(2611686848));
        this.button_info.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1683236992, method:  new IntPtr(2611696064));
        this.button_new_books.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1683236992, method:  new IntPtr(2611705280));
        this.button_free_books.m_OnClick.AddListener(call:  162246656);
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1683236992, name:  -1702028064);
    }
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.xfm_content_group.gameObject;
        this.xfm_content_group.SetActive(value:  false);
        this.Refresh();
        this.Invoke(methodName:  -1688057264, time:  null);
    }
    public void Refresh()
    {
        TheLibraryMainScreen val_28;
        var val_29;
        var val_30;
        var val_31;
        float val_32;
        var val_41;
        val_28 = this;
        val_29 = 4;
        var val_9 =  - 4;
        System.Collections.Generic.List<BookInfo> val_10 = TheLibraryLogic.PurchasableBooks;
        string val_11 = 1.ToString();
        if(1 > 0)
        {
                0 = 1;
        }
        
        this.object_new_books_count.SetActive(value:  true);
        string val_13 = TheLibraryLogic.LibraryScore.ToString(format:  -1774412176);
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_14 = TheLibraryLogic.PlayerBooksByCollection;
        Dictionary.KeyCollection<TKey, TValue> val_15 = this.text_total_score.Keys;
        System.Collections.Generic.List<TSource> val_16 = System.Linq.Enumerable.ToList<System.Object>(source:  this.text_total_score);
        val_30 = this.text_total_score;
        val_30.Sort();
        val_31 = 0;
        val_32 = 1152921511494046688;
        val_41 = 0;
        goto label_66;
        label_73:
        var val_32 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_32 = val_32 + 0;
        UnityEngine.GameObject val_27 = (0 + 0) + 16.gameObject;
        val_30 = this.text_total_score.Count;
        if(val_41 < val_30)
        {
                0 = 1;
        }
        
        (0 + 0) + 16.SetActive(value:  true);
        val_41 = 1;
        label_66:
        if(val_41 < ((0 + 0) + 16))
        {
            goto label_73;
        }
    
    }
    private void OnBookGranted()
    {
        this.Refresh();
    }
    private void ShowScroll()
    {
        UnityEngine.GameObject val_1 = this.xfm_content_group.gameObject;
        this.xfm_content_group.SetActive(value:  true);
    }
    private void OnBackClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BackButtonPressed();
    }
    private void OnInfoClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void OnNewBooksClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void OnFreeBooksClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static LibraryWindowManager MonoSingleton<LibraryWindowManager>::get_Instance()) != 0)
        {
                return;
        }
    
    }
    public TheLibraryMainScreen()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.collectionDisplayInstances = null;
    }

}
