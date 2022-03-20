using UnityEngine;

namespace RestaurantRivals
{
    public class SpritePairCollection : MonoBehaviour
    {
        // Fields
        private RestaurantRivals.SpritePair[] spritePairs;
        
        // Properties
        public System.Collections.ObjectModel.ReadOnlyCollection<RestaurantRivals.SpritePair> SpritePairs { get; }
        
        // Methods
        public System.Collections.ObjectModel.ReadOnlyCollection<RestaurantRivals.SpritePair> get_SpritePairs()
        {
            return System.Array.AsReadOnly<System.Reflection.CustomAttributeData>(array:  this.spritePairs);
        }
        public SpritePairCollection()
        {
        
        }
    
    }

}
