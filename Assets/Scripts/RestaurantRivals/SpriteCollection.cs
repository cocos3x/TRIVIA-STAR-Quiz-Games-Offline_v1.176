using UnityEngine;

namespace RestaurantRivals
{
    public class SpriteCollection : MonoBehaviour
    {
        // Fields
        private UnityEngine.Sprite[] sprites;
        
        // Properties
        public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Sprite> Sprites { get; }
        
        // Methods
        public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Sprite> get_Sprites()
        {
            return System.Array.AsReadOnly<System.Reflection.CustomAttributeData>(array:  this.sprites);
        }
        public SpriteCollection()
        {
        
        }
    
    }

}
