using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIUnlockableUICollections : WGUnlockableUIElement
    {
        // Properties
        protected override bool FeatureHidden { get; }
        protected override bool FeatureLocked { get; }
        protected override int UnlockLevel { get; }
        
        // Methods
        protected override bool get_FeatureHidden()
        {
            goto typeof(SLC.MatchyPics.MPIUnlockableUICollections).__il2cppRuntimeField_FC;
        }
        protected override bool get_FeatureLocked()
        {
            GameBehavior val_1 = App.getBehavior;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(0 < UnlockLevel)
            {
                    0 = 1;
            }
            
            return true;
        }
        protected override int get_UnlockLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance()) != 0)
            {
                    return UnlockLevel;
            }
            
            return UnlockLevel;
        }
        protected override void OnClickUnlocked()
        {
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        protected override void OnClickLocked()
        {
        
        }
        public MPIUnlockableUICollections()
        {
        
        }
    
    }

}
