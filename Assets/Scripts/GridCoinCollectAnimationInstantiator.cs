using UnityEngine;
public class GridCoinCollectAnimationInstantiator : StatViewInstantiatior
{
    // Fields
    private GridCoinCollectAnimationInstantiator.StoreButtonBehavior storeButtonStartBehavior;
    private bool disableWhenComplete;
    private UnityEngine.Transform animParentXfm;
    private int maxCoins;
    private float textTweenTime;
    private UnityEngine.Transform collectTarget;
    private float delayBeforeAnimationConclusion;
    private GridCoinCollectAnimation.BalanceCountOptions whenToCount;
    private PlayerCoinAddedBalance playerCoinAddedBalance;
    private UnityEngine.GameObject StatViewObjectOverride;
    private GridCoinCollectAnimation AnimObjectOverride;
    protected UnityEngine.Vector2 tweenPointBeforePlay;
    public System.Action OnCompleteCallback;
    private UnityEngine.GameObject animObject;
    private GridCoinCollectAnimation anim;
    private decimal startValue;
    private decimal finalValue;
    private bool firstCoinReached;
    private bool coinExpansionEnabled;
    private static System.Collections.Generic.List<GridCoinCollectAnimationInstantiator> gridCoinCollectAnimInstances;
    
    // Properties
    public UnityEngine.GameObject StatViewObject { get; }
    
    // Methods
    public UnityEngine.GameObject get_StatViewObject()
    {
    
    }
    protected override void SetupAnimatedElements()
    {
        UnityEngine.Transform val_20;
        GridCoinCollectAnimation val_21;
        GridCoinCollectAnimation val_22;
        System.Action<System.Boolean> val_23;
        UnityEngine.Transform val_24;
        object val_1 = static_value_021FD8D6.GetComponentInChildren<System.Object>();
        if((UnityEngine.Object.op_Implicit(exists:  static_value_021FD8D6)) != false)
        {
                UnityEngine.Object.Destroy(obj:  static_value_021FD8D6);
        }
        
        Player val_3 = App.Player;
        SB.Set(instantValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256});
        if(this.storeButtonStartBehavior != 0)
        {
                object val_4 = 256.GetComponentInChildren<System.Object>(includeInactive:  true);
            if(256 != 0)
        {
                if(this.storeButtonStartBehavior == 1)
        {
                UnityEngine.GameObject val_6 = 256.gameObject;
            256.SetActive(value:  false);
        }
        else
        {
                256.interactable = false;
        }
        
        }
        
        }
        
        bool val_7 = UnityEngine.Object.op_Equality(x:  this.AnimObjectOverride, y:  0);
        if(val_7 == false)
        {
            goto label_22;
        }
        
        GridCoinCollectAnimation val_8 = val_7.GetGridCoinCollectAnimationPrefab();
        UnityEngine.GameObject val_9 = val_7.gameObject;
        if(this.animParentXfm != 0)
        {
            goto label_26;
        }
        
