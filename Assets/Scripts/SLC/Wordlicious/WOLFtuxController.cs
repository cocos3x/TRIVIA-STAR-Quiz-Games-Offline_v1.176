using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLFtuxController : MonoSingleton<SLC.Wordlicious.WOLFtuxController>
    {
        // Fields
        private const string pref_ftux_finished = "wol_ftxu_finished";
        private const string key_basic_ftux_finished = "basic_ftux_finished";
        private const string key_tile_removed_ftux_finished = "tile_removed_ftux_finished";
        private const string key_random_letters_reward_ftux_finished = "random_letters_reward_ftux_finished";
        private const string key_extra_word_ftux_finished = "extra_word_ftux_finished";
        private bool isAllFtuxFinished;
        private bool isTileRemovedFtuxFinished;
        private bool isRandomLettersRewardFtuxFinished;
        private bool isExtraWordFtuxFinished;
        private bool isExtraWordFtuxStarted;
        public System.Action DefferedShowHint;
        
        // Methods
        private void Start()
        {
            var val_4;
            if(this.isExtraWordFtuxFinished != false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  699837648, method:  new IntPtr(699812624));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_54, b:  7401472);
            val_4 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_54;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_7;
            }
            
            }
            
            val_4 = 0;
            label_7:
            public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_54 = val_4;
        }
        public override void InitMonoSingleton()
        {
            this.InitMonoSingleton();
            this.LoadFtuxStatus();
        }
        public void CheckFTUX()
        {
            var val_20;
            if(this.isAllFtuxFinished != false)
            {
                    return;
            }
            
            Player val_1 = App.Player;
            if(0 == 1)
            {
                    twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
                ShowFtux(type:  0);
                return;
            }
            
            Player val_4 = App.Player;
            if(0 == 2)
            {
                    twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
                ShowFtux(type:  1);
            }
            
            Player val_7 = App.Player;
            GameEcon val_8 = App.getGameEcon;
            if((0 >= 18) && (SLC.Wordlicious.WOLHintButton.isFree != false))
            {
                    if(Prefs.HasUsedHint() != true)
            {
                    twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_12 = ShowUGUIMonolith<System.Object>(showNext:  false);
            }
            
            }
            
            if(this.isTileRemovedFtuxFinished != false)
            {
                    if(this.isRandomLettersRewardFtuxFinished == true)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(HasLongWordsInCurrentLevel() == false)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_16 = ShowUGUIMonolith<System.Object>(showNext:  false);
                ShowFtux(type:  4);
                this.isRandomLettersRewardFtuxFinished = true;
                if(this.isTileRemovedFtuxFinished == true)
            {
                    this.isAllFtuxFinished = true;
            }
            
                this.SaveFtuxStatus();
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Int32> val_18 = new System.Action<System.Int32>(object:  700065744, method:  new IntPtr(700040720));
            System.Delegate val_19 = System.Delegate.Combine(a:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_4C, b:  7401472);
            val_20 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_4C;
            if(val_20 != 0)
            {
                    if(val_20 == null)
            {
                goto label_43;
            }
            
            }
            
            val_20 = 0;
            label_43:
            public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_4C = val_20;
        }
        public void CompleteExtraWordFtux()
        {
            var val_4;
            this.isExtraWordFtuxFinished = true;
            this.isExtraWordFtuxStarted = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  700177744, method:  new IntPtr(699812624));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_54, value:  7401472);
            val_4 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_54;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_54 = val_4;
            this.SaveFtuxStatus();
        }
        public bool IsExtraWordFtuxInProgress()
        {
            if(this.isExtraWordFtuxStarted == false)
            {
                    this = 0;
            }
            
            if(this.isExtraWordFtuxStarted == true)
            {
                    this = 0;
            }
            
            if(this.isExtraWordFtuxStarted == true)
            {
                    this = 0;
            }
            
            return (bool)this;
        }
        public void SetupExtraWordRewardLetter(LineWord word, Cell letter)
        {
            Cell val_4;
            LineWord val_5;
            val_4 = letter;
            val_5 = word;
            if(new System.Object() != 0)
            {
                    typeof(WOLFtuxController.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = val_5;
                typeof(WOLFtuxController.<>c__DisplayClass16_0).__il2cppRuntimeField_C = val_4;
            }
            else
            {
                    mem[8] = val_5;
                val_5 = 12;
                mem[12] = val_4;
                val_4 = mem[12];
            }
            
            UnityEngine.Transform val_2 = letter + 16.transform;
            SLC.Wordlicious.WOLExtraWordFtuxWindow.TargetLetter = letter + 16;
            System.Action val_3 = new System.Action(object:  434929664, method:  new IntPtr(700385936));
            this.DefferedShowHint = null;
        }
        private void LoadFtuxStatus()
        {
            bool val_20;
            if((UnityEngine.PlayerPrefs.HasKey(key:  700507152)) == false)
            {
                    return;
            }
            
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  700507152);
            object val_3 = MiniJSON.Json.Deserialize(json:  700507152);
            if("wol_ftxu_finished" != 0)
            {
                    if(null == null)
            {
                goto label_28;
            }
            
            }
            
            label_28:
            if((0.ContainsKey(key:  700507264)) != false)
            {
                    string val_5 = 0.Item[700507264];
                val_20 = this.isAllFtuxFinished;
                bool val_7 = System.Boolean.TryParse(value:  null, result: out  val_20);
            }
            
            if((0.ContainsKey(key:  700507376)) != false)
            {
                    string val_9 = 0.Item[700507376];
                val_20 = this.isTileRemovedFtuxFinished;
                bool val_11 = System.Boolean.TryParse(value:  null, result: out  val_20);
            }
            
            if((0.ContainsKey(key:  700507504)) != false)
            {
                    string val_13 = 0.Item[700507504];
                val_20 = this.isRandomLettersRewardFtuxFinished;
                bool val_15 = System.Boolean.TryParse(value:  null, result: out  val_20);
            }
            
            if((0.ContainsKey(key:  700507648)) == false)
            {
                    return;
            }
            
            string val_17 = 0.Item[700507648];
            bool val_19 = System.Boolean.TryParse(value:  null, result: out  this.isExtraWordFtuxFinished);
        }
        private void SaveFtuxStatus()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  700507264, value:  8945664);
            Add(key:  700507376, value:  8945664);
            Add(key:  700507504, value:  8945664);
            Add(key:  700507648, value:  8945664);
            string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  700507152, value:  78753792);
            bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        }
        private void OnWolLetterTileRemoved(int count)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            ShowFtux(type:  3);
            this.isTileRemovedFtuxFinished = true;
            if(this.isRandomLettersRewardFtuxFinished == true)
            {
                    this.isAllFtuxFinished = true;
            }
            
            this.SaveFtuxStatus();
        }
        private void ShowExtraWordFTUX(string word)
        {
            this.isExtraWordFtuxStarted = true;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            ShowFtuxIntro(word:  null);
        }
        public WOLFtuxController()
        {
        
        }
    
    }

}
