using UnityEngine;
public class TRVYouBetchaBetPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button betButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button noThanksButton;
    private GemsCollectAnimationInstantiator gcAnim;
    private CoinCurrencyCollectAnimationInstantiator cAnim;
    private UnityEngine.UI.Text betCostText;
    private UnityEngine.UI.Text bestDescText;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -439509360, method:  new IntPtr(3855407008));
        this.betButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -439509360, method:  new IntPtr(3855416224));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -439509360, method:  new IntPtr(3855416224));
        this.noThanksButton.m_OnClick.AddListener(call:  162246656);
        string val_4 = TRVYouBetchaEventHandler.EVENT_TRACKING_ID + 24.ToString();
        string val_5 = Localization.Localize(key:  -439533472, defaultValue:  -439533664, useSingularKey:  false);
        float val_7 = 1f;
        val_7 = (TRVYouBetchaEventHandler.EVENT_TRACKING_ID + 28) + val_7;
        string val_6 = System.String.Format(format:  -439533472, arg0:  15282176);
        if(this.bestDescText != 0)
        {
                return;
        }
    
    }
    private void Start()
    {
    
    }
    private void OnClose()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -439252592, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickCoinBalance()
    {
        var val_3;
        var val_3 = 27313657;
        val_3 = 8312404 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        PurchaseProxy.currentPurchasePoint = 114;
        GameBehavior val_1 = App.getBehavior;
        0.Init(outOfCredits:  false, onCloseAction:  0);
    }
    private void OnClickGemBalance()
    {
        var val_4;
        string val_1 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        var val_4 = 27313221;
        val_4 = 8312840 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        PurchaseProxy.currentPurchasePoint = 114;
        GameBehavior val_2 = App.getBehavior;
        0.Init(outOfCredits:  false, onCloseAction:  0);
    }
    private void OnBetPressed()
    {
        var val_10;
        var val_10 = 27316540;
        val_10 = 8313200 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        if(TRVYouBetchaEventHandler.EVENT_TRACKING_ID.TryPlaceBet() != false)
        {
                UnityEngine.Transform val_2 = this.betCostText.transform;
            UnityEngine.Vector3 val_3 = position;
            if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
            SB.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  429496729, animateStatView:  true);
            this.betButton.interactable = false;
            this.closeButton.interactable = false;
            this.noThanksButton.interactable = false;
            UUI_EventsController.DisableInputs();
            object val_4 = this.GetComponentInChildren<System.Object>();
            this.Stop(withChildren:  true, stopBehavior:  0);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  2, oneshot:  true, pitch:  val_3.x, vol:  val_3.y);
            System.Collections.IEnumerator val_6 = this.WaitForCoinAnimation();
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  -438896112);
            return;
        }
        
        var val_11 = 27312209;
        val_11 = 8313852 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        PurchaseProxy.currentPurchasePoint = 114;
        GameBehavior val_8 = App.getBehavior;
        0.Init(outOfCredits:  true, onCloseAction:  0);
    }
    private System.Collections.IEnumerator WaitForCoinAnimation()
    {
        object val_1 = new System.Object();
        typeof(TRVYouBetchaBetPopup.<WaitForCoinAnimation>d__13).__il2cppRuntimeField_8 = 0;
        typeof(TRVYouBetchaBetPopup.<WaitForCoinAnimation>d__13).__il2cppRuntimeField_10 = this;
    }
    public TRVYouBetchaBetPopup()
    {
    
    }

}
