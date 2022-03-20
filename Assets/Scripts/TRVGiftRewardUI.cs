using UnityEngine;
public class TRVGiftRewardUI : GiftRewardUI
{
    // Fields
    private TRVExpertDisplay expertCardPrefab;
    private UnityEngine.GameObject coinBagPrefab;
    
    // Methods
    private void Awake()
    {
        if(static_value_021FAA5F != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R4.gameObject;
        object val_3 = R4.GetComponent<System.Object>();
        mem2[0] = R4;
    }
    protected override System.Collections.Generic.List<GiftRewardRevealInfo> CreateRewardReveals(System.Collections.Generic.List<GiftRewardUIParams> rewardsParams, System.Action onAllRewardsRevealed)
    {
        GiftRewardUIParams val_4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((val_4 + 8 + 8) == 0)
        {
            goto label_5;
        }
        
        if((val_4 + 8 + 8) != 3)
        {
            goto label_10;
        }
        
        GiftRewardRevealInfo val_5 = this.AddExpertReward(param:  val_4);
        Add(item:  -596391856);
        goto label_10;
        label_5:
        GiftRewardRevealInfo val_6 = this.AddCoinReward(param:  val_4);
        Add(item:  -596391856);
        goto label_10;
        label_2:
        Dispose();
    }
    public GiftRewardRevealInfo AddCoinReward(GiftRewardUIParams param)
    {
        if(new System.Object() != 0)
        {
                typeof(TRVGiftRewardUI.<>c__DisplayClass4_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(TRVGiftRewardUI.<>c__DisplayClass4_0).__il2cppRuntimeField_C = param;
        UnityEngine.Transform val_2 = param.transform;
        object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.coinBagPrefab, parent:  param);
        object val_4 = this.coinBagPrefab.GetComponentInChildren<System.Object>();
        string val_6 = (param + 8) + 20.ToString();
        UnityEngine.UI.LayoutElement val_7 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.coinBagPrefab);
        this.coinBagPrefab.alpha = null;
        this.coinBagPrefab.SetActive(value:  true);
        GiftRewardRevealInfo val_8 = new GiftRewardRevealInfo();
        typeof(GiftRewardRevealInfo).__il2cppRuntimeField_8 = this.coinBagPrefab;
        System.Action val_9 = new System.Action(object:  353460224, method:  new IntPtr(3698679824));
        typeof(GiftRewardRevealInfo).__il2cppRuntimeField_C = null;
    }
    public GiftRewardRevealInfo AddExpertReward(GiftRewardUIParams param)
    {
        object val_1 = new System.Object();
        UnityEngine.Transform val_2 = R7.transform;
        object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.expertCardPrefab, parent:  R7);
        typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = this.expertCardPrefab;
        typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_C = (GiftReward.__il2cppRuntimeField_typeHierarchy + (TRVDailyBonusRewardContainer.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_5 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.Item[(GiftReward.__il2cppRuntimeField_typeHierarchy + (TRVDailyBonusRewardContainer.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4 + 8];
        typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_10 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18;
        typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_8.Init(me:  typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_C, progress:  public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18, upgraded:  false, showName:  true);
        GiftRewardRevealInfo val_6 = new GiftRewardRevealInfo();
        UnityEngine.GameObject val_7 = typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_8.gameObject;
        typeof(GiftRewardRevealInfo).__il2cppRuntimeField_8 = typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_8;
        System.Action val_8 = new System.Action(object:  353513472, method:  new IntPtr(3698813328));
        typeof(GiftRewardRevealInfo).__il2cppRuntimeField_C = null;
        UnityEngine.GameObject val_9 = typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_8.gameObject;
        UnityEngine.UI.LayoutElement val_10 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_8);
        typeof(TRVGiftRewardUI.<>c__DisplayClass5_0).__il2cppRuntimeField_8.alpha = null;
    }
    public TRVGiftRewardUI()
    {
    
    }

}
