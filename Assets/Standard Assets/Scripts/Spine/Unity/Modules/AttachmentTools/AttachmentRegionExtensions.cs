using UnityEngine;

namespace Spine.Unity.Modules.AttachmentTools
{
    public static class AttachmentRegionExtensions
    {
        // Methods
        public static Spine.AtlasRegion GetRegion(Spine.Attachment attachment)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            if(attachment == 0)
            {
                    return;
            }
            
            val_1 = 0;
            if(((Spine.Attachment.__il2cppRuntimeField_typeHierarchy + (Spine.MeshAttachment.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    attachment = val_1;
            }
            
            val_2 = 0;
            if(null == 0)
            {
                    return;
            }
            
            val_1 = 0;
        }
        public static Spine.AtlasRegion GetRegion(Spine.RegionAttachment regionAttachment)
        {
            if(regionAttachment.RendererObject == 0)
            {
                    return;
            }
            
            if(((System.Object.__il2cppRuntimeField_typeHierarchy + (Spine.AtlasRegion.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    regionAttachment.RendererObject = 0;
            }
        
        }
        public static Spine.AtlasRegion GetRegion(Spine.MeshAttachment meshAttachment)
        {
            if(meshAttachment.RendererObject == 0)
            {
                    return;
            }
            
            if(((System.Object.__il2cppRuntimeField_typeHierarchy + (Spine.AtlasRegion.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    meshAttachment.RendererObject = 0;
            }
        
        }
        public static void SetRegion(Spine.Attachment attachment, Spine.AtlasRegion region, bool updateOffset = True)
        {
            var val_1 = 35652577;
            if(attachment == 0)
            {
                    return;
            }
            
            Spine.Unity.Modules.AttachmentTools.AttachmentRegionExtensions.SetRegion(attachment:  attachment, region:  region, updateOffset:  updateOffset);
        }
        public static void SetRegion(Spine.RegionAttachment attachment, Spine.AtlasRegion region, bool updateOffset = True)
        {
            if(region != 0)
            {
                    attachment.RendererObject = region;
                attachment.SetUVs(u:  region.v2, v:  null, u2:  null, v2:  null, rotate:  mem[region.u + (0)]>>0&0xFF);
                attachment.regionOffsetX = region.offsetX;
                attachment.regionOffsetY = region.offsetY;
                attachment.regionWidth = (float)region.width;
                attachment.regionHeight = (float)region.height;
                attachment.regionOriginalWidth = (float)region.originalWidth;
                attachment.regionOriginalHeight = (float)region.originalHeight;
                if(updateOffset == false)
            {
                    return;
            }
            
                attachment.UpdateOffset();
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  1956540704);
        }
        public static void SetRegion(Spine.MeshAttachment attachment, Spine.AtlasRegion region, bool updateUVs = True)
        {
            if(region != 0)
            {
                    attachment.RendererObject = region;
                attachment.<RegionU>k__BackingField = region.u;
                attachment.<RegionV>k__BackingField = region.v;
                attachment.<RegionU2>k__BackingField = region.u2;
                attachment.<RegionV2>k__BackingField = region.v2;
                attachment.<RegionRotate>k__BackingField = region.rotate;
                attachment.regionOffsetX = region.offsetX;
                attachment.regionOffsetY = region.offsetY;
                attachment.regionWidth = (float)region.width;
                attachment.regionHeight = (float)region.height;
                attachment.regionOriginalWidth = (float)region.originalWidth;
                attachment.regionOriginalHeight = (float)region.originalHeight;
                if(updateUVs == false)
            {
                    return;
            }
            
                attachment.UpdateUVs();
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  1956540704);
        }
        public static Spine.RegionAttachment ToRegionAttachment(UnityEngine.Sprite sprite, UnityEngine.Material material)
        {
            Spine.AtlasPage val_1 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToSpineAtlasPage(m:  material);
            return Spine.Unity.Modules.AttachmentTools.AttachmentRegionExtensions.ToRegionAttachment(sprite:  sprite, page:  material);
        }
        public static Spine.RegionAttachment ToRegionAttachment(UnityEngine.Sprite sprite, Spine.AtlasPage page)
        {
            var val_7;
            System.ArgumentNullException val_8;
            var val_9;
            if(sprite == 0)
            {
                goto label_3;
            }
            
            if(page == 0)
            {
                goto label_4;
            }
            
            Spine.AtlasRegion val_2 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegion(s:  sprite, page:  page);
            if(sprite != 0)
            {
                    float val_3 = sprite.pixelsPerUnit;
                val_7 = sprite;
            }
            else
            {
                    float val_4 = 0.pixelsPerUnit;
                val_7 = 0;
            }
            
            val_7 = 1f / val_7;
            string val_5 = sprite.name;
            return Spine.Unity.Modules.AttachmentTools.AttachmentRegionExtensions.ToRegionAttachment(region:  sprite, attachmentName:  sprite, scale:  1f);
            label_3:
            val_8 = null;
            val_9 = "sprite";
            goto label_7;
            label_4:
            val_8 = null;
            val_9 = "page";
            label_7:
            val_8 = new System.ArgumentNullException(paramName:  2041198912);
        }
        public static Spine.RegionAttachment ToRegionAttachmentPMAClone(UnityEngine.Sprite sprite, UnityEngine.Shader shader, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False, UnityEngine.Material materialPropertySource)
        {
            var val_8;
            System.ArgumentNullException val_9;
            var val_10;
            if(sprite == 0)
            {
                goto label_3;
            }
            
            if(shader == 0)
            {
                goto label_6;
            }
            
            Spine.AtlasRegion val_3 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegionPMAClone(s:  sprite, shader:  shader, textureFormat:  textureFormat, mipmaps:  mipmaps, materialPropertySource:  materialPropertySource);
            if(sprite != 0)
            {
                    float val_4 = sprite.pixelsPerUnit;
                val_8 = sprite;
            }
            else
            {
                    float val_5 = 0.pixelsPerUnit;
                val_8 = 0;
            }
            
            val_8 = 1f / val_8;
            string val_6 = sprite.name;
            return Spine.Unity.Modules.AttachmentTools.AttachmentRegionExtensions.ToRegionAttachment(region:  sprite, attachmentName:  sprite, scale:  1f);
            label_3:
            val_9 = null;
            val_10 = "sprite";
            goto label_9;
            label_6:
            val_9 = null;
            val_10 = "shader";
            label_9:
            val_9 = new System.ArgumentNullException(paramName:  2041336592);
        }
        public static Spine.RegionAttachment ToRegionAttachmentPMAClone(UnityEngine.Sprite sprite, UnityEngine.Material materialPropertySource, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False)
        {
            UnityEngine.Shader val_1 = materialPropertySource.shader;
            Spine.RegionAttachment val_2 = Spine.Unity.Modules.AttachmentTools.AttachmentRegionExtensions.ToRegionAttachmentPMAClone(sprite:  sprite, shader:  materialPropertySource, textureFormat:  textureFormat, mipmaps:  mipmaps, materialPropertySource:  materialPropertySource);
        }
        public static Spine.RegionAttachment ToRegionAttachment(Spine.AtlasRegion region, string attachmentName, float scale = 0.01)
        {
            float val_4;
            System.ArgumentException val_7;
            if((System.String.IsNullOrEmpty(value:  attachmentName)) == true)
            {
                goto label_1;
            }
            
            if(region == 0)
            {
                goto label_2;
            }
            
            Spine.RegionAttachment val_2 = new Spine.RegionAttachment(name:  attachmentName);
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_5C = region;
            SetUVs(u:  region.v2, v:  null, u2:  null, v2:  null, rotate:  mem[region.u + (0)]>>0&0xFF);
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_28 = region.offsetX;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_2C = region.offsetY;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_30 = (float)region.width;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_34 = (float)region.height;
            float val_7 = (float)region.originalWidth;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_38 = val_7;
            val_7 = val_7 * R2;
            float val_8 = (float)region.originalHeight;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_3C = val_8;
            val_8 = val_8 * R2;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_58 = region.name;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_14 = 0;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_18 = 1065353216;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_1C = 1065353216;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_20 = val_7;
            typeof(Spine.RegionAttachment).__il2cppRuntimeField_24 = val_8;
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            Spine.Unity.SkeletonExtensions.SetColor(attachment:  264589312, color:  new UnityEngine.Color() {a = val_4});
            UpdateOffset();
            return;
            label_1:
            val_7 = null;
            val_7 = new System.ArgumentException(message:  2041614944, paramName:  1940570448);
            goto label_4;
            label_2:
            val_7 = null;
            val_7 = new System.ArgumentNullException(paramName:  1956540704);
            label_4:
        }
        public static void SetScale(Spine.RegionAttachment regionAttachment, UnityEngine.Vector2 scale)
        {
            if(regionAttachment != 0)
            {
                    regionAttachment.scaleX = scale.x;
            }
            else
            {
                    mem[24] = scale.x;
            }
            
            regionAttachment.scaleY = scale.y;
        }
        public static void SetScale(Spine.RegionAttachment regionAttachment, float x, float y)
        {
            if(regionAttachment != 0)
            {
                    regionAttachment.scaleX = R1;
            }
            else
            {
                    mem[24] = R1;
            }
            
            regionAttachment.scaleY = R2;
        }
        public static void SetPositionOffset(Spine.RegionAttachment regionAttachment, UnityEngine.Vector2 offset)
        {
            if(regionAttachment != 0)
            {
                    regionAttachment.x = offset.x;
            }
            else
            {
                    mem[12] = offset.x;
            }
            
            regionAttachment.y = offset.y;
        }
        public static void SetPositionOffset(Spine.RegionAttachment regionAttachment, float x, float y)
        {
            if(regionAttachment != 0)
            {
                    regionAttachment.x = R1;
            }
            else
            {
                    mem[12] = R1;
            }
            
            regionAttachment.y = R2;
        }
        public static void SetRotation(Spine.RegionAttachment regionAttachment, float rotation)
        {
            regionAttachment.rotation = R1;
        }
    
    }

}
