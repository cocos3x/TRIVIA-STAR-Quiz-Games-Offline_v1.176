using UnityEngine;

namespace Spine.Unity
{
    public class SpineSlot : SpineAttributeBase
    {
        // Fields
        public bool containsBoundingBoxes;
        
        // Methods
        public SpineSlot(string startsWith = "", string dataField = "", bool containsBoundingBoxes = False, bool includeNone = True)
        {
            mem[1152921510920205724] = dataField;
            mem[1152921510920205728] = startsWith;
            this.containsBoundingBoxes = containsBoundingBoxes;
            mem[1152921510920205732] = includeNone;
        }
    
    }

}
