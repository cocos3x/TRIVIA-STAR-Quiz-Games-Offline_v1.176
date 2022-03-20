using UnityEngine;
public class SLCWindow : MonoBehaviour
{
    // Fields
    public bool postOnCloseNotification;
    private bool dontDestroyOnDisable;
    private bool tapToCloseOnAwake;
    private bool backButtonCanClose;
    private bool closeWindowCalledBeforeDisable;
    public System.Action Action_OnClose;
    
    // Properties
    public bool DontDestroyOnDisable { get; set; }
    
    // Methods
    public static void CloseWindow(UnityEngine.GameObject window, bool setDestroyOnDisableState = False, bool dontDestroyOnDisable = False)
    {
        bool val_6 = setDestroyOnDisableState;
        object val_1 = window.GetComponent<System.Object>();
        if(window == 0)
        {
            goto label_4;
        }
        
        if(val_6 == false)
        {
            goto label_5;
        }
        
        mem2[0] = dontDestroyOnDisable;
        goto label_16;
        label_4:
        string val_3 = window.name;
        val_6 = window;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_6;
        UnityEngine.Debug.LogWarningFormat(format:  -208110992, args:  472754880);
        goto label_15;
        label_5:
        label_16:
        mem2[0] = 1;
        label_15:
        object val_4 = window.GetComponent<System.Object>();
        if(window != 0)
        {
                window.TweenOffScreenAndDisable();
            return;
        }
        
        window.SetActive(value:  false);
    }
    public bool get_DontDestroyOnDisable()
    {
        return (bool)this.dontDestroyOnDisable;
    }
    public void set_DontDestroyOnDisable(bool value)
    {
        this.dontDestroyOnDisable = value;
    }
    private void Awake()
    {
        if(this.tapToCloseOnAwake == false)
        {
                return;
        }
        
        this.SetupTapToClose();
    }
    private void OnEnable()
    {
        this.closeWindowCalledBeforeDisable = false;
    }
    public void Setup(SLCWindowSetting settings)
    {
        bool val_3;
        if(settings != 0)
        {
                val_3 = settings.backButtonCanClose;
            this.backButtonCanClose = val_3;
        }
        else
        {
                val_3 = this.backButtonCanClose;
        }
        
        if(val_3 == false)
        {
                return;
        }
        
        System.Action val_2 = new System.Action(object:  -207516576, method:  new IntPtr(4087425696));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
    }
    protected virtual void OnDisable()
    {
        SLCWindow val_7;
        var val_8;
        if(this.closeWindowCalledBeforeDisable != true)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            string val_2 = this.name;
            typeof(System.Object[]).__il2cppRuntimeField_10 = this;
            UnityEngine.GameObject val_3 = this.gameObject;
            val_7 = this;
            typeof(System.Object[]).__il2cppRuntimeField_14 = val_7;
            UnityEngine.Debug.LogWarningFormat(format:  -207424480, args:  472754880);
        }
        
        if(this.backButtonCanClose != false)
        {
                System.Action val_4 = new System.Action(object:  -207396208, method:  new IntPtr(4087425696));
            DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        }
        
        if(this.Action_OnClose != 0)
        {
                this.Action_OnClose.Invoke();
        }
        
        this.Action_OnClose = 0;
        if(this.postOnCloseNotification != false)
        {
                NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            val_8 = null;
            val_8 = null;
            val_7 = SLCWindowManager<T>.color_show_available_popups;
            0.PostNotification(aSender:  -207396208, aName:  val_7);
        }
        
        if(this.dontDestroyOnDisable == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_6 = R4.gameObject;
        UnityEngine.Object.Destroy(obj:  R4);
    }
    private void DoOnCloseAction()
    {
        if(this.Action_OnClose != 0)
        {
                this.Action_OnClose.Invoke();
        }
        
        this.Action_OnClose = 0;
    }
    private void SetupTapToClose()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -207158896);
        UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        UnityEngine.GameObject val_4 = this.gameObject;
        UnityEngine.UI.LayoutElement val_5 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -207158896);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -207158896, method:  new IntPtr(4087783376));
        this.AddListener(call:  162246656);
    }
    private void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -207046896, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void HandleBackButtonClose()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -206934896, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public SLCWindow()
    {
        this.backButtonCanClose = true;
        this.postOnCloseNotification = true;
    }

}
