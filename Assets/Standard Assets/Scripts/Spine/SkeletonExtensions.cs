using UnityEngine;

namespace Spine
{
    public static class SkeletonExtensions
    {
        // Methods
        public static bool IsWeighted(Spine.VertexAttachment va)
        {
            if(va.bones == null)
            {
                    return false;
            }
            
            if(va.bones != null)
            {
                    va.bones = 1;
            }
            
            return true;
        }
        public static bool InheritsRotation(Spine.TransformMode mode)
        {
            mode = 1 & (~mode);
            return (bool)mode;
        }
        public static bool InheritsScale(Spine.TransformMode mode)
        {
            mode = mode & 2;
            mode = 1 ^ (mode >> 1);
            return (bool)mode;
        }
        internal static void SetPropertyToSetupPose(Spine.Skeleton skeleton, int propertyID)
        {
            int val_14 = propertyID;
            int val_1 = val_14 >> 24;
            if(val_1 > 14)
            {
                    return;
            }
            
            val_14 = val_14 & (~4278190080);
            var val_2 = 18754596 + (18754596 + ((propertyID >> 24)) << 2);
            if(val_1 == 14)
            {
                    18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & ((R8) << 4);
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & ((((18754596 + ((propertyID >> 24)) << 2 & (R8) << 4)) << (32-6)) | (((18754596 + ((propertyID >> 24)) << 2 & (R8) << 4)) << 6));
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & (((IP) << (32-5)) | ((IP) << 5));
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & (val_14 << 3);
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & ((IP) >> ((((18754596 + ((propertyID >> 24)) << 2 & (R8) << 4) & (((18754596 + ((propertyID >> 24)) << 2 & (R8) << 4)) << (32-6)) | (((18754596 + ((propertyID >> 24)) << 2 & (R8) << 4)) << 6)) & ((IP) << (32-5);
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & (((int)R8) >> 8);
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & ((R8) >> 11);
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & ((18754596 + ((propertyID >> 24)) << 2) >> 10);
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & (((int)IP) >> 9);
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & (val_14 << 2);
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & (((R8) << (32-R2)) | ((R8) << R2));
                18754596 + ((propertyID >> 24)) << 2 = val_14 * 18754596;
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) * (18754596 + ((propertyID >> 24)) << 2);
                18754596 + ((propertyID >> 24)) << 2 = (18754596 + ((propertyID >> 24)) << 2) & ((IP) >> (((propertyID & (~4278190080)) * 18754596) * ((propertyID & (~4278190080)) * 18754596)));
            }
            
            Spine.SkeletonExtensions.SetColorToSetupPose(slot:  skeleton.slots + (val_14 << 2));
        }
        public static void SetDrawOrderToSetupPose(Spine.Skeleton skeleton)
        {
            if(skeleton.slots != 0)
            {
                goto label_2;
            }
            
            skeleton.slots = skeleton.slots;
            if(skeleton.slots == 0)
            {
                goto label_3;
            }
            
            label_2:
            if(skeleton.drawOrder != 0)
            {
                    skeleton.drawOrder.Clear(clearArray:  false);
                skeleton.drawOrder.GrowIfNeeded(newCount:  skeleton);
            }
            else
            {
                    0.Clear(clearArray:  false);
                0.GrowIfNeeded(newCount:  skeleton);
            }
            
            System.Array.Copy(sourceArray:  skeleton.slots, destinationArray:  skeleton, length:  skeleton);
            return;
            label_3:
        }
        public static void SetColorToSetupPose(Spine.Slot slot)
        {
            Spine.SlotData val_1 = slot.data;
            if(val_1 == 0)
            {
                goto label_1;
            }
            
            slot.r = slot.data.r;
            goto label_2;
            label_1:
            slot.r = slot.data.r;
            if(slot.data == 0)
            {
                goto label_3;
            }
            
            val_1 = slot.data;
            label_2:
            slot.g = slot.data.g;
            label_4:
            slot.b = slot.data.b;
            label_6:
            slot.a = slot.data.a;
            label_7:
            slot.r2 = slot.data.r2;
            label_9:
            slot.g2 = slot.data.g2;
            label_10:
            slot.b2 = slot.data.b2;
            return;
            label_3:
            slot.g = slot.data.g;
            if(slot.data != 0)
            {
                goto label_4;
            }
            
            slot.b = slot.data.b;
            if(slot.data == 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_5:
            slot.a = slot.data.a;
            if(slot.data != 0)
            {
                goto label_7;
            }
            
            slot.r2 = slot.data.r2;
            if(slot.data == 0)
            {
                goto label_8;
            }
            
            goto label_9;
            label_8:
            slot.g2 = slot.data.g2;
            if(slot.data != 0)
            {
                goto label_10;
            }
        
        }
        public static void SetAttachmentToSetupPose(Spine.Slot slot)
        {
            Spine.SlotData val_2;
            var val_3;
            if(slot != 0)
            {
                    val_2 = slot.data;
            }
            else
            {
                    val_2 = 0;
            }
            
            if(val_2 != 0)
            {
                    val_3 = 0;
            }
            else
            {
                    val_3 = 0;
            }
            
            Spine.Attachment val_1 = slot.bone.skeleton.GetAttachment(slotName:  null, attachmentName:  6);
            slot.Attachment = slot.bone.skeleton;
        }
        public static void SetSlotAttachmentToSetupPose(Spine.Skeleton skeleton, int slotIndex)
        {
            Spine.Attachment val_4;
            Spine.ExposedList<Spine.Slot> val_1 = skeleton.slots + (slotIndex << 2);
            if((System.String.IsNullOrEmpty(value:  R7 + 52)) != false)
            {
                    val_4 = 0;
            }
            else
            {
                    Spine.Attachment val_3 = skeleton.GetAttachment(slotIndex:  slotIndex, attachmentName:  R7 + 52);
                val_4 = skeleton;
            }
            
            skeleton.slots.Attachment = val_4;
        }
        public static void PoseWithAnimation(Spine.Skeleton skeleton, string animationName, float time, bool loop = False)
        {
            Spine.Animation val_1 = skeleton.data.FindAnimation(animationName:  animationName);
            if(skeleton.data == 0)
            {
                    return;
            }
            
            skeleton.data.Apply(skeleton:  skeleton, lastTime:  time, time:  null, loop:  false, events:  loop, alpha:  null, pose:  R3, direction:  0);
        }
        public static void PoseSkeleton(Spine.Animation animation, Spine.Skeleton skeleton, float time, bool loop = False)
        {
            animation.Apply(skeleton:  skeleton, lastTime:  time, time:  null, loop:  false, events:  loop, alpha:  null, pose:  R3, direction:  0);
        }
        public static void SetKeyedItemsToSetupPose(Spine.Animation animation, Spine.Skeleton skeleton)
        {
            animation.Apply(skeleton:  skeleton, lastTime:  null, time:  null, loop:  false, events:  0, alpha:  null, pose:  0, direction:  0);
        }
        public static void FindNamesForSlot(Spine.Skin skin, string slotName, Spine.SkeletonData skeletonData, System.Collections.Generic.List<string> results)
        {
            skin.FindNamesForSlot(slotIndex:  skeletonData.FindSlotIndex(slotName:  slotName), names:  results);
        }
        public static void FindAttachmentsForSlot(Spine.Skin skin, string slotName, Spine.SkeletonData skeletonData, System.Collections.Generic.List<Spine.Attachment> results)
        {
            skin.FindAttachmentsForSlot(slotIndex:  skeletonData.FindSlotIndex(slotName:  slotName), attachments:  results);
        }
    
    }

}
