using UnityEngine;

namespace RestaurantRivals
{
    public class RandomSprite : MonoBehaviour
    {
        // Fields
        private RestaurantRivals.SpriteCollection source;
        private UnityEngine.UI.Image target;
        
        // Methods
        private void Awake()
        {
            this.Randomize();
        }
        private void Randomize()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Sprite> val_1 = this.source.Sprites;
            if(this.source == 0)
            {
                    return;
            }
            
            val_6 = 0;
            val_7 = 0;
            val_6 = val_6 + 1;
            val_7 = (uint)val_6 & 65535;
            val_8 = this.source;
            if(this.source == 0)
            {
                    return;
            }
            
            val_6 = 0;
            val_6 = val_6 + 1;
            val_9 = this.source;
            val_10 = 0;
            int val_4 = UnityEngine.Random.Range(min:  0, max:  this.source);
            val_6 = 0;
            val_10 = val_10 + 1;
            val_6 = (uint)val_10 & 65535;
            val_11 = this.source;
            this.target.sprite = this.source;
            if(this.target == 0)
            {
                
            }
        
        }
        public RandomSprite()
        {
        
        }
    
    }

}
