using UnityEngine;
public class AwardController : MonoSingleton<AwardController>
{
    // Fields
    private Award current_award;
    
    // Methods
    public override void InitMonoSingleton()
    {
        bool val_1 = this.FetchAwards();
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        if(pauseStatus == true)
        {
                return;
        }
        
        bool val_1 = this.FetchAwards();
    }
    public void HandleUpdateFromServer()
    {
        bool val_1 = this.FetchAwards();
    }
    private bool FetchAwards()
    {
        string val_10;
        var val_11;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            goto label_5;
        }
        
        val_10 = 1152921504898113536;
        System.Collections.Generic.List<Award> val_2 = ServerHandler.Awards;
        if(0 < 1)
        {
            goto label_9;
        }
        
        System.Collections.Generic.List<Award> val_3 = ServerHandler.Awards;
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = 0;
        var val_4 = 0 + 16;
        val_10 = D16;
        mem[1152921511369047868] = 35615780;
        mem[1152921511369047872] = 83886592;
        mem[1152921511369047876] = 2097204;
        if((System.String.op_Equality(a:  val_10, b:  2129282688)) == false)
        {
            goto label_14;
        }
        
        this.ShowCoinAward();
        return (bool)val_11;
        label_5:
        val_11 = 0;
        return (bool)val_11;
        label_9:
        val_11 = 1;
        return (bool)val_11;
        label_14:
        val_11 = 0;
        if((System.String.op_Equality(a:  val_10, b:  -1930648496)) != false)
        {
                this.ShowGemsAward();
            return (bool)val_11;
        }
        
        val_11 = 0;
        if((System.String.op_Equality(a:  val_10, b:  -1953369568)) != false)
        {
                this.ShowNoAdsAward();
            return (bool)val_11;
        }
        
        val_11 = 0;
        if((System.String.op_Equality(a:  val_10, b:  -1988561632)) != false)
        {
                this.ShowLevelAward();
            return (bool)val_11;
        }
        
        val_11 = 0;
        if((System.String.op_Equality(a:  val_10, b:  -1827757920)) != false)
        {
                this.ShowNewNameAward();
            return (bool)val_11;
        }
        
        if((System.String.op_Equality(a:  val_10, b:  -1827757824)) == false)
        {
                return (bool)val_11;
        }
        
