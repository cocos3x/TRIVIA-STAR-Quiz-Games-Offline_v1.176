using UnityEngine;

namespace Spine.Unity.Modules.AttachmentTools
{
    public static class SpriteAtlasRegionExtensions
    {
        // Fields
        internal const UnityEngine.TextureFormat SpineTextureFormat = 4;
        internal const bool UseMipMaps = False;
        internal const float DefaultScale = 0.01;
        
        // Methods
        public static Spine.AtlasRegion ToAtlasRegion(UnityEngine.Texture2D t, UnityEngine.Material materialPropertySource, float scale = 0.01)
        {
            UnityEngine.Shader val_1 = materialPropertySource.shader;
            Spine.AtlasRegion val_2 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegion(t:  t, shader:  materialPropertySource, scale:  scale, materialPropertySource:  R2);
        }
        public static Spine.AtlasRegion ToAtlasRegion(UnityEngine.Texture2D t, UnityEngine.Shader shader, float scale = 0.01, UnityEngine.Material materialPropertySource)
        {
            var val_10;
            var val_11;
            float val_14;
            var val_15;
            if(R3 != 0)
            {
                    CopyPropertiesFromMaterial(mat:  R3);
                System.String[] val_3 = R3.shaderKeywords;
                shaderKeywords = R3;
            }
            
            mainTexture = t;
            Spine.AtlasPage val_4 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToSpineAtlasPage(m:  152875008);
            string val_8 = t.name;
            if(new Spine.AtlasRegion() != 0)
            {
                    typeof(Spine.AtlasRegion).__il2cppRuntimeField_40 = 0;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_C = t;
            }
            else
            {
                    mem[12] = t;
                mem[64] = 0;
            }
            
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_44 = 0;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_9.x, y:  val_9.y);
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 1.233073E+35f, y = val_12.x}, d:  val_9.x);
            float val_17 = val_14;
            var val_18 = val_15;
            float val_19 = 0f;
            val_17 = val_17 - val_10;
            val_18 = val_18 - val_11;
            val_19 = val_19 - val_11;
            val_17 = (val_19 - val_10) / val_17;
            val_19 = val_19 / val_18;
            val_17 = 0.5f - val_17;
            val_19 = 0.5f - val_19;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_10 = 0;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_14 = 0;
            val_17 = val_17 * (float)t.width;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_8 = new UnityEngine.Material(shader:  shader);
            val_19 = val_19 * (float)t.height;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_18 = (int)(float)t.width;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_1C = (int)(float)t.height;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_30 = val_17;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_34 = val_19;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_38 = (int)(float)t.width;
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_3C = (int)(float)t.height;
        }
        public static Spine.AtlasRegion ToAtlasRegionPMAClone(UnityEngine.Texture2D t, UnityEngine.Material materialPropertySource, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False)
        {
            UnityEngine.Shader val_1 = materialPropertySource.shader;
            Spine.AtlasRegion val_2 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegionPMAClone(t:  t, shader:  materialPropertySource, textureFormat:  textureFormat, mipmaps:  mipmaps, materialPropertySource:  materialPropertySource);
        }
        public static Spine.AtlasRegion ToAtlasRegionPMAClone(UnityEngine.Texture2D t, UnityEngine.Shader shader, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False, UnityEngine.Material materialPropertySource)
        {
            UnityEngine.Material val_1 = new UnityEngine.Material(shader:  shader);
            if(materialPropertySource != 0)
            {
                    CopyPropertiesFromMaterial(mat:  materialPropertySource);
                System.String[] val_3 = materialPropertySource.shaderKeywords;
                shaderKeywords = materialPropertySource;
            }
            
            UnityEngine.Texture2D val_4 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.GetClone(t:  t, applyImmediately:  false, textureFormat:  textureFormat, mipmaps:  mipmaps);
            Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ApplyPMA(texture:  t, applyImmediately:  true);
            string val_5 = t.name;
            string val_6 = t + 2042759296;
            t.name = t;
            string val_7 = t.name;
            string val_8 = shader.name;
            string val_9 = t + shader;
            if(val_1 != 0)
            {
                    name = t;
            }
            else
            {
                    0.name = t;
            }
            
            mainTexture = t;
            Spine.AtlasPage val_10 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToSpineAtlasPage(m:  152875008);
            Spine.AtlasRegion val_11 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegion(t:  t, shader:  shader, scale:  null, materialPropertySource:  1008981770);
            mem2[0] = val_1;
        }
        public static Spine.AtlasPage ToSpineAtlasPage(UnityEngine.Material m)
        {
            Spine.AtlasPage val_1 = new Spine.AtlasPage();
            typeof(Spine.AtlasPage).__il2cppRuntimeField_20 = m;
            if(m != 0)
            {
                    string val_2 = m.name;
                typeof(Spine.AtlasPage).__il2cppRuntimeField_8 = m;
            }
            else
            {
                    string val_3 = 0.name;
                typeof(Spine.AtlasPage).__il2cppRuntimeField_8 = 0;
            }
            
            UnityEngine.Texture val_4 = m.mainTexture;
            if(m == 0)
            {
                    return;
            }
            
            typeof(Spine.AtlasPage).__il2cppRuntimeField_24 = m;
            typeof(Spine.AtlasPage).__il2cppRuntimeField_28 = m;
        }
        public static Spine.AtlasRegion ToAtlasRegion(UnityEngine.Sprite s, Spine.AtlasPage page)
        {
            if(page != 0)
            {
                    Spine.AtlasRegion val_1 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegion(s:  s, isolatedTexture:  false);
                mem2[0] = page;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  2041198912, message:  2043016144);
        }
        public static Spine.AtlasRegion ToAtlasRegion(UnityEngine.Sprite s, UnityEngine.Material material)
        {
            Spine.AtlasRegion val_1 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegion(s:  s, isolatedTexture:  false);
            Spine.AtlasPage val_2 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToSpineAtlasPage(m:  material);
            mem2[0] = material;
        }
        public static Spine.AtlasRegion ToAtlasRegionPMAClone(UnityEngine.Sprite s, UnityEngine.Shader shader, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False, UnityEngine.Material materialPropertySource)
        {
            var val_12;
            UnityEngine.Material val_1 = new UnityEngine.Material(shader:  shader);
            if(materialPropertySource != 0)
            {
                    CopyPropertiesFromMaterial(mat:  materialPropertySource);
                System.String[] val_3 = materialPropertySource.shaderKeywords;
                shaderKeywords = materialPropertySource;
            }
            
            UnityEngine.Texture2D val_4 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToTexture(s:  s, applyImmediately:  false, textureFormat:  textureFormat, mipmaps:  mipmaps);
            Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ApplyPMA(texture:  s, applyImmediately:  true);
            val_12 = 0;
            string val_5 = s.name;
            string val_6 = s + 2042759296;
            if(s != 0)
            {
                    s.name = s;
                val_12 = s;
            }
            else
            {
                    0.name = s;
            }
            
            string val_7 = val_12.name;
            string val_8 = shader.name;
            string val_9 = null + shader;
            if(val_1 != 0)
            {
                    name = null;
            }
            else
            {
                    0.name = null;
            }
            
            mainTexture = s;
            Spine.AtlasPage val_10 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToSpineAtlasPage(m:  152875008);
            Spine.AtlasRegion val_11 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegion(s:  s, isolatedTexture:  true);
            mem2[0] = val_1;
        }
        public static Spine.AtlasRegion ToAtlasRegionPMAClone(UnityEngine.Sprite s, UnityEngine.Material materialPropertySource, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False)
        {
            UnityEngine.Shader val_1 = materialPropertySource.shader;
            Spine.AtlasRegion val_2 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToAtlasRegionPMAClone(s:  s, shader:  materialPropertySource, textureFormat:  textureFormat, mipmaps:  mipmaps, materialPropertySource:  materialPropertySource);
        }
        internal static Spine.AtlasRegion ToAtlasRegion(UnityEngine.Sprite s, bool isolatedTexture = False)
        {
            float val_6;
            var val_9;
            var val_10;
            var val_13;
            var val_14;
            var val_38;
            int val_40;
            string val_2 = s.name;
            if(new Spine.AtlasRegion() != 0)
            {
                    typeof(Spine.AtlasRegion).__il2cppRuntimeField_C = s;
            }
            else
            {
                    mem[12] = s;
            }
            
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_40 = 0;
            val_38 = 0;
            if(s.packed != false)
            {
                    UnityEngine.SpritePackingRotation val_4 = s.packingRotation;
                if(s != 0)
            {
                    val_38 = 1;
            }
            
            }
            
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_44 = 1;
            UnityEngine.Bounds val_5 = bounds;
            UnityEngine.Vector3 val_7 = min;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.339002E+35f});
            UnityEngine.Vector3 val_11 = max;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.339E+35f});
            if(val_5.m_Extents.z != 0f)
            {
                    UnityEngine.Rect val_15 = rect;
            }
            else
            {
                    UnityEngine.Rect val_16 = rect;
            }
            
            UnityEngine.Texture2D val_17 = val_5.m_Extents.z.texture;
            UnityEngine.Rect val_18 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.SpineUnityFlipRect(rect:  new UnityEngine.Rect() {m_XMin = 1.339005E+35f}, textureHeight:  ???);
            val_40 = 0;
            float val_19 = width;
            mem2[0] = 2043563632;
            float val_20 = width;
            if(val_5.m_Extents.z == 0f)
            {
                    -D16 = -(-D16);
            }
            
            mem2[0] = 2043563632;
            float val_21 = height;
            if(val_5.m_Extents.z == 0f)
            {
                    -D16 = -(-D16);
            }
            
            mem2[0] = 2043563632;
            float val_22 = height;
            float val_41 = 0f;
            var val_39 = val_10;
            var val_38 = val_13;
            val_38 = val_38 - val_39;
            val_39 = val_41 - val_39;
            var val_40 = val_14;
            val_39 = val_39 / val_38;
            if(val_5.m_Extents.z == 0f)
            {
                    -D16 = -(-D16);
            }
            
            mem2[0] = 2043563632;
            val_40 = val_40 - val_9;
            val_41 = val_41 - val_9;
            float val_24 = val_41 / val_40;
            float val_25 = width;
            uint val_42 = 2043563632;
            val_24 = 0.5f - val_24;
            val_42 = (0.5f - val_39) * val_42;
            mem2[0] = val_42;
            float val_26 = height;
            uint val_43 = 2043563632;
            val_43 = val_24 * val_43;
            mem2[0] = val_43;
            if(isolatedTexture != false)
            {
                    mem2[0] = val_40;
                float val_27 = val_5.m_Extents.y + 32;
                mem2[0] = val_40;
                return;
            }
            
            if(val_5.m_Extents.z != 0f)
            {
                    UnityEngine.Texture2D val_28 = val_5.m_Extents.z.texture;
                val_40 = val_5.m_Extents.z;
            }
            else
            {
                    UnityEngine.Texture2D val_29 = 0.texture;
                val_40 = 0;
            }
            
            UnityEngine.Rect val_30 = textureRect;
            UnityEngine.Rect val_31 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.TextureRectToUVRect(textureRect:  new UnityEngine.Rect() {m_XMin = 1.339007E+35f}, texWidth:  ???, texHeight:  val_40);
            float val_32 = val_6.xMin;
            mem2[0] = ;
            float val_33 = val_6.yMax;
            mem2[0] = ;
            float val_34 = val_6.xMax;
            mem2[0] = ;
            float val_35 = val_6.yMin;
            mem2[0] = ;
            float val_36 = x;
            if(val_40 == 0)
            {
                    -D16 = -(-D16);
            }
            
            mem2[0] = 2043563632;
            float val_37 = y;
            if(val_40 == 0)
            {
                    -D16 = -(-D16);
            }
            
            mem2[0] = 2043563632;
        }
        public static Spine.Skin GetRepackedSkin(Spine.Skin o, string newName, UnityEngine.Material materialPropertySource, out UnityEngine.Material m, out UnityEngine.Texture2D t, int maxAtlasSize = 1024, int padding = 2, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False)
        {
            UnityEngine.Shader val_1 = materialPropertySource.shader;
            Spine.Skin val_4 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.GetRepackedSkin(o:  o, newName:  newName, shader:  materialPropertySource, m: out  UnityEngine.Material val_2 = 2043760672, t: out  UnityEngine.Texture2D val_3 = t, maxAtlasSize:  maxAtlasSize, padding:  padding, textureFormat:  textureFormat, mipmaps:  mipmaps, materialPropertySource:  materialPropertySource);
        }
        public static Spine.Skin GetRepackedSkin(Spine.Skin o, string newName, UnityEngine.Shader shader, out UnityEngine.Material m, out UnityEngine.Texture2D t, int maxAtlasSize = 1024, int padding = 2, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False, UnityEngine.Material materialPropertySource)
        {
            int val_9;
            string val_10;
            Spine.Attachment val_11;
            UnityEngine.Object val_30;
            var val_31;
            var val_32;
            var val_33;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_34;
            var val_36;
            Il2CppClass* val_37;
            float val_38;
            float val_39;
            string val_40;
            var val_42;
            Spine.Skin val_1 = null;
            val_31 = val_1;
            val_1 = new Spine.Skin(name:  newName);
            System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_2 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Dictionary.Enumerator<TKey, TValue> val_7 = GetEnumerator();
            label_15:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            Spine.Attachment val_12 = Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetClone(o:  val_11, cloneMeshesAsLinked:  true);
            if((Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.IsRenderable(a:  val_11)) != false)
            {
                    Spine.AtlasRegion val_14 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.GetAtlasRegion(a:  val_11);
                if((TryGetValue(key:  val_11, value: out  int val_15 = 2043882788)) != false)
            {
                    Add(item:  0);
            }
            else
            {
                    Add(item:  val_11);
                UnityEngine.Texture2D val_17 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToTexture(ar:  val_11, applyImmediately:  true, textureFormat:  4, mipmaps:  false);
                Add(item:  val_11);
                val_31 = val_31;
                Add(key:  val_11, value:  0);
                Add(item:  0);
            }
            
                Add(item:  val_11);
            }
            
            AddAttachment(slotIndex:  val_9, name:  val_10, attachment:  val_11);
            goto label_15;
            label_3:
            Dispose();
            UnityEngine.Texture2D val_18 = new UnityEngine.Texture2D(width:  maxAtlasSize, height:  maxAtlasSize, textureFormat:  textureFormat, mipChain:  mipmaps);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_32 = 0;
            int val_19 = List<T>.__il2cppRuntimeField_10.anisoLevel;
            if(val_18 != 0)
            {
                    anisoLevel = val_19;
                val_32 = val_18;
            }
            else
            {
                    0.anisoLevel = val_19;
            }
            
            name = newName;
            T[] val_20 = ToArray();
            UnityEngine.Rect[] val_21 = PackTextures(textures:  80883712, padding:  padding, maximumAtlasSize:  maxAtlasSize);
            UnityEngine.Material val_22 = new UnityEngine.Material(shader:  shader);
            if(materialPropertySource != 0)
            {
                    val_33 = val_22;
                if(val_33 == 0)
            {
                    val_33 = val_22;
            }
            
                CopyPropertiesFromMaterial(mat:  materialPropertySource);
                System.String[] val_24 = materialPropertySource.shaderKeywords;
                if(val_33 == 0)
            {
                    val_33 = val_22;
            }
            
                shaderKeywords = materialPropertySource;
            }
            
            if(val_22 != 0)
            {
                    name = newName;
            }
            else
            {
                    0.name = newName;
            }
            
            mainTexture = 0;
            Spine.AtlasPage val_25 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.ToSpineAtlasPage(m:  152875008);
            typeof(UnityEngine.Material).__il2cppRuntimeField_8 = newName;
            val_34 = null;
            val_34 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_36 = 0;
            goto label_33;
            label_40:
            val_36 = 1;
            label_33:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(val_22 != 0)
            {
                
            }
            else
            {
                    val_40 = 0;
                val_38 = 2.571435E-39f;
                val_39 = 8.407791E-45f;
            }
            
            Spine.AtlasRegion val_27 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.UVRectToAtlasRegion(uvRect:  new UnityEngine.Rect() {m_XMin = val_37, m_YMin = UnityEngine.Texture2D.__il2cppRuntimeField_castClass, m_Width = 0f, m_Height = 2.12078E-33f}, name:  val_40, page:  val_22, offsetX:  null, offsetY:  null, rotate:  val_38);
            val_34 = val_34;
            Add(item:  val_37 = UnityEngine.Texture2D.__il2cppRuntimeField_element_class);
            if(1152921505700909039 != val_36)
            {
                goto label_40;
            }
            
            val_42 = 0;
            goto label_43;
            label_49:
            val_42 = 1;
            label_43:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            Spine.Unity.Modules.AttachmentTools.AttachmentRegionExtensions.SetRegion(attachment:  val_37, region:  mem[1152921506312404992], updateOffset:  true);
            if(1152921505700909039 != val_42)
            {
                goto label_49;
            }
            
            List.Enumerator<T> val_28 = GetEnumerator();
            label_54:
            if(MoveNext() == false)
            {
                goto label_51;
            }
            
            UnityEngine.Object.Destroy(obj:  val_30);
            goto label_54;
            label_51:
            Dispose();
            t = val_18;
            mem2[0] = val_22;
        }
        public static UnityEngine.Sprite ToSprite(Spine.AtlasRegion ar, float pixelsPerUnit = 100)
        {
            float val_4;
            UnityEngine.Texture2D val_1 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.GetMainTexture(region:  ar);
            UnityEngine.Rect val_2 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.GetUnityRect(region:  2044031664);
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2.m_XMin, y:  val_2.m_YMin);
            UnityEngine.Sprite val_5 = UnityEngine.Sprite.Create(texture:  ar, rect:  new UnityEngine.Rect() {m_Height = val_4}, pivot:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, pixelsPerUnit:  val_2.m_XMin);
        }
        public static UnityEngine.Texture2D ToTexture(Spine.AtlasRegion ar, bool applyImmediately = True, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False)
        {
            UnityEngine.Texture2D val_1 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.GetMainTexture(region:  ar);
            UnityEngine.Rect val_2 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.GetUnityRect(region:  2044160040, textureHeight:  ar);
            float val_3 = width;
            float val_4 = height;
            UnityEngine.Texture2D val_5 = new UnityEngine.Texture2D(width:  2044160040, height:  S20, textureFormat:  textureFormat, mipChain:  mipmaps);
            name = ar.name;
            float val_6 = x;
            float val_7 = y;
            if(val_5 == 0)
            {
                    -D16 = -(-D16);
            }
            
            if(val_5 == 0)
            {
                    -D17 = -(-D17);
            }
            
            UnityEngine.Color[] val_8 = ar.GetPixels(x:  2044160040, y:  val_2.m_Width, blockWidth:  2044160040, blockHeight:  S20);
            SetPixels(colors:  ar);
            if(applyImmediately == false)
            {
                    return;
            }
            
            Apply();
        }
        private static UnityEngine.Texture2D ToTexture(UnityEngine.Sprite s, bool applyImmediately = True, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False)
        {
            var val_12;
            if(s != 0)
            {
                    UnityEngine.Texture2D val_1 = s.texture;
                val_12 = s;
            }
            else
            {
                    UnityEngine.Texture2D val_2 = 0.texture;
                val_12 = 0;
            }
            
            UnityEngine.Rect val_3 = textureRect;
            float val_4 = x;
            float val_5 = y;
            float val_6 = width;
            UnityEngine.Color[] val_8 = val_12.GetPixels(x:  val_3.m_Width, y:  S4, blockWidth:  S6, blockHeight:  height);
            float val_9 = width;
            float val_10 = height;
            if(val_12 == 0)
            {
                    -D16 = -(-D16);
            }
            
            if(val_12 == 0)
            {
                    -D17 = -(-D17);
            }
            
            UnityEngine.Texture2D val_11 = new UnityEngine.Texture2D(width:  2044292520, height:  2044292520, textureFormat:  textureFormat, mipChain:  mipmaps);
            SetPixels(colors:  null);
            if(applyImmediately == false)
            {
                    return;
            }
            
            Apply();
        }
        private static UnityEngine.Texture2D GetClone(UnityEngine.Texture2D t, bool applyImmediately = True, UnityEngine.TextureFormat textureFormat = 4, bool mipmaps = False)
        {
            var val_8;
            int val_1 = t.width;
            int val_2 = t.height;
            if(t != 0)
            {
                    UnityEngine.Color[] val_3 = t.GetPixels(x:  0, y:  0, blockWidth:  val_1, blockHeight:  val_2);
                val_8 = t;
            }
            else
            {
                    UnityEngine.Color[] val_4 = 0.GetPixels(x:  0, y:  0, blockWidth:  val_1, blockHeight:  val_2);
                val_8 = 0;
            }
            
            UnityEngine.Texture2D val_7 = new UnityEngine.Texture2D(width:  t.width, height:  t.height, textureFormat:  textureFormat, mipChain:  mipmaps);
            SetPixels(colors:  null);
            if(applyImmediately == false)
            {
                    return;
            }
            
            Apply();
        }
        private static bool IsRenderable(Spine.Attachment a)
        {
            if(a == 0)
            {
                    return (bool)0;
            }
            
            0 = (((Spine.Attachment.__il2cppRuntimeField_typeHierarchy + (Spine.MeshAttachment.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4 - null)) >> 5;
            return (bool)0;
        }
        private static UnityEngine.Rect SpineUnityFlipRect(UnityEngine.Rect rect, int textureHeight)
        {
            var val_3;
            float val_1 = rect.m_YMin.y;
            float val_2 = rect.m_YMin.height;
            float val_4 = (float)val_3;
            val_4 = val_4 - 2044661304;
            val_4 = val_4 - 2044661304;
            rect.m_YMin.y = val_4;
            return new UnityEngine.Rect() {m_XMin = val_4, m_Width = 2044661304};
        }
        private static UnityEngine.Rect GetUnityRect(Spine.AtlasRegion region)
        {
            int val_2;
            UnityEngine.Rect val_1 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.GetSpineAtlasRect(region:  2044777408, includeRotate:  false);
            UnityEngine.Rect val_3 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.SpineUnityFlipRect(rect:  new UnityEngine.Rect() {m_XMin = region}, textureHeight:  val_2);
            return new UnityEngine.Rect() {m_XMin = val_3.m_XMin, m_YMin = val_3.m_YMin, m_Width = val_3.m_Width, m_Height = val_3.m_Height};
        }
        private static UnityEngine.Rect GetUnityRect(Spine.AtlasRegion region, int textureHeight)
        {
            int val_2;
            UnityEngine.Rect val_1 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.GetSpineAtlasRect(region:  2044897600, includeRotate:  textureHeight);
            UnityEngine.Rect val_3 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.SpineUnityFlipRect(rect:  new UnityEngine.Rect() {m_XMin = region}, textureHeight:  val_2);
            return new UnityEngine.Rect() {m_XMin = val_3.m_XMin, m_YMin = val_3.m_YMin, m_Width = val_3.m_Width, m_Height = val_3.m_Height};
        }
        private static UnityEngine.Rect GetSpineAtlasRect(Spine.AtlasRegion region, bool includeRotate = True)
        {
            float val_2;
            float val_3;
            var val_4;
            var val_5;
            var val_6;
            if(R2 == 0)
            {
                goto label_0;
            }
            
            if((includeRotate + 68) == 0)
            {
                goto label_2;
            }
            
            val_2 = (float)includeRotate + 20;
            val_3 = (float)includeRotate + 24;
            goto label_3;
            label_0:
            if(includeRotate == false)
            {
                goto label_4;
            }
            
            label_2:
            val_4 = mem[includeRotate + 16];
            val_4 = includeRotate + 16;
            val_5 = mem[includeRotate + 20];
            val_5 = includeRotate + 20;
            val_6 = mem[includeRotate + 24];
            val_6 = includeRotate + 24;
            goto label_5;
            label_4:
            val_4 = 2621443;
            val_5 = 1;
            val_6 = 0;
            label_5:
            val_2 = 1f;
            val_3 = (float)includeRotate + 28;
            label_3:
            region = new UnityEngine.Rect(x:  val_3, y:  null, width:  val_2, height:  null);
            return new UnityEngine.Rect() {m_XMin = val_3, m_Width = val_2};
        }
        private static UnityEngine.Rect UVRectToTextureRect(UnityEngine.Rect uvRect, int texWidth, int texHeight)
        {
            var val_4;
            float val_1 = uvRect.m_YMin.x;
            uint val_6 = 2045133888;
            val_6 = val_6 * (float)texHeight;
            uvRect.m_YMin.x = val_6;
            float val_2 = uvRect.m_YMin.width;
            uint val_7 = 2045133888;
            val_7 = val_7 * (float)texHeight;
            uvRect.m_YMin.width = val_7;
            float val_3 = uvRect.m_YMin.y;
            uint val_8 = 2045133888;
            val_8 = val_8 * (float)val_4;
            uvRect.m_YMin.y = val_8;
            float val_5 = uvRect.m_YMin.height;
            uint val_9 = 2045133888;
            val_9 = val_9 * (float)val_4;
            uvRect.m_YMin.height = val_9;
            return new UnityEngine.Rect() {m_XMin = val_9};
        }
        private static UnityEngine.Rect TextureRectToUVRect(UnityEngine.Rect textureRect, int texWidth, int texHeight)
        {
            var val_1;
            float val_2 = textureRect.m_YMin.x;
            textureRect.m_YMin.x = UnityEngine.Mathf.InverseLerp(a:  (float)texHeight, b:  null, value:  null);
            float val_4 = textureRect.m_YMin.y;
            textureRect.m_YMin.y = UnityEngine.Mathf.InverseLerp(a:  (float)val_1, b:  null, value:  null);
            textureRect.m_YMin.width = UnityEngine.Mathf.InverseLerp(a:  textureRect.m_YMin.width, b:  null, value:  null);
            float val_9 = UnityEngine.Mathf.InverseLerp(a:  textureRect.m_YMin.height, b:  null, value:  null);
            textureRect.m_YMin.height = val_9;
            return new UnityEngine.Rect() {m_XMin = val_9};
        }
        private static Spine.AtlasRegion UVRectToAtlasRegion(UnityEngine.Rect uvRect, string name, Spine.AtlasPage page, float offsetX, float offsetY, bool rotate)
        {
            var val_1;
            int val_3;
            float val_11;
            Spine.AtlasPage val_21;
            int val_22;
            float val_23;
            var val_24;
            double val_25;
            val_21 = page;
            if(val_21 != 0)
            {
                    val_22 = page.width;
            }
            else
            {
                    val_22 = 83886592;
            }
            
            UnityEngine.Rect val_2 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.UVRectToTextureRect(uvRect:  new UnityEngine.Rect() {m_XMin = 1.517505E+35f, m_YMin = uvRect.m_XMin, m_Width = uvRect.m_YMin, m_Height = uvRect.m_Width}, texWidth:  uvRect.m_Height, texHeight:  83886592);
            UnityEngine.Rect val_4 = Spine.Unity.Modules.AttachmentTools.SpriteAtlasRegionExtensions.SpineUnityFlipRect(rect:  new UnityEngine.Rect() {m_XMin = 1.517507E+35f}, textureHeight:  val_3);
            float val_5 = x;
            float val_6 = y;
            val_23 = val_4.m_Width;
            if(val_1 != 0)
            {
                    float val_7 = height;
                val_24;
                val_25 = -D11;
                float val_8 = width;
            }
            else
            {
                    float val_9 = width;
                val_24;
                val_25 = -D11;
                float val_10 = height;
            }
            
            if(val_1 == 0)
            {
                    -D16 = -(-D16);
            }
            
            if(new Spine.AtlasRegion() != 0)
            {
                    typeof(Spine.AtlasRegion).__il2cppRuntimeField_8 = val_21;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_C = name;
                float val_13 = uvRect.m_XMin.xMin;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_20 = ;
                float val_14 = uvRect.m_XMin.xMax;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_28 = ;
                float val_15 = uvRect.m_XMin.yMax;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_24 = ;
                float val_16 = uvRect.m_XMin.yMin;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_2C = ;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_38 = val_10;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_3C = val_4.m_Width;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_40 = 0;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_30 = rotate;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_34 = val_11;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_10 = 2045366040;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_14 = val_23;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_18 = val_10;
                typeof(Spine.AtlasRegion).__il2cppRuntimeField_1C = val_4.m_Width;
            }
            else
            {
                    mem[8] = val_21;
                mem[12] = name;
                float val_17 = uvRect.m_XMin.xMin;
                val_21 = val_23;
                mem[32] = ;
                float val_18 = uvRect.m_XMin.xMax;
                mem[40] = ;
                float val_19 = uvRect.m_XMin.yMax;
                val_23 = ;
                mem[36] = val_23;
                float val_20 = uvRect.m_XMin.yMin;
                mem[44] = ;
                mem[64] = 0;
                mem[24] = val_10;
                mem[56] = val_10;
                mem[28] = val_4.m_Width;
                mem[60] = val_4.m_Width;
                mem[48] = rotate;
                mem[52] = val_11;
                mem[16] = 2045366040;
                mem[20] = val_21;
            }
            
            typeof(Spine.AtlasRegion).__il2cppRuntimeField_44 = val_1;
        }
        private static Spine.AtlasRegion GetAtlasRegion(Spine.Attachment a)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            if(a == 0)
            {
                    return;
            }
            
            val_1 = 0;
            if(((Spine.Attachment.__il2cppRuntimeField_typeHierarchy + (Spine.MeshAttachment.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    a = val_1;
            }
            
            val_2 = 0;
            if(null == 0)
            {
                    return;
            }
            
            val_1 = 0;
        }
        private static UnityEngine.Texture2D GetMainTexture(Spine.AtlasRegion region)
        {
            var val_2;
            var val_3;
            var val_4;
            if(region.page.rendererObject != 0)
            {
                    val_2 = null;
                val_2 = null;
                val_3 = 0;
                if(((System.Object.__il2cppRuntimeField_typeHierarchy + (UnityEngine.Material.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_2)
            {
                    region.page.rendererObject = 0;
            }
            
                val_3 = region.page.rendererObject;
            }
            else
            {
                    val_3 = 0;
            }
            
            val_4 = 0;
            UnityEngine.Texture val_1 = val_3.mainTexture;
            if(val_3 == 0)
            {
                    return;
            }
            
            if(1179403647 != null)
            {
                    val_3 = 0;
            }
            
            val_4 = val_3;
        }
        private static void ApplyPMA(UnityEngine.Texture2D texture, bool applyImmediately = True)
        {
            var val_8;
            var val_9;
            UnityEngine.Color[] val_1 = texture.GetPixels();
            if(texture < 1)
            {
                goto label_2;
            }
            
            val_8 = texture + 16;
            val_9 = 0;
            goto label_3;
            label_6:
            val_9 = 1;
            val_8 = val_8 + 16;
            label_3:
            mem2[0] = 1152921504761053184 * R7;
            mem2[0] = S2 * R7;
            mem2[0] = S4 * R7;
            mem2[0] = ???;
            if((texture - 1) != val_9)
            {
                goto label_6;
            }
            
            label_2:
            texture.SetPixels(colors:  texture);
            if(applyImmediately == false)
            {
                    return;
            }
            
            texture.Apply();
        }
        private static float InverseLerp(float a, float b, float value)
        {
            uint val_2 = 0;
            var val_1 = R1;
            val_1 = val_1 - val_2;
            val_2 = R2 - val_2;
            val_2 = val_2 / val_1;
            return (float)val_2;
        }
    
    }

}
