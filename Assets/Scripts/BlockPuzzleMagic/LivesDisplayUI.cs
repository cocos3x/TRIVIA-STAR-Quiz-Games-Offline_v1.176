using UnityEngine;

namespace BlockPuzzleMagic
{
    public class LivesDisplayUI : FrameSkipper
    {
        // Fields
        protected UnityEngine.UI.Text livesCounter;
        protected UnityEngine.UI.Text livesCooldownTimer;
        protected System.TimeSpan timerCooldownInterval;
        
        // Methods
        protected virtual void Start()
        {
            System.TimeSpan val_5;
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            var val_2 = 0 + 1404;
            System.TimeSpan val_3 = System.TimeSpan.FromMinutes(value:  null);
            this.timerCooldownInterval = val_5;
            mem[1152921514472721412] = 10;
        }
        protected void SetupUpdateLogic()
        {
            mem[1152921514472833412] = 10;
            goto typeof(BlockPuzzleMagic.LivesDisplayUI).__il2cppRuntimeField_DC;
        }
        protected override void UpdateLogic()
        {
            ulong val_11;
            long val_17;
            var val_23 = this;
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            string val_2 = 284.ToString();
            BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
            if(0.IsLivesMaxed() == false)
            {
                goto label_4;
            }
            
            string val_5 = Localization.Localize(key:  2128646960, defaultValue:  2128646880, useSingularKey:  false);
            if(this.livesCooldownTimer != 0)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            }
            
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            label_4:
            BestBlocksPlayer val_6 = BestBlocksPlayer.Instance;
            if(0.RefreshPlayerLives() != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                SaveGame();
            }
            
            System.DateTime val_9 = DateTimeCheat.UtcNow;
            BestBlocksPlayer val_10 = BestBlocksPlayer.Instance;
            System.TimeSpan val_13 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514472941608}, d2:  new System.DateTime() {dateData = val_11});
            System.TimeSpan val_16 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = 1152921514472941600}, t2:  new System.TimeSpan() {_ticks = R4 + 40});
            string val_19 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_17}, formatted:  true);
            var val_20 = FP - 24;
        }
        public LivesDisplayUI()
        {
        
        }
    
    }

}
