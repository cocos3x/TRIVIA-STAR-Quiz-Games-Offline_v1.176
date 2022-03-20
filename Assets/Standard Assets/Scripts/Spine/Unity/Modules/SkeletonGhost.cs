using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonGhost : MonoBehaviour
    {
        // Fields
        private const UnityEngine.HideFlags GhostHideFlags = 1;
        private const string GhostingShaderName = "Spine/Special/SkeletonGhost";
        public bool ghostingEnabled;
        public float spawnRate;
        public UnityEngine.Color32 color;
        public bool additive;
        public int maximumGhosts;
        public float fadeSpeed;
        public UnityEngine.Shader ghostShader;
        public float textureFade;
        public bool sortWithDistanceOnly;
        public float zOffset;
        private float nextSpawnTime;
        private Spine.Unity.Modules.SkeletonGhostRenderer[] pool;
        private int poolIndex;
        private Spine.Unity.SkeletonRenderer skeletonRenderer;
        private UnityEngine.MeshRenderer meshRenderer;
        private UnityEngine.MeshFilter meshFilter;
        private readonly System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> materialTable;
        
        // Methods
        private void Start()
        {
            Spine.Unity.Modules.SkeletonGhostRenderer[] val_15;
            var val_16;
            if(this.ghostShader == 0)
            {
                    UnityEngine.Shader val_2 = UnityEngine.Shader.Find(name:  2021719728);
                this.ghostShader = "Spine/Special/SkeletonGhost";
            }
            
            object val_3 = this.GetComponent<System.Object>();
            this.skeletonRenderer = this;
            object val_4 = this.GetComponent<System.Object>();
            this.meshFilter = this;
            object val_5 = this.GetComponent<System.Object>();
            this.meshRenderer = this;
            var val_16 = 0;
            float val_6 = UnityEngine.Time.time;
            float val_15 = this.spawnRate;
            val_15 = 0 + val_15;
            this.nextSpawnTime = val_15;
            this.pool = null;
            if(this.maximumGhosts >= 1)
            {
                    do
            {
                UnityEngine.GameObject val_7 = this.gameObject;
                string val_8 = this.name;
                string val_9 = 2021791040 + 2021724976;
                System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(269381632)});
                typeof(System.Type[]).__il2cppRuntimeField_10 = null;
                UnityEngine.GameObject val_11 = new UnityEngine.GameObject(name:  2021791040, components:  473824320);
                val_15 = this.pool;
                object val_12 = GetComponent<System.Object>();
                val_15[val_16] = val_11;
                if(val_11 != 0)
            {
                    SetActive(value:  false);
            }
            else
            {
                    SetActive(value:  false);
            }
            
                hideFlags = 1;
                val_16 = val_16 + 1;
            }
            while(val_16 < this.maximumGhosts);
            
            }
            
            if(this.skeletonRenderer == 0)
            {
                    return;
            }
            
            val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = this.skeletonRenderer;
            AnimationState.TrackEntryEventDelegate val_14 = new AnimationState.TrackEntryEventDelegate(object:  2021791040, method:  new IntPtr(2021766016));
            this.skeletonRenderer.add_Event(value:  263204864);
        }
        private void OnEvent(Spine.TrackEntry trackEntry, Spine.Event e)
        {
            if((e.data.name.Equals(value:  2021940480, comparisonType:  4)) == false)
            {
                    return;
            }
            
            if(e.intValue > 0)
            {
                    0 = 1;
            }
            
            this.ghostingEnabled = true;
            if(e.intValue > 0)
            {
                    this.spawnRate = e.floatValue;
            }
            
            if((System.String.IsNullOrEmpty(value:  e.stringValue)) == true)
            {
                    return;
            }
            
            UnityEngine.Color32 val_3 = Spine.Unity.Modules.SkeletonGhost.HexToColor(hex:  e.stringValue);
            this.color = val_3;
        }
        private void Ghosting(float val)
        {
            if()
            {
                    0 = 1;
            }
            
            this.ghostingEnabled = true;
        }
        private void Update()
        {
            float val_9;
            float val_22;
            var val_24;
            var val_25;
            var val_26;
            if(this.ghostingEnabled == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.time;
            val_22 = this.nextSpawnTime;
            if(this.ghostingEnabled < false)
            {
                    return;
            }
            
            Spine.Unity.Modules.SkeletonGhostRenderer val_22 = this.pool[this.poolIndex];
            UnityEngine.GameObject val_2 = val_22.gameObject;
            UnityEngine.Material[] val_3 = this.meshRenderer.sharedMaterials;
            val_24 = 0;
            goto label_7;
            label_23:
            if((this.materialTable.ContainsKey(key:  UnityEngine.MeshRenderer.__il2cppRuntimeField_byval_arg)) != false)
            {
                    UnityEngine.Material val_5 = this.materialTable.Item[UnityEngine.MeshRenderer.__il2cppRuntimeField_byval_arg];
                val_25 = this.materialTable;
            }
            else
            {
                    UnityEngine.Material val_6 = null;
                val_25 = val_6;
                val_6 = new UnityEngine.Material(source:  UnityEngine.MeshRenderer.__il2cppRuntimeField_byval_arg);
                if(val_25 != 0)
            {
                    val_26 = 0;
                shader = this.ghostShader;
                UnityEngine.Color val_7 = UnityEngine.Color.white;
            }
            else
            {
                    val_26 = 0;
                shader = this.ghostShader;
                UnityEngine.Color val_8 = UnityEngine.Color.white;
            }
            
                color = new UnityEngine.Color() {a = val_9};
                if((HasProperty(name:  2022256736)) != false)
            {
                    SetFloat(name:  2022256736, value:  val_8.r);
            }
            
                this.materialTable.Add(key:  UnityEngine.MeshRenderer.__il2cppRuntimeField_byval_arg, value:  152875008);
            }
            
            val_24 = 1;
            typeof(UnityEngine.MeshRenderer).__il2cppRuntimeField_10 = val_25;
            label_7:
            if(val_24 < val_25)
            {
                goto label_23;
            }
            
            UnityEngine.Transform val_11 = val_22.transform;
            UnityEngine.Transform val_12 = this.meshRenderer.transform;
            val_22.parent = 2022376064;
            UnityEngine.Mesh val_13 = this.meshFilter.sharedMesh;
            int val_15 = this.meshRenderer.sortingOrder;
            bool val_16 = this.sortWithDistanceOnly - 1;
            if(this.additive == true)
            {
                    this.additive = 1;
            }
            
            this.pool[this.poolIndex].Initialize(mesh:  this.meshFilter, materials:  this.meshRenderer, color:  new UnityEngine.Color32() {r = this.color, g = this.color, b = this.color, a = this.color}, additive:  true, speed:  val_8.r, sortingLayerID:  this.fadeSpeed, sortingOrder:  this.meshRenderer.sortingLayerID);
            UnityEngine.Vector3 val_17 = new UnityEngine.Vector3(x:  val_8.r, y:  val_8.g, z:  val_8.b);
            val_22.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.identity;
            val_22.localRotation = new UnityEngine.Quaternion() {x = val_17.z, w = val_9};
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
            val_22.localScale = new UnityEngine.Vector3();
            val_22.parent = 0;
            int val_20 = this.poolIndex + 1;
            this.poolIndex = val_20;
            if(val_20 == this.poolIndex)
            {
                    this.poolIndex = 0;
                this.poolIndex = this.poolIndex;
            }
            
            float val_21 = UnityEngine.Time.time;
            float val_24 = this.spawnRate;
            val_24 = 0 + val_24;
            this.nextSpawnTime = val_24;
        }
        private void OnDestroy()
        {
            UnityEngine.Object val_8;
            if(this.maximumGhosts >= 1)
            {
                    do
            {
                var val_1 = 4 - 4;
                if(this.pool[0] != 0)
            {
                    this.pool[0].Cleanup();
            }
            
                var val_3 = 4 + 1;
            }
            while((4 - 3) < this.maximumGhosts);
            
            }
            
            Dictionary.ValueCollection<TKey, TValue> val_5 = this.materialTable.Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_6 = GetEnumerator();
            label_16:
            if(MoveNext() == false)
            {
                goto label_13;
            }
            
            UnityEngine.Object.Destroy(obj:  val_8);
            goto label_16;
            label_13:
            Dispose();
        }
        private static UnityEngine.Color32 HexToColor(string hex)
        {
            var val_13;
            byte val_14;
            if(hex.m_stringLength > 5)
            {
                    string val_1 = hex.Replace(oldValue:  1726048032, newValue:  1098586544);
                string val_2 = hex.Substring(startIndex:  0, length:  2);
                string val_4 = hex.Substring(startIndex:  2, length:  2);
                string val_6 = hex.Substring(startIndex:  4, length:  2);
                val_13 = 255;
                if(hex.m_stringLength == 8)
            {
                    string val_8 = hex.Substring(startIndex:  6, length:  2);
            }
            
                UnityEngine.Color32 val_10 = new UnityEngine.Color32(r:  System.Byte.Parse(s:  hex, style:  515), g:  System.Byte.Parse(s:  hex, style:  515), b:  System.Byte.Parse(s:  hex, style:  515), a:  System.Byte.Parse(s:  hex, style:  515));
                val_14 = val_10.r;
                return new UnityEngine.Color32() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
            }
            
            UnityEngine.Color val_11 = UnityEngine.Color.magenta;
            UnityEngine.Color32 val_12 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            return new UnityEngine.Color32() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
        }
        public SkeletonGhost()
        {
            this.spawnRate = 0.05f;
            this.ghostingEnabled = true;
            UnityEngine.Color32 val_1 = new UnityEngine.Color32(r:  255, g:  255, b:  255, a:  0);
            this.additive = true;
            this.color = val_1.r;
            this.maximumGhosts = 10;
            this.fadeSpeed = 10f;
            this.textureFade = 1f;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.materialTable = null;
        }
    
    }

}
