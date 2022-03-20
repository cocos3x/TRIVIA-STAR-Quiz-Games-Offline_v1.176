using UnityEngine;

namespace Spine.Unity
{
    public class MaterialsTextureLoader : TextureLoader
    {
        // Fields
        private Spine.Unity.AtlasAsset atlasAsset;
        
        // Methods
        public MaterialsTextureLoader(Spine.Unity.AtlasAsset atlasAsset)
        {
            this.atlasAsset = atlasAsset;
        }
        public void Load(Spine.AtlasPage page, string path)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_14 = 0;
            string val_1 = System.IO.Path.GetFileNameWithoutExtension(path:  path);
            label_13:
            if(val_14 >= path)
            {
                goto label_5;
            }
            
            UnityEngine.Texture val_2 = 1152921506951554528.mainTexture;
            if((-1950259744) == 0)
            {
                goto label_11;
            }
            
            UnityEngine.Texture val_4 = 1152921506951554528.mainTexture;
            string val_5 = 1152921506951554528.name;
            val_14 = val_14 + 1;
            if((System.String.op_Equality(a:  -1950259744, b:  path)) == false)
            {
                goto label_13;
            }
            
            goto label_14;
            label_5:
            val_15 = 0;
            label_14:
            if(0 != 0)
            {
                goto label_17;
            }
            
            val_16 = 0;
            string val_8 = this.atlasAsset.name;
            string val_9 = 1976783600 + path + 1976783728 + this.atlasAsset;
            val_17 = "Material with texture name \"";
            val_18 = this.atlasAsset;
            goto label_21;
            label_11:
            string val_10 = 1152921506951554528.name;
            string val_11 = 1976783856 + -1950259744(-1950259744);
            val_17 = "Material is missing texture: ";
            val_18 = 1152921506951554528;
            label_21:
            UnityEngine.Debug.LogError(message:  1976783856, context:  -1950259744);
            return;
            label_17:
            if(page != 0)
            {
                    mem2[0] = val_15;
            }
            else
            {
                    mem[32] = val_15;
            }
            
            if((page + 36) != 0)
            {
                    page + 36 = mem[page + 40];
                page + 36 = page + 40;
                return;
            }
            
            UnityEngine.Texture val_12 = val_15.mainTexture;
            mem2[0] = val_15;
            UnityEngine.Texture val_13 = val_15.mainTexture;
            mem2[0] = val_15;
        }
        public void Unload(object texture)
        {
        
        }
    
    }

}
