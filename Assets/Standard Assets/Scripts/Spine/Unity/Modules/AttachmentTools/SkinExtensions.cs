using UnityEngine;

namespace Spine.Unity.Modules.AttachmentTools
{
    public static class SkinExtensions
    {
        // Methods
        public static Spine.Skin UnshareSkin(Spine.Skeleton skeleton, bool includeDefaultSkin, bool unshareAttachments, Spine.AnimationState state)
        {
            Spine.Skin val_1 = Spine.Unity.Modules.AttachmentTools.SkinExtensions.GetClonedSkin(skeleton:  skeleton, newSkinName:  2045971456, includeDefaultSkin:  includeDefaultSkin, cloneAttachments:  unshareAttachments, cloneMeshesAsLinked:  true);
            skeleton.SetSkin(newSkin:  skeleton);
            if(state == 0)
            {
                    return;
            }
            
            skeleton.SetToSetupPose();
            bool val_2 = state.Apply(skeleton:  skeleton);
        }
        public static Spine.Skin GetClonedSkin(Spine.Skeleton skeleton, string newSkinName, bool includeDefaultSkin = False, bool cloneAttachments = False, bool cloneMeshesAsLinked = True)
        {
            Spine.Skin val_1 = new Spine.Skin(name:  newSkinName);
            if(includeDefaultSkin != false)
            {
                    Spine.Unity.Modules.AttachmentTools.SkinExtensions.CopyTo(source:  skeleton.data.defaultSkin, destination:  266186752, overwrite:  true, cloneAttachments:  cloneAttachments, cloneMeshesAsLinked:  cloneMeshesAsLinked);
            }
            
            if(skeleton.skin == 0)
            {
                    return;
            }
            
            Spine.Unity.Modules.AttachmentTools.SkinExtensions.CopyTo(source:  skeleton.skin, destination:  266186752, overwrite:  true, cloneAttachments:  cloneAttachments, cloneMeshesAsLinked:  cloneMeshesAsLinked);
        }
        public static Spine.Skin GetClone(Spine.Skin original)
        {
            int val_5;
            string val_1 = original.name + 2046248800;
            Spine.Skin val_2 = new Spine.Skin(name:  original.name);
            Dictionary.Enumerator<TKey, TValue> val_3 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            set_Item(key:  new AttachmentKeyTuple() {slotIndex = val_5, name = R4, nameHashCode = R6}, value:  ???);
            goto label_6;
            label_4:
            Dispose();
        }
        public static void SetAttachment(Spine.Skin skin, string slotName, string keyName, Spine.Attachment attachment, Spine.Skeleton skeleton)
        {
            if(skeleton == 0)
            {
                goto label_1;
            }
            
            int val_1 = skeleton.FindSlotIndex(slotName:  slotName);
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            skin.AddAttachment(slotIndex:  val_1, name:  keyName, attachment:  attachment);
            return;
            label_1:
            int val_2 = skeleton.FindSlotIndex(slotName:  slotName);
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1843048096, message:  1843048192);
            label_2:
            string val_4 = System.String.Format(format:  2046402864, arg0:  slotName);
            System.ArgumentException val_5 = new System.ArgumentException(message:  2046402864, paramName:  1939892256);
        }
        public static Spine.Attachment GetAttachment(Spine.Skin skin, string slotName, string keyName, Spine.Skeleton skeleton)
        {
            if(skeleton == 0)
            {
                goto label_1;
            }
            
            int val_1 = skeleton.FindSlotIndex(slotName:  slotName);
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            if(skin != 0)
            {
                    return skin.GetAttachment(slotIndex:  val_1, name:  keyName);
            }
            
            return skin.GetAttachment(slotIndex:  val_1, name:  keyName);
            label_1:
            int val_2 = skeleton.FindSlotIndex(slotName:  slotName);
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1843048096, message:  1843048192);
            label_2:
            string val_4 = System.String.Format(format:  2046402864, arg0:  slotName);
            System.ArgumentException val_5 = new System.ArgumentException(message:  2046402864, paramName:  1939892256);
        }
        public static void SetAttachment(Spine.Skin skin, int slotIndex, string keyName, Spine.Attachment attachment)
        {
            skin.AddAttachment(slotIndex:  slotIndex, name:  keyName, attachment:  attachment);
        }
        public static bool RemoveAttachment(Spine.Skin skin, string slotName, string keyName, Spine.Skeleton skeleton)
        {
            if(skeleton == 0)
            {
                goto label_1;
            }
            
            int val_1 = skeleton.FindSlotIndex(slotName:  slotName);
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            return Spine.Unity.Modules.AttachmentTools.SkinExtensions.RemoveAttachment(skin:  skin, slotIndex:  val_1, keyName:  keyName);
            label_1:
            int val_2 = skeleton.FindSlotIndex(slotName:  slotName);
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1843048096, message:  1843048192);
            label_2:
            string val_4 = System.String.Format(format:  2046402864, arg0:  slotName);
            System.ArgumentException val_5 = new System.ArgumentException(message:  2046402864, paramName:  1939892256);
        }
        public static bool RemoveAttachment(Spine.Skin skin, int slotIndex, string keyName)
        {
            return (bool)skin.attachments.Remove(key:  new AttachmentKeyTuple() {slotIndex = slotIndex, name = keyName, nameHashCode = keyName});
        }
        public static void Clear(Spine.Skin skin)
        {
            skin.attachments.Clear();
        }
        public static void Append(Spine.Skin destination, Spine.Skin source)
        {
            Spine.Unity.Modules.AttachmentTools.SkinExtensions.CopyTo(source:  source, destination:  destination, overwrite:  true, cloneAttachments:  false, cloneMeshesAsLinked:  true);
        }
        public static void CopyTo(Spine.Skin source, Spine.Skin destination, bool overwrite, bool cloneAttachments, bool cloneMeshesAsLinked = True)
        {
            int val_3;
            string val_4;
            int val_5;
            Spine.Attachment val_6;
            bool val_20;
            System.Collections.Generic.Dictionary<AttachmentKeyTuple, Spine.Attachment> val_21;
            float val_22;
            val_20 = overwrite;
            val_21 = source.attachments;
            if(cloneAttachments == false)
            {
                goto label_23;
            }
            
            if(val_20 == false)
            {
                goto label_11;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            val_20 = 1152921510840447040;
            val_22 = 1152921510860299616;
            label_8:
            if(MoveNext() == false)
            {
                goto label_18;
            }
            
            Spine.Attachment val_7 = Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetClone(o:  val_6, cloneMeshesAsLinked:  cloneMeshesAsLinked);
            destination.attachments.set_Item(key:  new AttachmentKeyTuple() {slotIndex = val_3, name = val_4, nameHashCode = val_5}, value:  val_6);
            goto label_8;
            label_11:
            Dictionary.Enumerator<TKey, TValue> val_8 = GetEnumerator();
            val_22 = 1152921510949189712;
            do
            {
                label_17:
                if(MoveNext() == false)
            {
                goto label_18;
            }
            
            }
            while((destination.attachments.ContainsKey(key:  new AttachmentKeyTuple() {slotIndex = R6, name = R7, nameHashCode = R8})) == true);
            
            Spine.Attachment val_11 = Spine.Unity.Modules.AttachmentTools.AttachmentCloneExtensions.GetClone(o:  val_6, cloneMeshesAsLinked:  cloneMeshesAsLinked);
            destination.attachments.Add(key:  new AttachmentKeyTuple() {slotIndex = R6, name = R7, nameHashCode = R8}, value:  val_6);
            goto label_17;
            label_23:
            if( == false)
            {
                goto label_30;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_12 = GetEnumerator();
            val_22 = 1152921510840447040;
            val_20 = 1152921510860299616;
            label_28:
            if(MoveNext() == false)
            {
                goto label_26;
            }
            
            destination.attachments.set_Item(key:  new AttachmentKeyTuple() {slotIndex = R4, name = R6, nameHashCode = R7}, value:  val_6);
            goto label_28;
            label_26:
            Dispose();
            val_21 = ;
            if(0 != 1)
            {
                    if(327 == 327)
            {
                    return;
            }
            
            }
            
            label_30:
            Dictionary.Enumerator<TKey, TValue> val_14 = GetEnumerator();
            val_22 = 1152921510949189712;
            label_37:
            if(MoveNext() == false)
            {
                goto label_33;
            }
            
            if((destination.attachments.ContainsKey(key:  new AttachmentKeyTuple() {slotIndex = val_3, name = val_4, nameHashCode = val_5})) == true)
            {
                goto label_37;
            }
            
            destination.attachments.Add(key:  new AttachmentKeyTuple() {slotIndex = val_3, name = val_4, nameHashCode = val_5}, value:  val_6);
            goto label_37;
            label_33:
            label_18:
            Dispose();
        }
    
    }

}
