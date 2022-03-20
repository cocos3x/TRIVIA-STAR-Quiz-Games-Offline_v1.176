using UnityEngine;
public class CategoryPacksScreenMain : MonoSingleton<CategoryPacksScreenMain>
{
    // Fields
    private UnityEngine.RectTransform headerInfoGroupObj;
    private UnityEngine.GameObject completionMeterObject;
    private UnityEngine.UI.Slider completionMeterSlider;
    private UnityEngine.UI.Text completionMeterLabel;
    private UnityEngine.CanvasGroup completionMeterRewardObject;
    private UnityEngine.ParticleSystem rewardParticle;
    private UnityEngine.UI.LoopScrollRect packsScrollRect;
    private CategoryPackButton categoryPackPrefab;
    private UnityEngine.RectTransform packContainer;
    private UnityEngine.UI.Text subtitle;
    private UnityEngine.UI.Button buttonExit;
    public const int RESERVED_SCROLL_ID_FOR_HEADER_DISPLAY = 0;
    public const int INITIAL_SCROLL_ID_FOR_CONTENT = 2;
    private int currentHeaderParentId;
    private System.Collections.Generic.List<CategoryPackInfo> sortedPackData;
    
    // Properties
    public UnityEngine.RectTransform HeaderInfoDisplayGroup { get; }
    public System.Collections.Generic.List<CategoryPackInfo> SortedPackData { get; }
    
