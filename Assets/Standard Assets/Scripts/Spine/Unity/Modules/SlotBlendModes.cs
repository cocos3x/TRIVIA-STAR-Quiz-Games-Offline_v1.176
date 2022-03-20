using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SlotBlendModes : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.Dictionary<Spine.Unity.Modules.SlotBlendModes.MaterialTexturePair, UnityEngine.Material> materialTable;
        public UnityEngine.Material multiplyMaterialSource;
        public UnityEngine.Material screenMaterialSource;
        private UnityEngine.Texture2D texture;
        private bool <Applied>k__BackingField;
        
        // Properties
        internal static System.Collections.Generic.Dictionary<Spine.Unity.Modules.SlotBlendModes.MaterialTexturePair, UnityEngine.Material> MaterialTable { get; }
        public bool Applied { get; set; }
        
        // Methods
        internal static System.Collections.Generic.Dictionary<Spine.Unity.Modules.SlotBlendModes.MaterialTexturePair, UnityEngine.Material> get_MaterialTable()
        {
            if(Spine.Unity.Modules.SlotBlendModes.materialTable != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<MaterialTexturePair, UnityEngine.Material> val_1 = new System.Collections.Generic.Dictionary<MaterialTexturePair, UnityEngine.Material>();
            mem2[0] = null;
        }
        internal static UnityEngine.Material GetMaterialFor(UnityEngine.Material materialSource, UnityEngine.Texture2D texture)
        {
            var val_10;
            var val_11;
            val_10 = 0;
            val_11 = 1152921504765685760;
            if(materialSource == 0)
            {
                    return;
            }
            
            val_10 = 0;
            bool val_2 = UnityEngine.Object.op_Equality(x:  texture, y:  0);
            if(val_2 == true)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<MaterialTexturePair, UnityEngine.Material> val_3 = Spine.Unity.Modules.SlotBlendModes.MaterialTable;
            if((val_2.TryGetValue(key:  new MaterialTexturePair() {texture2D = texture, material = materialSource}, value: out  UnityEngine.Material val_4 = 2039195564)) != true)
            {
                    UnityEngine.Material val_6 = new UnityEngine.Material(source:  materialSource);
                string val_7 = texture.name;
                string val_8 = materialSource.name;
                string val_9 = 2039182480 + texture + 1359327184 + materialSource;
                name = 2039182480;
                mainTexture = texture;
                val_11 = val_6;
                val_2.set_Item(key:  new MaterialTexturePair() {texture2D = texture, material = materialSource}, value:  152875008);
            }
            
            val_10 = val_6;
        }
        public bool get_Applied()
        {
            return (bool)this.<Applied>k__BackingField;
        }
        private void set_Applied(bool value)
        {
            this.<Applied>k__BackingField = value;
        }
        private void Start()
        {
            if((this.<Applied>k__BackingField) == true)
            {
                    return;
            }
            
            this.Apply();
        }
        private void OnDestroy()
        {
            if((this.<Applied>k__BackingField) == false)
            {
                    return;
            }
            
            this.Remove();
        }
        public void Apply()
        {
            UnityEngine.Material val_6;
            var val_13;
            this.GetTexture();
            if(this.texture == 0)
            {
                    return;
            }
            
            object val_2 = this.GetComponent<System.Object>();
            if(2039808560 == 0)
            {
                    return;
            }
            
            if(this != 0)
            {
                
            }
            else
            {
                    val_13 = 52;
            }
            
            ExposedList.Enumerator<T> val_4 = GetEnumerator();
            label_25:
            if(MoveNext() == false)
            {
                goto label_11;
            }
            
            if((val_6 + 8 + 56) == 2)
            {
                goto label_14;
            }
            
            if(((val_6 + 8 + 56) != 3) || (this.screenMaterialSource == 0))
            {
                goto label_25;
            }
            
            UnityEngine.Material val_8 = Spine.Unity.Modules.SlotBlendModes.GetMaterialFor(materialSource:  this.screenMaterialSource, texture:  this.texture);
            val_13.set_Item(key:  val_6, value:  this.screenMaterialSource);
            goto label_25;
            label_14:
            if(this.multiplyMaterialSource == 0)
            {
                goto label_25;
            }
            
            UnityEngine.Material val_10 = Spine.Unity.Modules.SlotBlendModes.GetMaterialFor(materialSource:  this.multiplyMaterialSource, texture:  this.texture);
            val_13.set_Item(key:  val_6, value:  this.multiplyMaterialSource);
            goto label_25;
            label_11:
            Dispose();
            this.<Applied>k__BackingField = true;
            ExposedList.Enumerator<T> val_11 = this.GetEnumerator();
        }
        public void Remove()
        {
            UnityEngine.Material val_6;
            Spine.Unity.Modules.SlotBlendModes val_16;
            var val_17;
            val_16 = this;
            this.GetTexture();
            val_17 = 1152921504765685760;
            if(this.texture == 0)
            {
                    return;
            }
            
            object val_2 = this.GetComponent<System.Object>();
            if(2039961520 == 0)
            {
                    return;
            }
            
            if(val_16 != 0)
            {
                
            }
            else
            {
                    val_16 = 52;
            }
            
            ExposedList.Enumerator<T> val_4 = GetEnumerator();
            label_25:
            if(MoveNext() == false)
            {
                goto label_11;
            }
            
            if((val_6 + 8 + 56) == 2)
            {
                goto label_14;
            }
            
            if(((val_6 + 8 + 56) != 3) || ((val_16.TryGetValue(key:  val_6, value: out  UnityEngine.Material val_7 = 2039949460)) == false))
            {
                goto label_25;
            }
            
            UnityEngine.Material val_9 = Spine.Unity.Modules.SlotBlendModes.GetMaterialFor(materialSource:  this.screenMaterialSource, texture:  this.texture);
            if(0 != this.screenMaterialSource)
            {
                goto label_25;
            }
            
            bool val_10 = val_16.Remove(key:  val_6);
            goto label_25;
            label_14:
            if((val_16.TryGetValue(key:  val_6, value: out  UnityEngine.Material val_11 = 2039949460)) == false)
            {
                goto label_25;
            }
            
            UnityEngine.Material val_13 = Spine.Unity.Modules.SlotBlendModes.GetMaterialFor(materialSource:  mem[1152921510941775804], texture:  this.texture);
            if(0 != mem[1152921510941775804])
            {
                goto label_25;
            }
            
            bool val_14 = val_16.Remove(key:  val_6);
            goto label_25;
            label_11:
            Dispose();
            mem[1152921510941775816] = 0;
            ExposedList.Enumerator<T> val_15 = this.GetEnumerator();
        }
        public void GetTexture()
        {
            UnityEngine.Texture2D val_8 = 1152921504765685760;
            if(this.texture != 0)
            {
                    return;
            }
            
            object val_2 = this.GetComponent<System.Object>();
            if(2040089904 == 0)
            {
                    return;
            }
            
            if(this.texture == 0)
            {
                    return;
            }
            
            if(this.texture == 0)
            {
                    return;
            }
            
            if(this.texture == 0)
            {
                    return;
            }
            
            val_8 = 0;
            UnityEngine.Texture val_7 = this.texture.mainTexture;
            if(this.texture != 0)
            {
                    if(null != null)
            {
                    this.texture = 0;
            }
            
                val_8 = this.texture;
            }
            
            this.texture = val_8;
        }
        public SlotBlendModes()
        {
        
        }
    
    }

}
