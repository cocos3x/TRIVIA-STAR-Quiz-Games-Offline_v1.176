using UnityEngine;
public class CategoryPackCompletionRewardPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text descriptionLabel;
    private UnityEngine.UI.Button collectButton;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private GoldenCurrencyCollectAnimationInstantiator goldenAnimControl;
    private UnityEngine.Sprite coinIcon;
    private UnityEngine.Sprite goldenCurrencyIcon;
    private UnityEngine.Sprite bonusIconWheel;
    private UnityEngine.Sprite bonusIconSlots;
    private UnityEngine.GameObject rewardCoinObject;
    private UnityEngine.UI.Text reward;
    private UnityEngine.UI.Image rewardSingularIcon;
    private UnityEngine.GameObject rewardBonusGameObject;
    private UnityEngine.UI.Text rewardBonusGameLabel;
    private UnityEngine.UI.Image rewardBonusGameIcon;
    private UnityEngine.GameObject rewardCoinGoldenObject;
    private UnityEngine.UI.Text rewardCGCoin;
    private UnityEngine.UI.Text rewardCGGolden;
    private System.Func<float> onCollectCreditAction;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1505901328, method:  new IntPtr(2789040944));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    public void Initialize(CategoryCompletionReward _rewardData, int categoriesCleared)
    {
        int val_16;
        int val_17;
        int val_18;
        int val_19;
        int val_35;
        int val_36;
        int val_37;
        int val_38;
        CategoryPackCompletionRewardPopup val_64;
        CategoryPackCompletionRewardPopup val_65;
        int val_66;
        int val_67;
        GridCoinCollectAnimationInstantiator val_68;
        var val_72;
        System.Func<System.Single> val_74;
        var val_75;
        val_64 = this;
        val_65 = _rewardData;
        string val_1 = Localization.Localize(key:  -1505800896, defaultValue:  -1505801040, useSingularKey:  false);
        string val_2 = System.String.Format(format:  -1505800896, arg0:  13152256);
        val_68 = "cleared_x_categories";
        if((_rewardData.rewards.ContainsKey(key:  1)) != false)
        {
                if((_rewardData.rewards.ContainsKey(key:  2)) != false)
        {
                typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_0).__il2cppRuntimeField_1C = val_64;
            UnityEngine.GameObject val_6 = this.rewardCoinObject.gameObject;
            this.rewardCoinObject.SetActive(value:  false);
            UnityEngine.GameObject val_7 = this.rewardBonusGameObject.gameObject;
            this.rewardBonusGameObject.SetActive(value:  false);
            UnityEngine.GameObject val_8 = this.rewardCoinGoldenObject.gameObject;
            this.rewardCoinGoldenObject.SetActive(value:  true);
            decimal val_9 = categoriesCleared.Item[_rewardData.rewards];
            string val_10 = ToString();
            decimal val_11 = Item[_rewardData.rewards];
            string val_12 = ToString();
            Player val_13 = App.Player;
            val_66 = val_64;
            decimal val_14 = Item[_rewardData.rewards];
            decimal val_15 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1505579592, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            val_67 = val_16;
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = val_67;
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_0).__il2cppRuntimeField_C = val_17;
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_0).__il2cppRuntimeField_10 = val_18;
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_0).__il2cppRuntimeField_14 = val_19;
            this.coinsAnimControl.Set(instantValue:  new System.Decimal() {flags = val_67, hi = val_17, lo = val_18, mid = val_19});
            Player val_20 = App.Player;
            decimal val_21 = Item[_rewardData.rewards];
            val_68 = 0;
            val_64 = new System.Object();
            int val_23 = 4 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_0).__il2cppRuntimeField_18 = val_23;
            this.goldenAnimControl.SetStatViewValue(instantValue:  val_23);
            System.Func<System.Single> val_24 = new System.Func<System.Single>(object:  311128064, method:  new IntPtr(2789225904));
            this.onCollectCreditAction = null;
            return;
        }
        
        }
        
        if((_rewardData.rewards.ContainsKey(key:  1)) != false)
        {
                object val_26 = null;
            val_67 = val_26;
            val_26 = new System.Object();
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_1).__il2cppRuntimeField_18 = val_64;
            UnityEngine.GameObject val_27 = this.rewardCoinObject.gameObject;
            this.rewardCoinObject.SetActive(value:  true);
            UnityEngine.GameObject val_28 = this.rewardBonusGameObject.gameObject;
            this.rewardBonusGameObject.SetActive(value:  false);
            UnityEngine.GameObject val_29 = this.rewardCoinGoldenObject.gameObject;
            this.rewardCoinGoldenObject.SetActive(value:  false);
            decimal val_30 = categoriesCleared.Item[_rewardData.rewards];
            string val_31 = ToString();
            this.rewardSingularIcon.sprite = this.coinIcon;
            Player val_32 = App.Player;
            decimal val_33 = Item[_rewardData.rewards];
            decimal val_34 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1505579576, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            val_65 = val_64;
            val_66 = val_35;
            val_64 = val_37;
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_1).__il2cppRuntimeField_8 = val_66;
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_1).__il2cppRuntimeField_C = val_36;
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_1).__il2cppRuntimeField_10 = val_64;
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_1).__il2cppRuntimeField_14 = val_38;
            val_68 = this.coinsAnimControl;
            val_68.Set(instantValue:  new System.Decimal() {flags = val_66, hi = val_36, lo = val_64, mid = val_38});
            System.Func<System.Single> val_39 = new System.Func<System.Single>(object:  311181312, method:  new IntPtr(2789264816));
            mem[1152921511691214176] = null;
            return;
        }
        
        if((_rewardData.rewards.ContainsKey(key:  2)) != false)
        {
                object val_41 = null;
            val_68 = val_41;
            val_41 = new System.Object();
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_2).__il2cppRuntimeField_C = val_64;
            UnityEngine.GameObject val_42 = this.rewardCoinObject.gameObject;
            this.rewardCoinObject.SetActive(value:  true);
            UnityEngine.GameObject val_43 = this.rewardBonusGameObject.gameObject;
            this.rewardBonusGameObject.SetActive(value:  false);
            UnityEngine.GameObject val_44 = this.rewardCoinGoldenObject.gameObject;
            this.rewardCoinGoldenObject.SetActive(value:  false);
            val_67 = val_64;
            decimal val_45 = categoriesCleared.Item[_rewardData.rewards];
            string val_46 = ToString();
            this.rewardSingularIcon.sprite = this.goldenCurrencyIcon;
            Player val_47 = App.Player;
            decimal val_48 = Item[_rewardData.rewards];
            val_64 = 0;
            int val_50 = 4 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            typeof(CategoryPackCompletionRewardPopup.<>c__DisplayClass19_2).__il2cppRuntimeField_8 = val_50;
            this.goldenAnimControl.SetStatViewValue(instantValue:  val_50);
            System.Func<System.Single> val_51 = new System.Func<System.Single>(object:  311234560, method:  new IntPtr(2789306800));
            this.onCollectCreditAction = null;
            return;
        }
        
        if((_rewardData.rewards.ContainsKey(key:  3)) == false)
        {
            goto label_70;
        }
        
        UnityEngine.GameObject val_53 = this.rewardCoinObject.gameObject;
        this.rewardCoinObject.SetActive(value:  false);
        UnityEngine.GameObject val_54 = this.rewardBonusGameObject.gameObject;
        this.rewardBonusGameObject.SetActive(value:  true);
        UnityEngine.GameObject val_55 = this.rewardCoinGoldenObject.gameObject;
        this.rewardCoinGoldenObject.SetActive(value:  false);
        string val_56 = Localization.Localize(key:  -1505638896, defaultValue:  -1505638992, useSingularKey:  false);
        this.rewardBonusGameIcon.sprite = this.bonusIconWheel;
        val_68 = 1152921504918134784;
        val_72 = null;
        val_72 = null;
        val_74 = CategoryPackCompletionRewardPopup.<>c.<>9__19_0;
        if(val_74 != 0)
        {
            goto label_99;
        }
        
        val_74 = null;
        val_74 = new System.Func<System.Single>(object:  CategoryPackCompletionRewardPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2789340800));
        CategoryPackCompletionRewardPopup.<>c.<>9__19_0 = val_74;
        goto label_99;
        label_70:
        if((_rewardData.rewards.ContainsKey(key:  4)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_59 = this.rewardCoinObject.gameObject;
        this.rewardCoinObject.SetActive(value:  false);
        UnityEngine.GameObject val_60 = this.rewardBonusGameObject.gameObject;
        this.rewardBonusGameObject.SetActive(value:  true);
        UnityEngine.GameObject val_61 = this.rewardCoinGoldenObject.gameObject;
        this.rewardCoinGoldenObject.SetActive(value:  false);
        string val_62 = Localization.Localize(key:  -1505604896, defaultValue:  -1505604992, useSingularKey:  false);
        this.rewardBonusGameIcon.sprite = this.bonusIconSlots;
        val_68 = 1152921504918134784;
        val_75 = null;
        val_75 = null;
        val_74 = CategoryPackCompletionRewardPopup.<>c.<>9__19_1;
        if(val_74 == 0)
        {
                val_74 = null;
            val_74 = new System.Func<System.Single>(object:  CategoryPackCompletionRewardPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2789374800));
            CategoryPackCompletionRewardPopup.<>c.<>9__19_1 = val_74;
        }
        
        label_99:
        this.onCollectCreditAction = val_74;
    }
    private void OnCollectClick()
    {
        float val_4;
        this.collectButton.interactable = false;
        if(this.onCollectCreditAction != 0)
        {
                float val_1 = this.onCollectCreditAction.Invoke();
            val_4 = this.onCollectCreditAction;
        }
        else
        {
                val_4 = 0f;
        }
        
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -1505240432, method:  new IntPtr(2789701840));
        DG.Tweening.Tween val_3 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  0, ignoreTimeScale:  false);
    }
    private void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1505120240, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public CategoryPackCompletionRewardPopup()
    {
    
    }

}
