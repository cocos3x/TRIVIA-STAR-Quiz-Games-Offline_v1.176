using UnityEngine;

namespace WordForest
{
    public class WFODynamicBackground : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.RawImage backgroundImage;
        private System.Collections.Generic.List<UnityEngine.Texture> backgroundTextures;
        
        // Methods
        private void Start()
        {
            this.SetCurrentForestBackground();
        }
        public void SetCurrentForestBackground()
        {
            UnityEngine.Texture val_3;
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = mem[R1 + 16];
            val_3 = R1 + 16;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOBackgroundType val_2 = CurrentBGType;
            if(1152921511771698687 >= (public static WordForest.WFOForestManager MonoSingleton<WordForest.WFOForestManager>::get_Instance()))
            {
                    if(1152921511771698687 <= (public static WordForest.WFOForestManager MonoSingleton<WordForest.WFOForestManager>::get_Instance()))
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 2889603072;
                val_3 = mem[(0 + 2889603072) + 16];
                val_3 = (0 + 2889603072) + 16;
            }
            
            this.backgroundImage.texture = val_3;
        }
        public WFODynamicBackground()
        {
        
        }
    
    }

}
