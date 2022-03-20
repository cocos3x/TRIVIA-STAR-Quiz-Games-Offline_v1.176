using UnityEngine;
public class SROptions_WADPets : SuperLuckySROptionsParent<SROptions_WADPets>, INotifyPropertyChanged
{
    // Properties
    public string Food { get; }
    public string SetFood { get; set; }
    public string GoldieCards { get; set; }
    public string SimonCards { get; set; }
    public string HuskyCards { get; set; }
    public string HammerCards { get; set; }
    public string CocoCards { get; set; }
    public string PersiaCards { get; set; }
    public bool UseMinutes { get; set; }
    
    // Methods
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
    public string get_Food()
    {
        Player val_1 = App.Player;
        string val_2 = 1.ToString();
    }
    public void set_SetFood(string value)
    {
        Player val_1 = App.Player;
        if((System.Int32.TryParse(s:  value, result: out  int val_2 = -818954508)) == false)
        {
                return;
        }
        
        Player val_4 = App.Player;
        if(1 == 1)
        {
                return;
        }
        
        Player val_5 = App.Player;
        0.SetPetsFood(amount:  1);
        Player val_6 = App.Player;
        0.SaveState();
        string val_7 = -818966592(-818966592) + 13152256;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -818966592, displayTime:  null);
        SROptions_WADPets.NotifyPropertyChanged(propertyName:  -1929660112);
    }
    public string get_SetFood()
    {
        Player val_1 = App.Player;
        string val_2 = 1.ToString();
    }
    public void PetsFoodDown10()
    {
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        0.SetPetsFood(amount:  1 - 10);
        SROptions_WADPets.NotifyPropertyChanged(propertyName:  -1929660112);
    }
    public void PetsFoodDown1()
    {
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        0.SetPetsFood(amount:  1 - 1);
        SROptions_WADPets.NotifyPropertyChanged(propertyName:  -1929660112);
    }
    public void PetsFoodUp1()
    {
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        0.SetPetsFood(amount:  1 + 1);
        SROptions_WADPets.NotifyPropertyChanged(propertyName:  -1929660112);
    }
    public void PetsFoodUp10()
    {
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        0.SetPetsFood(amount:  1 + 10);
        SROptions_WADPets.NotifyPropertyChanged(propertyName:  -1929660112);
    }
    public void UnlockAllPets()
    {
        var val_4;
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.GetAllPetsCollection();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((val_4 + 16) != 0)
        {
            goto label_5;
        }
        
        val_4.Upgrade(hackLevel:  1);
        goto label_5;
        label_2:
        Dispose();
    }
    public void ResetAllPets()
    {
        var val_4;
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.GetAllPetsCollection();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        Dispose();
        WADPets.WADPetsUtils.QHACK_ResetWADPetsCollection();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ResetLevelCompleteEventTracking();
    }
    public void set_GoldieCards(string value)
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  0);
        if((System.Int32.TryParse(s:  value, result: out  int val_2 = -818050196)) == false)
        {
                return;
        }
        
        if(1 < 0)
        {
                return;
        }
        
        mem[20] = 1;
        string val_4 = -818062288(-818062288) + 13152256;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -818062288, displayTime:  null);
    }
    public string get_GoldieCards()
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  0);
        if(0 != 0)
        {
                return 20.ToString();
        }
        
        return 20.ToString();
    }
    public void set_SimonCards(string value)
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  4);
        if((System.Int32.TryParse(s:  value, result: out  int val_2 = -817817892)) == false)
        {
                return;
        }
        
        if(0 < 0)
        {
                return;
        }
        
        mem[24] = 0;
        string val_4 = -817829984(-817829984) + 13152256;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -817829984, displayTime:  null);
    }
    public string get_SimonCards()
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  4);
        if(4 != 0)
        {
                return 24.ToString();
        }
        
        return 24.ToString();
    }
    public void set_HuskyCards(string value)
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  5);
        if((System.Int32.TryParse(s:  value, result: out  int val_2 = -817585588)) == false)
        {
                return;
        }
        
        if(872415232 < 0)
        {
                return;
        }
        
        mem[25] = 872415232;
        string val_4 = -817597680(-817597680) + 13152256;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -817597680, displayTime:  null);
    }
    public string get_HuskyCards()
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  5);
        if(5 != 0)
        {
                return 25.ToString();
        }
        
        return 25.ToString();
    }
    public void set_HammerCards(string value)
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  3);
        if((System.Int32.TryParse(s:  value, result: out  int val_2 = -817353284)) == false)
        {
                return;
        }
        
        if(0 < 0)
        {
                return;
        }
        
        mem[23] = 0;
        string val_4 = -817365376(-817365376) + 13152256;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -817365376, displayTime:  null);
    }
    public string get_HammerCards()
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  3);
        if(3 != 0)
        {
                return 23.ToString();
        }
        
        return 23.ToString();
    }
    public void set_CocoCards(string value)
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  2);
        if((System.Int32.TryParse(s:  value, result: out  int val_2 = -817120980)) == false)
        {
                return;
        }
        
        if(0 < 0)
        {
                return;
        }
        
        mem[22] = 0;
        string val_4 = -817133072(-817133072) + 13152256;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -817133072, displayTime:  null);
    }
    public string get_CocoCards()
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  2);
        if(2 != 0)
        {
                return 22.ToString();
        }
        
        return 22.ToString();
    }
    public void set_PersiaCards(string value)
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  1);
        if((System.Int32.TryParse(s:  value, result: out  int val_2 = -816888676)) == false)
        {
                return;
        }
        
        if(0 < 0)
        {
                return;
        }
        
        mem[21] = 0;
        string val_4 = -816900768(-816900768) + 13152256;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -816900768, displayTime:  null);
    }
    public string get_PersiaCards()
    {
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  1);
        if(1 != 0)
        {
                return 21.ToString();
        }
        
        return 21.ToString();
    }
    public void ShowPetsInfoHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3478294736));
        SLCHUDWindow.SetupHUD(name:  -816671536, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_4;
        }
        
        var val_5 = 0;
        label_6:
        if((mem[1179403735] + 0) == null)
        {
            goto label_5;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_6;
        }
        
        label_4:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_5:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public bool get_UseMinutes()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance()) != 0)
        {
                return (bool)public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance().__il2cppRuntimeField_C;
        }
        
        return (bool)public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance().__il2cppRuntimeField_C;
    }
    public void set_UseMinutes(bool value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance().__il2cppRuntimeField_C = value;
    }
    public SROptions_WADPets()
    {
    
    }

}