        UnityEngine.Transform val_11 = this.animParentXfm.transform;
        val_20 = this;
        goto label_27;
        label_22:
        val_21 = this.AnimObjectOverride;
        val_22 = this.anim;
        this.anim = val_21;
        goto label_28;
        label_26:
        val_20 = this.animParentXfm;
        label_27:
        object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  val_7, parent:  val_20);
        this.animObject = val_7;
        object val_13 = val_7.GetComponent<System.Object>();
        val_22 = this;
        val_21 = val_7;
        this.anim = val_7;
        label_28:
        val_21.SetMaxCoins(coins:  this.maxCoins);
        System.Action<System.Boolean> val_14 = new System.Action<System.Boolean>(object:  -1757894464, method:  new IntPtr(2537023136));
        System.Delegate val_15 = System.Delegate.Combine(a:  val_7.OnCoinDepositSpecialAction, b:  7401472);
        val_23 = val_7.OnCoinDepositSpecialAction;
        if(val_23 != 0)
        {
                if(mem[val_7.OnCoinDepositSpecialAction] == null)
        {
            goto label_36;
        }
        
        }
        
        val_23 = 0;
        label_36:
        OnCoinDepositSpecialAction = val_23;
        UnityEngine.Transform val_16 = val_7.OnCoinDepositSpecialAction.transform;
        UnityEngine.Transform val_17 = val_7.OnCoinDepositSpecialAction.Find(n:  -1757943136);
        this.collectTarget = val_7.OnCoinDepositSpecialAction;
        if(val_7.OnCoinDepositSpecialAction == 0)
        {
                UnityEngine.Transform val_19 = this.transform;
            val_24 = this;
        }
        else
        {
                val_24 = this.collectTarget;
        }
        
        this.anim.collectTarget = val_24;
        this.anim.playerCoinAddedBalance = this.playerCoinAddedBalance;
        this.anim.whenToCount = this.whenToCount;
        GridCoinCollectAnimationInstantiator.AddToNotificationList(instance:  -1757894464);
    }
    private void OnDestroy()
    {
        GridCoinCollectAnimationInstantiator.RemoveFromNotificationList(instance:  -1757733312);
    }
    public static void AddToNotificationList(GridCoinCollectAnimationInstantiator instance)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(GridCoinCollectAnimationInstantiator.gridCoinCollectAnimInstances == 0)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_3 = null;
            val_3 = null;
            GridCoinCollectAnimationInstantiator.gridCoinCollectAnimInstances = null;
            val_2 = null;
        }
        
        val_2 = null;
        Add(item:  instance);
    }
    public static void RemoveFromNotificationList(GridCoinCollectAnimationInstantiator instance)
    {
        var val_2;
        System.Collections.Generic.List<GridCoinCollectAnimationInstantiator> val_3;
        val_2 = null;
        val_2 = null;
        val_3 = GridCoinCollectAnimationInstantiator.gridCoinCollectAnimInstances;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = GridCoinCollectAnimationInstantiator.gridCoinCollectAnimInstances;
        if(val_3 == 0)
        {
                val_3 = 0;
        }
        
        bool val_1 = val_3.Remove(item:  instance);
    }
    public void SetCoinStartPosition(UnityEngine.Vector3 pos)
    {
        UnityEngine.Transform val_1 = this.animObject.transform;
        this.animObject.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
    }
    public void Set(decimal instantValue)
    {
        this.Create();
        R5.Set(instantValue:  new System.Decimal() {flags = instantValue.flags, hi = instantValue.hi, lo = instantValue.lo, mid = instantValue.mid});
        this.SetActive(value:  true);
    }
    public void Play(decimal fromValue, decimal toValue, float textTickTime = -1, float delayBeforeComplete = -1)
    {
        float val_5;
        var val_11;
        int val_12;
        var val_13;
        System.Predicate<GridCoinCollectAnimationInstantiator> val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_11 = null;
        val_11 = null;
        val_12 = 1152921504903438336;
        val_13 = null;
        val_13 = null;
        val_15 = GridCoinCollectAnimationInstantiator.<>c.<>9__29_0;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Predicate<ZooTile>(object:  GridCoinCollectAnimationInstantiator.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2537797632));
            GridCoinCollectAnimationInstantiator.<>c.<>9__29_0 = val_15;
        }
        
        System.Collections.Generic.List<T> val_2 = GridCoinCollectAnimationInstantiator.gridCoinCollectAnimInstances.FindAll(match:  8040448);
        System.Collections.Generic.List<ZooTile> val_3 = new System.Collections.Generic.List<ZooTile>(collection:  GridCoinCollectAnimationInstantiator.gridCoinCollectAnimInstances);
        val_17 = null;
        val_17 = null;
        GridCoinCollectAnimationInstantiator.gridCoinCollectAnimInstances = null;
        if(1152921505700909039 < 0)
        {
                return;
        }
        
        val_12 = toValue.lo;
        do
        {
            val_18 = null;
            val_18 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.GameObject val_6 = mem[1152921505782185916].gameObject;
            val_19 = null;
            if(mem[1152921505782185916].activeInHierarchy != false)
        {
                val_20 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_21 = null;
            val_21 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            bool val_10 = (UnityEngine.Object.op_Equality(x:  mem[1152921505782185916], y:  -1757141568)) ^ 1;
            val_16 = mem[1152921505782185916];
            val_12 = val_12;
            val_16.PlayCoinCollectAnimation(fromValue:  new System.Decimal() {flags = fromValue.flags, hi = fromValue.hi, lo = fromValue.lo, mid = fromValue.mid}, toValue:  new System.Decimal() {flags = toValue.flags, hi = toValue.hi, lo = val_12, mid = toValue.mid}, textTickTime:  textTickTime, delayBeforeComplete:  delayBeforeComplete, doCoinTextTickerOnly:  val_5);
        }
        else
        {
                val_22 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_16 = mem[1152921505782185916];
            val_16.Set(instantValue:  new System.Decimal() {flags = toValue.flags, hi = toValue.hi, lo = val_12, mid = toValue.mid});
        }
        
        }
        while(1152921505700909038 > 1);
    
    }
    private void PlayCoinCollectAnimation(decimal fromValue, decimal toValue, float textTickTime = -1, float delayBeforeComplete = -1, bool doCoinTextTickerOnly = False)
    {
        var val_2;
        float val_3;
        float val_5;
        float val_6;
        float val_12;
        int val_18;
        int val_19;
        int val_20;
        float val_21;
        float val_22;
        var val_23;
        float val_24;
        DG.Tweening.TweenCallback val_25;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        val_18 = toValue.mid;
        val_19 = toValue.lo;
        val_20 = toValue.flags;
        typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_C = fromValue.flags;
        if(val_1 == 0)
        {
                val_19 = val_19;
            val_20 = val_20;
            val_18 = val_18;
        }
        
        typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_20 = toValue.hi;
        typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_24 = val_19;
        typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_28 = val_18;
        typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_1C = val_20;
        if(val_1 != 0)
        {
                typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_2C = doCoinTextTickerOnly;
            val_21 = 1152921504903491632;
            typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_30 = val_3;
            val_22 = 1152921504903491628;
        }
        else
        {
                val_22 = 6.165713E-44f;
            mem[44] = doCoinTextTickerOnly;
            val_21 = 6.726233E-44f;
            mem[48] = val_3;
        }
        
        typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_34 = val_2;
        val_2.SetActive(value:  true);
        if(val_2 != 0)
        {
                this.textTweenTime = val_22;
        }
        
        if(val_2 != 0)
        {
                this.delayBeforeAnimationConclusion = val_21;
        }
        
        this.Set(instantValue:  new System.Decimal() {flags = typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_C, hi = fromValue.hi, lo = fromValue.lo, mid = fromValue.mid});
        val_23 = 1152921504762331136;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.tweenPointBeforePlay, y = 6.165713E-44f}, rhs:  new UnityEngine.Vector2() {x = val_5, y = val_6})) != false)
        {
                UnityEngine.Transform val_8 = this.tweenPointBeforePlay.transform;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -6.387649E-25f, y = val_24});
            this.tweenPointBeforePlay.localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_10 = 0.transform;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -6.387639E-25f, y = val_12});
            DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  0, endValue:  new UnityEngine.Vector3(), duration:  val_14.x, snapping:  false);
            val_25 = null;
            val_25 = new DG.Tweening.TweenCallback(object:  296644608, method:  new IntPtr(2537913728));
            object val_17 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
            return;
        }
        
        val_24 = typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_1C;
        val_25 = typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_20;
        this.ContinueCoinCollectAnimation(fromValue:  new System.Decimal() {flags = typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_C, hi = fromValue.hi, lo = fromValue.lo, mid = fromValue.mid}, toValue:  new System.Decimal() {flags = val_24, hi = val_25, lo = typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_24, mid = typeof(GridCoinCollectAnimationInstantiator.<>c__DisplayClass30_0).__il2cppRuntimeField_28}, textTickTime:  val_4.x, delayBeforeComplete:  val_4.y, doCoinTextTickerOnly:  false);
    }
    private void ContinueCoinCollectAnimation(decimal fromValue, decimal toValue, float textTickTime = -1, float delayBeforeComplete = -1, bool doCoinTextTickerOnly = False)
    {
        var val_3;
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        int val_10;
        val_5 = fromValue.hi;
        val_5 = val_5;
        val_6 = fromValue.mid;
        val_7 = toValue.flags;
        val_5 = val_5;
        val_9 = toValue.lo;
        val_8 = val_8;
        decimal val_1 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1756920404, hi = val_7, lo = val_8, mid = val_9}, d2:  new System.Decimal() {flags = val_10, hi = fromValue.flags, lo = val_5, mid = fromValue.lo});
        this.firstCoinReached = false;
        if(val_3 != 0)
        {
                this.OnCoinReachedBank(textTickerOnly:  true);
            return;
        }
        
        val_10 = this.anim;
        this.anim.coinExpansionEnabled = this.coinExpansionEnabled;
        val_6 = this.maxCoins;
        this.anim.Play(coinsCount:  UnityEngine.Mathf.Min(a:  val_6, b:  System.Decimal.op_Explicit(value:  new System.Decimal())));
    }
    private void OnEnable()
    {
        this.Create();
    }
    private void OnDisable()
    {
        if(R1 == 0)
        {
                return;
        }
        
        this.anim.Reset();
    }
    public void OnCoinReachedBank(bool textTickerOnly = False)
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        if(this.firstCoinReached != false)
        {
                return;
        }
        
        this.firstCoinReached = true;
        if(R6 == 0)
        {
                val_4 = mem[this.startValue + (16)];
            val_3 = mem[this.startValue + (12)];
            val_7 = mem[this.startValue + (8)];
            val_6 = mem[this.startValue + (4)];
            val_5 = mem[this.startValue + (0)];
        }
        
        R6.Tween(startValue:  new System.Decimal() {flags = val_5, hi = val_6, lo = val_7, mid = val_3}, endValue:  new System.Decimal() {flags = val_4, hi = ???, lo = ???, mid = ???}, seconds:  null);
        System.Collections.IEnumerator val_1 = this.ConcludeAnimationDelay(textTickerOnly:  textTickerOnly);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1756555968);
    }
    private System.Collections.IEnumerator ConcludeAnimationDelay(bool textTickerOnly = False)
    {
        typeof(GridCoinCollectAnimationInstantiator.<ConcludeAnimationDelay>d__35).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(GridCoinCollectAnimationInstantiator.<ConcludeAnimationDelay>d__35).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(GridCoinCollectAnimationInstantiator.<ConcludeAnimationDelay>d__35).__il2cppRuntimeField_14 = textTickerOnly;
    }
    private void ConcludeAnimation(bool textTickerOnly = False)
    {
        float val_2;
        float val_3;
        DG.Tweening.TweenCallback val_10;
        var val_11;
        var val_12;
        val_10 = 35641566;
        if((this.OnCompleteCallback != 0) && (textTickerOnly != true))
        {
                this.OnCompleteCallback.Invoke();
        }
        
        if(this.disableWhenComplete != false)
        {
                val_11 = this;
            val_12 = 0;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            val_10 = UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.tweenPointBeforePlay, y = 1.174371E-37f}, rhs:  new UnityEngine.Vector2() {x = val_2, y = val_3});
            if(val_10 != false)
        {
                val_12 = 0;
            UnityEngine.Transform val_5 = this.tweenPointBeforePlay.transform;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -6.733616E-25f, y = this.tweenPointBeforePlay});
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.tweenPointBeforePlay, endValue:  new UnityEngine.Vector3(), duration:  val_6.x, snapping:  false);
            val_10 = null;
            val_10 = new DG.Tweening.TweenCallback(object:  -1756326848, method:  new IntPtr(2538615424));
            object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.tweenPointBeforePlay, action:  190734336);
        }
        else
        {
                this.tweenPointBeforePlay.SetActive(value:  false);
        }
        
        }
        
        CurrencyController.HandleBalanceChanged(type:  0);
    }
    protected override UnityEngine.GameObject GetPrefabFromTheme()
    {
        if(this.StatViewObjectOverride != 0)
        {
                return;
        }
        
        ThemesHandler val_2 = App.ThemesHandler;
        if(0 != 0)
        {
                ThemesHandler val_4 = App.ThemesHandler;
            bool val_5 = UnityEngine.Object.op_Inequality(x:  2621443, y:  0);
            if(val_5 != false)
        {
                if(val_5 != true)
        {
                ThemesHandler val_6 = App.ThemesHandler;
            UnityEngine.GameObject val_7 = 2621443.StatViewPrefab;
            if(2621443 != 0)
        {
                ThemesHandler val_9 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.StatViewPrefab;
        }
        
            return 2621443.StatViewPrefab;
        }
        
        }
        
            ThemesHandler val_10 = App.ThemesHandler;
            UnityEngine.GameObject val_11 = 2621443.StatViewPrefab_anchored;
            if(2621443 != 0)
        {
                ThemesHandler val_13 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.StatViewPrefab_anchored;
        }
        
            return 2621443.StatViewPrefab_anchored;
        }
        
        }
        
        }
        
        GameSpecificUI val_14 = GameSpecificUI.currentGame;
        if(0 != 0)
        {
                return;
        }
    
    }
    private GridCoinCollectAnimation GetGridCoinCollectAnimationPrefab()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(0 != 0)
        {
                ThemesHandler val_3 = App.ThemesHandler;
            if(2621443 != 0)
        {
                ThemesHandler val_5 = App.ThemesHandler;
            GridCoinCollectAnimation val_6 = 2621443.GridCoinCollectAnimation;
            if(2621443 != 0)
        {
                ThemesHandler val_8 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.GridCoinCollectAnimation;
        }
        
            return 2621443.GridCoinCollectAnimation;
        }
        
        }
        
        }
        
        GameSpecificUI val_9 = GameSpecificUI.currentGame;
        if(0 != 0)
        {
                return;
        }
    
    }
    public void EnableCoinExpansion(bool enable)
    {
        this.coinExpansionEnabled = enable;
    }
    protected override void OverrideStatViewPostion(UnityEngine.RectTransform rectTransform)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public GridCoinCollectAnimationInstantiator()
    {
        UnityEngine.Vector2 val_2;
        var val_3;
        this.maxCoins = 10;
        this.textTweenTime = 2f;
        this.delayBeforeAnimationConclusion = 0.25f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.tweenPointBeforePlay = val_2;
        mem[1152921511441043488] = val_3;
        decimal val_4 = new System.Decimal(value:  -999);
         = new System.Decimal(value:  999);
        this.coinExpansionEnabled = true;
    }
    private static GridCoinCollectAnimationInstantiator()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        GridCoinCollectAnimationInstantiator.gridCoinCollectAnimInstances = null;
    }
    private void <ConcludeAnimation>b__36_0()
    {
        R4.SetActive(value:  false);
    }

}
