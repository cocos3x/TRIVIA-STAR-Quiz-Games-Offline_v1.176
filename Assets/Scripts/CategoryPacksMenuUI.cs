using UnityEngine;
public class CategoryPacksMenuUI : MonoSingleton<CategoryPacksMenuUI>
{
    // Fields
    private static System.Action awakeCommand;
    private PrefabsFromFolder prefabsFolder;
    private System.Collections.Generic.Stack<UnityEngine.GameObject> screenStack;
    
    // Methods
    private void Start()
    {
        if(CategoryPacksMenuUI.awakeCommand != 0)
        {
                CategoryPacksMenuUI.awakeCommand.Invoke();
        }
        
        CategoryPacksMenuUI.awakeCommand = 0;
        System.Action val_1 = new System.Action(object:  -1491200368, method:  new IntPtr(2803741904));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
    }
    private void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  -1491088368, method:  new IntPtr(2803741904));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
    }
    public static void ShowMainScreen()
    {
        CategoryPacksMenuUI.ShowScreen<System.Object>();
    }
    public static void Exit()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.AsyncOperation val_2 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
    }
    public void BackButtonPressed()
    {
        if(this.screenStack != 0)
        {
                if(R1 >= 1)
        {
                UnityEngine.GameObject val_1 = this.screenStack.Peek();
            if(this.screenStack != 0)
        {
                this.screenStack.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this.screenStack.Pop();
        }
        
        }
        
            if((this.screenStack != 0) && ((public UnityEngine.GameObject System.Collections.Generic.Stack<UnityEngine.GameObject>::Pop()) > 0))
        {
                UnityEngine.GameObject val_4 = this.screenStack.Peek();
            this.screenStack.SetActive(value:  true);
            return;
        }
        
        }
        
        CategoryPacksMenuUI.Exit();
    }
    public void ShowPopupNoNetwork()
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
    public void ShowPopupReward(CategoryCompletionReward reward, int categoriesCleared)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        Initialize(_rewardData:  reward, categoriesCleared:  categoriesCleared);
    }
    private static void ShowScreen<T>()
    {
        var val_8;
        System.Action val_9;
        var val_10;
        val_8 = mem[__RuntimeMethodHiddenParam + 24 + 186];
        val_8 = __RuntimeMethodHiddenParam + 24 + 186;
        if(val_8 == 1)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 186];
            val_8 = __RuntimeMethodHiddenParam + 24 + 186;
        }
        
        val_9 = mem[__RuntimeMethodHiddenParam + 24 + 92 + 4];
        val_9 = __RuntimeMethodHiddenParam + 24 + 92 + 4;
        if(val_9 == 0)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 186];
            val_10 = __RuntimeMethodHiddenParam + 24 + 186;
            if(val_10 == 1)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 186];
            val_10 = __RuntimeMethodHiddenParam + 24 + 186;
        }
        
            val_9 = null;
            val_9 = new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 92, method:  __RuntimeMethodHiddenParam + 24 + 4);
            mem2[0] = val_9;
        }
        
        CategoryPacksMenuUI.awakeCommand = val_9;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1490404528) == 0)
        {
                GameBehavior val_4 = App.getBehavior;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null, mode:  1);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = public static CategoryPacksMenuUI MonoSingleton<CategoryPacksMenuUI>::get_Instance().__il2cppRuntimeField_10.Peek();
        public static CategoryPacksMenuUI MonoSingleton<CategoryPacksMenuUI>::get_Instance().__il2cppRuntimeField_10.SetActive(value:  false);
        Invoke();
        CategoryPacksMenuUI.awakeCommand = 0;
    }
    private void HandleBackButtonClose()
    {
        CategoryPacksMenuUI.Exit();
    }
    public CategoryPacksMenuUI()
    {
        System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_1 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
        this.screenStack = null;
    }

}
