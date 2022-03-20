using UnityEngine;
public class WGBonusRewardsStoreDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text playerBonusPointsText;
    private UnityEngine.UI.Text playerBonusLevelText;
    private UnityEngine.UI.Button bonusRewardInfoButton;
    private BonusRewardCurrencyParticles brcParticles;
    private int currentBonusRewardPoints;
    private int currentBonusRewardLevel;
    private int currentDisplayPoints;
    
    // Methods
    private void OnEnable()
    {
        var val_25;
        System.Delegate val_26;
        var val_27;
        var val_28;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -359401008, method:  new IntPtr(3935532048));
        this.bonusRewardInfoButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.UI.LayoutElement val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -359401008);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -359401008, method:  new IntPtr(3935532048));
        this.AddListener(call:  162246656);
        val_25 = null;
        val_25 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -359401008, method:  new IntPtr(3935533072));
        val_26 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_6 = System.Delegate.Combine(a:  val_26, b:  7401472);
        if(val_26 != 0)
        {
                if(null == null)
        {
            goto label_8;
        }
        
        }
        
        val_26 = 0;
        label_8:
        PurchasesHandler.OnPurchaseCompleted = val_26;
        Player val_7 = App.Player;
        this.currentBonusRewardPoints = 4;
        WGBonusRewardsHandler val_8 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        BonusRewardsContainer val_9 = GetCurrentRewards();
        this.currentBonusRewardLevel = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance().__il2cppRuntimeField_8;
        WGBonusRewardsHandler val_10 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        BonusRewardsContainer val_11 = GetNextRewards();
        val_27 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance();
        if((public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance()) != 0)
        {
            goto label_17;
        }
        
        WGBonusRewardsHandler val_12 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        BonusRewardsContainer val_13 = GetCurrentRewards();
        val_27 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance();
        if((public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance()) == 0)
        {
            goto label_21;
        }
        
        label_17:
        WGBonusRewardsHandler val_14 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        GameEcon val_16 = App.getGameEcon;
        string val_17 = GetProgressThroughCurrentTier().ToString(format:  null);
        GameEcon val_18 = App.getGameEcon;
        string val_19 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance().__il2cppRuntimeField_C.ToString(format:  null);
        string val_20 = System.String.Format(format:  -1222347616, arg0:  -359413048, arg1:  -359413044);
        val_28 = "{0} / {1}";
        WGBonusRewardsHandler val_21 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        this.currentDisplayPoints = GetProgressThroughCurrentTier();
        WGBonusRewardsHandler val_23 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if(MaxPointsGained() != false)
        {
                val_28 = "MAX";
        }
        
        this.SetText(model:  2128646880);
        return;
        label_21:
    }
    private void SetText(PurchaseModel model)
    {
        var val_31;
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        BonusRewardsContainer val_2 = GetNextRewards();
        val_31 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance();
        if((public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance()) == 0)
        {
                WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            BonusRewardsContainer val_4 = GetCurrentRewards();
            val_31 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance();
        }
        
        WGBonusRewardsHandler val_5 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        BonusRewardsContainer val_6 = GetCurrentRewards();
        string val_7 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance().__il2cppRuntimeField_8.ToString();
        WGBonusRewardsHandler val_8 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        int val_9 = GetProgressThroughCurrentTier();
        WGBonusRewardsHandler val_10 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        BonusRewardsContainer val_11 = GetCurrentRewards();
        Player val_12 = App.Player;
        if(this.currentBonusRewardPoints != 4)
        {
                WGBonusRewardsHandler val_13 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if(MaxPointsGained() != true)
        {
                this.TweenText(startValue:  this.currentDisplayPoints, endValue:  val_9, myContainer:  -1254191344);
        }
        
        }
        
        this.currentDisplayPoints = val_9;
        Player val_24 = App.Player;
        if(this.currentBonusRewardPoints != 4)
        {
                Player val_25 = App.Player;
            int val_31 = 4;
            val_31 = val_31 - this.currentBonusRewardPoints;
            System.Collections.IEnumerator val_26 = this.PlayBonusRewardsAnim(particleCount:  val_31);
            UnityEngine.Coroutine val_27 = this.StartCoroutine(routine:  -359255216);
        }
        
        WGBonusRewardsHandler val_28 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        BonusRewardsContainer val_29 = GetCurrentRewards();
        this.currentBonusRewardLevel = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance().__il2cppRuntimeField_8;
        Player val_30 = App.Player;
        this.currentBonusRewardPoints = 4;
    }
    private System.Collections.IEnumerator PlayBonusRewardsAnim(int particleCount)
    {
        if((new WGBonusRewardsStoreDisplay.<PlayBonusRewardsAnim>d__9(<>1__state:  0)) != 0)
        {
                typeof(WGBonusRewardsStoreDisplay.<PlayBonusRewardsAnim>d__9).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(WGBonusRewardsStoreDisplay.<PlayBonusRewardsAnim>d__9).__il2cppRuntimeField_14 = particleCount;
    }
    private void TweenText(int startValue, int endValue, BonusRewardsContainer myContainer)
    {
        WGBonusRewardsStoreDisplay val_14;
        var val_15;
        DG.Tweening.TweenCallback val_16;
        val_14 = this;
        if((new WGBonusRewardsStoreDisplay.<>c__DisplayClass10_0()) != 0)
        {
                typeof(WGBonusRewardsStoreDisplay.<>c__DisplayClass10_0).__il2cppRuntimeField_C = val_14;
            typeof(WGBonusRewardsStoreDisplay.<>c__DisplayClass10_0).__il2cppRuntimeField_10 = myContainer;
        }
        else
        {
                mem[12] = val_14;
            mem[16] = myContainer;
        }
        
        typeof(WGBonusRewardsStoreDisplay.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = (float)startValue;
        DG.Tweening.Core.DOSetter<System.Single> val_2 = new DG.Tweening.Core.DOSetter<System.Single>(object:  369168384, method:  new IntPtr(3935932560));
        DG.Tweening.Tweener val_3 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  (float)endValue, endValue:  null, duration:  null);
        object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
        val_15 = 1152921504797581312;
        DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  369168384, method:  new IntPtr(3935933584));
        object val_6 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
        val_16 = null;
        val_16 = new DG.Tweening.TweenCallback(object:  369168384, method:  new IntPtr(3935934608));
        object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198881280, action:  190734336);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  198881280, autoKillOnCompletion:  true);
        WGBonusRewardsHandler val_10 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if(MaxPointsGained() != false)
        {
                if(this.playerBonusPointsText != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        }
        else
        {
                var val_12 = FP - 32;
        }
    
    }
    private void OnDestroy()
    {
        var val_3;
        System.Delegate val_4;
        val_3 = null;
        val_3 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -358883376, method:  new IntPtr(3935533072));
        val_4 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_2 = System.Delegate.Remove(source:  val_4, value:  7401472);
        if(val_4 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        PurchasesHandler.OnPurchaseCompleted = val_4;
    }
    private void OnInfoPressed()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public WGBonusRewardsStoreDisplay()
    {
    
    }

}
