using UnityEngine;

namespace SLC.Minigames.EmojiMatch
{
    public class EmojiMatchController : MonoSingleton<SLC.Minigames.EmojiMatch.EmojiMatchController>
    {
        // Fields
        private UnityEngine.TextAsset pairData;
        public const string SHARED_EMOJI_LOOKUP = "SharedEmoji";
        public const string NUM_PAIRS = "Pairs";
        public const string PHRASE_KEY_PREFIX = "Phrase";
        public const string EMOJI_KEY_PREFIX = "Emoji";
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> levelData;
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> usedData;
        private int lives;
        
        // Properties
        public int CurrentLives { get; }
        public float getLevelDuration { get; }
        
        // Methods
        public int get_CurrentLives()
        {
            return (int)this.lives;
        }
        public override void InitMonoSingleton()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            this.ParseData();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BuildEmojiLookup();
            val_13 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_5 = new System.Action(object:  1084358048, method:  new IntPtr(1084333024));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_14 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_14 != 0)
            {
                    if(val_14 == null)
            {
                goto label_14;
            }
            
            }
            
            val_14 = 0;
            label_14:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_14;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_8 = new System.Action(object:  1084358048, method:  new IntPtr(1084333024));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
            val_15 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_15 != 0)
            {
                    if(val_15 == null)
            {
                goto label_18;
            }
            
            }
            
            val_15 = 0;
            label_18:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_15;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_11 = new System.Action(object:  1084358048, method:  new IntPtr(1084333024));
            System.Delegate val_12 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C, b:  7454720);
            val_16 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C;
            if(val_16 != 0)
            {
                    if(val_16 == null)
            {
                goto label_22;
            }
            
            }
            
            val_16 = 0;
            label_22:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = val_16;
        }
        private void Update()
        {
        
        }
        private void ParseData()
        {
            var val_7;
            string val_1 = this.pairData.text;
            object val_2 = MiniJSON.Json.Deserialize(json:  this.pairData);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.levelData = null;
            val_7 = 0;
            List.Enumerator<T> val_4 = GetEnumerator();
            label_13:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            this.levelData.Add(item:  0);
            goto label_13;
            label_8:
            Dispose();
        }
        public System.Collections.Generic.Dictionary<string, object> getLevel()
        {
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_4;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  0);
            if(val_1 <= val_1)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (val_1 << 2);
            bool val_2 = this.levelData.Remove(item:  (0 + (val_1) << 2) + 16);
            this.usedData.Add(item:  (0 + (val_1) << 2) + 16);
            val_4 = this.usedData;
            if(this.usedData < 100)
            {
                    return;
            }
            
            if(this.usedData == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = 2621443;
            bool val_3 = this.usedData.Remove(item:  2621443);
            this.levelData.Add(item:  2621443);
        }
        public float get_getLevelDuration()
        {
            var val_8;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                    val_8 = UnityEngine.Random.Range(min:  0, max:  400);
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            }
            
            float val_8 = -2f;
            val_8 = ((float)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60) + val_8;
            float val_9 = 5f;
            val_9 = 1065322376 * val_9;
            return (float)val_9;
        }
        private void OnRestartMinigame()
        {
            this.lives = 3;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnpauseForRestart();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GetAndDisplayLevel();
        }
        public bool ShouldReset()
        {
            var val_5;
            int val_5 = this.lives;
            val_5 = val_5 - 1;
            this.lives = val_5;
            val_5 = 1;
            if(val_5 > 0)
            {
                    return (bool)val_5;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  -1745297776)) == false)
            {
                    return (bool)val_5;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = 0;
            bool val_4 = HandleLevelFailed();
            return (bool)val_5;
        }
        public void PauseHack()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.EmojiMatch.EmojiMatchUIController MonoSingleton<SLC.Minigames.EmojiMatch.EmojiMatchUIController>::get_Instance().__il2cppRuntimeField_C = 1036831949;
        }
        public void StopTimerHack()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.EmojiMatch.EmojiMatchUIController MonoSingleton<SLC.Minigames.EmojiMatch.EmojiMatchUIController>::get_Instance().__il2cppRuntimeField_C = 0;
        }
        public void ResumeTimerHack()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.EmojiMatch.EmojiMatchUIController MonoSingleton<SLC.Minigames.EmojiMatch.EmojiMatchUIController>::get_Instance().__il2cppRuntimeField_C = 1065353216;
        }
        public EmojiMatchController()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.usedData = null;
            this.lives = 3;
        }
    
    }

}
