using UnityEngine;
public class WADPetsFeedFoodPopup : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<WADPetCardItem> cards;
    private UnityEngine.ParticleSystem particles;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Button storeButton;
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.UI.Button feedButton;
    private UnityEngine.UI.Button visitPetsButton;
    private UnityEngine.UI.Button closeButton;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -146050160, method:  new IntPtr(4148855248));
        this.storeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -146050160, method:  new IntPtr(4148864464));
        this.infoButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -146050160, method:  new IntPtr(4148873680));
        this.feedButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -146050160, method:  new IntPtr(4148882896));
        this.visitPetsButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -146050160, method:  new IntPtr(4148892112));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void Start()
    {
        var val_3;
        this.UpdateCardsCollection();
        string val_1 = Localization.Localize(key:  -145916944, defaultValue:  -145917104, useSingularKey:  false);
        val_3 = null;
        val_3 = null;
        string val_2 = System.String.Format(format:  -145916944, arg0:  13152256);
        if(this.description != 0)
        {
                return;
        }
    
    }
    private void UpdateCardsCollection()
    {
        bool val_2;
        var val_3;
        val_2 = static_value_021FD20D;
        if(val_2 != true)
        {
                val_2 = true;
        }
        
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.AllPetsCollection;
        val_3 = 4;
        goto label_1;
        label_7:
        if(val_2 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(50331648 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.Setup(pet:  2621443, highlight:  false);
        val_3 = 5;
        label_1:
        if(1 < 50331648)
        {
            goto label_7;
        }
    
    }
    private System.Collections.IEnumerator OnFed()
    {
        object val_1 = new System.Object();
        typeof(WADPetsFeedFoodPopup.<OnFed>d__11).__il2cppRuntimeField_8 = 0;
        typeof(WADPetsFeedFoodPopup.<OnFed>d__11).__il2cppRuntimeField_10 = this;
    }
    private void DeactivateAllButtons()
    {
        this.feedButton.interactable = false;
        this.visitPetsButton.interactable = false;
        this.storeButton.interactable = false;
    }
    private void OnClick_Feed()
    {
        var val_10;
        System.Action val_12;
        this.DeactivateAllButtons();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(FeedAllPets() != false)
        {
                System.Collections.IEnumerator val_3 = this.OnFed();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -145406912);
            return;
        }
        
        GameBehavior val_5 = App.getBehavior;
        object val_7 = 0.GetComponent<System.Object>();
        val_10 = null;
        val_10 = null;
        val_12 = WADPetsFeedFoodPopup.<>c.<>9__13_0;
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Action(object:  WADPetsFeedFoodPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4149535360));
            WADPetsFeedFoodPopup.<>c.<>9__13_0 = val_12;
        }
        
        mem[20] = val_12;
        0.Init(type:  0);
        UnityEngine.GameObject val_9 = this.gameObject;
        SLCWindow.CloseWindow(window:  -145406912, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_VisitPets()
    {
        this.DeactivateAllButtons();
        WADPetsScreenUI.ShowMainScreen();
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -145294912, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Info()
    {
        var val_6;
        System.Action val_8;
        this.DeactivateAllButtons();
        GameBehavior val_1 = App.getBehavior;
        object val_3 = 0.GetComponent<System.Object>();
        val_6 = null;
        val_6 = null;
        val_8 = WADPetsFeedFoodPopup.<>c.<>9__15_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  WADPetsFeedFoodPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4149761408));
            WADPetsFeedFoodPopup.<>c.<>9__15_0 = val_8;
        }
        
        mem[20] = val_8;
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -145180864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_FoodStore()
    {
        var val_6;
        var val_7;
        System.Action val_9;
        this.DeactivateAllButtons();
        var val_6 = 22117037;
        val_6 = 13509024 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        PurchaseProxy.currentPurchasePoint = 80;
        GameBehavior val_1 = App.getBehavior;
        object val_3 = 0.GetComponent<System.Object>();
        val_7 = null;
        val_7 = null;
        val_9 = WADPetsFeedFoodPopup.<>c.<>9__16_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Action(object:  WADPetsFeedFoodPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4149874432));
            WADPetsFeedFoodPopup.<>c.<>9__16_0 = val_9;
        }
        
        mem[20] = val_9;
        0.Init(type:  0);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -145067840, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -144955840, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WADPetsFeedFoodPopup()
    {
    
    }

}
