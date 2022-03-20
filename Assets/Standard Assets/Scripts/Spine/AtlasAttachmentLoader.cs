using UnityEngine;

namespace Spine
{
    public class AtlasAttachmentLoader : AttachmentLoader
    {
        // Fields
        private Spine.Atlas[] atlasArray;
        
        // Methods
        public AtlasAttachmentLoader(Spine.Atlas[] atlasArray)
        {
            if(atlasArray != null)
            {
                    this.atlasArray = atlasArray;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  1885506992);
        }
        public Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path)
        {
            Spine.AtlasRegion val_1 = this.FindRegion(name:  path);
            if(this != 0)
            {
                    Spine.RegionAttachment val_2 = new Spine.RegionAttachment(name:  name);
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_5C = this;
                SetUVs(u:  null, v:  null, u2:  null, v2:  null, rotate:  false);
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_28 = val_2;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_2C = val_2;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_30 = (float)S0;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_34 = (float)(float)S0;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_38 = (float)(float)(float)S0;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_3C = (float)(float)(float)(float)S0;
                return;
            }
            
            string val_3 = System.String.Format(format:  1885669296, arg0:  path, arg1:  name);
            System.ArgumentException val_4 = new System.ArgumentException(message:  1885669296);
        }
        public Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path)
        {
            Spine.AtlasRegion val_1 = this.FindRegion(name:  path);
            if(this != 0)
            {
                    typeof(Spine.MeshAttachment).__il2cppRuntimeField_60 = this;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_64 = new Spine.MeshAttachment(name:  name);
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_68 = new Spine.MeshAttachment(name:  name);
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_6C = new Spine.MeshAttachment(name:  name);
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_70 = new Spine.MeshAttachment(name:  name);
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_74 = new Spine.MeshAttachment(name:  name);
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_1C = new Spine.MeshAttachment(name:  name);
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_20 = new Spine.MeshAttachment(name:  name);
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_24 = (float)S0;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_28 = (float)(float)S0;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_2C = (float)(float)(float)S0;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_30 = (float)(float)(float)(float)S0;
                return;
            }
            
            string val_3 = System.String.Format(format:  1885669296, arg0:  path, arg1:  name);
            System.ArgumentException val_4 = new System.ArgumentException(message:  1885669296);
        }
        public Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name)
        {
            Spine.BoundingBoxAttachment val_1 = new Spine.BoundingBoxAttachment(name:  name);
        }
        public Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name)
        {
            Spine.PathAttachment val_1 = new Spine.PathAttachment(name:  name);
        }
        public Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name)
        {
            Spine.PointAttachment val_1 = new Spine.PointAttachment(name:  name);
        }
        public Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name)
        {
            Spine.ClippingAttachment val_1 = new Spine.ClippingAttachment(name:  name);
        }
        public Spine.AtlasRegion FindRegion(string name)
        {
            var val_3 = 0;
            do
            {
                if(val_3 >= this)
            {
                    return;
            }
            
                Spine.Atlas val_2 = this.atlasArray[val_3];
                Spine.AtlasRegion val_1 = val_2.FindRegion(name:  name);
                val_3 = val_3 + 1;
            }
            while(val_2 == 0);
        
        }
    
    }

}
