using UnityEngine;
public class WGVipPartyEventInfoPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text timer;
    private UnityEngine.GameObject nonVipGroup;
    private UnityEngine.GameObject vipGroup;
    private UnityEngine.UI.Button getVipButton;
    private UnityEngine.UI.Button closeButton;
    private FrameSkipper frameSkipper;
    private bool fromLevelComplete;
    private System.Action onStoreCloseAction;
    
    // Methods
    private void Awake()
    {
        UnityEngine.UI.Button val_7;
        this.nonVipGroup.SetActive(value:  false);
        this.vipGroup.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -984111200, method:  new IntPtr(3310816736));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -984111200, method:  new IntPtr(3310825952));
        this.getVipButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.UI.LayoutElement val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -984111200);
        this.frameSkipper = this;
        System.Action val_5 = new System.Action(object:  -984111200, method:  new IntPtr(3310831072));
        System.Delegate val_6 = System.Delegate.Combine(a:  this.getVipButton, b:  7454720);
        val_7 = this.getVipButton;
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        val_7 = 0;
        label_10:
        this.getVipButton = val_7;
    }
    private void OnEnable()
    {
        this.nonVipGroup.SetActive(value:  false);
        if(VIPPartyEventInfo.__il2cppRuntimeField_element_class != 0)
        {
                VIPPartyEventInfo.__il2cppRuntimeField_element_class = 1;
        }
        
        this.vipGroup.SetActive(value:  true);
    }
    public void Init(bool levelComplete = False, System.Action onCloseAction)
    {
        this.fromLevelComplete = levelComplete;
        this.onStoreCloseAction = onCloseAction;
    }
    private void UpdateTimer()
    {
        string val_1 = VIPPartyEventHandler.instance.GetEventRemainingTime();
        if(this.timer == 0)
        {
            
        }
    
    }
    private void OpenStore()
    {
        if(this.fromLevelComplete != false)
        {
                GameBehavior val_1 = App.getBehavior;
            mem[24] = 0;
            mem[32] = this.onStoreCloseAction;
        }
        else
        {
                WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            bool val_4 = OpenStore(forceShowNext:  true);
        }
        
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -983596640, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -983480544, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGVipPartyEventInfoPopup()
    {
    
    }

}
