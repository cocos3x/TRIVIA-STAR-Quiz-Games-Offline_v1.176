using UnityEngine;

namespace Spine.Unity
{
    public class SpineAttachment : SpineAttributeBase
    {
        // Fields
        public bool returnAttachmentPath;
        public bool currentSkinOnly;
        public bool placeholdersOnly;
        public string skinField;
        public string slotField;
        
        // Methods
        public SpineAttachment(bool currentSkinOnly = True, bool returnAttachmentPath = False, bool placeholdersOnly = False, string slotField = "", string dataField = "", string skinField = "", bool includeNone = True)
        {
            this.skinField = "";
            this.slotField = "";
            this.returnAttachmentPath = returnAttachmentPath;
            this.currentSkinOnly = currentSkinOnly;
            this.placeholdersOnly = placeholdersOnly;
            mem[1152921510921108508] = dataField;
            this.skinField = skinField;
            this.slotField = slotField;
            mem[1152921510921108516] = includeNone;
        }
        public static Spine.Unity.SpineAttachment.Hierarchy GetHierarchy(string fullPath)
        {
            mem2[0] = 0;
            mem2[0] = 0;
            fullPath.m_stringLength = 0;
            val_1 = new SpineAttachment.Hierarchy(fullPath:  null);
            return new Hierarchy() {skin = val_1};
        }
        public static Spine.Attachment GetAttachment(string attachmentPath, Spine.SkeletonData skeletonData)
        {
            var val_6;
            SpineAttachment.Hierarchy val_1 = new SpineAttachment.Hierarchy(fullPath:  attachmentPath);
            if((System.String.IsNullOrEmpty(value:  val_1.name)) != false)
            {
                    return;
            }
            
            if(skeletonData != 0)
            {
                    Spine.Skin val_3 = skeletonData.FindSkin(skinName:  val_1.skin);
                val_6 = skeletonData;
            }
            else
            {
                    Spine.Skin val_4 = 0.FindSkin(skinName:  val_1.skin);
                val_6 = 0;
            }
            
            if(val_6 != 0)
            {
                    return val_6.GetAttachment(slotIndex:  skeletonData.FindSlotIndex(slotName:  val_1.slot), name:  val_1.name);
            }
            
            return val_6.GetAttachment(slotIndex:  skeletonData.FindSlotIndex(slotName:  val_1.slot), name:  val_1.name);
        }
        public static Spine.Attachment GetAttachment(string attachmentPath, Spine.Unity.SkeletonDataAsset skeletonDataAsset)
        {
            Spine.SkeletonData val_1 = skeletonDataAsset.GetSkeletonData(quiet:  true);
            return Spine.Unity.SpineAttachment.GetAttachment(attachmentPath:  attachmentPath, skeletonData:  skeletonDataAsset);
        }
    
    }

}
