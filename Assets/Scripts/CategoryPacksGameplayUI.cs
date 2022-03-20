using UnityEngine;
public class CategoryPacksGameplayUI : MonoSingleton<CategoryPacksGameplayUI>
{
    // Fields
    private bool isInitialized;
    
    // Properties
    private UnityEngine.UI.Image CategoryLetterCellImagePrefab { get; }
    
    // Methods
    private UnityEngine.UI.Image get_CategoryLetterCellImagePrefab()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((-2084533312) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = mem[public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 220];
        val_6 = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 220;
    }
    private void OnSceneChanged(UnityEngine.SceneManagement.Scene outgoingScene, UnityEngine.SceneManagement.Scene incomingScene)
    {
        System.Action<twelvegigs.storage.JsonDictionary> val_12;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = incomingScene.m_Handle.name;
        val_12;
        if(0 == 2)
        {
                if(CategoryPacksManager.IsPlaying != false)
        {
                this.isInitialized = CategoryPacksManager.IsPlaying;
            WordRegion val_5 = WordRegion.instance;
            val_12 = null;
            val_12 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1500728432, method:  new IntPtr(2794213840));
            0.addOnLevelLoadedAction(callback:  7401472);
            this.UpdateLevelName();
            return;
        }
        
        }
        
        if(this.isInitialized == false)
        {
                return;
        }
        
        val_12 = 1152921504886931456;
        WordRegion val_7 = WordRegion.instance;
        if(0 == 0)
        {
            goto label_20;
        }
        
        WordRegion val_9 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1500728432, method:  new IntPtr(2794213840));
        System.Delegate val_11 = System.Delegate.Remove(source:  33453552, value:  7401472);
        val_12 = 33453552;
        if(val_12 != 0)
        {
                if(3571904 == null)
        {
            goto label_26;
        }
        
        }
        
        val_12 = 0;
        label_26:
        mem[128] = val_12;
        label_20:
        bool val_12 = this.isInitialized;
        val_12 = val_12 ^ 1;
        this.isInitialized = val_12;
    }
    public override void InitMonoSingleton()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  -1500615408, method:  new IntPtr(2794326864));
        UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  162459648);
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  -1500503408, method:  new IntPtr(2794326864));
        UnityEngine.SceneManagement.SceneManager.remove_activeSceneChanged(value:  162459648);
    }
    private void OnLevelLoaded(GameLevel gameLevel)
    {
        float val_15;
        string val_16;
        UnityEngine.Transform val_17;
        var val_18;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
        string val_4 = gameLevel.word.Replace(oldValue:  -2100450224, newValue:  1098586544);
        val_16 = gameLevel.word;
        WordRegion val_5 = WordRegion.instance;
        val_17 = 0;
        val_18 = 4;
        goto label_12;
        label_19:
        if(0 <= gameLevel)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_6 = static_value_0028000F.ToUpper();
        string val_7 = val_16.ToUpper();
        if((System.String.op_Equality(a:  static_value_0028000F, b:  val_16)) == true)
        {
            goto label_17;
        }
        
        val_18 = 5;
        label_12:
        if(1 < 0)
        {
            goto label_19;
        }
        
        return;
        label_17:
        if(0 <= gameLevel)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = 5890;
        val_16 = 0;
        goto label_23;
        label_37:
        UnityEngine.UI.Image val_9 = this.CategoryLetterCellImagePrefab;
        if(548077568 <= val_16)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = 1179648;
        val_15 = val_15 + 0;
        UnityEngine.GameObject val_10 = (1179648 + 0) + 16.gameObject;
        UnityEngine.Transform val_11 = (1179648 + 0) + 16.transform;
        val_17 = (1179648 + 0) + 16;
        object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  0, parent:  val_17);
        UnityEngine.Transform val_13 = 0.transform;
        0.SetAsFirstSibling();
        CategoryColor val_14 = GetColor(colorCode:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 52);
        if(val_15 != 0)
        {
                0.sprite = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_1C;
            val_15 = val_15;
            val_18 = val_18;
        }
        
        val_16 = 1;
        label_23:
        if(val_16 < 548077568)
        {
            goto label_37;
        }
    
    }
    private void UpdateLevelName()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance()) != 0)
        {
                val_13 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28;
        }
        else
        {
                val_13 = 2097204;
            val_12 = 2097204;
        }
        
        if(val_12 != 0)
        {
                CategoryPackWordBank val_2 = GetWordBank(packId:  34776348);
            val_14 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
        }
        else
        {
                val_14 = 0;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = 23;
        typeof(System.Object[]).__il2cppRuntimeField_14 = 34776364;
        int val_3 = GetPackProgress(packId:  34776348);
        val_3 = val_3 + 1;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_4 = val_14.Size;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_5 = System.String.Format(format:  -1500286000, args:  472754880);
        MainController val_6 = MainController.instance;
        val_15 = 0;
        UnityEngine.Transform val_7 = 83886592.transform;
        if(83886592 != 0)
        {
                if(mem[83886592] == null)
        {
            goto label_28;
        }
        
        }
        
        val_16 = 1;
        goto label_29;
        label_28:
        val_16 = 0;
        val_15 = 83886592;
        label_29:
        UnityEngine.Vector2 val_8 = sizeDelta;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_8.x, y:  val_8.y);
        val_15.sizeDelta = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        MainController val_11 = MainController.instance;
        0.SetLevelName(str:  -1500286000, isVisible:  true);
    }
    public CategoryPacksGameplayUI()
    {
    
    }

}
