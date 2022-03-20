using UnityEngine;
public class DailyChallengeZooTileAreaUI : MonoBehaviour
{
    // Fields
    private const int PREV = -1;
    private const int NEXT = 1;
    private UnityEngine.UI.Text month;
    private UnityEngine.UI.Text currentMonthStars;
    private WGDailyChallengeZooTile monthTile;
    private UnityEngine.UI.Text lifetimeStars;
    private WGDailyChallengeZooTile lifetimeTile;
    private UnityEngine.GameObject tilesGallery;
    private UnityEngine.Transform zooTilesParent;
    private UnityEngine.GameObject arrowsGroup;
    private UnityEngine.UI.Button leftArrowBtn;
    private UnityEngine.UI.Button rightArrowBtn;
    private WGDailyChallengeFunFact funFact;
    private int currentStartNavigationIndex;
    
    // Methods
    private void Awake()
    {
        this.tilesGallery.SetActive(value:  false);
        UnityEngine.GameObject val_1 = this.funFact.gameObject;
        this.funFact.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1454866208, method:  new IntPtr(2840066848));
        this.leftArrowBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1454866208, method:  new IntPtr(2840076064));
        this.rightArrowBtn.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        var val_3;
        System.Globalization.DateTimeFormatInfo val_1 = new System.Globalization.DateTimeFormatInfo();
        System.DateTime val_2 = DateTimeCheat.Now;
        string val_6 = GetMonthName(month:  val_3.Month);
        string val_7 = ToLower();
        string val_8 = Localization.Localize(key:  35729408, defaultValue:  35729408, useSingularKey:  false);
        string val_9 = ToUpper();
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_11 = System.Decimal.op_Implicit(value:  -1454729416);
        decimal val_12 = new System.Decimal(value:  1000);
        string val_13 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  false, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid}, useRichText:  false, withSpaces:  false);
        Player val_14 = App.Player;
        decimal val_15 = System.Decimal.op_Implicit(value:  -1454729448);
        decimal val_16 = new System.Decimal(value:  1000);
        string val_17 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  false, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_16.flags, hi = val_16.hi, lo = val_16.lo, mid = val_16.flags}, useRichText:  false, withSpaces:  false);
        System.Collections.IEnumerator val_18 = this.WaitSetup();
        UnityEngine.Coroutine val_19 = this.StartCoroutine(routine:  -1454717344);
    }
    public void HideFunFactPopup()
    {
        this.funFact.HideFunFact();
    }
    private System.Collections.IEnumerator WaitSetup()
    {
        object val_1 = new System.Object();
        typeof(DailyChallengeZooTileAreaUI.<WaitSetup>d__17).__il2cppRuntimeField_8 = 0;
        typeof(DailyChallengeZooTileAreaUI.<WaitSetup>d__17).__il2cppRuntimeField_10 = this;
    }
    private void SetupZooTiles()
    {
        var val_10;
        ZooTile val_11;
        var val_12;
        WGDailyChallengeZooTile val_13;
        object val_1 = new System.Object();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(val_1 != 0)
        {
                val_10 = val_1;
            typeof(DailyChallengeZooTileAreaUI.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        }
        else
        {
                val_10 = 8;
            mem[8] = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        }
        
        if((-2116505760) == 0)
        {
                return;
        }
        
        string val_4 = GetMonthTileName();
        mem2[0] = mem[8];
        val_11 = 0;
        if((System.String.IsNullOrEmpty(value:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_30 + 12)) != true)
        {
                val_12 = null;
            val_12 = null;
            System.Predicate<ZooTile> val_6 = new System.Predicate<ZooTile>(object:  313470976, method:  new IntPtr(2840586528));
            ZooTile val_7 = ZooTilePool.MonthlyZooTiles.Find(match:  8040448);
            val_11 = ZooTilePool.MonthlyZooTiles;
        }
        
        this.monthTile.tile = val_11;
        val_13 = this.lifetimeTile;
        ZooTile val_8 = GetNextLifetimeTile();
        this.lifetimeTile.tile = mem[8];
        if(this.monthTile.tile != 0)
        {
                val_13 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 8];
            val_13 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 8;
            this.monthTile.tile.requiredStars = val_13;
        }
        
        this.monthTile.Setup(lockCompValue:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_30 + 8, isMonthTileInCollection:  false);
        Player val_9 = App.Player;
        this.lifetimeTile.Setup(lockCompValue:  2165608, isMonthTileInCollection:  false);
        this.UpdateZooTiles(cmd:  0);
    }
    private void UpdateZooTiles(int cmd = 0)
    {
        var val_18;
        float val_19;
        UnityEngine.Transform val_20;
        var val_21;
        var val_22;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<ZooTile> val_2 = ZooTileCollection;
        int val_5 = UnityEngine.Mathf.Clamp(value:  this.currentStartNavigationIndex + cmd, min:  0, max:  (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_C - 4));
        this.currentStartNavigationIndex = val_5;
        if(val_5 != 0)
        {
                val_5 = 1;
        }
        
        this.leftArrowBtn.interactable = true;
        this.rightArrowBtn.interactable = true;
        val_18 = 0;
        val_19 = 1152921504920371200;
        goto label_13;
        label_32:
        object val_8 = null;
        val_20 = val_8;
        val_8 = new System.Object();
        UnityEngine.Transform val_9 = this.zooTilesParent.GetChild(index:  0);
        object val_10 = this.zooTilesParent.GetComponent<System.Object>();
        if(val_20 != 0)
        {
                val_21 = val_20;
            typeof(DailyChallengeZooTileAreaUI.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = this.zooTilesParent;
        }
        else
        {
                val_21 = 8;
            mem[8] = this.zooTilesParent;
        }
        
        int val_12 = val_18 + this.currentStartNavigationIndex;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        mem2[0] = (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_8 + ((val_18 + this.currentStartNavigationIndex)) << 2) + 16;
        val_22 = null;
        val_22 = null;
        System.Predicate<ZooTile> val_14 = new System.Predicate<ZooTile>(object:  313524224, method:  new IntPtr(2840780448));
        ZooTile val_15 = ZooTilePool.MonthlyZooTiles.Find(match:  8040448);
        val_20 = mem[8];
        Player val_16 = App.Player;
        val_19 = 1152921504920371200;
        if(ZooTilePool.MonthlyZooTiles != 0)
        {
                ZooTilePool.MonthlyZooTiles = 1;
        }
        
        val_20.Setup(lockCompValue:  2165608, isMonthTileInCollection:  true);
        val_18 = 1;
        label_13:
        if(val_18 < this.zooTilesParent.childCount)
        {
            goto label_32;
        }
        
        this.tilesGallery.SetActive(value:  true);
    }
    public DailyChallengeZooTileAreaUI()
    {
    
    }
    private void <Awake>b__14_0()
    {
        this.UpdateZooTiles(cmd:  0);
    }
    private void <Awake>b__14_1()
    {
        this.UpdateZooTiles(cmd:  1);
    }

}
