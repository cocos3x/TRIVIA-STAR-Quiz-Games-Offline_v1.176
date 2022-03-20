using UnityEngine;
public class WGChapterClearPopup : MonoBehaviour
{
    // Fields
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private UnityEngine.Transform coinsAnimParent;
    private GridCoinCollectAnimationInstantiator coinsAnimControl2;
    private UnityEngine.Transform coinsAnimParent2;
    private UnityEngine.UI.Button[] collectButtons;
    private UnityEngine.ParticleSystem chapClearSystem;
    private LevelCompletePopup levelCompletePopup;
    private UnityEngine.CanvasGroup collectButtonCanvasGroup;
    private UnityEngine.CanvasGroup normalRewardCanvasGroup;
    private UnityEngine.UI.Text coinRewardAmount;
    private UnityEngine.GameObject vipRewardGroup;
    private UnityEngine.UI.Text regularCoinRewardAmount;
    private UnityEngine.UI.Text vipCoinRewardAmount;
    private UnityEngine.Transform normalRewardCoin;
    private UnityEngine.Transform regularRewardCoin;
    private UnityEngine.Transform vipRewardCoin;
    private UnityEngine.UI.Image vipMask;
    private UnityEngine.GameObject galaRewardGroup;
    private UnityEngine.UI.Text galaRegularCoinAmount;
    private UnityEngine.UI.Text galaBonusCoinAmount;
    private UnityEngine.Transform galaRegularCoin;
    private UnityEngine.Transform galaBonusCoin;
    private UnityEngine.GameObject galaRewardOverlay;
    private UnityEngine.UI.Button galaRewardsButton;
    private UnityEngine.GameObject[] appearingOrder;
    private shake vipImgAnim;
    private UnityEngine.GameObject[] galaAppearingOrder;
    private shake galaImgAnim;
    private decimal total_reward;
    private int order;
    private bool animDone;
    private VIPPartyEventInfo vipEventInfo;
    private bool rewardsAvailable;
    
    // Properties
    private bool VIPPartyCanShow { get; }
    private bool GoldenGalaCanShow { get; }
    