        this.ShowPetsAward();
        return (bool)val_11;
    }
    private Award GenerateAwardFromPair(ConsumableAmountPair cap)
    {
        string val_2;
        var val_14;
        System.DateTime val_1 = System.DateTime.Now;
        if(R2 != 0)
        {
                val_14 = mem[R2 + 8];
            val_14 = R2 + 8;
        }
        else
        {
                val_14 = 0;
        }
        
        var val_4 = R2 + 12;
        int val_5 = val_2.Year;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        string val_7 = val_2.Month.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        string val_9 = val_2.Day.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        int val_10 = val_2.Millisecond;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        int val_11 = UnityEngine.Random.Range(min:  0, max:  999999999);
        string val_12 = val_11.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_20 = ;
        string val_13 = System.String.Format(format:  -1827641552, args:  472754880);
        mem[1152921511369164152] = 0;
        return new Award() {id = -1827641552, kind = -1827617432, amount = new System.Decimal() {mid = val_11}, text = val_2};
    }
    public void AddAwards(System.Collections.Generic.List<ConsumableAmountPair> awards)
    {
        List.Enumerator<T> val_1 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        Award val_5 = GenerateAwardFromPair(cap:  DefaultHandler<T>.__il2cppRuntimeField_cctor_finished);
        AddAward(award:  new Award() {amount = new System.Decimal()});
        goto label_6;
        label_2:
        Dispose();
        bool val_6 = this.FetchAwards();
    }
    private void ShowCoinAward()
    {
        decimal val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1827402080, defaultValue:  -1827401984, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1827401904, defaultValue:  -1827401792, useSingularKey:  false);
        val_12 = 1152921511369405236;
        GameEcon val_5 = App.getGameEcon;
        string val_6 = ToString(format:  null);
        string val_7 = System.String.Format(format:  -1827401904, arg0:  -1827376332);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_8 = Localization.Localize(key:  -1827401648, defaultValue:  -1827401552, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "collect_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "OK";
        GameBehavior val_9 = App.getBehavior;
        if(0 != 0)
        {
                val_13 = 1152921511369405248;
            val_14 = 1152921511369405244;
            val_15 = 1152921511369405240;
            val_16 = this;
        }
        else
        {
                val_17 = null;
            val_16 = this;
            val_13 = 1152921504617021488;
            val_14 = 1152921504617021484;
            val_15 = 1152921504617021480;
            val_12 = 1152921504617021476;
        }
        
        System.Func<System.Boolean> val_10 = new System.Func<System.Boolean>(object:  -1827376352, method:  new IntPtr(2467565920));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        System.Func<System.Boolean> val_11 = new System.Func<System.Boolean>(object:  -1827376352, method:  new IntPtr(2467565920));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = null;
        0.SetupMessage(titleTxt:  -1827402080, messageTxt:  -1827401904, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = val_12, hi = mem[1152921504617021480], lo = mem[1152921504617021484], mid = mem[1152921504617021488]}, collectType:  "credits");
    }
    private void ShowGemsAward()
    {
        decimal val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1827402080, defaultValue:  -1827401984, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1827288352, defaultValue:  -1827288224, useSingularKey:  false);
        val_12 = 1152921511369517508;
        GameEcon val_5 = App.getGameEcon;
        string val_6 = ToString(format:  null);
        string val_7 = System.String.Format(format:  -1827288352, arg0:  -1827264060);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_8 = Localization.Localize(key:  -1827401648, defaultValue:  -1827401552, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "collect_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "OK";
        GameBehavior val_9 = App.getBehavior;
        if(0 != 0)
        {
                val_13 = 1152921511369517520;
            val_14 = 1152921511369517516;
            val_15 = 1152921511369517512;
            val_16 = this;
        }
        else
        {
                val_17 = null;
            val_16 = this;
            val_13 = 1152921504617021488;
            val_14 = 1152921504617021484;
            val_15 = 1152921504617021480;
            val_12 = 1152921504617021476;
        }
        
        System.Func<System.Boolean> val_10 = new System.Func<System.Boolean>(object:  -1827264080, method:  new IntPtr(2467565920));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        System.Func<System.Boolean> val_11 = new System.Func<System.Boolean>(object:  -1827264080, method:  new IntPtr(2467565920));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = null;
        0.SetupMessage(titleTxt:  -1827402080, messageTxt:  -1827288352, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = val_12, hi = mem[1152921504617021480], lo = mem[1152921504617021484], mid = mem[1152921504617021488]}, collectType:  "gems");
    }
    private void ShowNoAdsAward()
    {
        var val_8;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1827176080, defaultValue:  -1827175968, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1827175872, defaultValue:  -1827175744, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "OK";
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = new System.Func<System.Boolean>(object:  -1827151456, method:  new IntPtr(2467565920));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = new System.Func<System.Boolean>(object:  -1827151456, method:  new IntPtr(2467565920));
        val_8 = null;
        val_8 = null;
        0.SetupMessage(titleTxt:  -1827176080, messageTxt:  -1827175872, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void ShowLevelAward()
    {
        var val_8;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1827063456, defaultValue:  -1827063344, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1827063248, defaultValue:  -1827063136, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "OK";
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = new System.Func<System.Boolean>(object:  -1827037968, method:  new IntPtr(2467904304));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = new System.Func<System.Boolean>(object:  -1827037968, method:  new IntPtr(2467904304));
        val_8 = null;
        val_8 = null;
        0.SetupMessage(titleTxt:  -1827063456, messageTxt:  -1827063248, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void ShowNewNameAward()
    {
        var val_9;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1826949968, defaultValue:  -1826949856, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1826949760, defaultValue:  -1826949648, useSingularKey:  false);
        string val_5 = System.String.Format(format:  -1826949520, arg0:  -1826949760, arg1:  mem[1152921511369856180]);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_6 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "OK";
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = new System.Func<System.Boolean>(object:  -1826925424, method:  new IntPtr(2467565920));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = new System.Func<System.Boolean>(object:  -1826925424, method:  new IntPtr(2467565920));
        val_9 = null;
        val_9 = null;
        0.SetupMessage(titleTxt:  -1826949968, messageTxt:  -1826949520, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void ShowPetsAward()
    {
        decimal val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1827402080, defaultValue:  -1827401984, useSingularKey:  false);
        string val_4 = System.String.Format(format:  -1826837424, arg0:  -1827401984);
        string val_5 = Localization.Localize(key:  -1826837424, defaultValue:  -1826837296, useSingularKey:  false);
        val_13 = 1152921511369968452;
        GameEcon val_6 = App.getGameEcon;
        string val_7 = ToString(format:  null);
        string val_8 = System.String.Format(format:  -1826837424, arg0:  -1826813116);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_9 = Localization.Localize(key:  -1827401648, defaultValue:  -1827401552, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "collect_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "OK";
        GameBehavior val_10 = App.getBehavior;
        if(0 != 0)
        {
                val_14 = 1152921511369968464;
            val_15 = 1152921511369968460;
            val_16 = 1152921511369968456;
        }
        else
        {
                val_17 = null;
            val_17 = null;
            val_14 = 1152921504617021488;
            val_15 = 1152921504617021484;
            val_16 = 1152921504617021480;
            val_13 = 1152921504617021476;
        }
        
        System.Func<System.Boolean> val_11 = new System.Func<System.Boolean>(object:  -1826813136, method:  new IntPtr(2467565920));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        System.Func<System.Boolean> val_12 = new System.Func<System.Boolean>(object:  -1826813136, method:  new IntPtr(2467565920));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_14 = null;
        0.SetupMessage(titleTxt:  -1827402080, messageTxt:  -1826837424, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = val_13, hi = mem[1152921504617021480], lo = mem[1152921504617021484], mid = mem[1152921504617021488]}, collectType:  this);
    }
    private bool Collect_New_Level()
    {
        SceneType val_1 = SceneDictator.GetActiveSceneType();
        if(0 != 2)
        {
                return this.OnClick_Collect();
        }
        
        GameBehavior val_2 = App.getBehavior;
        WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        CashOutAward(id:  this.current_award);
        return true;
    }
    private bool OnClick_Collect()
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        CashOutAward(id:  this.current_award);
        CurrencyController.HandleBalanceChanged(type:  0);
        CurrencyController.HandleBalanceChanged(type:  1);
        return this.FetchAwards();
    }
    public AwardController()
    {
    
    }

}
