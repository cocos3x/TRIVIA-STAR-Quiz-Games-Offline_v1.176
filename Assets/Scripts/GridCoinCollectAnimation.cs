using UnityEngine;
public class GridCoinCollectAnimation : MonoBehaviour, CollectAnimation
{
    // Fields
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.UI.GridLayoutGroup _rowsGrid;
    private UnityEngine.UI.GridLayoutGroup[] childGrids;
    private bool playOnEnable;
    private UnityEngine.TextAnchor verticalAlignment;
    private System.Collections.Generic.List<AnimatedCoin> coins;
    private DG.Tweening.Sequence showSequence;
    private DG.Tweening.Sequence middleSequence;
    private DG.Tweening.Sequence finalSequence;
    public System.Action<bool> OnCoinDepositSpecialAction;
    public UnityEngine.Transform collectTarget;
    public PlayerCoinAddedBalance playerCoinAddedBalance;
    public GridCoinCollectAnimation.BalanceCountOptions whenToCount;
    private int maxCoins;
    private int numberOfCoinsToShow;
    private int coinsPerRow;
    private UnityEngine.Vector2 coinSize;
    private float soundTimer;
    private float soundIntervalLimit;
    private float horizontalSpacing;
    private float verticalSpacing;
    private float jumpInterval;
    private float jumpDuration;
    private float flyToBalanceDuration;
    private AnimatedCoin AnimatedCoinPrefabOverride;
    private bool <isAnimating>k__BackingField;
    private bool initialized;
    private bool coinExpansionEnabled;
    
    // Properties
    private UnityEngine.UI.GridLayoutGroup rowsGrid { get; }
    private float coinsVerticalSpacing { get; set; }
    private float coinsHorizontalSpacing { get; set; }
    public bool isAnimating { get; set; }
    
