using UnityEngine;

namespace SLC.Minigames
{
    public class MinigameRankProgressBar : MonoBehaviour
    {
        // Fields
        private bool showTooltip;
        private bool showRankIcon;
        private bool showFlagInsteadOfIcon;
        private UnityEngine.UI.Image sliderImage;
        private UnityEngine.UI.Text tooltipContainer;
        private SLC.Minigames.MinigameRankSpriteDisplay rankSprite;
        private UnityEngine.RectTransform sliderRect;
        private UnityEngine.GameObject[] sliderTicks;
        private UnityEngine.UI.Image[] checkpointFlags;
        
        // Methods
        private void OnEnable()
        {
            var val_16;
            var val_17;
            UnityEngine.RectTransform val_18;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_2 = GetCurrentRank;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_4 = GetNextRank;
            UnityEngine.GameObject val_5 = this.rankSprite.gameObject;
            if(this.showRankIcon == true)
            {
                    this.showRankIcon = 1;
            }
            
            this.rankSprite.SetActive(value:  true);
            if(this.showRankIcon == true)
            {
                    this.showRankIcon = this;
                1 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance();
                this.SetupRankIcon(nextRank:  -1745297776);
            }
            
            val_16 = 0;
            if(this.tooltipContainer != 0)
            {
                    UnityEngine.Transform val_7 = this.tooltipContainer.transform;
                UnityEngine.Transform val_8 = this.tooltipContainer.parent;
                UnityEngine.GameObject val_9 = this.tooltipContainer.gameObject;
                if(this.showTooltip == true)
            {
                    this.showTooltip = 1;
            }
            
                val_16 = 0;
                this.tooltipContainer.SetActive(value:  true);
                if(this.showTooltip != false)
            {
                    val_16 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance();
                this.SetupTooltip(currentRank:  -1745297776, nextRank:  -1745297776);
            }
            
            }
            
            UnityEngine.Color val_10 = Color;
            this.sliderImage.color = new UnityEngine.Color() {a = ???};
            val_18 = this.sliderRect;
            bool val_11 = UnityEngine.Object.op_Inequality(x:  val_18, y:  0);
            if(val_11 != false)
            {
                    if(val_11 == true)
            {
                    val_11 = this;
                0 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance();
                this.SetupCheckpointTicks(rankData:  -1745297776);
            }
            
            }
            
            if(val_11 == 0)
            {
                    return;
            }
            
            val_17 = 0;
            goto label_23;
            label_33:
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_18 = this.checkpointFlags[val_17];
            int val_14 = (public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14.GetCheckpointsCompletedInRank()) - 1;
            UnityEngine.GameObject val_15 = val_18.gameObject;
            if(val_17 != val_14)
            {
                    0 = 0;
            }
            
            if(val_17 == val_14)
            {
                    0 = 1;
            }
            
            val_18.SetActive(value:  true);
            val_17 = 1;
            label_23:
            if(val_17 < val_18)
            {
                goto label_33;
            }
        
        }
        private void SetupCheckpointTicks(SLC.Minigames.MinigameLevelRank rankData)
        {
            var val_6;
            int val_1 = rankData.NumCheckpoints;
            UnityEngine.Rect val_2 = rect;
            float val_3 = width;
            val_6 = 4;
            goto label_3;
            label_12:
            if( <= this.sliderRect)
            {
                    float val_7 = 0f;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 16;
            float val_8 = val_7;
            val_8 = val_8 / 100f;
            val_8 = val_8 * (9.046445E+08f);
            UnityEngine.GameObject val_9 = this.sliderTicks[0];
            object val_4 = val_9.GetComponent<System.Object>();
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_7, y:  val_2.m_YMin);
            val_9.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            val_6 = 5;
            label_3:
            if((val_6 - 4) < val_9)
            {
                goto label_12;
            }
        
        }
        private void SetupRankIcon(SLC.Minigames.MinigameLevelRank nextRank)
        {
            if(this.showFlagInsteadOfIcon != false)
            {
                    this.rankSprite.OverrideRankWithFlag();
                return;
            }
            
            this.rankSprite.DisplaySprite(rank:  nextRank);
        }
        private void SetupTooltip(SLC.Minigames.MinigameLevelRank currentRank, SLC.Minigames.MinigameLevelRank nextRank)
        {
            decimal val_1 = new System.Decimal(value:  1000);
            string val_2 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = currentRank.percentPlayersComplete, hi = 1, lo = SL, mid = SB}, maxSigFigs:  3, round:  true, useColor:  true, maxValueWithoutAbbr:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, useRichText:  false, withSpaces:  false);
            string val_3 = System.String.Format(format:  904975376, arg0:  currentRank.percentPlayersComplete, arg1:  nextRank + 28);
            if(this.tooltipContainer != 0)
            {
                    return;
            }
        
        }
        public MinigameRankProgressBar()
        {
        
        }
    
    }

}
