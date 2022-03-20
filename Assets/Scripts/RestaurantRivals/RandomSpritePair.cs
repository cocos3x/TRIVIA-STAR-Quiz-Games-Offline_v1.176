using UnityEngine;

namespace RestaurantRivals
{
    public class RandomSpritePair : MonoBehaviour
    {
        // Fields
        private RestaurantRivals.SpritePairCollection source;
        private UnityEngine.UI.Image target1;
        private UnityEngine.UI.Image target2;
        
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
            System.Collections.ObjectModel.ReadOnlyCollection<RestaurantRivals.SpritePair> val_1 = this.source.SpritePairs;
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
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_9 = this.source;
            var val_7 = 0;
            int val_4 = UnityEngine.Random.Range(min:  0, max:  this.source);
            val_7 = val_7 + 1;
            val_10 = this.source;
            this.target1.sprite = 0;
            this.target2.sprite = this.source.spritePairs;
            if(this.target2 == 0)
            {
                
            }
        
        }
        public RandomSpritePair()
        {
        
        }
    
    }

}
