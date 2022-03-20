using UnityEngine;
public class WGFreeTilePopup : MonoBehaviour
{
    // Fields
    private UGUINetworkedButton Button_Entry;
    private UnityEngine.GameObject group_sorry;
    private UGUINetworkedButton Button_WatchAnother;
    private UnityEngine.UI.Button Button_Close_Sorry;
    protected UnityEngine.GameObject group_success;
    private UnityEngine.UI.Button Button_CollectHint;
    private UnityEngine.GameObject currentAlphabetTileObject;
    private HeyZapAdTag currTag;
    private bool gotVideoResponse;
    
    // Methods
    private void Awake()
    {
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -1556698816, method:  new IntPtr(2738225024));
        this.Button_WatchAnother.OnConnectionClick = null;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1556698816, method:  new IntPtr(2738234240));
        this.Button_Close_Sorry.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1556698816, method:  new IntPtr(2738243456));
        this.Button_CollectHint.m_OnClick.AddListener(call:  162246656);
    }
    public void OnEnable()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1556549952, name:  2128120864);
        this.Button_Entry.interactable = false;
        this.group_success.SetActive(value:  false);
        this.Button_CollectHint.interactable = false;
        this.group_sorry.SetActive(value:  false);
        this.OnFreeHintClick(result:  true);
    }
    public void OnFreeHintClick(bool result)
    {
        var val_13;
        System.String[] val_14;
        var val_15;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        if(result == false)
        {
            goto label_1;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowIncentivizedVideo(tag:  this.currTag, adCapExempt:  false)) == false)
        {
            goto label_5;
        }
        
        this.gotVideoResponse = false;
        return;
        label_1:
        GameBehavior val_3 = App.getBehavior;
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        val_13 = "connection_required_explanation";
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        val_14 = null;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_15 = 0;
        if(val_15 == 0)
        {
                val_15 = 0;
        }
        
        val_19 = "internet_required_upper";
        val_20 = val_13;
        goto label_22;
        label_5:
        GameBehavior val_8 = App.getBehavior;
        string val_10 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
        string val_11 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
        val_18 = "no_videos_explanation";
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        val_14 = null;
        string val_12 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_later_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_21 = null;
        val_13 = "unavailable_upper";
        val_22 = 0;
        if( == 0)
        {
                val_22 = 0;
        }
        
        val_19 = ;
        val_20 = val_18;
        label_22:
        val_22.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  val_14, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        mem[1152921511640364108].interactable = true;
        this.Close();
    }
    public void OnVideoResponse(Notification notif)
    {
        string val_1 = notif.data.ToString();
        bool val_2 = System.Boolean.Parse(value:  notif.data);
        this.group_success.SetActive(value:  val_2);
        this.Button_CollectHint.interactable = val_2;
        this.group_sorry.SetActive(value:  val_2 ^ 1);
        this.gotVideoResponse = true;
    }
    public void OnCollectClicked()
    {
        this.Button_CollectHint.interactable = false;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C = this.currentAlphabetTileObject;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CollectCurrentVideoRewardTile();
        System.Collections.IEnumerator val_3 = this.CloseAfterDelay();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1556140224);
    }
    private System.Collections.IEnumerator CloseAfterDelay()
    {
        object val_1 = new System.Object();
        typeof(WGFreeTilePopup.<CloseAfterDelay>d__14).__il2cppRuntimeField_8 = 0;
        typeof(WGFreeTilePopup.<CloseAfterDelay>d__14).__il2cppRuntimeField_10 = this;
    }
    private void OnApplicationPause(bool pause)
    {
        if(pause != false)
        {
                return;
        }
        
        if(this.gotVideoResponse == true)
        {
                return;
        }
        
        R4 + 28.SetActive(value:  false);
        R4 + 32.interactable = false;
        R4 + 16.SetActive(value:  true);
    }
    private void Cancel()
    {
        this.Button_Entry.interactable = true;
        this.Close();
    }
    private void Close()
    {
        this.group_success.SetActive(value:  false);
        this.group_sorry.SetActive(value:  false);
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDisable()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -1555547456, name:  2128120864);
    }
    public WGFreeTilePopup()
    {
        this.currTag = 12;
    }

}