    // Methods
    public UnityEngine.RectTransform get_HeaderInfoDisplayGroup()
    {
    
    }
    public System.Collections.Generic.List<CategoryPackInfo> get_SortedPackData()
    {
    
    }
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1489443568, method:  new IntPtr(2805485392));
        this.buttonExit.m_OnClick.AddListener(call:  162246656);
        this.Initialize();
        this.packsScrollRect.totalCount = this.sortedPackData + 2;
        this.packsScrollRect.RefillCells(offset:  0);
        System.Action val_3 = new System.Action(object:  -1489443568, method:  new IntPtr(2805498704));
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  -1489443568, callback:  7454720);
    }
    private void OnDestroy()
    {
        if(this.buttonExit == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1489298800, method:  new IntPtr(2805485392));
        this.buttonExit.m_OnClick.RemoveListener(call:  162246656);
    }
    private void Initialize()
    {
        bool val_14 = static_value_021F9F84;
        if(val_14 != true)
        {
                val_14 = true;
        }
        
        System.Collections.Generic.List<CategoryPackInfo> val_1 = this.SortPacks();
        this.sortedPackData = val_14;
        string val_2 = Localization.Localize(key:  -1489194416, defaultValue:  -1489194304, useSingularKey:  false);
        GameEcon val_3 = App.getGameEcon;
        string val_4 = System.String.Format(format:  -1489194416, arg0:  1016);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_6 = RewardCurrentPacks;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_8 = RewardTargetPacks;
        string val_9 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_14 = (float)RewardTargetPacks;
        val_14 = (float)RewardCurrentPacks / val_14;
    }
    private CategoryPackButton GetPackButtonFromId(int packIdToFind)
    {
        T[] val_1 = this.packsScrollRect.m_Content.GetComponentsInChildren<System.Object>();
        if(this.packsScrollRect.m_Content == 0)
        {
                return;
        }
        
        if((public T[] UnityEngine.Component::GetComponentsInChildren<CategoryPackButton>()) < 1)
        {
                return;
        }
        
        UnityEngine.RectTransform val_2 = this.packsScrollRect.m_Content + 16;
        var val_4 = 0;
        do
        {
            if(160436224 != 0)
        {
                if(UnityEngine.RectTransform.__il2cppRuntimeField_properties != 0)
        {
                UnityEngine.RectTransform.__il2cppRuntimeField_properties = IL2CPP_Property{name:offsetMax, type: UnityEngine.Vector2, class: UnityEngine.Vector2};
        }
        
            if(UnityEngine.RectTransform.__il2cppRuntimeField_properties == 0)
        {
                UnityEngine.RectTransform.__il2cppRuntimeField_properties = 0;
        }
        
        }
        
            val_4 = val_4 + 1;
        }
        while(val_4 < 0);
    
    }
    private System.Collections.Generic.List<CategoryPackInfo> SortPacks()
    {
        var val_16;
        var val_17;
        var val_18;
        float val_19;
        var val_20;
        twelvegigs.sweepstakes.Distribution val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        CategoryPacksScreenMain.<>c__DisplayClass23_0 val_1 = new CategoryPacksScreenMain.<>c__DisplayClass23_0();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(CategoryPacksScreenMain.<>c__DisplayClass23_0).__il2cppRuntimeField_8 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
        val_16 = null;
        val_16 = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_17 = 0;
        val_18 = val_1;
        val_19 = 1152921511707850304;
        goto label_6;
        label_40:
        if(val_8 <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_16 = CategoryPackData.packList + 8;
        val_16 = val_16 + 0;
        val_18 = val_1;
        if((IsPackCompleted(packId:  (CategoryPackData.packList + 8 + 0) + 16 + 8)) == false)
        {
            goto label_10;
        }
        
        if((CategoryPackData.packList + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_17 = CategoryPackData.packList + 8;
        val_17 = val_17 + 0;
        if(((CategoryPackData.packList + 8 + 0) + 16 + 8) != PackNewlyCompleted)
        {
            goto label_26;
        }
        
        label_10:
        if((CategoryPackData.packList + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_18 = CategoryPackData.packList + 8;
        val_18 = val_18 + 0;
        if((CategoryPackData.packList + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_19 = CategoryPackData.packList + 8;
        val_19 = val_19 + 0;
        if((IsPackOwned(packId:  (CategoryPackData.packList + 8 + 0) + 16 + 8)) == false)
        {
            goto label_19;
        }
        
        val_20 = public System.Void System.Collections.Generic.List<CategoryPackInfo>::Add(CategoryPackInfo item);
        val_21 = (CategoryPackData.packList + 8 + 0) + 16;
        goto label_21;
        label_19:
        val_18 = val_1;
        if(((CategoryPackData.packList + 8 + 0) + 16 + 20) == 0)
        {
            goto label_23;
        }
        
        if((CategoryPackData.packList + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_20 = CategoryPackData.packList + 8;
        val_20 = val_20 + 0;
        if(((CategoryPackData.packList + 8 + 0) + 16.IsAvailable) == false)
        {
            goto label_26;
        }
        
        label_23:
        if((CategoryPackData.packList + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_21 = CategoryPackData.packList + 8;
        val_21 = val_21 + 0;
        if((CategoryPackData.packList + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_22 = CategoryPackData.packList + 8;
        val_22 = val_22 + 0;
        if((CategoryPackData.packList + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_23 = CategoryPackData.packList + 8;
        val_23 = val_23 + 0;
        if((IsPackNewlyDiscovered(packId:  (CategoryPackData.packList + 8 + 0) + 16 + 8)) == false)
        {
            goto label_33;
        }
        
        if(((CategoryPackData.packList + 8 + 0) + 16 + 20) == 0)
        {
            goto label_34;
        }
        
        val_19 = 1152921511707850304;
        goto label_36;
        label_33:
        if(((CategoryPackData.packList + 8 + 0) + 16 + 20) == 0)
        {
                (CategoryPackData.packList + 8 + 0) + 16 + 20 = val_8;
        }
        
        if(((CategoryPackData.packList + 8 + 0) + 16 + 20) != 0)
        {
                val_22 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
        
        goto label_37;
        label_34:
        val_22 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        label_37:
        val_19 = 1152921511707850304;
        label_36:
        val_21 = (CategoryPackData.packList + 8 + 0) + 16;
        label_21:
        Add(item:  val_21);
        val_18 = val_1;
        label_26:
        val_17 = 1;
        label_6:
        if(val_17 < (CategoryPackData.packList + 12))
        {
            goto label_40;
        }
        
        System.Comparison<WordForest.NewsArticle> val_14 = new System.Comparison<WordForest.NewsArticle>(object:  312193024, method:  new IntPtr(2806037056));
        Sort(comparison:  7933952);
        LockedCategoryPacksComparer val_15 = new LockedCategoryPacksComparer();
        Sort(comparer:  312299520);
        Sort(comparer:  312299520);
        Sort(comparer:  312299520);
        Sort(comparer:  312299520);
        val_23 = 0;
        val_24 = 0;
        val_25 = val_5;
        if(val_25 == 0)
        {
                val_25 = val_5;
        }
        
        val_26 = 0;
        val_27 = 0;
        val_28 = 0;
        if(val_8 != 0)
        {
                return;
        }
    
    }
    private void ResolveQueuedActions()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PackNewlyCompleted < 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CategoryPackButton val_5 = this.GetPackButtonFromId(packIdToFind:  PackNewlyCompleted);
        if((-1488790144) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_8 = RewardCurrentPacks;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CategoryCompletionReward val_12 = ResolveNewlyCompletedPack();
        if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance()) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CreditGoalReward(chosenReward:  -2102212592);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        1152921504901095424 = RewardCurrentPacks;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.DoPackCompleteAnimation(packButton:  -1488790144, goalValueStart:  0, goalValueEnd:  1152921504901095424, goalTargetStart:  RewardTargetPacks, goalTargetEnd:  RewardTargetPacks, goalRewardData:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance());
    }
    private void DoPackCompleteAnimation(CategoryPackButton packButton, int goalValueStart, int goalValueEnd, int goalTargetStart, int goalTargetEnd, CategoryCompletionReward goalRewardData)
    {
        float val_13;
        float val_61;
        float val_64;
        float val_90;
        CategoryPacksScreenMain val_91;
        float val_92;
        var val_93;
        CategoryPacksScreenMain.<>c__DisplayClass25_0 val_1 = new CategoryPacksScreenMain.<>c__DisplayClass25_0();
        if(val_1 != 0)
        {
                if(goalRewardData != 0)
        {
                goalRewardData = 1;
        }
        
            typeof(CategoryPacksScreenMain.<>c__DisplayClass25_0).__il2cppRuntimeField_28 = 1;
            if(goalRewardData != 0)
        {
                goalValueEnd = goalTargetStart;
        }
        
            CategoryPacksScreenMain.<>c__DisplayClass25_0.__il2cppRuntimeField_declaringType.__il2cppRuntimeField_FFFFFFFFFFFFFFE0 = this;
            CategoryPacksScreenMain.<>c__DisplayClass25_0.__il2cppRuntimeField_declaringType.__il2cppRuntimeField_4 = goalRewardData;
            CategoryPacksScreenMain.<>c__DisplayClass25_0.__il2cppRuntimeField_declaringType.__il2cppRuntimeField_FFFFFFFFFFFFFFE8 = goalValueEnd;
            CategoryPacksScreenMain.<>c__DisplayClass25_0.__il2cppRuntimeField_declaringType.__il2cppRuntimeField_FFFFFFFFFFFFFFEC = goalTargetStart;
        }
        else
        {
                mem[8] = this;
            if(goalRewardData != 0)
        {
                goalRewardData = 1;
        }
        
            mem[40] = 1;
            mem[44] = goalRewardData;
            if(mem[40] == 0)
        {
                goalTargetStart = goalValueEnd;
        }
        
            typeof(CategoryPacksScreenMain.<>c__DisplayClass25_0).__il2cppRuntimeField_10 = goalTargetStart;
            mem[20] = goalTargetStart;
        }
        
        if(mem[40] != 0)
        {
                val_90 = 1f;
        }
        else
        {
                val_90 = (float)goalValueEnd / (float)goalTargetEnd;
        }
        
        if(packButton != 0)
        {
            
        }
        
        UnityEngine.Transform val_2 = 1835037.transform;
        object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  1835037, parent:  1835037);
        if(val_1 != 0)
        {
                typeof(CategoryPacksScreenMain.<>c__DisplayClass25_0).__il2cppRuntimeField_C = 1835037;
        }
        else
        {
                mem[12] = 1835037;
        }
        
        UnityEngine.Transform val_4 = mem[12].transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        mem[12].localPosition = new UnityEngine.Vector3();
        UnityEngine.Transform val_6 = this.completionMeterLabel.transform;
        object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  this.completionMeterLabel, parent:  this.completionMeterLabel);
        if(val_1 != 0)
        {
                typeof(CategoryPacksScreenMain.<>c__DisplayClass25_0).__il2cppRuntimeField_18 = this.completionMeterLabel;
        }
        else
        {
                mem[24] = this.completionMeterLabel;
        }
        
        UnityEngine.Transform val_8 = mem[24].transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        mem[24].localPosition = new UnityEngine.Vector3();
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_11 = UnityEngine.Color.clear;
        System.Nullable<UnityEngine.Color> val_12 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {a = ???});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_12.HasValue}, fadeInDuration:  val_11.r, fadeOutDuration:  val_11.g);
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_91 = this;
        ShowOverlay(contentToOverlay:  public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 92);
        DG.Tweening.Sequence val_17 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_11.r);
        DG.Tweening.TweenCallback val_19 = new DG.Tweening.TweenCallback(object:  312246272, method:  new IntPtr(2806283584));
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_11.r);
        UnityEngine.Transform val_22 = mem[12].transform;
        UnityEngine.Transform val_23 = mem[1152921511708127004].transform;
        UnityEngine.Vector3 val_24 = position;
        DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions.DOMove(target:  1835037, endValue:  new UnityEngine.Vector3(), duration:  val_24.x, snapping:  false);
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  1835037);
        UnityEngine.Transform val_27 = mem[12].transform;
        DG.Tweening.Tweener val_28 = DG.Tweening.ShortcutExtensions.DOScale(target:  1835037, endValue:  val_24.x, duration:  val_24.y);
        object val_29 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  1835037, ease:  1);
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  1835037);
        DG.Tweening.Tweener val_31 = DG.Tweening.ShortcutExtensions46.DOFade(target:  1835037, endValue:  val_24.x, duration:  val_24.y);
        object val_32 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  1835037, delay:  val_24.x);
        object val_33 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  1835037, ease:  1);
        DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  1835037);
        UnityEngine.Transform val_35 = mem[1152921511708127004].transform;
        UnityEngine.Vector3 val_36 = new UnityEngine.Vector3(x:  val_24.x, y:  val_24.y, z:  val_24.z);
        DG.Tweening.Tweener val_37 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  mem[1152921511708127004], punch:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, duration:  val_24.x, vibrato:  1051931443, elasticity:  val_24.y);
        DG.Tweening.TweenCallback val_38 = new DG.Tweening.TweenCallback(object:  312246272, method:  new IntPtr(2806284608));
        object val_39 = DG.Tweening.TweenSettingsExtensions.OnStart<System.Object>(t:  mem[1152921511708127004], action:  190734336);
        DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921511708127004]);
        DG.Tweening.Tweener val_41 = DG.Tweening.ShortcutExtensions46.DOValue(target:  mem[1152921511708126996], endValue:  val_24.x, duration:  val_24.y, snapping:  val_90);
        DG.Tweening.Sequence val_42 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921511708126996]);
        val_92 = 5.605194E-44f;
        val_93 = 1152921509932985248;
        UnityEngine.Transform val_43 = mem[24].transform;
        DG.Tweening.Tweener val_44 = DG.Tweening.ShortcutExtensions.DOScale(target:  mem[24], endValue:  val_24.x, duration:  val_24.y);
        object val_45 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[24], ease:  1);
        DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[24]);
        DG.Tweening.Tweener val_47 = DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[24], endValue:  val_24.x, duration:  val_24.y);
        object val_48 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  mem[24], delay:  val_24.x);
        object val_49 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[24], ease:  1);
        DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[24]);
        DG.Tweening.TweenCallback val_51 = new DG.Tweening.TweenCallback(object:  312246272, method:  new IntPtr(2806286656));
        DG.Tweening.Tween val_52 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_24.x, callback:  1036831949, ignoreTimeScale:  false);
        DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  1036831949);
        UnityEngine.Transform val_54 = mem[1152921511708127004].transform;
        UnityEngine.Vector3 val_55 = position;
        if(mem[40] != 0)
        {
                UnityEngine.Transform val_56 = mem[1152921511708127004].transform;
            UnityEngine.Vector3 val_57 = val_12.HasValue.position;
            twelvegigs.Autopilot.AutopilotManager val_58 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_59 = mem[1152921511708127012].transform;
            UnityEngine.Vector3 val_60 = TransformPositionToOverlaySpace(objectTransform:  -1637058032);
            UnityEngine.Transform val_62 = mem[1152921511708127004].transform;
            UnityEngine.Vector3 val_63 = position;
            val_91 = this;
            UnityEngine.Transform val_65 = mem[1152921511708127004].transform;
            DG.Tweening.Tweener val_66 = DG.Tweening.ShortcutExtensions.DOMove(target:  mem[1152921511708127004], endValue:  new UnityEngine.Vector3() {x = val_13, y = val_61, z = val_64}, duration:  val_63.x, snapping:  true);
            object val_67 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[1152921511708127004], ease:  1);
            DG.Tweening.Sequence val_68 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921511708127004]);
            val_93 = 0;
            UnityEngine.Transform val_69 = mem[1152921511708127004].transform;
            UnityEngine.Vector3 val_70 = new UnityEngine.Vector3(x:  val_63.x, y:  val_63.y, z:  val_63.z);
            DG.Tweening.Tweener val_71 = DG.Tweening.ShortcutExtensions.DOScale(target:  mem[1152921511708127004], endValue:  new UnityEngine.Vector3() {x = val_70.x, y = val_70.y, z = val_70.z}, duration:  val_63.x);
            object val_72 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[1152921511708127004], ease:  1);
            DG.Tweening.Sequence val_73 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[1152921511708127004]);
            val_92 = 15820;
            val_92 = 1036831949;
            DG.Tweening.Sequence val_74 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_63.x);
            UnityEngine.Transform val_75 = mem[1152921511708127004].transform;
            UnityEngine.Vector3 val_76 = new UnityEngine.Vector3(x:  val_63.x, y:  val_63.y, z:  val_63.z);
            DG.Tweening.Tweener val_77 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  mem[1152921511708127004], duration:  val_63.x, strength:  new UnityEngine.Vector3() {x = 1f, y = val_76.x, z = val_76.y}, vibrato:  val_76.z, randomness:  val_63.y, fadeOut:  true);
            DG.Tweening.Sequence val_78 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921511708127004]);
            UnityEngine.Transform val_79 = mem[1152921511708127004].transform;
            UnityEngine.Vector3 val_80 = new UnityEngine.Vector3(x:  val_63.x, y:  val_63.y, z:  val_63.z);
            DG.Tweening.Tweener val_81 = DG.Tweening.ShortcutExtensions.DOScale(target:  mem[1152921511708127004], endValue:  new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z}, duration:  val_63.x);
            object val_82 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[1152921511708127004], ease:  mem[12]);
            DG.Tweening.Sequence val_83 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921511708127004]);
            DG.Tweening.Tweener val_84 = DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[1152921511708127004], endValue:  val_63.x, duration:  val_63.y);
            object val_85 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[1152921511708127004], ease:  1);
            DG.Tweening.Sequence val_86 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921511708127004]);
        }
        
        DG.Tweening.TweenCallback val_87 = new DG.Tweening.TweenCallback(object:  312246272, method:  new IntPtr(2806287680));
        object val_88 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    public void OnScrollFocusChanged(int currScrollFocalIndex, UnityEngine.Transform currScrollFocalTransform)
    {
        float val_8;
        float val_9;
        UnityEngine.Transform val_12;
        var val_13;
        val_12 = 35626889;
        if(currScrollFocalIndex != 0)
        {
                if(currScrollFocalTransform.GetInstanceID() != this.currentHeaderParentId)
        {
                return;
        }
        
            UnityEngine.Transform val_2 = this.packsScrollRect.transform;
            val_12 = this.packsScrollRect;
            this.headerInfoGroupObj.SetParent(p:  val_12);
            UnityEngine.GameObject val_3 = this.headerInfoGroupObj.gameObject;
            this.headerInfoGroupObj.SetActive(value:  false);
            val_13 = 0;
        }
        else
        {
                this.headerInfoGroupObj.SetParent(p:  currScrollFocalTransform);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            this.headerInfoGroupObj.localScale = new UnityEngine.Vector3();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.headerInfoGroupObj.localPosition = new UnityEngine.Vector3();
            val_12 = this.headerInfoGroupObj;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.y);
            val_12.anchorMax = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            if(val_12 != 0)
        {
                val_12.anchorMin = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        else
        {
                0.anchorMin = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        
            val_12.pivot = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            this.headerInfoGroupObj.anchoredPosition = new UnityEngine.Vector2() {x = val_8, y = val_9};
            UnityEngine.GameObject val_10 = this.headerInfoGroupObj.gameObject;
            this.headerInfoGroupObj.SetActive(value:  true);
        }
        
        this.currentHeaderParentId = currScrollFocalTransform.GetInstanceID();
    }
    public void CloseWindow()
    {
        CategoryPacksMenuUI.Exit();
    }
    public void CloseWindow(bool rememberScrollAmt)
    {
        CategoryPacksMenuUI.Exit();
    }
    public CategoryPacksScreenMain()
    {
        this.currentHeaderParentId = 0;
    }

}
