using UnityEngine;

namespace BlockPuzzleMagic
{
    public class PowerupBombShapeInfo : GridPlaceableShapeInfo
    {
        // Fields
        public const int SHAPE_ID = -100;
        
        // Methods
        protected override void Awake()
        {
            mem[1152921514473185788] = 99;
            this.Awake();
        }
        public override bool CanResolveAction()
        {
            var val_5;
            var val_6;
            var val_7;
            if(true != 0)
            {
                    val_5 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance();
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_6 = 0;
                return (bool)CanUsePowerup(powerupType:  1, showStoreIfOOC:  false, oocDelay:  null);
            }
            
            bool val_2 = System.String.op_Equality(a:  "shpsrc_shp_spwn", b:  1235593280);
            if("shpsrc_shp_spwn" > 0)
            {
                    val_7 = 1;
            }
            
            if("shpsrc_shp_spwn" < 1)
            {
                    0 = 1;
            }
            
            if("shpsrc_shp_spwn" != 1)
            {
                    return (bool)CanUsePowerup(powerupType:  1, showStoreIfOOC:  false, oocDelay:  null);
            }
            
            val_5 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = 1;
            return (bool)CanUsePowerup(powerupType:  1, showStoreIfOOC:  false, oocDelay:  null);
        }
        public override void ResolveAction()
        {
            var val_5;
            if(true != 0)
            {
                    return;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateGoalProgress(clearedBlocks:  R6, skipRowColumnCheck:  true);
            val_5 = 0;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UsePowerup(powerupType:  1, freeUsage:  System.String.op_Equality(a:  "shpsrc_shp_spwn", b:  1235593280));
        }
        public PowerupBombShapeInfo()
        {
        
        }
    
    }

}
