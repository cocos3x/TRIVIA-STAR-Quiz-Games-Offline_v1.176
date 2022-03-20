using UnityEngine;
public class WADPetsScreenUI : MonoSingleton<WADPetsScreenUI>
{
    // Fields
    private static System.Action awakeCommand;
    private PrefabsFromFolder prefabsFolder;
    private System.Collections.Generic.Stack<UnityEngine.GameObject> screenStack;
    
    // Methods
    private void Start()
    {
        if(WADPetsScreenUI.awakeCommand != 0)
        {
                WADPetsScreenUI.awakeCommand.Invoke();
        }
        
        WADPetsScreenUI.awakeCommand = 0;
        System.Action val_1 = new System.Action(object:  -963011904, method:  new IntPtr(3331930368));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
    }
    private void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  -962899904, method:  new IntPtr(3331930368));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
    }
    public static void ShowMainScreen()
    {
        WADPetsScreenUI.ShowScreen<System.Object>();
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
        
        WADPetsScreenUI.Exit();
    }
    private static void Exit()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.AsyncOperation val_2 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
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
        
        WADPetsScreenUI.awakeCommand = val_9;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-980061728) == 0)
        {
                GameBehavior val_4 = App.getBehavior;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null, mode:  1);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = public static WADPetsScreenUI MonoSingleton<WADPetsScreenUI>::get_Instance().__il2cppRuntimeField_10.Peek();
        public static WADPetsScreenUI MonoSingleton<WADPetsScreenUI>::get_Instance().__il2cppRuntimeField_10.SetActive(value:  false);
        Invoke();
        WADPetsScreenUI.awakeCommand = 0;
    }
    private void HandleBackButtonClose()
    {
        WADPetsScreenUI.Exit();
    }
    public WADPetsScreenUI()
    {
        System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_1 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
        this.screenStack = null;
    }

}
