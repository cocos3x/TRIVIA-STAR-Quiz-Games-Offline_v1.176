using UnityEngine;

namespace Spine.Unity
{
    public class SpineAtlasRegion : PropertyAttribute
    {
        // Fields
        public string atlasAssetField;
        
        // Methods
        public SpineAtlasRegion(string atlasAssetField = "")
        {
            this.atlasAssetField = atlasAssetField;
        }
    
    }

}