    // Methods
    private UnityEngine.UI.GridLayoutGroup get_rowsGrid()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this._rowsGrid)) != false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.UI.LayoutElement val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  104616896);
        this._rowsGrid = this;
    }
    private float get_coinsVerticalSpacing()
    {
        UnityEngine.UI.GridLayoutGroup val_1 = this.rowsGrid;
        if(this != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private void set_coinsVerticalSpacing(float value)
    {
        UnityEngine.UI.GridLayoutGroup val_1 = this.rowsGrid;
        UnityEngine.UI.GridLayoutGroup val_2 = this.rowsGrid;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  value, y:  null);
        this.spacing = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
    }
    private float get_coinsHorizontalSpacing()
    {
        if(this.childGrids[0] != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private void set_coinsHorizontalSpacing(float value)
    {
        goto label_0;
        label_8:
        UnityEngine.UI.GridLayoutGroup val_3 = this.childGrids[0];
        UnityEngine.UI.GridLayoutGroup val_4 = this.childGrids[0];
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  value, y:  null);
        val_3.spacing = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        4 = 5;
        label_0:
        if((4 - 4) < val_3)
        {
            goto label_8;
        }
    
    }
    public bool get_isAnimating()
    {
        return (bool)this.<isAnimating>k__BackingField;
    }
    private void set_isAnimating(bool value)
    {
        this.<isAnimating>k__BackingField = value;
    }
    private void Awake()
    {
    
    }
    private void Start()
    {
    
    }
    private void Initialize()
    {
        float val_49;
        var val_50;
        var val_51;
        GridCoinCollectAnimation val_52;
        UnityEngine.TextAnchor val_53;
        var val_54;
        UnityEngine.Transform val_55;
        if(this.initialized == true)
        {
                return;
        }
        
        this.initialized = true;
        float val_49 = (float)this.coinsPerRow;
        val_49 = (float)this.maxCoins / val_49;
        this.childGrids = null;
        GameSpecificUI val_1 = GameSpecificUI.currentGame;
        AnimatedCoin val_2 = 0.AnimatedCoin;
        object val_3 = 0.GetComponent<System.Object>();
        val_49 = 0;
        UnityEngine.Rect val_4 = rect;
        float val_5 = width;
        UnityEngine.Rect val_6 = rect;
        float val_7 = height;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_7, y:  val_6.m_YMin);
        this.coinSize = val_8.x;
        mem[1152921513302741488] = val_8.y;
        UnityEngine.UI.GridLayoutGroup val_9 = this.rowsGrid;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_7, y:  val_6.m_YMin);
        this.spacing = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        UnityEngine.UI.GridLayoutGroup val_11 = this.rowsGrid;
        val_50 = this;
        val_51 = 0;
        UnityEngine.Rect val_12 = rect;
        float val_13 = width;
        UnityEngine.Rect val_14 = rect;
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  height, y:  val_14.m_YMin);
        val_52 = this;
        this.cellSize = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
        UnityEngine.UI.GridLayoutGroup val_17 = this.rowsGrid;
        this.constraint = 1;
        UnityEngine.UI.GridLayoutGroup val_18 = this.rowsGrid;
        this.constraintCount = 1;
        UnityEngine.UI.GridLayoutGroup val_19 = this.rowsGrid;
        val_53 = mem[1152921513302741436];
        val_54 = 0;
        this.childAlignment = val_53;
        if(val_49 >= (1.401298E-45f))
        {
                do
        {
            string val_20 = 105932672 + 13152256;
            UnityEngine.GameObject val_21 = null;
            val_50 = val_21;
            val_21 = new UnityEngine.GameObject(name:  105932672);
            UnityEngine.Transform val_22 = transform;
            UnityEngine.UI.GridLayoutGroup val_23 = this.rowsGrid;
            UnityEngine.Transform val_24 = this.transform;
            SetParent(p:  105959840);
            UnityEngine.Transform val_25 = transform;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.zero;
            localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_27 = transform;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
            localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y};
            object val_29 = AddComponent<System.Object>();
            UnityEngine.UI.GridLayoutGroup[].__il2cppRuntimeField_namespaze.__unknownFiledOffset_10 = val_50;
            UnityEngine.Rect val_30 = rect;
            UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  width, y:  val_30.m_YMin);
            UnityEngine.UI.GridLayoutGroup[].__il2cppRuntimeField_namespaze + 16.spacing = new UnityEngine.Vector2() {x = val_32.x, y = val_32.y};
            UnityEngine.Rect val_33 = rect;
            float val_34 = width;
            UnityEngine.Rect val_35 = rect;
            val_54 = 0;
            UnityEngine.Vector2 val_37 = new UnityEngine.Vector2(x:  height, y:  val_35.m_YMin);
            UnityEngine.UI.GridLayoutGroup[].__il2cppRuntimeField_namespaze + 16.cellSize = new UnityEngine.Vector2() {x = val_37.x, y = val_37.y};
            val_52 = this;
            UnityEngine.UI.GridLayoutGroup[].__il2cppRuntimeField_namespaze + 16.constraint = 1;
            val_53 = mem[UnityEngine.UI.GridLayoutGroup[].__il2cppRuntimeField_namespaze + 16];
            val_53 = UnityEngine.UI.GridLayoutGroup[].__il2cppRuntimeField_namespaze + 16;
            val_53.constraintCount = this.coinsPerRow;
            UnityEngine.UI.GridLayoutGroup[].__il2cppRuntimeField_namespaze + 16.childAlignment = 4;
            val_51 = 0 + 1;
        }
        while(val_49 != val_51);
        
        }
        
        if(this.maxCoins < 1)
        {
                return;
        }
        
        var val_50 = 0;
        val_50 = 1152921504765685760;
        val_49 = 1152921513302715360;
        label_69:
        int val_38 = this.GetRowForCoin(i:  0);
        if(mem[1152921513302741520] != 0)
        {
            goto label_53;
        }
        
        GameSpecificUI val_40 = GameSpecificUI.currentGame;
        AnimatedCoin val_41 = 0.AnimatedCoin;
        val_51 = 0;
        UnityEngine.UI.GridLayoutGroup[] val_42 = this.childGrids + (val_38 << 2);
        UnityEngine.Transform val_43 = mem[(this.childGrids + (val_38) << 2) + 16].transform;
        val_55 = mem[(this.childGrids + (val_38) << 2) + 16];
        if(mem[1152921513302741526] == false)
        {
            goto label_58;
        }
        
        val_49 = val_49;
        goto label_59;
        label_53:
        val_51 = mem[1152921513302741520];
        UnityEngine.UI.GridLayoutGroup[] val_44 = this.childGrids + (val_38 << 2);
        UnityEngine.Transform val_45 = mem[(this.childGrids + (val_38) << 2) + 16].transform;
        val_55 = mem[(this.childGrids + (val_38) << 2) + 16];
        goto label_63;
        label_58:
        UnityEngine.Transform val_46 = val_55.parent;
        val_49 = val_49;
        UnityEngine.Transform val_47 = val_55.parent;
        val_55 = val_55;
        label_59:
        val_50 = 1152921504765685760;
        label_63:
        object val_48 = UnityEngine.Object.Instantiate<System.Object>(original:  0, parent:  val_55);
        val_54 = mem[1152921513302741440];
        val_53 = val_51;
        val_54.Add(item:  0);
        val_50 = val_50 + 1;
        if(val_50 < this.maxCoins)
        {
            goto label_69;
        }
    
    }
    private void OnEnable()
    {
        if(this.playOnEnable == false)
        {
                return;
        }
        
        this.Reset();
        this.Play(coinsCount:  0);
    }
    private void OnDisable()
    {
        DG.Tweening.TweenExtensions.Kill(t:  this.showSequence, complete:  false);
        DG.Tweening.TweenExtensions.Kill(t:  this.middleSequence, complete:  false);
        DG.Tweening.TweenExtensions.Kill(t:  this.finalSequence, complete:  false);
    }
    public void Play(int coinsCount = -1)
    {
        int val_2;
        if(this.initialized == false)
        {
                this.initialized = this;
            this.Initialize();
        }
        
        val_2 = this.maxCoins;
        if(coinsCount >= 0)
        {
                val_2 = UnityEngine.Mathf.Min(a:  coinsCount, b:  val_2);
        }
        
        this.numberOfCoinsToShow = val_2;
        if(val_2 != 0)
        {
                this.Reset();
            this.StartFirstSequence();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  106296416, context:  106324736);
        if(this.OnCoinDepositSpecialAction == 0)
        {
                return;
        }
        
        this.OnCoinDepositSpecialAction.Invoke(obj:  false);
    }
    public void Reset()
    {
        var val_5;
        var val_6;
        this.StopAllCoroutines();
        this.<isAnimating>k__BackingField = false;
        this.canvasGroup.alpha = null;
        UnityEngine.Vector2 val_1 = this.coinSize ^ 2147483648;
        this.coinsHorizontalSpacing = null;
        this.coinsVerticalSpacing = null;
        val_5 = 4;
        goto label_2;
        label_11:
        if(this <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.Reset(grid:  106535040);
        if(2621443 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_2 = 2621443.gameObject;
        if(R7 < this.numberOfCoinsToShow)
        {
                0 = 1;
        }
        
        2621443.SetActive(value:  true);
        val_5 = 5;
        label_2:
        if((val_5 - 4) < 2621443)
        {
            goto label_11;
        }
        
        val_6 = 0;
        goto label_12;
        label_18:
        UnityEngine.UI.GridLayoutGroup val_6 = this.childGrids[val_6];
        UnityEngine.GameObject val_4 = val_6.gameObject;
        val_5 = this.GetNumberOfRowsForCoinCount(coinCount:  this.numberOfCoinsToShow);
        if(val_6 < val_5)
        {
                0 = 1;
        }
        
        val_6.SetActive(value:  true);
        val_6 = 1;
        label_12:
        if(val_6 < val_6)
        {
            goto label_18;
        }
        
        this.SetGridsEnabled(state:  true);
    }
    public void SetMaxCoins(int coins)
    {
        if(this.initialized != false)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Debug.LogWarning(message:  106717248, context:  106741440);
            return;
        }
        
        this.maxCoins = coins;
    }
    public void EnableCoinExpansion(bool enable)
    {
        this.coinExpansionEnabled = enable;
    }
    private void StartFirstSequence()
    {
        this.<isAnimating>k__BackingField = true;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.showSequence = 0;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.canvasGroup);
        DG.Tweening.Core.DOGetter<System.Single> val_4 = new DG.Tweening.Core.DOGetter<System.Single>(object:  106974656, method:  new IntPtr(106945536));
        DG.Tweening.Core.DOSetter<System.Single> val_5 = new DG.Tweening.Core.DOSetter<System.Single>(object:  106974656, method:  new IntPtr(106946560));
        if(this.coinExpansionEnabled == false)
        {
                14371132 = 14371136;
        }
        
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_6 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  this.verticalSpacing, duration:  null);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198828032, ease:  6);
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  198828032);
        DG.Tweening.Core.DOGetter<System.Single> val_9 = new DG.Tweening.Core.DOGetter<System.Single>(object:  106974656, method:  new IntPtr(106947584));
        DG.Tweening.Core.DOSetter<System.Single> val_10 = new DG.Tweening.Core.DOSetter<System.Single>(object:  106974656, method:  new IntPtr(106948608));
        if(this.coinExpansionEnabled == false)
        {
                14371140 = 14371144;
        }
        
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_11 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  this.horizontalSpacing, duration:  null);
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198828032, ease:  6);
        DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  106974656, method:  new IntPtr(106949632));
        object val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198828032, action:  190734336);
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  198828032);
    }
    private void StartMiddleSequence()
    {
        var val_14;
        float val_15;
        var val_16;
        DG.Tweening.Sequence val_17;
        DG.Tweening.Sequence val_18;
        this.SetGridsEnabled(state:  false);
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        val_14 = 0;
        this.middleSequence = 0;
        if(this.numberOfCoinsToShow < 1)
        {
            goto label_5;
        }
        
        val_16 = 4;
        goto label_6;
        label_22:
        val_17 = this.middleSequence;
        val_16 = 5;
        val_15 = this.jumpInterval;
        label_6:
        if(this.numberOfCoinsToShow <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_3 = 1.transform;
        if(1 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 * 1f;
        UnityEngine.Transform val_4 = 1.transform;
        UnityEngine.Vector3 val_5 = position;
        DG.Tweening.Sequence val_6 = DG.Tweening.ShortcutExtensions.DOJump(target:  1, endValue:  new UnityEngine.Vector3(), jumpPower:  this.jumpDuration, numJumps:  1045220557, duration:  val_5.y, snapping:  true);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  1, delay:  this.jumpDuration);
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  1, ease:  5);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_17, atPosition:  this.jumpDuration, t:  0);
        if(val_17 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        float val_10 = (this.jumpDuration * 0.36f) + val_15;
        1.PlaySparkle(delay:  val_10);
        if(((UnityEngine.Object.op_Implicit(exists:  this.playerCoinAddedBalance)) != false) && (this.whenToCount == 1))
        {
                this.playerCoinAddedBalance.Add(addAmount:  1, delay:  val_10);
        }
        
        if((val_16 - 3) < this.numberOfCoinsToShow)
        {
            goto label_22;
        }
        
        val_18 = this.middleSequence;
        label_5:
        DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  107125568, method:  new IntPtr(107100544));
        object val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_18, action:  190734336);
    }
    private void StartFinalSequence()
    {
        DG.Tweening.Sequence val_14;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        val_14 = 0;
        this.finalSequence = val_14;
        if(this.numberOfCoinsToShow >= 1)
        {
                do
        {
            var val_2 = 4 - 4;
            if(this.numberOfCoinsToShow <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Transform val_3 = 2621443.transform;
            int val_4 = 2621443.GetSiblingIndex();
            float val_17 = (float)val_4;
            if(val_4 <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_17 = val_17 * 0.06f;
            UnityEngine.Transform val_5 = 2621443.transform;
            UnityEngine.Vector3 val_6 = position;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOMove(target:  2621443, endValue:  new UnityEngine.Vector3(), duration:  this.flyToBalanceDuration, snapping:  this.flyToBalanceDuration);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  2621443, delay:  this.flyToBalanceDuration);
            object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2621443, ease:  5);
            if(2621443 <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  0, method:  new IntPtr(107266816));
            object val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  2621443, action:  190734336);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.finalSequence, atPosition:  this.flyToBalanceDuration, t:  0);
            var val_13 = 4 + 1;
        }
        while((4 - 3) < this.numberOfCoinsToShow);
        
            val_14 = this.finalSequence;
        }
        
        DG.Tweening.TweenCallback val_15 = new DG.Tweening.TweenCallback(object:  107296960, method:  new IntPtr(107271936));
        object val_16 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_14, action:  190734336);
    }
    private void FinishedAnimation()
    {
        this.<isAnimating>k__BackingField = false;
    }
    public void OnCoinDeposited()
    {
        var val_9;
        if(((UnityEngine.Object.op_Implicit(exists:  this.playerCoinAddedBalance)) != false) && (this.whenToCount == 0))
        {
                this.playerCoinAddedBalance.Add(addAmount:  1);
        }
        
        if(this.OnCoinDepositSpecialAction != 0)
        {
                this.OnCoinDepositSpecialAction.Invoke(obj:  false);
        }
        
        if(this.AllowSound() != false)
        {
                val_9 = 1152921511082729536;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2114052032) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  2, oneshot:  true, pitch:  null, vol:  null);
            return;
        }
        
        }
        
        val_9 = 1152921513304319488;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(107537920 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayCoinCollect();
    }
    public void OnSparkle()
    {
        if(this.AllowSound() == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  3, oneshot:  true, pitch:  null, vol:  null);
    }
    private int GetRowForCoin(int i)
    {
        float val_1 = (float)this.coinsPerRow;
        val_1 = (float)i / val_1;
        return UnityEngine.Mathf.FloorToInt(f:  val_1);
    }
    private int GetNumberOfRowsForCoinCount(int coinCount)
    {
        float val_1 = (float)this.coinsPerRow;
        val_1 = (float)coinCount / val_1;
        return (int)val_1;
    }
    private void SetGridsEnabled(bool state)
    {
        var val_2;
        UnityEngine.UI.GridLayoutGroup val_1 = this.rowsGrid;
        val_2 = 0;
        this.enabled = state;
        goto label_1;
        label_6:
        UnityEngine.UI.GridLayoutGroup val_2 = this.childGrids[val_2];
        val_2.enabled = state;
        val_2 = 1;
        label_1:
        if(val_2 < val_2)
        {
            goto label_6;
        }
    
    }
    private bool AllowSound()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        if()
        {
                return (bool)0;
        }
        
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        float val_3 = this.soundIntervalLimit;
        0 = 1;
        val_3 = 0 + val_3;
        this.soundTimer = val_3;
        return (bool)0;
    }
    public GridCoinCollectAnimation()
    {
        this.childGrids = null;
        this.playOnEnable = true;
        this.verticalAlignment = 4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.coins = null;
        this.maxCoins = 10;
        this.numberOfCoinsToShow = 10;
        this.coinsPerRow = 10;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  null, y:  null);
        this.coinSize = val_2.x;
        mem[1152921513305189648] = val_2.y;
        this.jumpDuration = 0.33f;
        this.flyToBalanceDuration = 0.25f;
        this.coinExpansionEnabled = true;
    }
    private float <StartFirstSequence>b__49_0()
    {
        UnityEngine.UI.GridLayoutGroup val_1 = this.rowsGrid;
        if(this != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private void <StartFirstSequence>b__49_1(float x)
    {
        this.coinsVerticalSpacing = x;
    }
    private float <StartFirstSequence>b__49_2()
    {
        return this.coinsHorizontalSpacing;
    }
    private void <StartFirstSequence>b__49_3(float y)
    {
        this.coinsHorizontalSpacing = y;
    }

}
