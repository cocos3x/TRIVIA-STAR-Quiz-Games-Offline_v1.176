using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonRendererCustomMaterials : MonoBehaviour
    {
        // Fields
        public Spine.Unity.SkeletonRenderer skeletonRenderer;
        protected System.Collections.Generic.List<Spine.Unity.Modules.SkeletonRendererCustomMaterials.SlotMaterialOverride> customSlotMaterials;
        protected System.Collections.Generic.List<Spine.Unity.Modules.SkeletonRendererCustomMaterials.AtlasMaterialOverride> customMaterialOverrides;
        
        // Methods
        private void SetCustomSlotMaterials()
        {
            var val_4;
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.skeletonRenderer, y:  0);
            if(val_1 != false)
            {
                    UnityEngine.Debug.LogError(message:  2020410544);
                return;
            }
            
            val_4 = 0;
            goto label_6;
            label_16:
            if(val_1 <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if(((0 + 0) + 16) == 0)
            {
                    if((System.String.IsNullOrEmpty(value:  (0 + 0) + 20)) != true)
            {
                    Spine.Slot val_3 = this.skeletonRenderer.skeleton.FindSlot(slotName:  (0 + 0) + 20);
                this.skeletonRenderer.customSlotMaterials.set_Item(key:  this.skeletonRenderer.skeleton, value:  (0 + 0) + 24);
            }
            
            }
            
            val_4 = 1;
            label_6:
            if(val_4 < this.skeletonRenderer.customSlotMaterials)
            {
                goto label_16;
            }
        
        }
        private void RemoveCustomSlotMaterials()
        {
            var val_8;
            var val_9;
            string val_10;
            val_8 = 0;
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.skeletonRenderer, y:  0);
            if(val_1 != false)
            {
                    UnityEngine.Debug.LogError(message:  2020410544);
                return;
            }
            
            val_9 = 0;
            goto label_7;
            label_22:
            if(val_1 <= val_9)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + val_8;
            val_10 = mem[(0 + val_8) + 20];
            val_10 = (0 + val_8) + 20;
            if((System.String.IsNullOrEmpty(value:  val_10)) != true)
            {
                    Spine.Slot val_3 = this.skeletonRenderer.skeleton.FindSlot(slotName:  val_10);
                val_10 = this.skeletonRenderer.skeleton;
            }
            
            val_8 = 12;
            val_9 = 1;
            label_7:
            if(val_9 < (this.skeletonRenderer.customSlotMaterials.Remove(key:  val_10)))
            {
                goto label_22;
            }
        
        }
        private void SetCustomMaterialOverrides()
        {
            var val_2;
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.skeletonRenderer, y:  0);
            if(val_1 != false)
            {
                    UnityEngine.Debug.LogError(message:  2020410544);
                return;
            }
            
            val_2 = 0;
            goto label_6;
            label_13:
            if(val_1 <= val_2)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            if(((0 + 0) + 16) == 0)
            {
                    this.skeletonRenderer.customMaterialOverride.set_Item(key:  (0 + 0) + 20, value:  (0 + 0) + 24);
            }
            
            val_2 = 1;
            label_6:
            if(val_2 < this.skeletonRenderer.customMaterialOverride)
            {
                goto label_13;
            }
        
        }
        private void RemoveCustomMaterialOverrides()
        {
            var val_6;
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.skeletonRenderer, y:  0);
            if(val_1 != false)
            {
                    UnityEngine.Debug.LogError(message:  2020410544);
                return;
            }
            
            val_6 = 0;
            goto label_7;
            label_19:
            if(val_1 <= val_6)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            val_6 = 1;
            label_7:
            if(val_6 < (this.skeletonRenderer.customMaterialOverride.Remove(key:  (0 + 0) + 20)))
            {
                goto label_19;
            }
        
        }
        private void OnEnable()
        {
            Spine.Unity.SkeletonRenderer val_4;
            if(this.skeletonRenderer == 0)
            {
                    object val_2 = this.GetComponent<System.Object>();
                val_4 = this;
                this.skeletonRenderer = this;
            }
            else
            {
                    val_4 = this.skeletonRenderer;
            }
            
            if(val_4 == 0)
            {
                    UnityEngine.Debug.LogError(message:  2020410544);
                return;
            }
            
            this.SetCustomMaterialOverrides();
            this.SetCustomSlotMaterials();
        }
        private void OnDisable()
        {
            if(this.skeletonRenderer == 0)
            {
                    UnityEngine.Debug.LogError(message:  2020410544);
                return;
            }
            
            this.RemoveCustomMaterialOverrides();
            this.RemoveCustomSlotMaterials();
        }
        public SkeletonRendererCustomMaterials()
        {
            System.Collections.Generic.List<SlotMaterialOverride> val_1 = new System.Collections.Generic.List<SlotMaterialOverride>();
            this.customSlotMaterials = null;
            System.Collections.Generic.List<AtlasMaterialOverride> val_2 = new System.Collections.Generic.List<AtlasMaterialOverride>();
            this.customMaterialOverrides = null;
        }
    
    }

}
