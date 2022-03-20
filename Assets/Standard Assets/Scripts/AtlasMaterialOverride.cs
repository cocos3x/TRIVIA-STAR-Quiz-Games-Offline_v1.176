using UnityEngine;
[Serializable]
public struct SkeletonRendererCustomMaterials.AtlasMaterialOverride : IEquatable<Spine.Unity.Modules.SkeletonRendererCustomMaterials.AtlasMaterialOverride>
{
    // Fields
    public bool overrideDisabled;
    public UnityEngine.Material originalMaterial;
    public UnityEngine.Material replacementMaterial;
    
    // Methods
    public bool Equals(Spine.Unity.Modules.SkeletonRendererCustomMaterials.AtlasMaterialOverride other)
    {
        bool val_2 = other.overrideDisabled;
        if(((int)val_2 & 255) != 0)
        {
                (int)val_2 & 255 = 1;
        }
        
        if(1 == 0)
        {
                return false;
        }
        
        val_2 = this.originalMaterial;
        if(val_2 != other.originalMaterial)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Equality(x:  this.replacementMaterial, y:  other.replacementMaterial);
    }

}
