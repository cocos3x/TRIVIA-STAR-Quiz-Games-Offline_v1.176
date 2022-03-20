using UnityEngine;
public class SROptions_TRVCategoryHack : SuperLuckySROptionsParent<SROptions_TRVCategoryHack>, INotifyPropertyChanged
{
    // Fields
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> availableSubCategories;
    private int generalCategorySelected;
    private int sportsCategorySelected;
    private int entertainmentCategorySelected;
    
    // Properties
    private System.Collections.Generic.List<string> SelectedCategories { get; set; }
    public string CatInfo { get; }
    public int GeneralCategorySelected { get; set; }
    public int SportsCategorySelected { get; set; }
    public int EntertainmentCategorySelected { get; set; }
    public string CurrentFakeAdjustCampaign { get; set; }
    
    // Methods
    private System.Collections.Generic.List<string> get_SelectedCategories()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private void set_SelectedCategories(System.Collections.Generic.List<string> value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.getCurrentAvailableCategories = value;
    }
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((SuperLuckySROptionsParent<T>._Instance) == 0)
        {
                return;
        }
        
        goto typeof(T).__il2cppRuntimeField_EC;
    }
    public void Back()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        var val_6 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_5 = 0;
        label_4:
        val_5 = 0;
        val_6 = mem[mem[1179403735] + 0];
        val_6 = mem[1179403735] + 0;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_5 = val_5 + 1;
        val_5 = (uint)val_5 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_7 = 0;
        goto label_5;
        label_3:
        var val_2 = mem[1179403735] + 0;
        val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
        val_7 = val_6 + 332;
        label_5:
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_5 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_5 = (uint)val_6 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_8 = 0;
        goto label_10;
        label_8:
        var val_4 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 292;
        label_10:
        SuperLuckySROptionsController.OpenGameSpecificOptionsController();
    }
    public void DisplayCategoriesInfo()
    {
        var val_6;
        System.Func<TRVQuizProgress> val_7;
        var val_8;
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_1 = System.String.Format(format:  -826587056, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3468380368));
        SLCHUDWindow.SetupHUD(name:  -826587056, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_10;
        }
        
        val_7 = 0;
        label_12:
        if((mem[1179403735] + 0) == null)
        {
            goto label_11;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < mem[1179403825])
        {
            goto label_12;
        }
        
        label_10:
        val_8 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_11:
        var val_5 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_8 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public string get_CatInfo()
    {
        int val_9 = 1152921511548963376;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1647818192) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(System.Object[]).__il2cppRuntimeField_10 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryProgress val_5 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetSubCatProgress(subCategory:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8);
        int val_6 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 8.Item[public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 16];
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        val_9 = mem[public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 16];
        val_9 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 16;
        System.TimeType val_7 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 36 + 12.Item[val_9];
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_8 = System.String.Format(format:  -826472768, args:  472754880);
    }
    public void NearlyCompleteCat()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1647818192) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryProgress val_5 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetSubCatProgress(subCategory:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8);
        int val_6 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 8.Item[public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 16];
        System.TimeType val_7 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 36 + 12.Item[public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 16];
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 8.set_Item(key:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 16, value:  ((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 36 + 12 + 12 - 2) | val_6));
        SROptions_TRVCategoryHack.NotifyPropertyChanged(propertyName:  -826360640);
    }
    public int get_GeneralCategorySelected()
    {
        return (int)this.generalCategorySelected;
    }
    public void set_GeneralCategorySelected(int value)
    {
        this.generalCategorySelected = value;
        SROptions_TRVCategoryHack.NotifyPropertyChanged(propertyName:  -826136512);
        if(value != 1)
        {
                if(value < 1)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_2 = HackCategories;
            System.Collections.Generic.List<System.String> val_3 = this.availableSubCategories.Item[-826136512];
            int val_6 = this.generalCategorySelected;
            val_6 = val_6 - 1;
            if(this.availableSubCategories <= val_6)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = val_7 + (val_6 << 2);
            set_Item(index:  0, value:  (0 + ((this.generalCategorySelected - 1)) << 2) + 16);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_5 = HackCategories;
        set_Item(index:  0, value:  1098586544);
    }
    public int get_SportsCategorySelected()
    {
        return (int)this.sportsCategorySelected;
    }
    public void set_SportsCategorySelected(int value)
    {
        this.sportsCategorySelected = value;
        SROptions_TRVCategoryHack.NotifyPropertyChanged(propertyName:  -825902176);
        if(value != 1)
        {
                if(value < 1)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_2 = HackCategories;
            System.Collections.Generic.List<System.String> val_3 = this.availableSubCategories.Item[-825902176];
            int val_6 = this.sportsCategorySelected;
            val_6 = val_6 - 1;
            if(this.availableSubCategories <= val_6)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = val_7 + (val_6 << 2);
            set_Item(index:  1, value:  (0 + ((this.sportsCategorySelected - 1)) << 2) + 16);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_5 = HackCategories;
        set_Item(index:  1, value:  1098586544);
    }
    public int get_EntertainmentCategorySelected()
    {
        return (int)this.entertainmentCategorySelected;
    }
    public void set_EntertainmentCategorySelected(int value)
    {
        this.entertainmentCategorySelected = value;
        SROptions_TRVCategoryHack.NotifyPropertyChanged(propertyName:  -825669904);
        if(value != 1)
        {
                if(value < 1)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_2 = HackCategories;
            System.Collections.Generic.List<System.String> val_3 = this.availableSubCategories.Item[-825669904];
            int val_6 = this.entertainmentCategorySelected;
            val_6 = val_6 - 1;
            if(this.availableSubCategories <= val_6)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = val_7 + (val_6 << 2);
            set_Item(index:  2, value:  (0 + ((this.entertainmentCategorySelected - 1)) << 2) + 16);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_5 = HackCategories;
        set_Item(index:  2, value:  1098586544);
    }
    public string get_CurrentFakeAdjustCampaign()
    {
        null = null;
    }
    public void set_CurrentFakeAdjustCampaign(string value)
    {
        null = null;
        TRVDataParser.hackedAdjustCampaign = value;
    }
    public void PromoCategoriesLogicHUD()
    {
        var val_4;
        System.Func<TRVQuizProgress> val_1 = new System.Func<TRVQuizProgress>(object:  0, method:  new IntPtr(3469649872));
        SLCHUDWindow.SetupHUD(name:  -825316400, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_4 = 0;
        label_4:
        if((mem[1179403735] + 0) == null)
        {
            goto label_3;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_3:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public SROptions_TRVCategoryHack()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_2 = getAvailableSubCategories;
        this.availableSubCategories = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        this.generalCategorySelected = 0;
        this.sportsCategorySelected = 0;
        this.entertainmentCategorySelected = 0;
    }

}
