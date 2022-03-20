using UnityEngine;

namespace Spine.Unity
{
    public static class SpineMesh
    {
        // Fields
        internal const UnityEngine.HideFlags MeshHideflags = 20;
        
        // Methods
        public static UnityEngine.Mesh NewMesh()
        {
            var val_2;
            UnityEngine.Mesh val_1 = null;
            val_2 = 0;
            val_1 = new UnityEngine.Mesh();
            if(val_1 != 0)
            {
                    MarkDynamic();
                name = 1981468384;
                val_2 = val_1;
            }
            else
            {
                    MarkDynamic();
                0.name = 1981468384;
            }
            
            val_2.hideFlags = 20;
        }
    
    }

}
