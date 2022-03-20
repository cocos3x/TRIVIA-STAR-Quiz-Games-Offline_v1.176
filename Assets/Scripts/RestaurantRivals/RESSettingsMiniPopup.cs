using UnityEngine;

namespace RestaurantRivals
{
    public class RESSettingsMiniPopup : WGSettingsMiniPopup
    {
        // Methods
        protected override void LoadToggleButtons()
        {
            UnityEngine.GameObject val_1 = PrefabLoader.LoadPrefab(featureName:  50272352, prefabName:  50272240);
            if(50272352 != 0)
            {
                    object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  50272352, parent:  R6);
            }
            
            UnityEngine.GameObject val_4 = PrefabLoader.LoadPrefab(featureName:  50272352, prefabName:  50276544);
            if(50272352 != 0)
            {
                    object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  50272352, parent:  R6);
            }
            
            UnityEngine.GameObject val_7 = PrefabLoader.LoadPrefab(featureName:  50272352, prefabName:  644609936);
            if(50272352 != 0)
            {
                    object val_9 = UnityEngine.Object.Instantiate<System.Object>(original:  50272352, parent:  R6);
            }
            
            UnityEngine.GameObject val_10 = PrefabLoader.LoadPrefab(featureName:  50272352, prefabName:  644610080);
            if(50272352 == 0)
            {
                    return;
            }
            
            object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  50272352, parent:  "Settings");
        }
        public RESSettingsMiniPopup()
        {
        
        }
    
    }

}
