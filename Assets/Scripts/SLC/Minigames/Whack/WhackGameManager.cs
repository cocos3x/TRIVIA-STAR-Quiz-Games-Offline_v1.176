using UnityEngine;

namespace SLC.Minigames.Whack
{
    public class WhackGameManager : MonoSingleton<SLC.Minigames.Whack.WhackGameManager>
    {
        // Fields
        public const int PLAYERLIFE_TOTALNUM = 3;
        public const string PLAYERLIFEKEY = "whack_player_life";
        private int _livesUsed;
        private SLC.Minigames.Whack.WhackLevel currentLevel;
        
        // Properties
        public int PlayerLife { get; set; }
        
        // Methods
        public int get_PlayerLife()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  1003061952, defaultValue:  3);
        }
        public void set_PlayerLife(int value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  1003061952, value:  value);
        }
        public override void InitMonoSingleton()
        {
            var val_13;
            var val_14;
            SLC.Minigames.Whack.WhackDataParser.Initialize();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  1003314160, method:  new IntPtr(1003286064));
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = null;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = new System.Action(object:  1003314160, method:  new IntPtr(1003287088));
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = new System.Action(object:  1003314160, method:  new IntPtr(1003287088));
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  1003314160, method:  new IntPtr(1003288112));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78, b:  7401472);
            val_13 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78;
            if(val_13 != 0)
            {
                    if(val_13 == null)
            {
                goto label_11;
            }
            
            }
            
            val_13 = 0;
            label_11:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78 = val_13;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_11 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1003314160, method:  new IntPtr(1003289136));
            System.Delegate val_12 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74, b:  7401472);
            val_14 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74;
            if(val_14 != 0)
            {
                    if(val_14 == null)
            {
                goto label_15;
            }
            
            }
            
            val_14 = 0;
            label_15:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74 = val_14;
        }
        private void Instance_OnInjectTracking(System.Collections.Generic.Dictionary<string, object> obj)
        {
            obj.Add(key:  -487709536, value:  13152256);
        }
        private void TogglePopupWindow(bool showing)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HideUIForPopup(showingPopup:  showing);
        }
        public int GetCurrentLevelIndex()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
            {
                    return (int)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            }
            
            return (int)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
        }
        public void ItemClicked(SLC.Minigames.Whack.WhackItem item)
        {
            if(item.wordDefinition == 0)
            {
                    return;
            }
            
            if(item.wordDefinition.incorrect != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.Collections.IEnumerator val_2 = displayResult(item:  item, won:  true);
                UnityEngine.Coroutine val_3 = StartCoroutine(routine:  -849013632);
                return;
            }
            
            this.LevelFailed(itemClicked:  item);
        }
        public void LevelFailed(SLC.Minigames.Whack.WhackItem itemClicked)
        {
            int val_9 = this._livesUsed;
            val_9 = val_9 + 1;
            this._livesUsed = val_9;
            int val_1 = val_9.PlayerLife;
            val_1.PlayerLife = val_1 - 1;
            if(itemClicked != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                35639336 = public static SLC.Minigames.Whack.WhackUIController MonoSingleton<SLC.Minigames.Whack.WhackUIController>::get_Instance();
                System.Collections.IEnumerator val_5 = displayResult(item:  itemClicked, won:  false);
                UnityEngine.Coroutine val_6 = StartCoroutine(routine:  -849013632);
            }
            
            DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  1003903856, method:  new IntPtr(1003878832));
            DG.Tweening.Tween val_8 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1069547520, ignoreTimeScale:  false);
        }
        private void Start()
        {
            this.ResetLevel(firstLevel:  true);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StartMusic(clipIndex:  0);
        }
        private void RestartGame()
        {
            this.ResetLevel(firstLevel:  true);
        }
        private void ContinueGame()
        {
            this.ResetLevel(firstLevel:  false);
        }
        private void ResetLevel(bool firstLevel)
        {
            if(firstLevel == true)
            {
                    true = 0;
                this._livesUsed = true;
            }
            
            SLC.Minigames.Whack.WhackLevel val_1 = SLC.Minigames.Whack.WhackDataParser.GetWhackLevel();
            this.currentLevel = null;
            PluginExtension.Shuffle<UnityEngine.Sprite>(list:  -444210816, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Initialize(level:  this.currentLevel);
        }
        private void OnCheckPointReached()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
        }
        public void CheckCheckpoint()
        {
            DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  1004590192, method:  new IntPtr(1004565168));
            DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1069547520, ignoreTimeScale:  false);
        }
        public WhackGameManager()
        {
        
        }
        private void <LevelFailed>b__12_0()
        {
            if(this.PlayerLife != 0)
            {
                    this.ResetLevel(firstLevel:  false);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_3 = HandleLevelFailed();
        }
        private void <CheckCheckpoint>b__18_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = HandleLevelComplete();
            if(val_2 != false)
            {
                    val_2.OnCheckPointReached();
                return;
            }
            
            this.ResetLevel(firstLevel:  false);
        }
    
    }

}
