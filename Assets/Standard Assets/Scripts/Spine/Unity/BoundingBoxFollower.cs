using UnityEngine;

namespace Spine.Unity
{
    public class BoundingBoxFollower : MonoBehaviour
    {
        // Fields
        internal static bool DebugMessages;
        public Spine.Unity.SkeletonRenderer skeletonRenderer;
        public string slotName;
        public bool isTrigger;
        public bool clearStateOnDisable;
        private Spine.Slot slot;
        private Spine.BoundingBoxAttachment currentAttachment;
        private string currentAttachmentName;
        private UnityEngine.PolygonCollider2D currentCollider;
        public readonly System.Collections.Generic.Dictionary<Spine.BoundingBoxAttachment, UnityEngine.PolygonCollider2D> colliderTable;
        public readonly System.Collections.Generic.Dictionary<Spine.BoundingBoxAttachment, string> nameTable;
        
        // Properties
        public Spine.Slot Slot { get; }
        public Spine.BoundingBoxAttachment CurrentAttachment { get; }
        public string CurrentAttachmentName { get; }
        public UnityEngine.PolygonCollider2D CurrentCollider { get; }
        public bool IsTrigger { get; }
        
        // Methods
        public Spine.Slot get_Slot()
        {
        
        }
        public Spine.BoundingBoxAttachment get_CurrentAttachment()
        {
        
        }
        public string get_CurrentAttachmentName()
        {
        
        }
        public UnityEngine.PolygonCollider2D get_CurrentCollider()
        {
        
        }
        public bool get_IsTrigger()
        {
            return (bool)this.isTrigger;
        }
        private void Start()
        {
            this.Initialize();
        }
        private void OnEnable()
        {
            if(this.skeletonRenderer != 0)
            {
                    SkeletonRenderer.SkeletonRendererDelegate val_2 = new SkeletonRenderer.SkeletonRendererDelegate(object:  1989326208, method:  new IntPtr(1989297088));
                this.skeletonRenderer.remove_OnRebuild(value:  268156928);
                SkeletonRenderer.SkeletonRendererDelegate val_3 = new SkeletonRenderer.SkeletonRendererDelegate(object:  1989326208, method:  new IntPtr(1989297088));
                this.skeletonRenderer.add_OnRebuild(value:  268156928);
            }
            
            this.Initialize();
        }
        private void HandleRebuild(Spine.Unity.SkeletonRenderer sr)
        {
            this.Initialize();
        }
        public void Initialize()
        {
            Spine.BoundingBoxAttachment val_11;
            string val_15;
            var val_27;
            string val_28;
            Spine.BoundingBoxAttachment val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            if(mem[1152921510891392124] == 0)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  mem[1152921510891392128])) == true)
            {
                    return;
            }
            
            if(mem[1152921510891392152].Count >= 1)
            {
                    val_27 = mem[1152921510891392136];
                if(val_27 != 0)
            {
                    if(mem[1152921510891392124] == 0)
            {
                    val_27 = mem[1152921510891392136];
                if(val_27 == 0)
            {
                goto label_84;
            }
            
            }
            
                if((mem[1152921510891392124] + 80) == (mem[1152921510891392136] + 12 + 12))
            {
                    val_28 = mem[mem[1152921510891392136] + 8];
                val_28 = mem[1152921510891392136] + 8;
                if((System.String.op_Equality(a:  mem[1152921510891392128], b:  mem[1152921510891392136] + 8 + 12)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            }
            
            this.DisposeColliders();
            Spine.Slot val_5 = mem[1152921510891392124] + 80.FindSlot(slotName:  mem[1152921510891392128]);
            val_28 = mem[1152921510891392128];
            mem[1152921510891392136] = mem[1152921510891392124] + 80;
            int val_6 = mem[1152921510891392124] + 80.FindSlotIndex(slotName:  val_28);
            if(mem[1152921510891392136] == 0)
            {
                goto label_19;
            }
            
            UnityEngine.GameObject val_7 = this.gameObject;
            val_28 = this;
            if(this.activeInHierarchy == false)
            {
                goto label_87;
            }
            
            ExposedList.Enumerator<T> val_9 = GetEnumerator();
            val_28 = 1152921504874418176;
            label_47:
            if(MoveNext() == false)
            {
                goto label_25;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_12 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_11.FindNamesForSlot(slotIndex:  val_6, names:  80883712);
            List.Enumerator<T> val_13 = GetEnumerator();
            label_44:
            if(MoveNext() == false)
            {
                goto label_28;
            }
            
            Spine.Attachment val_16 = val_11.GetAttachment(slotIndex:  val_6, name:  val_15);
            val_29 = 0;
            if(val_11 != 0)
            {
                    if(((val_11 + 100 + (Spine.BoundingBoxAttachment.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) == null)
            {
                    val_29 = val_11;
            }
            
            }
            
            val_30 = null;
            val_30 = null;
            if(val_29 == 0)
            {
                    string val_17 = 1989549760 + mem[1152921510891392128];
                UnityEngine.Debug.Log(message:  1989549760);
            }
            
            if(val_29 == 0)
            {
                goto label_44;
            }
            
            UnityEngine.GameObject val_18 = this.gameObject;
            UnityEngine.PolygonCollider2D val_19 = Spine.Unity.SkeletonUtility.AddBoundingBoxAsComponent(box:  val_29, slot:  mem[1152921510891392136], gameObject:  1989577840, isTrigger:  mem[1152921510891392132]);
            val_29.enabled = false;
            val_29.hideFlags = 8;
            if(mem[1152921510891392132] == true)
            {
                    mem[1152921510891392132] = 1;
            }
            
            val_29.isTrigger = true;
            mem[1152921510891392152].Add(key:  val_29, value:  val_29);
            mem[1152921510891392156].Add(key:  val_29, value:  val_15);
            goto label_44;
            label_28:
            var val_20 = 0 + 1;
            mem2[0] = 473;
            Dispose();
            if(val_20 == 1)
            {
                goto label_47;
            }
            
            if((1989565720 + ((0 + 1)) << 2) == 473)
            {
                    val_20 = val_20 >> 31;
                val_20 = ~(val_20 >> 31);
                val_20 = val_20 + val_20;
            }
            
            goto label_47;
            label_19:
            val_31 = null;
            val_31 = null;
            if(Spine.Unity.BoundingBoxFollower.DebugMessages == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_21 = this.gameObject;
            string val_22 = this.name;
            val_32 = "Slot \'{0}\' not found for BoundingBoxFollower on \'{1}\'. (Previous colliders were disposed.)";
            string val_23 = System.String.Format(format:  1989553072, arg0:  mem[1152921510891392128], arg1:  1989577840);
            goto label_65;
            label_25:
            Dispose();
            label_87:
            val_33 = null;
            val_33 = null;
            if(Spine.Unity.BoundingBoxFollower.DebugMessages == false)
            {
                    return;
            }
            
            if(mem[1152921510891392152].Count != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_25 = this.gameObject;
            if(this.activeInHierarchy == false)
            {
                goto label_77;
            }
            
            val_32 = "Bounding Box Follower not valid! Slot [";
            string val_27 = 1989553504 + mem[1152921510891392128] + 1989553328;
            label_65:
            label_77:
            UnityEngine.Debug.LogWarning(message:  1989553504);
            return;
            label_84:
            if(473 != 1)
            {
                goto label_85;
            }
            
            Dispose();
            if(val_20 == 0)
            {
                goto label_87;
            }
            
            goto label_87;
            label_85:
        }
        private void OnDisable()
        {
            if(this.clearStateOnDisable == false)
            {
                    return;
            }
            
            this.ClearState();
        }
        public void ClearState()
        {
            var val_4;
            if(this.colliderTable == 0)
            {
                goto label_1;
            }
            
            Dictionary.ValueCollection<TKey, TValue> val_1 = this.colliderTable.Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            val_4.enabled = false;
            goto label_5;
            label_3:
            Dispose();
            label_1:
            this.currentAttachment = 0;
            this.currentAttachmentName = 0;
            this.currentCollider = 0;
        }
        private void DisposeColliders()
        {
            string val_7;
            float val_8;
            UnityEngine.Object val_9;
            T[] val_1 = this.GetComponents<System.Object>();
            if(this.skeletonRenderer == 0)
            {
                    return;
            }
            
            if(UnityEngine.Application.isEditor == false)
            {
                goto label_3;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_4;
            }
            
            if(this.skeletonRenderer < 1)
            {
                goto label_23;
            }
            
            val_7 = this.slotName;
            var val_7 = 0;
            val_8 = 1152921504765685760;
            do
            {
                val_9 = mem[this.slotName + 0];
                if(val_9 != 0)
            {
                    UnityEngine.Object.Destroy(obj:  val_9);
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < this.skeletonRenderer);
            
            goto label_23;
            label_3:
            if(this.skeletonRenderer < 1)
            {
                goto label_23;
            }
            
            val_7 = this.slotName;
            var val_8 = 0;
            val_8 = 1152921504765685760;
            do
            {
                val_9 = mem[this.slotName + 0];
                if(val_9 != 0)
            {
                    UnityEngine.Object.Destroy(obj:  val_9);
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < this.skeletonRenderer);
            
            goto label_23;
            label_4:
            if(this.skeletonRenderer >= 1)
            {
                    val_7 = this.slotName;
                var val_9 = 0;
                val_8 = 1152921504765685760;
                do
            {
                val_9 = mem[this.slotName + 0];
                if(val_9 != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  val_9);
            }
            
                val_9 = val_9 + 1;
            }
            while(val_9 < this.skeletonRenderer);
            
            }
            
            label_23:
            this.colliderTable.Clear();
            this.nameTable.Clear();
        }
        private void LateUpdate()
        {
            if(this.slot == this.currentAttachment)
            {
                    return;
            }
            
            this.MatchAttachment(attachment:  this.slot = this.slot.attachment);
        }
        private void MatchAttachment(Spine.Attachment attachment)
        {
            Spine.BoundingBoxAttachment val_4;
            var val_5;
            UnityEngine.PolygonCollider2D val_6;
            UnityEngine.PolygonCollider2D val_7;
            val_4 = 0;
            if(attachment != 0)
            {
                    if(((Spine.Attachment.__il2cppRuntimeField_typeHierarchy + (Spine.BoundingBoxAttachment.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_4 = 0;
            }
            
            }
            
            val_5 = null;
            val_5 = null;
            if(val_4 == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  1990223408);
            }
            
            val_6 = this.currentCollider;
            if(val_6 != 0)
            {
                    val_6 = this.currentCollider;
                val_6.enabled = false;
            }
            
            if(val_4 != 0)
            {
                    UnityEngine.PolygonCollider2D val_2 = this.colliderTable.Item[0];
                this.currentCollider = this.colliderTable;
                this.colliderTable.enabled = true;
                val_6 = this.nameTable;
                this.currentAttachment = val_4;
                val_7 = val_6;
                string val_3 = val_7.Item[0];
            }
            else
            {
                    val_7 = 0;
                this.currentAttachment = val_4;
                this.currentCollider = val_7;
            }
            
            this.currentAttachmentName = val_7;
        }
        public BoundingBoxFollower()
        {
            this.clearStateOnDisable = true;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.colliderTable = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.nameTable = null;
        }
        private static BoundingBoxFollower()
        {
            Spine.Unity.BoundingBoxFollower.DebugMessages = true;
        }
    
    }

}
