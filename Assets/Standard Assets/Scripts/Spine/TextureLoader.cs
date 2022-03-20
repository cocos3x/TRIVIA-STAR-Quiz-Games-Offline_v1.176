using UnityEngine;

namespace Spine
{
    public interface TextureLoader
    {
        // Methods
        public abstract void Load(Spine.AtlasPage page, string path); // 0
        public abstract void Unload(object texture); // 0
    
    }

}
