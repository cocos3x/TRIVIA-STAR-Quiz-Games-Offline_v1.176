using UnityEngine;

namespace SLC.Minigames.Snake
{
    public class SnakeGameManager : MonoSingleton<SLC.Minigames.Snake.SnakeGameManager>
    {
        // Fields
        private const string MINIGAME_NAME = "Snake";
        private SLC.Minigames.Snake.SnakeUIController uiController;
        private int _snakePlayerLevel;
        private int _snakeObjectivesCount;
        private int _snakeObjectivesReq;
        private bool inMinigameFramework;
        private bool isPaused;
        
        // Properties
        public bool IsPaused { get; }
        
        // Methods
        public bool get_IsPaused()
        {
            return (bool)this.isPaused;
        }
        private void Start()
        {
            var val_13;
            var val_14;
            var val_15;
            this.inMinigameFramework = true;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) != 0)
            {
                goto label_5;
            }
            
            val_13 = "Snake: No Minigame Manager";
            goto label_8;
            label_5:
            if(this.inMinigameFramework == false)
            {
                goto label_27;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = CurrentMinigameId;
            if((Equals(value:  -61694528)) == false)
            {
                goto label_14;
            }
            
            if(this.inMinigameFramework == false)
            {
                goto label_27;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this._snakePlayerLevel = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_8 = new System.Action(object:  1033708944, method:  new IntPtr(1033679824));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
            val_14 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_14 != 0)
            {
                    if(val_14 == null)
            {
                goto label_22;
            }
            
            }
            
            val_14 = 0;
            label_22:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_14;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_11 = new System.Action(object:  1033708944, method:  new IntPtr(1033679824));
            System.Delegate val_12 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_15 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_15 != 0)
            {
                    if(val_15 == null)
            {
                goto label_26;
            }
            
            }
            
            val_15 = 0;
            label_26:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_15;
            goto label_27;
            label_14:
            val_13 = "Snake: Minigame Mismatch";
            label_8:
            UnityEngine.Debug.LogError(message:  1029283920, context:  1033708944);
            this.inMinigameFramework = false;
            label_27:
            this.SetupCurrentLevel(level:  this._snakePlayerLevel);
            if(this.isPaused == true)
            {
                    this.isPaused = 1;
            }
            
            this.uiController.UpdateUI(paused:  true, currLevel:  this._snakePlayerLevel, currObjs:  this._snakeObjectivesCount, reqObjs:  this._snakeObjectivesReq);
        }
        private void OnRestartFromCheckpoint()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this._snakePlayerLevel = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            this.SetupCurrentLevel(level:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60);
            if(this.isPaused == true)
            {
                    this.isPaused = 1;
            }
            
            this.uiController.UpdateUI(paused:  true, currLevel:  this._snakePlayerLevel, currObjs:  this._snakeObjectivesCount, reqObjs:  this._snakeObjectivesReq);
        }
        private void SetupCurrentLevel(int level)
        {
            this.isPaused = true;
            this._snakeObjectivesCount = 0;
            this._snakeObjectivesReq = UnityEngine.Mathf.Min(a:  20, b:  level + 3);
        }
        private void Update()
        {
        
        }
        public void HACK_InstantWin()
        {
            this._snakeObjectivesCount = this._snakeObjectivesReq;
            this.HandleCollectedObjective();
        }
        public void HandleCollectedObjective()
        {
            int val_6;
            int val_7;
            int val_8;
            val_6 = this._snakeObjectivesReq;
            val_7 = this._snakeObjectivesCount + 1;
            this._snakeObjectivesCount = val_7;
            if(val_7 < val_6)
            {
                goto label_1;
            }
            
            if(this.inMinigameFramework != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                bool val_2 = HandleLevelComplete();
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
            {
                goto label_7;
            }
            
            }
            else
            {
                    val_8 = this._snakePlayerLevel + 1;
            }
            
            label_7:
            this._snakePlayerLevel = val_8;
            this.SetupCurrentLevel(level:  val_8);
            val_7 = this._snakeObjectivesCount;
            val_6 = this._snakeObjectivesReq;
            label_1:
            if(this.isPaused == true)
            {
                    this.isPaused = 1;
            }
            
            this.uiController.UpdateUI(paused:  true, currLevel:  this._snakePlayerLevel, currObjs:  val_7, reqObjs:  val_6);
        }
        public void HandleFailed()
        {
            this.isPaused = true;
            if(this.inMinigameFramework != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                bool val_2 = HandleLevelFailed();
            }
            else
            {
                    int val_3 = this._snakePlayerLevel - 1;
                this._snakePlayerLevel = val_3;
                this.SetupCurrentLevel(level:  val_3);
            }
            
            if(this.isPaused == true)
            {
                    this.isPaused = 1;
            }
            
            this.uiController.UpdateUI(paused:  true, currLevel:  this._snakePlayerLevel, currObjs:  this._snakeObjectivesCount, reqObjs:  this._snakeObjectivesReq);
        }
        public void OnPauseInput()
        {
            this.isPaused = this.isPaused ^ 1;
            this.uiController.UpdateUI(paused:  true, currLevel:  this._snakePlayerLevel, currObjs:  this._snakeObjectivesCount, reqObjs:  this._snakeObjectivesReq);
        }
        public SnakeGameManager()
        {
            this.isPaused = true;
            this._snakeObjectivesReq = 3;
        }
    
    }

}
