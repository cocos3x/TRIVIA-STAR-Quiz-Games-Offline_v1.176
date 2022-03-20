using UnityEngine;

namespace RestaurantRivals
{
    public class ScaleRestaurantForAd : MonoBehaviour
    {
        // Fields
        private UnityEngine.RectTransform chainedRegion;
        private UnityEngine.UI.LayoutElement layoutElement;
        private UnityEngine.Vector3 adOffScale;
        private UnityEngine.Vector3 adOnScale;
        
        // Methods
        private void OnEnable()
        {
            if(this.chainedRegion == 0)
            {
                    return;
            }
            
            this.chainedRegion.localScale = new UnityEngine.Vector3() {x = mem[this.adOnScale + (0)], y = mem[this.adOnScale + (4)], z = mem[this.adOnScale + (8)]};
            UnityEngine.Vector2 val_2 = offsetMin;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.y);
            this.chainedRegion.offsetMin = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        private void OnDisable()
        {
            if(this.chainedRegion == 0)
            {
                    return;
            }
            
            this.chainedRegion.localScale = new UnityEngine.Vector3() {x = mem[this.adOffScale + (0)], y = mem[this.adOffScale + (4)], z = mem[this.adOffScale + (8)]};
            UnityEngine.Vector2 val_2 = offsetMin;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.y);
            this.chainedRegion.offsetMin = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public ScaleRestaurantForAd()
        {
        
        }
    
    }

}
