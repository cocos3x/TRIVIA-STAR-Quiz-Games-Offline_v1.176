using UnityEngine;

namespace Spine.Unity
{
    public class AtlasAsset : ScriptableObject
    {
        // Fields
        public UnityEngine.TextAsset atlasFile;
        public UnityEngine.Material[] materials;
        protected Spine.Atlas atlas;
        
        // Properties
        public bool IsLoaded { get; }
        
        // Methods
        public bool get_IsLoaded()
        {
            if(this.atlas != 0)
            {
                    this.atlas = 1;
            }
            
            return true;
        }
        public static Spine.Unity.AtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Material[] materials, bool initialize)
        {
            UnityEngine.Networking.PlayerConnection.PlayerConnection val_1 = UnityEngine.ScriptableObject.CreateInstance<UnityEngine.Networking.PlayerConnection.PlayerConnection>();
            if((public static Spine.Unity.AtlasAsset UnityEngine.ScriptableObject::CreateInstance<Spine.Unity.AtlasAsset>()) != 0)
            {
                    public static Spine.Unity.AtlasAsset UnityEngine.ScriptableObject::CreateInstance<Spine.Unity.AtlasAsset>().__il2cppRuntimeField_C = atlasText;
                public static Spine.Unity.AtlasAsset UnityEngine.ScriptableObject::CreateInstance<Spine.Unity.AtlasAsset>().__il2cppRuntimeField_10 = materials;
                if(initialize == false)
            {
                    return;
            }
            
                object val_2 = CreateTrack<System.Object>();
                return;
            }
        
        }
        public static Spine.Unity.AtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Texture2D[] textures, UnityEngine.Shader shader, bool initialize)
        {
            UnityEngine.TextAsset val_15;
            var val_16;
            twelvegigs.sweepstakes.Distribution val_17;
            var val_18;
            float val_19;
            float val_20;
            var val_21;
            var val_22;
            val_15 = atlasText;
            if(shader == 0)
            {
                    UnityEngine.Shader val_2 = UnityEngine.Shader.Find(name:  1975549904);
            }
            
            string val_3 = val_15.text;
            val_16 = 0;
            string val_4 = val_15.Replace(oldValue:  1975550000, newValue:  1098586544);
            val_17 = val_15;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
            val_18 = 0;
            System.String[] val_5 = val_17.Split(separator:  478563824);
            val_19 = ".png";
            val_20 = 1152921510046813136;
            goto label_13;
            label_19:
            string val_7 = UnityEngine.TextAsset.__il2cppRuntimeField_byval_arg.Trim();
            val_17 = UnityEngine.TextAsset.__il2cppRuntimeField_byval_arg;
            val_18 = 1;
            string val_8 = typeof(UnityEngine.TextAsset).__il2cppRuntimeField_14.Trim();
            val_16 = 0;
            string val_9 = typeof(UnityEngine.TextAsset).__il2cppRuntimeField_14.Replace(oldValue:  1975550080, newValue:  1098586544);
            val_15 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_17 = typeof(UnityEngine.TextAsset).__il2cppRuntimeField_14;
            Add(item:  val_17);
            label_13:
            if(val_18 < 1152921504687730687)
            {
                goto label_19;
            }
            
            val_21 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(val_15 < 1)
            {
                goto label_26;
            }
            
            var val_15 = 0;
            val_22 = val_15;
            goto label_27;
            label_31:
            label_27:
            string val_10 = 1152921506184672528.name;
            val_16 = 0;
            if((System.String.Equals(a:  List<T>.__il2cppRuntimeField_10, b:  1577825552, comparisonType:  5)) == true)
            {
                goto label_30;
            }
            
            val_15 = val_15 + 1;
            if(val_15 < val_15)
            {
                goto label_31;
            }
            
            val_17 = 0;
            goto label_32;
            label_26:
            val_17 = 0;
            goto label_33;
            label_30:
            UnityEngine.Material val_12 = null;
            val_17 = val_12;
            val_12 = new UnityEngine.Material(shader:  1975549904);
            mainTexture = 1577825552;
            label_32:
            val_21 = val_21;
            label_33:
            if(152875008 != 0)
            {
                    val_19 = 0 + 1;
                typeof(UnityEngine.Material[]).__il2cppRuntimeField_10 = val_17;
                return Spine.Unity.AtlasAsset.CreateRuntimeInstance(atlasText:  val_15, materials:  1564202640, initialize:  initialize);
            }
            
            System.ArgumentException val_14 = new System.ArgumentException(message:  1975550160);
        }
        public static Spine.Unity.AtlasAsset CreateRuntimeInstance(UnityEngine.TextAsset atlasText, UnityEngine.Texture2D[] textures, UnityEngine.Material materialPropertySource, bool initialize)
        {
            UnityEngine.Texture2D[] val_5;
            UnityEngine.TextAsset val_6;
            var val_7;
            val_5 = textures;
            val_6 = atlasText;
            val_7 = 0;
            UnityEngine.Shader val_1 = materialPropertySource.shader;
            Spine.Unity.AtlasAsset val_2 = Spine.Unity.AtlasAsset.CreateRuntimeInstance(atlasText:  val_6, textures:  val_5, shader:  materialPropertySource, initialize:  initialize);
            var val_3 = SB + 16;
            goto label_2;
            label_8:
            val_5 = mem[(SB + 16) + 0];
            val_5 = (SB + 16) + 0;
            val_5.CopyPropertiesFromMaterial(mat:  materialPropertySource);
            System.String[] val_4 = materialPropertySource.shaderKeywords;
            val_6 = materialPropertySource;
            val_5.shaderKeywords = val_6;
            val_7 = 1;
            label_2:
            if(val_7 < (SB + 12))
            {
                goto label_8;
            }
        
        }
        private void Reset()
        {
            goto typeof(Spine.Unity.AtlasAsset).__il2cppRuntimeField_DC;
        }
        public virtual void Clear()
        {
            this.atlas = 0;
        }
        public virtual Spine.Atlas GetAtlas()
        {
            var val_11;
            var val_12;
            var val_13;
            if(this.atlasFile == 0)
            {
                    val_11 = 0;
                string val_2 = this.name;
                val_12 = this;
                val_13 = "Atlas file not set for atlas asset: ";
            }
            else
            {
                    val_11 = 0;
                string val_3 = this.name;
                val_12 = this;
                val_13 = "Materials not set for atlas asset: ";
            }
            
            string val_4 = 1976175648 + 1976212240;
            UnityEngine.Debug.LogError(message:  1976175648, context:  1976212240);
        }
        public UnityEngine.Mesh GenerateMesh(string name, UnityEngine.Mesh mesh, out UnityEngine.Material material, float scale = 0.01)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_27;
            UnityEngine.Object val_28;
            Spine.Atlas val_29;
            UnityEngine.Material val_30;
            var val_31;
            var val_32;
            var val_33;
            Spine.Atlas val_34;
            UnityEngine.Material val_35;
            val_27 = 1152921510878252400;
            val_28 = mesh;
            val_29 = this.atlas;
            val_30 = 0;
            Spine.AtlasRegion val_1 = val_29.FindRegion(name:  name);
            material = val_30;
            if(val_29 == 0)
            {
                    return;
            }
            
            if(val_28 == 0)
            {
                    UnityEngine.Mesh val_3 = null;
                val_31 = val_3;
                val_3 = new UnityEngine.Mesh();
                name = name;
            }
            
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            UnityEngine.Color val_5 = UnityEngine.Color.white;
            UnityEngine.Color val_6 = UnityEngine.Color.white;
            UnityEngine.Color val_7 = UnityEngine.Color.white;
            float val_28 = (float)val_7.r;
            float val_27 = (float)val_7.b;
            val_7.r = val_28 * (-0.5f);
            val_7.b = val_27 * (-0.5f);
            UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_7.r, y:  val_7.g, z:  val_7.b);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 5.203806E+32f, y = val_9.x, z = val_9.y}, d:  val_7.r);
            val_27 = val_27 * 0.5f;
            val_28 = val_28 * 0.5f;
            UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_10.x, y:  val_10.y, z:  val_10.z);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 5.203797E+32f, y = val_11.x, z = val_11.y}, d:  val_10.x);
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_1C = val_13;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_14;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_15;
            UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  val_12.x, y:  val_12.y, z:  val_12.z);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 5.203788E+32f, y = val_16.x, z = val_16.y}, d:  val_12.x);
            UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  val_17.x, y:  val_17.y, z:  val_17.z);
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 5.203778E+32f, y = val_18.x, z = val_18.y}, d:  val_17.x);
            if((this.atlas + 68) != 0)
            {
                    UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  this.atlas + 44, y:  val_19.y);
                val_32 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = val_20.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_14 = val_20.y;
                UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  this.atlas + 44, y:  val_19.y);
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_18 = val_21.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_1C = val_21.y;
                val_33 = null;
                UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  this.atlas + 44, y:  val_19.y);
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_22.x;
            }
            else
            {
                    UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  this.atlas + 44, y:  val_19.y);
                val_32 = 0;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = val_23.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_14 = val_23.y;
                UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  this.atlas + 44, y:  val_19.y);
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_18 = val_24.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_1C = val_24.y;
                UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  this.atlas + 44, y:  val_19.y);
                val_33 = null;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_25.x;
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = val_25.y;
            }
            
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  this.atlas + 44, y:  val_19.y);
            val_29 = val_31;
            val_34 = val_29;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_26.x;
            if(val_29 != 0)
            {
                    triangles = 478302960;
                vertices = 533912224;
                uv = 533908128;
                colors = 533899936;
                triangles = 478302960;
                RecalculateNormals();
            }
            else
            {
                    0.triangles = 478302960;
                0.vertices = 533912224;
                0.uv = 533908128;
                0.colors = 533899936;
                0.triangles = 478302960;
                0.RecalculateNormals();
            }
            
            val_27 = val_27;
            RecalculateBounds();
            if((this.atlas + 8 + 32) != 0)
            {
                    val_35 = this.atlas + 8 + 32;
                val_35 = 0;
                material = val_35;
            }
            else
            {
                    material = 0;
            }
            
            val_30 = val_29;
        }
        public AtlasAsset()
        {
        
        }
    
    }

}
