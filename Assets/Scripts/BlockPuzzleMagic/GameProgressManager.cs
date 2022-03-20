using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GameProgressManager : MonoSingleton<BlockPuzzleMagic.GameProgressManager>
    {
        // Fields
        private const string PREFKEY_SAVEDGAMELEVEL_ZEN = "bbl_savedlevel_zen";
        private const string PREFKEY_SAVEDGAMELEVEL_CHALLENGE = "bbl_savedlevel";
        
        // Methods
        public override void InitMonoSingleton()
        {
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  1248366176, method:  new IntPtr(1248340128));
            UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  162459648);
            this.InitMonoSingleton();
        }
        private void OnScreenSwitched(UnityEngine.SceneManagement.Scene outgoingScene, UnityEngine.SceneManagement.Scene incomingScene)
        {
            var val_11;
            var val_12;
            var val_13;
            float val_14;
            System.Action<System.Boolean> val_15;
            System.Delegate val_16;
            var val_17;
            GameBehavior val_1 = App.getBehavior;
            val_11 = 1152921504901095424;
            if(0 == 2)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_12 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance();
                val_13 = val_12;
                val_14 = 1152921504614248448;
                val_15 = null;
                val_15 = new System.Action<System.Boolean>(object:  1248479200, method:  new IntPtr(1248454176));
                val_16 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38;
                System.Delegate val_5 = System.Delegate.Combine(a:  val_16, b:  7401472);
            }
            else
            {
                    val_15 = 1152921511020107712;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(2118293440 == 0)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_12 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance();
                val_13 = val_12;
                val_14 = 1152921504614248448;
                val_15 = null;
                val_15 = new System.Action<System.Boolean>(object:  1248479200, method:  new IntPtr(1248454176));
                val_16 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38;
                System.Delegate val_10 = System.Delegate.Remove(source:  val_16, value:  7401472);
            }
            
            val_17 = val_16;
            if(val_17 != 0)
            {
                    if(val_17 == val_14)
            {
                goto label_20;
            }
            
            }
            
            val_17 = 0;
            label_20:
            mem[1152921511020107768] = val_17;
        }
        private string GetPrefKeyForMode(BlockPuzzleMagic.GameMode mode)
        {
            if(mode == 1)
            {
                    return;
            }
            
            if(mode != 2)
            {
                    "bbl_savedlevel" = 0;
            }
        
        }
        public bool HasSavedGame(BlockPuzzleMagic.GameMode gameMode)
        {
            var val_1;
            if(gameMode == 1)
            {
                    val_1 = "bbl_savedlevel_zen";
                return UnityEngine.PlayerPrefs.HasKey(key:  null);
            }
            
            if(gameMode != 2)
            {
                    val_1 = 0;
            }
            
            return UnityEngine.PlayerPrefs.HasKey(key:  null);
        }
        public BlockPuzzleMagic.Level LoadSavedGame(BlockPuzzleMagic.GameMode gameMode)
        {
            var val_3;
            if(gameMode == 1)
            {
                    val_3 = "bbl_savedlevel_zen";
            }
            else
            {
                    if(gameMode != 2)
            {
                    val_3 = 0;
            }
            
            }
            
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  null, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  null)) == false)
            {
                    return BlockPuzzleMagic.Level.Parse(_jsonString:  null);
            }
        
        }
        private void OnApplicationPause(bool pause)
        {
            if(pause == false)
            {
                    return;
            }
            
            this.SaveGame();
        }
        public void SaveGame()
        {
            var val_7;
            var val_8;
            val_7 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2118293440 != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14) != 0)
            {
                    val_7 = mem[public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 8];
                val_7 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 8;
            }
            
                if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14) == 0)
            {
                    val_7 = 0;
            }
            
                if(val_7 == 1)
            {
                    val_8 = "bbl_savedlevel_zen";
            }
            else
            {
                    if(val_7 != 2)
            {
                    val_8 = 0;
            }
            
            }
            
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.PlayerPrefs.SetString(key:  null, value:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14);
            }
            
            Player val_6 = App.Player;
            0.SaveState();
        }
        public void ClearProgress(BlockPuzzleMagic.GameMode gameMode)
        {
            var val_4;
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            1919184449.Clear();
            BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
            var val_4 = 21979228;
            mem[324] = 0;
            val_4 = 13660856 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            if(gameMode == 1)
            {
                    val_4 = "bbl_savedlevel_zen";
            }
            else
            {
                    if(gameMode != 2)
            {
                    val_4 = 0;
            }
            
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  null);
            Player val_3 = App.Player;
            0.SaveState();
        }
        private void OnGameOver(bool success)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(success != false)
            {
                    Player val_3 = App.Player;
                mem[340] = 0;
                this.TrackLevelComplete(gameMode:  2);
                this.AdvanceLevelLogic();
                this.ClearProgress(gameMode:  2);
                return;
            }
            
            Player val_4 = App.Player;
            mem[340] = 1;
            this.SaveGame();
        }
        private void AdvanceLevelLogic()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            if(0.IsFTUXGameLevels() == false)
            {
                goto label_2;
            }
            
            val_13 = null;
            val_13 = null;
            if(BlockPuzzleMagic.BBLFtuxData.PlayerFtuxLevel >= BlockPuzzleMagic.BBLFtuxData.MaxFtuxLevel)
            {
                goto label_5;
            }
            
            val_14 = null;
            val_14 = null;
            int val_14 = BlockPuzzleMagic.BBLFtuxData.PlayerFtuxLevel;
            val_14 = val_14 + 1;
            BlockPuzzleMagic.BBLFtuxData.PlayerFtuxLevel = val_14;
            return;
            label_2:
            val_15 = 1152921504892043264;
            GameBehavior val_4 = App.getBehavior;
            var val_5 = 0 + 1;
            GameBehavior val_6 = App.getBehavior;
            if(0 >= 10)
            {
                    GameBehavior val_7 = App.getBehavior;
                if((-4294967290) != 0)
            {
                    return;
            }
            
            }
            
            var val_15 = 21950134;
            val_15 = 13675404 + val_15;
            if(val_15 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_16 = null;
            val_16 = null;
            val_17 = null;
            val_17 = null;
            GameBehavior val_8 = App.getBehavior;
            val_15 = 0;
            string val_9 = val_15.ToString();
            string val_10 = Events.LEVEL_REACHED + 2144339952 + 1249397172;
            App.trackerManager.track(eventName:  Events.LEVEL_REACHED);
            return;
            label_5:
            BestBlocksPlayer val_11 = BestBlocksPlayer.Instance;
            0.SetFtuxStatus(ftuxId:  1, completed:  true);
            BestBlocksPlayer val_12 = BestBlocksPlayer.Instance;
            0.SetFtuxStatus(ftuxId:  2, completed:  true);
            BestBlocksPlayer val_13 = BestBlocksPlayer.Instance;
            0.SetFtuxStatus(ftuxId:  3, completed:  true);
        }
        private void TrackLevelComplete(BlockPuzzleMagic.GameMode gameMode)
        {
            var val_14;
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            BlockPuzzleMagic.BestBlocksGameEcon val_2 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            int val_5 = BlockPuzzleMagic.LevelManager.GetChapterIdFromPlayerLevel(playerLevel:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 12);
            string val_6 = System.String.Format(format:  -1655001648, arg0:  13152256, arg1:  13152256);
            Add(key:  -2100706208, value:  -1655001648);
            if(6580591 > 0)
            {
                    0 = 1;
            }
            
            string val_7 = 1.ToString();
            Add(key:  1249501296, value:  1249515019);
            if(0.IsEasyMode() == true)
            {
                    "Default" = "Easy";
            }
            
            Add(key:  -2100062992, value:  1249501408);
            int val_9 = 0.GetPowerupAmountUsedThisLevel(powerupType:  0);
            Add(key:  1249501488, value:  13152256);
            int val_10 = 0.GetPowerupAmountUsedThisLevel(powerupType:  1);
            Add(key:  1249501600, value:  13152256);
            int val_11 = 0.GetPowerupAmountUsedThisLevel(powerupType:  2);
            Add(key:  1249501712, value:  13152256);
            int val_12 = EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Int32>(dic:  3748210, key:  gameMode, defaultValue:  0);
            Add(key:  1249501824, value:  13152256);
            bool val_13 = EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Boolean>(dic:  0, key:  gameMode, defaultValue:  false);
            Add(key:  1249502944, value:  8945664);
            var val_14 = 21950974;
            val_14 = 13674564 + val_14;
            if(val_14 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_14 = null;
            val_14 = null;
            App.trackerManager.track(eventName:  -1942299264, data:  78753792);
        }
        public void OnLevelClearClosed()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = ShowInterstitial(context:  2);
            GameBehavior val_3 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        public void OnChapterClearClosed()
        {
            var val_5;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = ShowInterstitial(context:  2);
            GameBehavior val_3 = App.getBehavior;
            val_5 = 2;
            goto mem[1179404171];
        }
        public GameProgressManager()
        {
        
        }
    
    }

}
