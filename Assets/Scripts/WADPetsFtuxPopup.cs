using UnityEngine;
public class WADPetsFtuxPopup : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<WADPetsFtuxDisplay> petsDisplay;
    private WADPets.WADPet pendingAlphabetTilePet;
    private System.Collections.Generic.List<WADPets.WADPet> pendingFtuxes;
    private bool onEnabled;
    
    // Methods
    private void OnEnable()
    {
        var val_15;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.GetComponent<System.Object>();
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.enabled = false;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = 1152921510536702560;
        object val_4 = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C.GetComponent<System.Object>();
        public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C.enabled = false;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_6 = FreeHintButtonGroup;
        object val_7 = GetComponent<System.Object>();
        enabled = false;
        GameBehavior val_8 = App.getBehavior;
        if(0 != 0)
        {
                val_15 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_12 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.transform;
            UnityEngine.Transform val_13 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.parent;
            object val_14 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.GetComponent<System.Object>();
            public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.enabled = false;
        }
        
        }
        
        this.onEnabled = true;
        if(this.pendingFtuxes != 0)
        {
                if(true == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            this.ShowFtux(pet:  2621443);
            return;
        }
        
        if(this.pendingAlphabetTilePet == 0)
        {
                return;
        }
        
        this.Close();
    }
    private void OnDisable()
    {
        var val_15;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.GetComponent<System.Object>();
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.enabled = true;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = 1152921510536702560;
        object val_4 = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C.GetComponent<System.Object>();
        public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C.enabled = true;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_6 = FreeHintButtonGroup;
        object val_7 = GetComponent<System.Object>();
        enabled = true;
        GameBehavior val_8 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        val_15 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_12 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.transform;
        UnityEngine.Transform val_13 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.parent;
        object val_14 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.GetComponent<System.Object>();
        public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.enabled = true;
    }
    public void SetupFtux(System.Collections.Generic.List<WADPets.WADPet> pets)
    {
        System.Collections.Generic.List<WADPets.WADPet> val_8;
        var val_9;
        char* val_10;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_8 = val_1;
            typeof(WADPetsFtuxPopup.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = pets;
            WADPetsFtuxPopup.<>c__DisplayClass6_0.__il2cppRuntimeField_name.__il2cppRuntimeField_4 = this;
        }
        else
        {
                val_8 = 8;
            mem[8] = pets;
            mem[12] = this;
        }
        
        this.pendingFtuxes = val_8;
        this.DeactiveAllFtux();
        object val_2 = new System.Object();
        if(val_2 != 0)
        {
                val_9 = val_2;
            typeof(WADPetsFtuxPopup.<>c__DisplayClass6_1).__il2cppRuntimeField_C = val_1;
        }
        else
        {
                val_9 = 12;
            mem[12] = val_1;
        }
        
        val_10 = 0;
        typeof(WADPetsFtuxPopup.<>c__DisplayClass6_1).__il2cppRuntimeField_8 = ;
        if(this.onEnabled == false)
        {
                return;
        }
        
        if((pets + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.ShowFtux(pet:  pets + 8 + 16);
    }
    public void AddPetAlphabetTileFtux(WADPets.WADPet pet)
    {
        this.pendingAlphabetTilePet = pet;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                35639841 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_5 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.transform;
            UnityEngine.Transform val_6 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.parent;
            object val_7 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.GetComponent<System.Object>();
            public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.enabled = false;
        }
        
        }
        
        if(this.onEnabled == false)
        {
                return;
        }
        
        this.Close();
    }
    private void ShowFtux(WADPets.WADPet pet)
    {
        string val_5;
        string val_6;
        WADPetsFtuxPopup val_77;
        System.Predicate<ZooTile> val_78;
        var val_79;
        var val_80;
        var val_81;
        float val_82;
        var val_83;
        val_77 = this;
        object val_1 = new System.Object();
        typeof(WADPetsFtuxPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = pet;
        this.DeactiveAllFtux();
        val_78 = null;
        val_78 = new System.Predicate<ZooTile>(object:  383864832, method:  new IntPtr(4151980544));
        WADPetsFtuxDisplay val_3 = this.petsDisplay.Find(match:  8040448);
        typeof(WADPetsFtuxPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_C = this.petsDisplay;
        if(this.petsDisplay == 0)
        {
            goto label_3;
        }
        
        val_79 = null;
        val_79 = null;
        System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_4 = Item[WADPets.LocTexts.FtuxDescription];
        string val_7 = Localization.Localize(key:  val_5, defaultValue:  val_6, useSingularKey:  false);
        string val_8 = typeof(WADPetsFtuxPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_8.GetPrettyName();
        string val_9 = System.String.Format(format:  val_5, arg0:  typeof(WADPetsFtuxPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_8);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_12 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_13 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_13.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Interactable = true;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if((pet + 8 + 12) > 4)
        {
            goto label_20;
        }
        
        var val_18 = 13513796 + (13513796 + (pet + 8 + 12) << 2);
        if((pet + 8 + 12) == 4)
        {
                13513796 + (pet + 8 + 12) << 2 = (13513796 + (pet + 8 + 12) << 2) & (1041865114 << (13513796 + (pet + 8 + 12) << 2));
            13513796 + (pet + 8 + 12) << 2 = (13513796 + (pet + 8 + 12) << 2) & (((IP) << (32-1)) | ((IP) << 1));
            13513796 + (pet + 8 + 12) << 2 = (13513796 + (pet + 8 + 12) << 2) & (-1887017370);
            13513796 + (pet + 8 + 12) << 2 = (13513796 + (pet + 8 + 12) << 2) & ((((((13513796 + (pet + 8 + 12) << 2 & (1041865114) << 13513796 + (pet + 8 + 12) << 2) & ((IP) << (32-1)) | ((IP) << 1)) & -1887017370)) << (32-13513796)) | (((((13513796 + (pet + 8 + 12) << 2 & (1041865114) << 13513796 + (pet + 8 + 12) << 2) & ((IP) << (32-1)) | ((IP) << 1)) & -1887017370)) << 13513796));
            13513796 + (pet + 8 + 12) << 2 = (13513796 + (pet + 8 + 12) << 2) & 0;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_20 = HintButtonGroup;
        val_80 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        goto label_24;
        label_3:
        string val_21 = typeof(WADPetsFtuxPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_8.GetPrettyName();
        string val_22 = System.String.Format(format:  -142985728, arg0:  typeof(WADPetsFtuxPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_8);
        UnityEngine.Debug.LogError(message:  -142985728);
        this.Close();
        return;
        label_24:
        val_81 = 1152921504901095424;
        UnityEngine.Transform val_24 = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C.transform;
        val_77 = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C;
        val_82 = 0.8f;
        goto label_44;
        label_20:
        val_82 = 0.5f;
        val_77 = 0;
        val_81 = 1152921504901095424;
        label_44:
        this.petsDisplay + 12.SetActive(value:  true);
        Add(item:  2124183120);
        UnityEngine.Transform val_36 = this.petsDisplay + 12.transform;
        Add(item:  this.petsDisplay + 12);
        twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_38 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
        if(((pet + 8 + 12) != 0) && ((pet + 8 + 12) != 1))
        {
                if((pet + 8 + 12) != 4)
        {
            goto label_67;
        }
        
        }
        
        UnityEngine.Transform val_39 = this.petsDisplay + 12.transform;
        UnityEngine.Transform val_40 = this.petsDisplay + 12.transform;
        UnityEngine.Vector3 val_41 = val_13.HasValue.position;
        UnityEngine.Vector3 val_42 = val_13.HasValue.position;
        val_78 = 0;
        UnityEngine.Transform val_43 = this.petsDisplay + 12.transform;
        UnityEngine.Vector3 val_44 = position;
        UnityEngine.Vector3 val_47 = new UnityEngine.Vector3(x:   + val_12.g, y:  val_44.y, z:  val_44.z);
        label_113:
        this.petsDisplay + 12.position = new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z};
        return;
        label_67:
        if((pet + 8 + 12) != 3)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_48 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_49 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.GetComponent<System.Object>();
        UnityEngine.Vector2 val_50 = val_13.HasValue.anchoredPosition;
        System.Predicate<ZooTile> val_51 = new System.Predicate<ZooTile>(object:  383864832, method:  new IntPtr(4151981760));
        WADPetsFtuxDisplay val_52 = this.petsDisplay.Find(match:  8040448);
        UnityEngine.Transform val_53 = this.petsDisplay.transform;
        UnityEngine.Transform val_54 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.transform;
        this.petsDisplay.parent = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C;
        if(this.petsDisplay != 0)
        {
                UnityEngine.Transform val_55 = this.petsDisplay.transform;
            val_83 = this.petsDisplay;
        }
        else
        {
                UnityEngine.Transform val_56 = 0.transform;
            val_83 = 0;
        }
        
        UnityEngine.Transform val_57 = this.petsDisplay.transform;
        UnityEngine.Vector3 val_58 = val_13.HasValue.localPosition;
        UnityEngine.Vector3 val_60 = new UnityEngine.Vector3(x:  UnityEngine.Mathf.Clamp(value:  val_58.x, min:  val_58.y, max:  val_58.z), y:  val_58.y, z:  val_58.z);
        val_83.localPosition = new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z};
        UnityEngine.Camera val_61 = SLCWindowManager<WGWindowManager>.monolithPopupCamera;
        UnityEngine.Transform val_62 = this.petsDisplay.transform;
        UnityEngine.Vector3 val_63 = position;
        UnityEngine.Vector3 val_64 = val_47.x.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = -2.323061E+20f, y = val_5, z = val_6});
        float val_65 = UnityEngine.Mathf.Clamp(value:  val_64.x, min:  val_64.y, max:  val_64.z);
        UnityEngine.Transform val_66 = this.petsDisplay.transform;
        UnityEngine.Vector3 val_67 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = -2.323061E+20f, y = val_47.x, z = val_47.y});
        this.petsDisplay.position = new UnityEngine.Vector3();
        UnityEngine.Transform val_68 = this.petsDisplay + 16.transform;
        UnityEngine.Vector3 val_69 = position;
        UnityEngine.Transform val_72 = this.petsDisplay + 16.transform;
        UnityEngine.Transform val_73 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C.transform;
        UnityEngine.Vector3 val_74 = position;
        UnityEngine.Vector3 val_76 = new UnityEngine.Vector3(x:  val_74.x, y:  val_74.y, z:  val_74.z);
        if((this.petsDisplay + 16) != 0)
        {
            goto label_113;
        }
        
        goto label_113;
    }
    private void DeactiveAllFtux()
    {
        List.Enumerator<T> val_1 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3 + 12.SetActive(value:  false);
        goto label_5;
        label_2:
        Dispose();
    }
    private void Close()
    {
        if(this.pendingAlphabetTilePet != 0)
        {
                this.onEnabled = false;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Add(item:  this.pendingAlphabetTilePet);
            this.SetupFtux(pets:  80883712);
            this.ShowFtux(pet:  this.pendingAlphabetTilePet);
            this.pendingAlphabetTilePet = false;
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_3 = new System.Action(object:  -142703744, method:  new IntPtr(4152238528));
        CloseOverlay(onClosed:  7454720);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -142703744, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WADPetsFtuxPopup()
    {
    
    }
    private void <Close>b__10_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -142467456, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
