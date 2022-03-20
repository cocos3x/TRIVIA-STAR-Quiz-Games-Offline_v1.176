using UnityEngine;

namespace SLC.Minigames.Whack
{
    public class WhackLevel
    {
        // Fields
        public int levelIndex;
        public System.Collections.Generic.List<SLC.Minigames.Whack.WhackWord> whackWords;
        public const float timerPercentage = 0.9975852;
        
        // Properties
        public float TimeRemaining { get; }
        
        // Methods
        public float get_TimeRemaining()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_2 = 5f;
            val_2 = 1065312703 * val_2;
            return (float)val_2;
        }
        public void SaveRemainingTimer()
        {
        
        }
        public WhackLevel(int index, System.Collections.Generic.List<object> words)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4;
            var val_5;
            this.levelIndex = index;
            val_4 = null;
            val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.whackWords = val_4;
            val_5 = 4;
            goto label_1;
            label_9:
            if(val_4 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = 2621443;
            bool val_2 = System.String.IsNullOrEmpty(value:  2621443);
            if(val_2 != true)
            {
                    val_4 = this.whackWords;
                if(val_2 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                new System.Object() = new System.Object() >> 5;
                typeof(SLC.Minigames.Whack.WhackWord).__il2cppRuntimeField_C = new System.Object();
                typeof(SLC.Minigames.Whack.WhackWord).__il2cppRuntimeField_8 = 2621443;
                val_4.Add(item:  452874240);
            }
            
            val_5 = 5;
            label_1:
            if((val_5 - 4) < val_4)
            {
                goto label_9;
            }
        
        }
        public override string ToString()
        {
            string val_1 = MiniJSON.Json.Serialize(obj:  this.whackWords);
            string val_2 = System.String.Format(format:  1002705232, arg0:  13152256, arg1:  this.whackWords);
        }
    
    }

}
