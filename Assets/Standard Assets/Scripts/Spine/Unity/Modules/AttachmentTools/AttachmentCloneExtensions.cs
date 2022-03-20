using UnityEngine;

namespace Spine.Unity.Modules.AttachmentTools
{
    public static class AttachmentCloneExtensions
    {
        // Methods
        public static Spine.Attachment GetClone(Spine.Attachment o, bool cloneMeshesAsLinked)
        {
            var val_6;
            var val_7;
            val_6 = cloneMeshesAsLinked;
            val_7 = 35652564;
            if(o == 0)
            {
                    return;
            }
            
            val_6 = (Spine.Attachment.__il2cppRuntimeField_typeHierarchy + (Spine.BoundingBoxAttachment.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4;
            if(val_6 != null)
            {
                    return;
            }
            
            Spine.BoundingBoxAttachment val_4 = Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetClone(o:  o);
        }
        public static Spine.RegionAttachment GetClone(Spine.RegionAttachment o)
        {
            float val_5;
            string val_1 = "clone" + 2047630160;
            if((new Spine.RegionAttachment(name:  "clone")) != 0)
            {
                    typeof(Spine.RegionAttachment).__il2cppRuntimeField_C = o.x;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_10 = o.y;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_14 = o.rotation;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_18 = o.scaleX;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_1C = o.scaleY;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_20 = o.width;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_24 = o.height;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_48 = o.r;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_4C = o.g;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_50 = o.b;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_54 = o.a;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_58 = o.<Path>k__BackingField;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_5C = o.RendererObject;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_28 = o.regionOffsetX;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_2C = o.regionOffsetY;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_30 = o.regionWidth;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_34 = o.regionHeight;
                typeof(Spine.RegionAttachment).__il2cppRuntimeField_38 = o.regionOriginalWidth;
                val_5 = o.regionOriginalHeight;
            }
            else
            {
                    mem[12] = o.x;
                mem[16] = o.y;
                mem[20] = o.rotation;
                mem[24] = o.scaleX;
                mem[28] = o.scaleY;
                mem[32] = o.width;
                mem[36] = o.height;
                mem[72] = o.r;
                mem[76] = o.g;
                mem[80] = o.b;
                mem[84] = o.a;
                mem[88] = o.<Path>k__BackingField;
                mem[92] = o.RendererObject;
                mem[40] = o.regionOffsetX;
                mem[44] = o.regionOffsetY;
                mem[48] = o.regionWidth;
                mem[52] = o.regionHeight;
                mem[56] = o.regionOriginalWidth;
                val_5 = o.regionOriginalHeight;
            }
            
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_3C = val_5;
            object val_3 = o.uvs.Clone();
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_44 = o.uvs;
            object val_4 = o.offset.Clone();
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_40 = o.offset;
        }
        public static Spine.BoundingBoxAttachment GetClone(Spine.BoundingBoxAttachment o)
        {
            Spine.BoundingBoxAttachment val_1 = new Spine.BoundingBoxAttachment(name:  static_value_022003D6);
            Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.CloneVertexAttachment(src:  o, dest:  264323072);
        }
        public static Spine.MeshAttachment GetLinkedClone(Spine.MeshAttachment o, bool inheritDeform = True)
        {
            var val_2;
            var val_3;
            if(o != 0)
            {
                
            }
            else
            {
                    val_2 = 0;
            }
            
            val_3 = 0;
            if(o.RendererObject != 0)
            {
                    if(((System.Object.__il2cppRuntimeField_typeHierarchy + (Spine.AtlasRegion.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    o.RendererObject = 0;
            }
            
                val_3 = o.RendererObject;
            }
            
            Spine.MeshAttachment val_1 = Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetLinkedMesh(o:  o, newLinkedMeshName:  null, region:  0, inheritDeform:  inheritDeform);
        }
        public static Spine.MeshAttachment GetClone(Spine.MeshAttachment o)
        {
            bool val_6;
            var val_7;
            System.Int32[] val_8;
            if((new Spine.MeshAttachment(name:  R6)) != 0)
            {
                    typeof(Spine.MeshAttachment).__il2cppRuntimeField_44 = o.r;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_48 = o.g;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_4C = o.b;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_50 = o.a;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_58 = o.inheritDeform;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_5C = o.<Path>k__BackingField;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_60 = o.RendererObject;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_1C = o.regionOffsetX;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_20 = o.regionOffsetY;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_24 = o.regionWidth;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_28 = o.regionHeight;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_2C = o.regionOriginalWidth;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_30 = o.regionOriginalHeight;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_64 = o.<RegionU>k__BackingField;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_68 = o.<RegionV>k__BackingField;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_6C = o.<RegionU2>k__BackingField;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_70 = o.<RegionV2>k__BackingField;
                val_6 = o.<RegionRotate>k__BackingField;
            }
            else
            {
                    mem[68] = o.r;
                mem[72] = o.g;
                mem[76] = o.b;
                mem[80] = o.a;
                mem[88] = o.inheritDeform;
                mem[92] = o.<Path>k__BackingField;
                mem[96] = o.RendererObject;
                mem[28] = o.regionOffsetX;
                mem[32] = o.regionOffsetY;
                mem[36] = o.regionWidth;
                mem[40] = o.regionHeight;
                mem[44] = o.regionOriginalWidth;
                mem[48] = o.regionOriginalHeight;
                mem[100] = o.<RegionU>k__BackingField;
                mem[104] = o.<RegionV>k__BackingField;
                mem[108] = o.<RegionU2>k__BackingField;
                mem[112] = o.<RegionV2>k__BackingField;
                val_6 = o.<RegionRotate>k__BackingField;
            }
            
            typeof(Spine.MeshAttachment).__il2cppRuntimeField_74 = val_6;
            object val_2 = o.uvs.Clone();
            val_7 = 1152921505140742816;
            typeof(Spine.MeshAttachment).__il2cppRuntimeField_38 = o.uvs;
            if(o.parentMesh != 0)
            {
                    ParentMesh = o.parentMesh;
                return;
            }
            
            Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.CloneVertexAttachment(src:  o, dest:  264429568);
            val_8 = 0;
            object val_3 = o.regionUVs.Clone();
            typeof(Spine.MeshAttachment).__il2cppRuntimeField_3C = o.regionUVs;
            object val_4 = o.triangles.Clone();
            val_7 = 1152921505085149936;
            typeof(Spine.MeshAttachment).__il2cppRuntimeField_40 = o.triangles;
            typeof(Spine.MeshAttachment).__il2cppRuntimeField_54 = o.hulllength;
            if((o.<Edges>k__BackingField) != null)
            {
                    object val_5 = o.<Edges>k__BackingField.Clone();
                val_8 = o.<Edges>k__BackingField;
            }
            
            typeof(Spine.MeshAttachment).__il2cppRuntimeField_78 = val_8;
            typeof(Spine.MeshAttachment).__il2cppRuntimeField_7C = o.<Width>k__BackingField;
            typeof(Spine.MeshAttachment).__il2cppRuntimeField_80 = o.<Height>k__BackingField;
        }
        public static Spine.PathAttachment GetClone(Spine.PathAttachment o)
        {
            bool val_3;
            object val_2 = o.lengths.Clone();
            typeof(Spine.PathAttachment).__il2cppRuntimeField_1C = o.lengths;
            if((new Spine.PathAttachment(name:  R6)) != 0)
            {
                    typeof(Spine.PathAttachment).__il2cppRuntimeField_20 = o.closed;
                val_3 = o.constantSpeed;
            }
            else
            {
                    mem[32] = o.closed;
                val_3 = o.constantSpeed;
            }
            
            typeof(Spine.PathAttachment).__il2cppRuntimeField_21 = val_3;
            Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.CloneVertexAttachment(src:  o, dest:  264482816);
        }
        private static void CloneVertexAttachment(Spine.VertexAttachment src, Spine.VertexAttachment dest)
        {
            dest.worldVerticesLength = src.worldVerticesLength;
            if(src.bones != null)
            {
                    object val_1 = src.bones.Clone();
                dest.bones = src.bones;
            }
            
            if(src.vertices == null)
            {
                    return;
            }
            
            object val_2 = src.vertices.Clone();
            dest.vertices = src.vertices;
        }
        public static Spine.MeshAttachment GetLinkedMesh(Spine.MeshAttachment o, string newLinkedMeshName, Spine.AtlasRegion region, bool inheritDeform = True)
        {
            if(region != 0)
            {
                    Spine.Unity.Modules.AttachmentTools.AttachmentRegionExtensions.SetRegion(attachment:  264429568, region:  region, updateUVs:  false);
                if(o.parentMesh == 0)
            {
                    o.parentMesh = o;
            }
            
                if((new Spine.MeshAttachment(name:  newLinkedMeshName)) != 0)
            {
                    typeof(Spine.MeshAttachment).__il2cppRuntimeField_5C = newLinkedMeshName;
                typeof(Spine.MeshAttachment).__il2cppRuntimeField_58 = inheritDeform;
                ParentMesh = o.parentMesh;
            }
            else
            {
                    mem[92] = newLinkedMeshName;
                mem[68] = 1065353216;
                mem[72] = 1065353216;
                mem[76] = 1065353216;
                mem[80] = 1065353216;
                mem[88] = inheritDeform;
                ParentMesh = o.parentMesh;
            }
            
                UpdateUVs();
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1956540704);
        }
        public static Spine.MeshAttachment GetLinkedMesh(Spine.MeshAttachment o, UnityEngine.Sprite sprite, UnityEngine.Shader shader, bool inheritDeform = True, UnityEngine.Material materialPropertySource)
        {
            UnityEngine.Material val_1 = new UnityEngine.Material(shader:  shader);
            if(materialPropertySource != 0)
            {
                    CopyPropertiesFromMaterial(mat:  materialPropertySource);
                System.String[] val_3 = materialPropertySource.shaderKeywords;
                shaderKeywords = materialPropertySource;
            }
            
            string val_4 = sprite.name;
            Spine.AtlasRegion val_5 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegion(s:  sprite, isolatedTexture:  false);
            Spine.MeshAttachment val_6 = Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetLinkedMesh(o:  o, newLinkedMeshName:  sprite, region:  sprite, inheritDeform:  inheritDeform);
        }
        public static Spine.MeshAttachment GetLinkedMesh(Spine.MeshAttachment o, UnityEngine.Sprite sprite, UnityEngine.Material materialPropertySource, bool inheritDeform = True)
        {
            UnityEngine.Shader val_1 = materialPropertySource.shader;
            Spine.MeshAttachment val_2 = Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetLinkedMesh(o:  o, sprite:  sprite, shader:  materialPropertySource, inheritDeform:  inheritDeform, materialPropertySource:  materialPropertySource);
        }
        public static Spine.Attachment GetRemappedClone(Spine.Attachment o, UnityEngine.Sprite sprite, UnityEngine.Material sourceMaterial, bool premultiplyAlpha = True, bool cloneMeshAsLinked = True, bool useOriginalRegionSize = False)
        {
            if(premultiplyAlpha != false)
            {
                    Spine.AtlasRegion val_1 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegionPMAClone(s:  sprite, materialPropertySource:  sourceMaterial, textureFormat:  4, mipmaps:  false);
            }
            else
            {
                    Spine.AtlasRegion val_2 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegion(s:  sprite, isolatedTexture:  false);
            }
            
            float val_3 = sprite.pixelsPerUnit;
            float val_5 = 1f;
            val_5 = val_5 / sprite;
            Spine.Attachment val_4 = Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetRemappedClone(o:  o, atlasRegion:  sprite, cloneMeshAsLinked:  cloneMeshAsLinked, useOriginalRegionSize:  useOriginalRegionSize, scale:  val_5);
        }
        public static Spine.Attachment GetRemappedClone(Spine.Attachment o, Spine.AtlasRegion atlasRegion, bool cloneMeshAsLinked = True, bool useOriginalRegionSize = False, float scale = 0.01)
        {
            if(o == 0)
            {
                    return Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetClone(o:  o, cloneMeshesAsLinked:  true);
            }
            
            return Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetClone(o:  o, cloneMeshesAsLinked:  true);
        }
    
    }

}
