using UnityEngine;

namespace Spine
{
    public class Skin
    {
        // Fields
        internal string name;
        private System.Collections.Generic.Dictionary<Spine.Skin.AttachmentKeyTuple, Spine.Attachment> attachments;
        
        // Properties
        public string Name { get; }
        public System.Collections.Generic.Dictionary<Spine.Skin.AttachmentKeyTuple, Spine.Attachment> Attachments { get; }
        
        // Methods
        public string get_Name()
        {
        
        }
        public System.Collections.Generic.Dictionary<Spine.Skin.AttachmentKeyTuple, Spine.Attachment> get_Attachments()
        {
        
        }
        public Skin(string name)
        {
            var val_4;
            string val_2 = name;
            val_4 = null;
            val_4 = null;
            System.Collections.Generic.Dictionary<AttachmentKeyTuple, System.Object> val_1 = new System.Collections.Generic.Dictionary<AttachmentKeyTuple, System.Object>(comparer:  Skin.AttachmentKeyTupleComparer.Instance);
            this.attachments = null;
            val_2 = new System.Object();
            if(val_2 != null)
            {
                    this.name = val_2;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1679334848, message:  1842907312);
        }
        public void AddAttachment(int slotIndex, string name, Spine.Attachment attachment)
        {
            if(attachment != 0)
            {
                    this.attachments.set_Item(key:  new AttachmentKeyTuple() {slotIndex = slotIndex, name = name, nameHashCode = name}, value:  attachment);
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  1956389920, message:  1958486368);
        }
        public Spine.Attachment GetAttachment(int slotIndex, string name)
        {
            bool val_2 = this.attachments.TryGetValue(key:  new AttachmentKeyTuple() {slotIndex = slotIndex, name = name, nameHashCode = name}, value: out  0);
        }
        public void FindNamesForSlot(int slotIndex, System.Collections.Generic.List<string> names)
        {
            var val_4;
            if(names == 0)
            {
                goto label_1;
            }
            
            Dictionary.KeyCollection<TKey, TValue> val_1 = this.attachments.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = 0.GetEnumerator();
            label_6:
            if(0.MoveNext() == false)
            {
                goto label_4;
            }
            
            if(val_4 != slotIndex)
            {
                goto label_6;
            }
            
            names.Add(item:  null);
            goto label_6;
            label_4:
            0.Dispose();
            return;
            label_1:
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  1958753504, message:  1958753584);
            if((public System.Void Spine.Skin::FindNamesForSlot(int slotIndex, System.Collections.Generic.List<string> names)) == 1)
            {
                    0.Dispose();
                if(null == 0)
            {
                    return;
            }
            
                return;
            }
        
        }
        public void FindAttachmentsForSlot(int slotIndex, System.Collections.Generic.List<Spine.Attachment> attachments)
        {
            var val_3;
            Spine.Attachment val_4;
            if(attachments == 0)
            {
                goto label_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            if(val_3 != slotIndex)
            {
                goto label_5;
            }
            
            attachments.Add(item:  val_4);
            goto label_5;
            label_3:
            Dispose();
            return;
            label_1:
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  1958884128, message:  1958884224);
            if((public System.Void Spine.Skin::FindAttachmentsForSlot(int slotIndex, System.Collections.Generic.List<Spine.Attachment> attachments)) == 1)
            {
                    Dispose();
                if(null == 0)
            {
                    return;
            }
            
                return;
            }
        
        }
        public override string ToString()
        {
        
        }
        internal void AttachAll(Spine.Skeleton skeleton, Spine.Skin oldSkin)
        {
            int val_3;
            string val_4;
            var val_5;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_11:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            if((skeleton.slots + (val_3 << 2)) != val_5)
            {
                goto label_11;
            }
            
            Spine.Attachment val_7 = this.GetAttachment(slotIndex:  val_3, name:  val_4);
            if(this == 0)
            {
                goto label_11;
            }
            
            skeleton.slots.Attachment = 1959166144;
            goto label_11;
            label_3:
            Dispose();
        }
    
    }

}
