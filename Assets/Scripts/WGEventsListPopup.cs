using UnityEngine;
public class WGEventsListPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text titleText;
    private UnityEngine.Transform buttonsParent;
    private UnityEngine.UI.Button closeButton;
    private bool displayEventQuantity;
    private EventListItem _EventListItemPrefab;
    
    // Properties
    private EventListItem EventListItemPrefab { get; }
    
    // Methods
    private EventListItem get_EventListItemPrefab()
    {
        if(this._EventListItemPrefab != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1535358816);
        this._EventListItemPrefab = "Events";
    }
    private void OnEnable()
    {
        WGEventHandler val_14;
        ButtonClickedEvent val_23;
        var val_24;
        float val_25;
        var val_26;
        var val_27;
        WGEventsListPopup val_28;
        val_23 = this.closeButton.m_OnClick;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1286742992, method:  new IntPtr(3008186592));
        val_23.AddListener(call:  162246656);
        val_24 = 1152921504901095424;
        val_25 = 1152921511095741472;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
                UnityEngine.GameObject val_4 = this.gameObject;
            SLCWindow.CloseWindow(window:  -1286742992, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        if(this.displayEventQuantity != false)
        {
                string val_5 = Localization.Localize(key:  -1286775488, defaultValue:  -1286775584, useSingularKey:  false);
            val_26 = "events_x_upper";
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_8 = GetCurrentEventsCount.ToString();
            val_27 = val_26;
            string val_9 = System.String.Format(format:  -1286775488, arg0:  -1286755032);
        }
        else
        {
                val_27 = "active_events_upper";
            string val_10 = Localization.Localize(key:  -1286775296, defaultValue:  -1286775392, useSingularKey:  false);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<WGEventHandler> val_12 = GetOrderedEventHandlers();
        List.Enumerator<T> val_13 = GetEnumerator();
        val_25 = 1152921504614248448;
        val_24 = 1152921511910006384;
        goto label_19;
        label_30:
        EventListItem val_15 = this.EventListItemPrefab;
        object val_16 = UnityEngine.Object.Instantiate<System.Object>(original:  -1286742992, parent:  this.buttonsParent);
        object val_17 = this.GetComponent<System.Object>();
        this.InitWithEventHandler(handler:  val_14);
        UnityEngine.GameObject val_18 = this.gameObject;
        object val_19 = this.GetComponent<System.Object>();
        val_23 = this;
        System.Action<System.Boolean> val_20 = new System.Action<System.Boolean>(object:  -1286742992, method:  new IntPtr(3008192112));
        System.Delegate val_21 = System.Delegate.Combine(a:  -1286742992, b:  7401472);
        val_28 = 0;
        if(this != 0)
        {
                if(null != null)
        {
            
        }
        else
        {
                val_28 = this;
        }
        
        }
        
        mem[1152921511910038876] = val_28;
        label_19:
        if(MoveNext() == true)
        {
            goto label_30;
        }
        
        Dispose();
    }
    private System.Collections.IEnumerator UpdateTitleCounter()
    {
        object val_1 = new System.Object();
        typeof(WGEventsListPopup.<UpdateTitleCounter>d__8).__il2cppRuntimeField_8 = 0;
        typeof(WGEventsListPopup.<UpdateTitleCounter>d__8).__il2cppRuntimeField_10 = this;
    }
    private void OnClose(bool eventClicked = False)
    {
        var val_4;
        var val_4 = 28370295;
        val_4 = 7255492 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1286502608, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(eventClicked != false)
        {
                return;
        }
        
        if(SceneDictator.IsInGameScene() == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Init(currentlySelectedCategores:  0, fromReroll:  false);
    }
    private void OnDestroy()
    {
        this.StopAllCoroutines();
    }
    public WGEventsListPopup()
    {
        this.displayEventQuantity = true;
    }
    private void <OnEnable>b__7_0()
    {
        this.OnClose(eventClicked:  false);
    }
    private void <OnEnable>b__7_1(bool obj)
    {
        this.OnClose(eventClicked:  true);
    }

}
