using UnityEngine;
public class WGBuyAVowelInfoPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text playButtonText;
    private UnityEngine.UI.Text timerText;
    
    // Methods
    private void Awake()
    {
        UnityEngine.UI.Text val_11;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1510267440, method:  new IntPtr(2784649232));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1510267440, method:  new IntPtr(2784649232));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1510267440, method:  typeof(WGBuyAVowelInfoPopup).__il2cppRuntimeField_E0);
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        string val_4 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_5 = App.Player;
        string val_6 = System.String.Format(format:  -1672741904, arg0:  13152256);
        UnityEngine.GameObject val_7 = this.gameObject;
        UnityEngine.UI.LayoutElement val_8 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1510267440);
        System.Action val_9 = new System.Action(object:  -1510267440, method:  new IntPtr(2784674832));
        System.Delegate val_10 = System.Delegate.Combine(a:  this.playButtonText, b:  7454720);
        val_11 = this.playButtonText;
        if(val_11 != 0)
        {
                if(null == null)
        {
            goto label_14;
        }
        
        }
        
        val_11 = 0;
        label_14:
        this.playButtonText = val_11;
    }
    private void Start()
    {
        UnityEngine.GameObject val_1 = this.continueButton.gameObject;
        this.continueButton.SetActive(value:  SceneDictator.IsInGameScene());
        UnityEngine.GameObject val_3 = this.playButton.gameObject;
        this.playButton.SetActive(value:  SceneDictator.IsInGameScene() ^ 1);
    }
    private void UpdateEventTimer()
    {
        string val_1 = BuyAVowelEventHandler.<Instance>k__BackingField.GetEventRemainingTime();
        if(this.timerText == 0)
        {
            
        }
    
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1509874096, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_PlayButton()
    {
        if(SceneDictator.IsInGameScene() != true)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1509762096, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected virtual void OnClick_CloseButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1509650096, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGBuyAVowelInfoPopup()
    {
    
    }

}
