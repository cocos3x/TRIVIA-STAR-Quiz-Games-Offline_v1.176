using UnityEngine;
public class WGBuyAVowelEventPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private WGBuyAVowelEventVowelButton aButton;
    private WGBuyAVowelEventVowelButton eButton;
    private WGBuyAVowelEventVowelButton iButton;
    private WGBuyAVowelEventVowelButton oButton;
    private WGBuyAVowelEventVowelButton uButton;
    private System.Collections.Generic.List<System.Tuple<LineWord, Cell>> aS;
    private System.Collections.Generic.List<System.Tuple<LineWord, Cell>> eS;
    private System.Collections.Generic.List<System.Tuple<LineWord, Cell>> iS;
    private System.Collections.Generic.List<System.Tuple<LineWord, Cell>> oS;
    private System.Collections.Generic.List<System.Tuple<LineWord, Cell>> uS;
    
    // Methods
    private void Start()
    {
        System.Threading.SendOrPostCallback val_24;
        object val_27;
        float val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        System.Func<LineWord, System.Boolean> val_44;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1513202112, method:  new IntPtr(2781734800));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        Interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_5 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_6 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_6.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_38 = public System.Void System.Nullable<UnityEngine.Color>::.ctor(UnityEngine.Color value);
        UnityEngine.GameObject val_10 = gameObject;
        UnityEngine.Transform val_11 = transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = val_38;
        val_39 = 1152921504886931456;
        WordRegion val_12 = WordRegion.instance;
        UnityEngine.Transform val_13 = 0.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = 0;
        MainController val_14 = MainController.instance;
        val_40 = 0;
        UnityEngine.Transform val_15 = val_40.transform;
        val_41 = val_40;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_18 = val_41;
        ShowOverlay(contentToOverlay:  -2028557104);
        WordRegion val_16 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_18 = WordRegion.instance;
        val_42 = null;
        val_42 = null;
        val_44 = WGBuyAVowelEventPopup.<>c.<>9__11_0;
        if(val_44 == 0)
        {
                val_44 = null;
            val_44 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGBuyAVowelEventPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2781735824));
            WGBuyAVowelEventPopup.<>c.<>9__11_0 = val_44;
        }
        
        val_39 = val_38;
        System.Collections.Generic.IEnumerable<TSource> val_20 = System.Linq.Enumerable.Where<System.Object>(source:  0, predicate:  7720960);
        System.Collections.Generic.List<TSource> val_21 = System.Linq.Enumerable.ToList<System.Object>(source:  0);
        List.Enumerator<T> val_22 = val_6.HasValue.GetEnumerator();
        val_41 = 0;
        val_38 = 1152921511116727136;
        label_67:
        if(MoveNext() == false)
        {
            goto label_39;
        }
        
        List.Enumerator<T> val_25 = val_6.HasValue.GetEnumerator();
        label_64:
        if(MoveNext() == false)
        {
            goto label_42;
        }
        
        if((val_27 + 36) != 0)
        {
            goto label_64;
        }
        
        if((val_27 + 32.Equals(value:  -1930531024)) == false)
        {
            goto label_46;
        }
        
        System.Tuple<System.Threading.SendOrPostCallback, System.Object> val_29 = new System.Tuple<System.Threading.SendOrPostCallback, System.Object>(item1:  val_24, item2:  val_27);
        public System.Void System.Nullable<UnityEngine.Color>::.ctor(UnityEngine.Color value).__il2cppRuntimeField_24.Add(item:  6656000);
        goto label_64;
        label_46:
        if((val_27 + 32.Equals(value:  -1513226352)) == false)
        {
            goto label_50;
        }
        
        System.Tuple<System.Threading.SendOrPostCallback, System.Object> val_31 = new System.Tuple<System.Threading.SendOrPostCallback, System.Object>(item1:  val_24, item2:  val_27);
        public System.Void System.Nullable<UnityEngine.Color>::.ctor(UnityEngine.Color value).__il2cppRuntimeField_28.Add(item:  6656000);
        goto label_64;
        label_50:
        if((val_27 + 32.Equals(value:  -1706786096)) == false)
        {
            goto label_54;
        }
        
        System.Tuple<System.Threading.SendOrPostCallback, System.Object> val_33 = new System.Tuple<System.Threading.SendOrPostCallback, System.Object>(item1:  val_24, item2:  val_27);
        public System.Void System.Nullable<UnityEngine.Color>::.ctor(UnityEngine.Color value).__il2cppRuntimeField_2C.Add(item:  6656000);
        goto label_64;
        label_54:
        if((val_27 + 32.Equals(value:  -1513226272)) == false)
        {
            goto label_58;
        }
        
        System.Tuple<System.Threading.SendOrPostCallback, System.Object> val_35 = new System.Tuple<System.Threading.SendOrPostCallback, System.Object>(item1:  val_24, item2:  val_27);
        public System.Void System.Nullable<UnityEngine.Color>::.ctor(UnityEngine.Color value).__il2cppRuntimeField_30.Add(item:  6656000);
        goto label_64;
        label_58:
        if((val_27 + 32.Equals(value:  -1513226192)) == false)
        {
            goto label_64;
        }
        
        System.Tuple<System.Threading.SendOrPostCallback, System.Object> val_37 = new System.Tuple<System.Threading.SendOrPostCallback, System.Object>(item1:  val_24, item2:  val_27);
        public System.Void System.Nullable<UnityEngine.Color>::.ctor(UnityEngine.Color value).__il2cppRuntimeField_34.Add(item:  6656000);
        goto label_64;
        label_42:
        var val_38 = val_41 + 1;
        mem2[0] = 514;
        Dispose();
        if(val_38 == 1)
        {
            goto label_67;
        }
        
        if((-1513214256 + ((val_41 + 1)) << 2) == 514)
        {
                -1513214256 + ((val_41 + 1)) << 2 = val_38 >> 31;
            -1513214256 + ((val_41 + 1)) << 2 = ~(val_38 >> 31);
            val_38 = val_38 + (-1513214256 + ((val_41 + 1)) << 2);
        }
        
        goto label_67;
        label_39:
        Dispose();
        SetupButtons();
    }
    private System.Collections.IEnumerator AutoClose()
    {
        object val_1 = new System.Object();
        typeof(WGBuyAVowelEventPopup.<AutoClose>d__12).__il2cppRuntimeField_8 = 0;
        typeof(WGBuyAVowelEventPopup.<AutoClose>d__12).__il2cppRuntimeField_10 = this;
    }
    private void SetupButtons()
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        int val_9;
        int val_10;
        int val_11;
        int val_12;
        int val_15;
        int val_16;
        int val_17;
        int val_18;
        int val_21;
        int val_22;
        int val_23;
        int val_24;
        int val_27;
        int val_28;
        int val_29;
        int val_30;
        decimal val_1 = GetCostForVowel(vowel:  null, cells:  -1930531024);
        this.aButton.Setup(letter:  -1930531024, cost:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_3}, callback:  new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1512907456, method:  new IntPtr(2781981568)));
        decimal val_7 = GetCostForVowel(vowel:  -1930531024, cells:  -1513226352);
        this.eButton.Setup(letter:  -1513226352, cost:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_12, mid = val_9}, callback:  new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1512907456, method:  new IntPtr(2781981568)));
        decimal val_13 = GetCostForVowel(vowel:  -1513226352, cells:  -1706786096);
        this.iButton.Setup(letter:  -1706786096, cost:  new System.Decimal() {flags = val_16, hi = val_17, lo = val_18, mid = val_15}, callback:  new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1512907456, method:  new IntPtr(2781981568)));
        decimal val_19 = GetCostForVowel(vowel:  -1706786096, cells:  -1513226272);
        this.oButton.Setup(letter:  -1513226272, cost:  new System.Decimal() {flags = val_22, hi = val_23, lo = val_24, mid = val_21}, callback:  new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1512907456, method:  new IntPtr(2781981568)));
        decimal val_25 = GetCostForVowel(vowel:  -1513226272, cells:  -1513226192);
        this.uButton.Setup(letter:  -1513226192, cost:  new System.Decimal() {flags = val_28, hi = val_29, lo = val_30, mid = val_27}, callback:  new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1512907456, method:  new IntPtr(2781981568)));
        if(this.uButton != 0)
        {
                return;
        }
        
        if(this.uButton != 0)
        {
                return;
        }
        
        if(this.uButton != 0)
        {
                return;
        }
        
        if(this.uButton != 0)
        {
                return;
        }
        
        if(this.uButton != 0)
        {
                return;
        }
        
        System.Collections.IEnumerator val_31 = this.AutoClose();
        UnityEngine.Coroutine val_32 = this.StartCoroutine(routine:  -1512907456);
    }
    private decimal GetCostForVowel(string vowel, System.Collections.Generic.List<System.Tuple<LineWord, Cell>> cells)
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        var val_15;
        object val_1 = new System.Object();
        var val_15 = 28935302;
        typeof(WGBuyAVowelEventPopup.<>c__DisplayClass14_0).__il2cppRuntimeField_8 = cells;
        val_15 = 6691820 + val_15;
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        decimal val_2 = GetVowelPrice;
        val_15 = "";
        if(CategoryPacksManager.IsPlaying != false)
        {
                GameLevel val_8 = PlayingLevel.GetCategoryLevel(categoryPackId:  0);
            val_15 = 1835037;
        }
        
        GameLevel val_9 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        if(0 != 0)
        {
                GameLevel val_10 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
            val_15 = 1835037;
        }
        
        System.Func<System.Char, System.Boolean> val_11 = new System.Func<System.Char, System.Boolean>(object:  310595584, method:  new IntPtr(2782217472));
        int val_12 = System.Linq.Enumerable.Count<System.Char>(source:  1835037, predicate:  7720960);
        if((R3 + 12) == 0)
        {
                val_4 = R3 + 12;
            val_5 = R3 + 12;
        }
        
        if((R3 + 12) == 0)
        {
                val_3 = R3 + 12;
        }
        
        if((R3 + 12) == 0)
        {
                val_6 = R3 + 12;
        }
        
        decimal val_13 = System.Decimal.op_Implicit(value:  -1512734804);
        decimal val_14 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1512722752, hi = val_4, lo = val_3, mid = val_5}, d2:  new System.Decimal() {flags = val_6});
        return new System.Decimal() {flags = val_14.flags, hi = val_14.hi, lo = val_14.lo, mid = val_14.mid};
    }
    private void OnVowelClicked(string vowel)
    {
        int val_12;
        int val_13;
        int val_14;
        int val_15;
        int val_17;
        int val_18;
        int val_19;
        int val_20;
        var val_27;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_33;
        var val_34;
        WGBuyAVowelEventVowelButton val_35;
        var val_36;
        int val_37;
        int val_38;
        int val_39;
        var val_40;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_41;
        var val_42;
        var val_43;
        var val_44;
        System.Action val_46;
        val_33 = null;
        val_33 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.Transform val_3 = this.transform;
        val_34 = this;
        if((System.String.op_Equality(a:  vowel, b:  -1930531024)) == false)
        {
            goto label_2;
        }
        
        val_35 = this.aButton;
        val_33 = this.aS;
        goto label_9;
        label_2:
        if((System.String.op_Equality(a:  vowel, b:  -1513226352)) == false)
        {
            goto label_4;
        }
        
        val_35 = this.eButton;
        val_33 = this.eS;
        goto label_9;
        label_4:
        if((System.String.op_Equality(a:  vowel, b:  -1706786096)) == false)
        {
            goto label_6;
        }
        
        val_35 = this.iButton;
        val_33 = this.iS;
        goto label_9;
        label_6:
        if((System.String.op_Equality(a:  vowel, b:  -1513226272)) == false)
        {
            goto label_8;
        }
        
        val_35 = this.oButton;
        val_33 = this.oS;
        goto label_9;
        label_8:
        val_36 = "U";
        if((System.String.op_Equality(a:  vowel, b:  -1513226192)) == false)
        {
            goto label_10;
        }
        
        val_35 = this.uButton;
        val_33 = this.uS;
        label_9:
        UnityEngine.GameObject val_9 = val_35.gameObject;
        val_36 = 0;
        UnityEngine.Transform val_10 = val_35.transform;
        val_34 = val_35;
        label_10:
        decimal val_11 = GetCostForVowel(vowel:  null, cells:  vowel);
        val_37 = val_13;
        val_38 = val_15;
        decimal val_16 = CurrencyController.GetBalance();
        val_39 = val_17;
        val_40 = null;
        val_40 = null;
        val_41 = 0;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_12, hi = val_37, lo = val_14, mid = val_38}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_15;
        }
        
        val_41 = 0;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_18, hi = val_39, lo = val_19, mid = val_20}, d2:  new System.Decimal() {flags = val_12, hi = val_37, lo = val_14, mid = val_38})) == false)
        {
            goto label_18;
        }
        
        string val_23 = System.String.Format(format:  -1512580480, arg0:  vowel);
        bool val_24 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_12, hi = val_37, lo = val_14, mid = val_38}, source:  "Vowel - {0}", externalParams:  val_41, animated:  true);
        label_15:
        List.Enumerator<T> val_25 = GetEnumerator();
        val_39 = 1152921511684202208;
        val_38 = 1152921504886931456;
        label_26:
        if(MoveNext() == false)
        {
            goto label_20;
        }
        
        WordRegion val_28 = WordRegion.instance;
        if(val_27 != 0)
        {
                val_42 = mem[val_27 + 8];
            val_42 = val_27 + 8;
        }
        else
        {
                val_42 = 0;
        }
        
        if(0 != 0)
        {
            goto label_26;
        }
        
        goto label_26;
        label_20:
        Dispose();
        var val_33 = 28932526;
        val_37 = val_33;
        val_33 = 6694596 + val_33;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_29 = Player.GetLevelForTracking();
        BuyAVowelEventHandler.<Instance>k__BackingField.TrackBuyVowelOnLevel(level:  null);
        val_37.Clear();
        this.SetupButtons();
        return;
        label_18:
        var val_34 = 28931237;
        val_34 = 6694824 + val_34;
        if(val_34 == 0)
        {
                mem2[0] = 1;
        }
        
        val_43 = null;
        val_43 = null;
        PurchaseProxy.currentPurchasePoint = 100;
        twelvegigs.Autopilot.AutopilotManager val_30 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_31 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_41 = 1152921504917336064;
        val_44 = null;
        val_44 = null;
        val_46 = WGBuyAVowelEventPopup.<>c.<>9__15_0;
        if(val_46 == 0)
        {
                val_46 = null;
            val_46 = new System.Action(object:  WGBuyAVowelEventPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2782391008));
            WGBuyAVowelEventPopup.<>c.<>9__15_0 = val_46;
        }
        
        Init(outOfCredits:  true, onCloseAction:  7454720);
        this.Close();
    }
    private void Close()
    {
        System.Collections.IEnumerator val_1 = this.AutoClose();
        this.StopCoroutine(routine:  -1512394208);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1512394208, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGBuyAVowelEventPopup()
    {
        this.aS = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.eS = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.iS = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.oS = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.uS = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }

}
