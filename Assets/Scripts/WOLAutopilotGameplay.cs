using UnityEngine;
public class WOLAutopilotGameplay : AutopilotGameplay
{
    // Fields
    private SLC.Wordlicious.WOLUIGrid grid;
    private UnityEngine.Camera gridCamera;
    private bool onGameScene;
    
    // Methods
    public override bool IsExecutable()
    {
        if(this.onGameScene == false)
        {
                return false;
        }
        
        Player val_1 = App.Player;
        if(0 > mem[1179403871])
        {
                float val_2 = UnityEngine.Random.value;
            if(0 < 0)
        {
                return false;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1759400800) == 0)
        {
                return this.IsGridEnabled();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return false;
    }
    public override void RunAction()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1759400800) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_GrantWord();
    }
    public override void OnSceneLoaded(SceneType sceneType)
    {
        SceneType val_1 = sceneType - 2;
        val_1 = val_1 >> 5;
        this.onGameScene = val_1;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.grid = public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance();
        UnityEngine.Transform val_3 = transform;
        UnityEngine.Camera val_4 = twelvegigs.Autopilot.AutopilotTools.GetCamera(go:  -1759171680);
        this.gridCamera = public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance();
    }
    public override void OnSceneUnloaded(SceneType sceneType)
    {
        this.grid = 0;
        this.gridCamera = 0;
    }
    public void HandleLevelComplete()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ClearIgnore();
        Player val_2 = App.Player;
        if(0 == 0)
        {
            
        }
    
    }
    private bool IsGridEnabled()
    {
        if(this.grid == 0)
        {
                return (bool)0;
        }
        
        UnityEngine.GameObject val_2 = this.grid.gameObject;
        UnityEngine.Vector3 val_3 = position;
        0 = twelvegigs.Autopilot.AutopilotTools.RaycastOnPosition(target:  this.grid, worldPos:  new UnityEngine.Vector3(), camera:  this.gridCamera);
        return (bool)0;
    }
    public WOLAutopilotGameplay()
    {
    
    }

}