    // Methods
    private bool get_VIPPartyCanShow()
    {
        if(VIPPartyEventHandler.instance == 0)
        {
                return false;
        }
        
        bool val_1 = VIPPartyEventHandler.instance.IsEventExpired();
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    private bool get_GoldenGalaCanShow()
    {
        string val_1 = GoldenGalaHandler.dailyChallengeApple;
        if(val_1 == null)
        {
                return false;
        }
        
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public void OnEnable()
    {
        var val_6;
        var val_7;
        System.Action<System.Boolean> val_8;
        var val_9;
        val_6 = 0;
        goto label_1;
        label_6:
        UnityEngine.UI.Button val_6 = this.collectButtons[val_6];
        val_6.interactable = true;
        val_6 = 1;
        label_1:
        if(val_6 < val_6)
        {
            goto label_6;
        }
        
        val_7 = 1152921504901095424;
        val_8 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = null;
        val_8 = new System.Action<System.Boolean>(object:  -123293216, method:  new IntPtr(4171649056));
        System.Delegate val_5 = System.Delegate.Combine(a:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_9 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_17;
        }
        
        }
        
        val_9 = 0;
        label_17:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_9;
    }
    public void OnDisable()
    {
        var val_6;
        System.Action<System.Boolean> val_7;
        var val_8;
        val_6 = 1152921504901095424;
        val_7 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Action<System.Boolean>(object:  -123103392, method:  new IntPtr(4171649056));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_8 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_8;
    }
    public void Setup(bool shouldBeShowing, bool showRewards)
    {
        bool val_14;
        var val_15;
        val_14 = shouldBeShowing;
        UnityEngine.GameObject val_1 = this.collectButtonCanvasGroup.gameObject;
        this.collectButtonCanvasGroup.SetActive(value:  false);
        this.collectButtonCanvasGroup.alpha = null;
        UnityEngine.GameObject val_2 = this.normalRewardCanvasGroup.gameObject;
        this.normalRewardCanvasGroup.SetActive(value:  false);
        this.normalRewardCanvasGroup.alpha = null;
        this.vipRewardGroup.SetActive(value:  false);
        this.galaRewardGroup.SetActive(value:  false);
        this.vipImgAnim.enabled = false;
        this.galaImgAnim.enabled = false;
        UnityEngine.GameObject val_3 = this.coinsAnimParent.gameObject;
        this.coinsAnimParent.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.coinsAnimParent2.gameObject;
        this.coinsAnimParent2.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.coinsAnimControl.gameObject;
        this.coinsAnimControl.SetActive(value:  false);
        UnityEngine.GameObject val_6 = this.coinsAnimControl2.gameObject;
        this.coinsAnimControl2.SetActive(value:  false);
        bool val_7 = this.coinsAnimControl2.VIPPartyCanShow;
        if(val_7 == true)
        {
                val_7 = this;
            this.PrepareAppearingAnimation();
        }
        
        bool val_8 = this.GoldenGalaCanShow;
        if(val_8 == true)
        {
                val_8 = this;
            this.PrepareGalaAppearingAnimation();
        }
        
        val_15 = 0;
        UnityEngine.GameObject val_9 = this.gameObject;
        this.SetActive(value:  val_14);
        this.rewardsAvailable = val_14 & showRewards;
        goto label_20;
        label_26:
        UnityEngine.UI.Button val_14 = this.collectButtons[val_15];
        UnityEngine.GameObject val_11 = val_14.gameObject;
        if(this.rewardsAvailable == true)
        {
                val_14 = 1;
        }
        
        val_14.SetActive(value:  true);
        val_15 = 1;
        label_20:
        if(val_15 < val_14)
        {
            goto label_26;
        }
        
        if(this.rewardsAvailable == false)
        {
                return;
        }
        
        this.SetupRewards();
        UnityEngine.EventSystems.EventSystem val_12 = UnityEngine.EventSystems.EventSystem.current;
        UnityEngine.UI.Button val_15 = this.collectButtons[0];
        UnityEngine.GameObject val_13 = val_15.gameObject;
        0.SetSelectedGameObject(selected:  val_15);
    }
    public void PlayStartAnims()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeSelf != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  1, oneshot:  true, pitch:  null, vol:  null);
        }
        
        if(this.rewardsAvailable == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.chapClearSystem)) != false)
        {
                this.chapClearSystem.Play();
        }
        
        bool val_5 = this.chapClearSystem.VIPPartyCanShow;
        if(val_5 != false)
        {
                System.Collections.IEnumerator val_6 = this.ExecuteAppearingAnimationSequence_VIP();
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  -122527136);
            return;
        }
        
        if(val_5.GoldenGalaCanShow != false)
        {
                this.PlayGoldenGalaSequence();
            return;
        }
        
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.normalRewardCanvasGroup, endValue:  null, duration:  null);
        object val_10 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.normalRewardCanvasGroup, delay:  null);
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.collectButtonCanvasGroup, endValue:  null, duration:  null);
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.collectButtonCanvasGroup, delay:  null);
    }
    public void OnCollectClicked()
    {
        int val_15;
        int val_16;
        int val_17;
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        int val_22;
        int val_29;
        GridCoinCollectAnimationInstantiator val_30;
        int val_31;
        var val_32;
        VIPPartyEventInfo val_35;
        var val_36;
        var val_37;
        var val_38;
        decimal val_39;
        var val_40;
        var val_41;
        val_29 = 1152921504614301696;
        val_30 = this.coinsAnimControl;
        this.coinsAnimControl.OnCompleteCallback = null;
        label_7:
        if(0 >= (new System.Action(object:  -122179616, method:  new IntPtr(4172548640))))
        {
            goto label_3;
        }
        
        UnityEngine.UI.Button val_29 = this.collectButtons[0];
        val_31 = 0 + 1;
        if(this.collectButtons[0] != null)
        {
            goto label_7;
        }
        
        return;
        label_3:
        val_32 = 0;
        goto label_9;
        label_14:
        UnityEngine.UI.Button val_30 = this.collectButtons[val_32];
        val_30.interactable = false;
        val_32 = 1;
        label_9:
        if(val_32 < val_30)
        {
            goto label_14;
        }
        
        bool val_2 = val_30.VIPPartyCanShow;
        if(val_2 == false)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_3 = position;
        this.coinsAnimParent.position = new UnityEngine.Vector3();
        UnityEngine.GameObject val_4 = this.coinsAnimParent.gameObject;
        this.coinsAnimParent.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.coinsAnimControl.gameObject;
        this.coinsAnimControl.SetActive(value:  true);
        this.coinsAnimControl.coinExpansionEnabled = false;
        if(this.vipEventInfo.isVIP == false)
        {
            goto label_36;
        }
        
        val_35 = this.vipEventInfo;
        goto label_25;
        label_15:
        if(val_2.GoldenGalaCanShow == false)
        {
            goto label_26;
        }
        
        UnityEngine.Vector3 val_7 = position;
        this.coinsAnimParent.position = new UnityEngine.Vector3();
        UnityEngine.GameObject val_8 = this.coinsAnimParent.gameObject;
        this.coinsAnimParent.SetActive(value:  true);
        UnityEngine.GameObject val_9 = this.coinsAnimControl.gameObject;
        this.coinsAnimControl.SetActive(value:  true);
        var val_31 = 28874251;
        this.coinsAnimControl.coinExpansionEnabled = false;
        val_31 = 6752872 + val_31;
        if(val_31 == 0)
        {
                mem2[0] = 1;
        }
        
        if(GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive == false)
        {
            goto label_36;
        }
        
        if(val_31 == 0)
        {
                mem2[0] = 1;
        }
        
        val_35 = GoldenGalaHandler.dailyChallengeApple;
        label_25:
        if(val_35 != null)
        {
            goto label_39;
        }
        
        goto label_39;
        label_36:
        val_40 = null;
        val_40 = null;
        val_36 = 1152921504617021456;
        val_37 = 1152921504617021452;
        val_38 = 1152921504617021448;
        val_39 = 1152921504617021444;
        label_39:
        Player val_11 = App.Player;
        val_41 = 52;
        val_41 = val_41;
        decimal val_12 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -122191668, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = this.total_reward, mid = val_29});
        Player val_13 = App.Player;
        decimal val_14 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -122191684, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = val_39, lo = mem[1152921504617021448], mid = mem[1152921504617021452]});
        val_29 = this.coinsAnimControl;
        val_30 = val_15;
        val_31 = val_20;
        val_29.Play(fromValue:  new System.Decimal() {flags = val_16, hi = val_17, lo = val_18, mid = val_19}, toValue:  new System.Decimal() {flags = val_30, hi = val_31, lo = val_21, mid = val_22}, textTickTime:  val_3.x, delayBeforeComplete:  val_3.y);
        return;
        label_26:
        twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGFlyoutManager MonoSingleton<WGFlyoutManager>::get_Instance().__il2cppRuntimeField_10.SetDarkenedBackgroundAlpha(alpha:  null);
        GameBehavior val_24 = App.getBehavior;
        object val_26 = 0.GetComponent<System.Object>();
        System.Action val_27 = new System.Action(object:  -122179616, method:  new IntPtr(4172758560));
        mem[20] = null;
        0.Setup(rewardSource:  3);
        UnityEngine.Transform val_28 = this.levelCompletePopup.transform;
        MethodExtensionForMonoBehaviourTransform.SetActiveChildren(t:  this.levelCompletePopup, state:  false);
    }
    private void OnRegularCoinsAnimFinished()
    {
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        System.Action val_22;
        float val_25;
        var val_26;
        var val_27;
        var val_28;
        System.Action val_1 = new System.Action(object:  -121774752, method:  new IntPtr(4172548640));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.coinsAnimControl.OnCompleteCallback, value:  7454720);
        val_22 = this.coinsAnimControl.OnCompleteCallback;
        if(val_22 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_22 = 0;
        label_4:
        this.coinsAnimControl.OnCompleteCallback = val_22;
        bool val_3 = val_22.VIPPartyCanShow;
        if((val_3 == false) || (this.vipEventInfo.isVIP == false))
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_4 = position;
        this.coinsAnimParent2.position = new UnityEngine.Vector3();
        UnityEngine.GameObject val_5 = this.coinsAnimParent2.gameObject;
        this.coinsAnimParent2.SetActive(value:  true);
        UnityEngine.GameObject val_6 = this.coinsAnimControl2.gameObject;
        this.coinsAnimControl2.SetActive(value:  true);
        this.coinsAnimControl2.coinExpansionEnabled = false;
        System.Action val_7 = new System.Action(object:  -121774752, method:  new IntPtr(4173129632));
        this.coinsAnimControl2.OnCompleteCallback = null;
        Player val_8 = App.Player;
        val_25 = 7.286752E-44f;
        val_26 = 52;
        if(this.vipEventInfo == 0)
        {
                val_26 = val_26;
        }
        
        val_26 = val_26;
        val_27 = val_25;
        val_28 = 3.587324E-43f;
        goto label_22;
        label_7:
        if((val_3.GoldenGalaCanShow == false) || (GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive == false))
        {
            goto label_26;
        }
        
        UnityEngine.Vector3 val_11 = position;
        this.coinsAnimParent2.position = new UnityEngine.Vector3();
        UnityEngine.GameObject val_12 = this.coinsAnimParent2.gameObject;
        this.coinsAnimParent2.SetActive(value:  true);
        UnityEngine.GameObject val_13 = this.coinsAnimControl2.gameObject;
        this.coinsAnimControl2.SetActive(value:  true);
        this.coinsAnimControl2.coinExpansionEnabled = false;
        System.Action val_14 = new System.Action(object:  -121774752, method:  new IntPtr(4173129632));
        this.coinsAnimControl2.OnCompleteCallback = null;
        Player val_15 = App.Player;
        val_25 = 7.286752E-44f;
        val_28 = 256;
        val_28 = val_28;
        if(GoldenGalaHandler.dailyChallengeApple == null)
        {
                val_28 = val_28;
        }
        
        val_28 = val_28;
        val_27 = val_25;
        val_26 = 7.286752E-44f;
        label_22:
        decimal val_16 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -121786816, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_17 = App.Player;
        this.coinsAnimControl2.Play(fromValue:  new System.Decimal() {flags = val_19, hi = val_20, lo = val_21, mid = val_18}, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  val_11.x, delayBeforeComplete:  val_11.y);
        return;
        label_26:
        this.Close();
    }
    private void OnExtraCoinsAnimFinished()
    {
        System.Action val_3;
        System.Action val_1 = new System.Action(object:  -121580832, method:  new IntPtr(4173129632));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.coinsAnimControl2.OnCompleteCallback, value:  7454720);
        val_3 = this.coinsAnimControl2.OnCompleteCallback;
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_3 = 0;
        label_4:
        this.coinsAnimControl2.OnCompleteCallback = val_3;
        this.Close();
    }
    private void Close()
    {
        this.StopAllCoroutines();
        if(this.levelCompletePopup == 0)
        {
            
        }
    
    }
    private void OnVipButtonClicked()
    {
        GameBehavior val_1 = App.getBehavior;
        System.Action val_3 = new System.Action(object:  -121338400, method:  new IntPtr(4173603872));
        0.Init(levelComplete:  true, onCloseAction:  7454720);
    }
    private void OnGalaButtonClicked()
    {
        var val_8;
        var val_9;
        var val_6 = 28870919;
        val_6 = 6756204 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        if(GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive != false)
        {
                GameBehavior val_2 = App.getBehavior;
            val_9 = mem[(1179403647 + (public WGGoldenGalaInfoPopup MetaGameBehavior::ShowUGUIFlyOut<WGGoldenGalaInfoPopup>().__il2cppRuntimeField_28) << 3) + 192];
            val_9 = (1179403647 + (public WGGoldenGalaInfoPopup MetaGameBehavior::ShowUGUIFlyOut<WGGoldenGalaInfoPopup>().__il2cppRuntimeField_28) << 3) + 192;
            val_8 = 0;
        }
        else
        {
                GameBehavior val_4 = App.getBehavior;
            WGSubscriptionManager._subEntryPoint = 65;
        }
    
    }
    private void SetupRewards()
    {
        UnityEngine.GameObject val_1 = this.normalRewardCanvasGroup.gameObject;
        this.normalRewardCanvasGroup.SetActive(value:  false);
        this.vipRewardGroup.SetActive(value:  false);
        this.galaRewardGroup.SetActive(value:  false);
    }
    private void PrepareAppearingAnimation()
    {
        goto label_1;
        label_5:
        UnityEngine.UI.LayoutElement val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1692633120);
        1152921507209181152.alpha = null;
        0 = 1;
        label_1:
        if(0 < 1152921507209181152)
        {
            goto label_5;
        }
    
    }
    private System.Collections.IEnumerator ExecuteAppearingAnimationSequence_VIP()
    {
        object val_1 = new System.Object();
        typeof(WGChapterClearPopup.<ExecuteAppearingAnimationSequence_VIP>d__49).__il2cppRuntimeField_8 = 0;
        typeof(WGChapterClearPopup.<ExecuteAppearingAnimationSequence_VIP>d__49).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator ExecuteAppearingAnimation(UnityEngine.CanvasGroup cg)
    {
        typeof(WGChapterClearPopup.<ExecuteAppearingAnimation>d__50).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGChapterClearPopup.<ExecuteAppearingAnimation>d__50).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(WGChapterClearPopup.<ExecuteAppearingAnimation>d__50).__il2cppRuntimeField_10 = cg;
    }
    private void PrepareGalaAppearingAnimation()
    {
        var val_2 = 0;
        goto label_1;
        label_6:
        UnityEngine.GameObject val_2 = this.galaAppearingOrder[val_2];
        UnityEngine.UI.LayoutElement val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  val_2);
        val_2.alpha = null;
        val_2 = 1;
        label_1:
        if(val_2 < val_2)
        {
            goto label_6;
        }
    
    }
    private void PlayGoldenGalaSequence()
    {
        var val_8 = 0;
        goto label_9;
        label_11:
        UnityEngine.GameObject val_8 = this.galaAppearingOrder[val_8];
        UnityEngine.UI.LayoutElement val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  val_8);
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_8, endValue:  null, duration:  null);
        object val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  val_8, delay:  0f);
        UnityEngine.GameObject val_9 = this.galaAppearingOrder[val_8];
        string val_4 = val_9.name;
        bool val_5 = val_9.Contains(value:  -1266462592);
        if(val_5 != false)
        {
                DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  -120170400, method:  new IntPtr(4174653088));
            val_8 = 1;
            DG.Tweening.Tween val_7 = DG.Tweening.DOVirtual.DelayedCall(delay:  0.5f, callback:  0.5f, ignoreTimeScale:  false);
        }
        else
        {
                val_8 = 1;
        }
        
        label_9:
        if(val_8 < val_5)
        {
            goto label_11;
        }
    
    }
    private void OnSubscriptionPurchaseAttempt(bool success)
    {
        this.galaRewardOverlay.SetActive(value:  GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive ^ 1);
        this.SetupRewards();
    }
    public WGChapterClearPopup()
    {
        this.vipEventInfo = new VIPPartyEventInfo();
    }
    private void <PlayGoldenGalaSequence>b__52_0()
    {
        this.galaImgAnim.enabled = true;
    }

}
