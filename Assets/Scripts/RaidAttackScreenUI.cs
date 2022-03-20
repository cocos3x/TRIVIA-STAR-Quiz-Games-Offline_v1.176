using UnityEngine;
public class RaidAttackScreenUI : MonoSingleton<RaidAttackScreenUI>
{
    // Fields
    private static System.Action awakeCommand;
    private PrefabsFromFolder prefabsFolder;
    private WordForest.RaidAttackScreenTransition screenTransition;
    private System.Collections.Generic.Stack<UnityEngine.GameObject> screenStack;
    
    // Methods
    private void Start()
    {
        if(RaidAttackScreenUI.awakeCommand != 0)
        {
                RaidAttackScreenUI.awakeCommand.Invoke();
        }
        
        RaidAttackScreenUI.awakeCommand = 0;
        System.Action val_1 = new System.Action(object:  -390504496, method:  new IntPtr(3904437776));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
    }
    private void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  -390392496, method:  new IntPtr(3904437776));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
    }
    public static void ShowRaidScreen()
    {
        RaidAttackScreenUI.ShowScreen<WordForest.RaidScreenMain>(sceneType:  1);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  0, trackIndex:  2);
    }
    public static void ShowAttackScreen()
    {
        RaidAttackScreenUI.ShowScreen<WordForest.RaidScreenMain>(sceneType:  2);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  0, trackIndex:  1);
    }
    public static void Exit()
    {
        MainController val_1 = MainController.instance;
        4.enabled = true;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  0, trackIndex:  0);
        GameBehavior val_3 = App.getBehavior;
        UnityEngine.AsyncOperation val_4 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
    }
    public void BackButtonPressed()
    {
        if((this.screenStack != 0) && (this.screenStack >= 1))
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  -389936304, method:  new IntPtr(3905005968));
            public static RaidAttackScreenUI MonoSingleton<RaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_10.ExtendCurtains(sceneType:  0, onComplete:  7454720);
            return;
        }
        
        RaidAttackScreenUI.Exit();
    }
    public void ShowConnectionRequired()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_6 = null;
        val_6 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private static void ShowScreen<T>(WordForest.RaidAttackActionType sceneType)
    {
        mem2[0] = sceneType;
        System.Action val_1 = new System.Action(object:  __RuntimeMethodHiddenParam + 24, method:  __RuntimeMethodHiddenParam + 24 + 8);
        RaidAttackScreenUI.awakeCommand = null;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-389962352) == 0)
        {
                GameBehavior val_4 = App.getBehavior;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null, mode:  1);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = public static RaidAttackScreenUI MonoSingleton<RaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_14.Peek();
        public static RaidAttackScreenUI MonoSingleton<RaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_14.SetActive(value:  false);
        Invoke();
        RaidAttackScreenUI.awakeCommand = 0;
    }
    public RaidAttackScreenUI()
    {
        System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_1 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
        this.screenStack = null;
    }
    private void <BackButtonPressed>b__9_0()
    {
        MainController val_1 = MainController.instance;
        4.enabled = true;
        UnityEngine.GameObject val_2 = this.screenStack.Peek();
        if(this.screenStack != 0)
        {
                this.screenStack.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.screenStack.Pop();
        }
        
        if(this.screenStack >= 1)
        {
                UnityEngine.GameObject val_5 = this.screenStack.Peek();
            this.screenStack.SetActive(value:  true);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_7 = new System.Action(object:  -389456560, method:  new IntPtr(3905485712));
        public static RaidAttackScreenUI MonoSingleton<RaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_10.WithdrawCurtains(delay:  null, onComplete:  1036831949);
    }
    private void <BackButtonPressed>b__9_1()
    {
        if(this.screenStack != 0)
        {
                if(this.screenStack > 0)
        {
                return;
        }
        
        }
        
        RaidAttackScreenUI.Exit();
    }

}
