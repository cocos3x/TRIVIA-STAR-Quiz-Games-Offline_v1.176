using UnityEngine;
public class TheLibraryUI : MonoSingleton<TheLibraryUI>
{
    // Fields
    private static System.Action AwakeCommand;
    private static System.Action OnCloseAction;
    private PrefabsFromFolder prefabsFromFolder;
    private UnityEngine.Canvas mainUICanvas;
    private System.Collections.Generic.Stack<UnityEngine.GameObject> screenStack;
    
    // Methods
    public static void ShowTheLibrary(System.Action onCloseAction)
    {
        var val_12;
        var val_13;
        System.Action val_15;
        var val_16;
        if(TheLibraryLogic.LifetimeBooksEarned < 1)
        {
                return;
        }
        
        TheLibraryUI.OnCloseAction = onCloseAction;
        val_12 = 1152921511511211728;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1685569840) == 0)
        {
                val_12 = 1152921504908177408;
            val_13 = null;
            val_13 = null;
            val_15 = TheLibraryUI.<>c.<>9__2_0;
            if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Action(object:  TheLibraryUI.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2612944064));
            TheLibraryUI.<>c.<>9__2_0 = val_15;
        }
        
            TheLibraryUI.AwakeCommand = val_15;
            GameBehavior val_5 = App.getBehavior;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null, mode:  1);
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TheLibraryMainScreen val_7 = public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
            UnityEngine.GameObject val_8 = public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C.gameObject;
            if((public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C.activeSelf) != true)
        {
                public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C.SetActive(value:  true);
        }
        
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_14.Push(item:  public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BannerAdsUnblocked = false;
        val_16 = null;
        val_16 = null;
        TheLibraryLogic.prefs_server_queue = TheLibraryLogic.prefs_server_queue;
    }
    public static void ShowTheLibraryCollection(string collectionName, bool trackLibraryAccessed = False)
    {
        System.Action val_15;
        var val_16;
        object val_1 = new System.Object();
        typeof(TheLibraryUI.<>c__DisplayClass3_0).__il2cppRuntimeField_8 = collectionName;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1685569840) == 0)
        {
                val_15 = null;
            val_15 = new System.Action(object:  301383680, method:  new IntPtr(2613067328));
            TheLibraryUI.AwakeCommand = val_15;
            GameBehavior val_5 = App.getBehavior;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null, mode:  1);
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_14.Peek();
            public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_14.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TheLibraryMainScreen val_10 = public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
            public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C.Setup(collectionName:  typeof(TheLibraryUI.<>c__DisplayClass3_0).__il2cppRuntimeField_8);
            UnityEngine.GameObject val_11 = public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C.gameObject;
            if((public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C.activeSelf) != true)
        {
                public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C.SetActive(value:  true);
        }
        
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_14.Push(item:  public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_C);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BannerAdsUnblocked = false;
        if(trackLibraryAccessed == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        TheLibraryLogic.prefs_server_queue = TheLibraryLogic.prefs_server_queue;
    }
    public static void HandleTheLibraryClose()
    {
        var val_4;
        TheLibraryUI.AwakeCommand = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static LibraryWindowManager MonoSingleton<LibraryWindowManager>::get_Instance().__il2cppRuntimeField_40 = 0;
        GameBehavior val_2 = App.getBehavior;
        UnityEngine.AsyncOperation val_3 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
        if(TheLibraryUI.OnCloseAction != 0)
        {
                TheLibraryUI.OnCloseAction.Invoke();
            val_4 = 1152921504908128260;
        }
        
        TheLibraryUI.OnCloseAction = 0;
    }
    public static void ForceTheLibraryClose()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1685569840) == 0)
        {
                return;
        }
        
        TheLibraryUI.AwakeCommand = null;
        GameBehavior val_3 = App.getBehavior;
        UnityEngine.AsyncOperation val_4 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
    }
    public static void HideMainUICanvas()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1685569840) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_10.enabled = false;
    }
    public static void ShowMainUICanvas()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1685569840) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TheLibraryUI MonoSingleton<TheLibraryUI>::get_Instance().__il2cppRuntimeField_10.enabled = true;
    }
    private void Start()
    {
        if(TheLibraryUI.AwakeCommand != 0)
        {
                TheLibraryUI.AwakeCommand.Invoke();
            TheLibraryUI.AwakeCommand = 0;
        }
        
        System.Action val_1 = new System.Action(object:  -1681307776, method:  new IntPtr(2613634496));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
    }
    private void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  -1681195776, method:  new IntPtr(2613634496));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
    }
    public void BackButtonPressed()
    {
        if(this.screenStack == 0)
        {
            goto label_1;
        }
        
        if(R1 >= 1)
        {
                UnityEngine.GameObject val_1 = this.screenStack.Peek();
            if(this.screenStack != 0)
        {
                this.screenStack.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this.screenStack.Pop();
        }
        
        }
        
        if((public UnityEngine.GameObject System.Collections.Generic.Stack<UnityEngine.GameObject>::Pop()) != 0)
        {
            goto label_8;
        }
        
        label_1:
        TheLibraryUI.HandleTheLibraryClose();
        goto label_9;
        label_8:
        UnityEngine.GameObject val_4 = this.screenStack.Peek();
        this.screenStack.SetActive(value:  true);
        label_9:
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BannerAdsUnblocked = true;
    }
    private void HandleBackButtonClose()
    {
        TheLibraryUI.HandleTheLibraryClose();
    }
    public TheLibraryUI()
    {
        System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_1 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
        this.screenStack = null;
    }

}
