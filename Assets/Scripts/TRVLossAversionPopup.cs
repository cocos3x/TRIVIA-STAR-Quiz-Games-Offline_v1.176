using UnityEngine;
public class TRVLossAversionPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text descText;
    private UnityEngine.UI.Text costText;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button exitQuizButton;
    private UnityEngine.UI.Image chestImage;
    private UnityEngine.Sprite bronzeChest;
    private UnityEngine.Sprite silverChest;
    private UnityEngine.Sprite goldenChest;
    private GemsCollectAnimationInstantiator gcAnim;
    private UnityEngine.GameObject mainGroup;
    private UnityEngine.GameObject streakBrokenGroup;
    private CurrencyStatViewInstantiator streakStatViewInstantiator;
    private UnityEngine.UI.Image streakImage;
    private UnityEngine.Sprite streakSprite;
    private UnityEngine.Sprite brokenStreakSprite;
    private UnityEngine.UI.Text streakText;
    private TweenCoinsText streakAmountText;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        object val_1 = new System.Object();
        typeof(TRVLossAversionPopup.<Start>d__17).__il2cppRuntimeField_8 = 0;
        typeof(TRVLossAversionPopup.<Start>d__17).__il2cppRuntimeField_10 = this;
    }
    private void OnClickContinue()
    {
        var val_13;
        var val_14;
        System.Action val_16;
        Player val_1 = App.Player;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((PurchaseExtraLife(updateGems:  false, addExtraLife:  true)) != false)
        {
                this.continueButton.interactable = false;
            this.exitQuizButton.interactable = false;
            UnityEngine.Transform val_4 = this.continueButton.transform;
            UnityEngine.Vector3 val_5 = position;
            Player val_6 = App.Player;
            int val_13 = 0;
            val_13 = 0f - val_13;
            this.gcAnim.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  val_13, animateStatView:  true);
            System.Action val_7 = new System.Action(object:  -498108336, method:  new IntPtr(3796832912));
            mem2[0] = null;
            return;
        }
        
        string val_8 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        var val_14 = 24818769;
        val_14 = 10807292 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        PurchaseProxy.currentPurchasePoint = 98;
        GameBehavior val_9 = App.getBehavior;
        val_14 = null;
        val_14 = null;
        val_16 = TRVLossAversionPopup.<>c.<>9__18_1;
        if(val_16 == 0)
        {
                val_16 = null;
            val_16 = new System.Action(object:  TRVLossAversionPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3796833936));
            TRVLossAversionPopup.<>c.<>9__18_1 = val_16;
        }
        
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
        UnityEngine.GameObject val_12 = this.gameObject;
        SLCWindow.CloseWindow(window:  -498108336, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnGemStoreButtonClicked()
    {
        var val_6;
        var val_7;
        System.Action val_9;
        string val_1 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        var val_6 = 24817353;
        val_6 = 10808708 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        PurchaseProxy.currentPurchasePoint = 98;
        GameBehavior val_2 = App.getBehavior;
        val_7 = null;
        val_7 = null;
        val_9 = TRVLossAversionPopup.<>c.<>9__19_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Action(object:  TRVLossAversionPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3796967440));
            TRVLossAversionPopup.<>c.<>9__19_0 = val_9;
        }
        
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -497974832, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickNoThanks()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BreakStreak();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ConcludeQuestionComplete();
        this.continueButton.interactable = false;
        this.exitQuizButton.interactable = false;
        System.Collections.IEnumerator val_5 = this.animateStreakBreaking(preStreak:  getCurrentStreak);
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -497854640);
    }
    private System.Collections.IEnumerator animateStreakBreaking(int preStreak)
    {
        typeof(TRVLossAversionPopup.<animateStreakBreaking>d__21).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TRVLossAversionPopup.<animateStreakBreaking>d__21).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(TRVLossAversionPopup.<animateStreakBreaking>d__21).__il2cppRuntimeField_14 = preStreak;
    }
    private void SetChestSprite()
    {
        UnityEngine.UI.Image val_3;
        UnityEngine.Sprite val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 52) != 0)
        {
                return;
        }
        
        val_3 = mem[R4 + 28];
        val_3 = R4 + 28;
        val_4 = mem[R4 + 32];
        val_4 = R4 + 32;
        sprite = ;
    }
    public TRVLossAversionPopup()
    {
    
    }
    private void <Start>b__17_0()
    {
        object val_1 = R5.GetComponent<System.Object>();
        if(R5 != 0)
        {
                object val_3 = R5.GetComponent<System.Object>();
            UnityEngine.Object.Destroy(obj:  R5);
        }
        
        R5 + 172.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -497359536, method:  new IntPtr(3797582736));
        R5 + 172.AddListener(call:  162246656);
        UnityEngine.GameObject val_5 = R5.gameObject;
        R5.SetActive(value:  true);
    }
    private void <OnClickContinue>b__18_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnExtraLifeClicked();
        GameBehavior val_2 = App.getBehavior;
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -497243440, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -497243440, aName:  -1618809792);
    }

}
