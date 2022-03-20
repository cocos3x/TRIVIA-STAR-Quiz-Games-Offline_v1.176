using UnityEngine;

namespace Spine.Unity
{
    public class WaitForSpineAnimationComplete : IEnumerator
    {
        // Fields
        private bool m_WasFired;
        
        // Properties
        private object System.Collections.IEnumerator.Current { get; }
        
        // Methods
        public WaitForSpineAnimationComplete(Spine.TrackEntry trackEntry)
        {
            Spine.TrackEntry val_1 = trackEntry;
            val_1 = new System.Object();
            this.SafeSubscribe(trackEntry:  val_1);
        }
        private void HandleComplete(Spine.TrackEntry trackEntry)
        {
            this.m_WasFired = true;
        }
        private void SafeSubscribe(Spine.TrackEntry trackEntry)
        {
            if(trackEntry != 0)
            {
                    AnimationState.TrackEntryDelegate val_1 = new AnimationState.TrackEntryDelegate(object:  1995095328, method:  new IntPtr(1995070112));
                trackEntry.add_Complete(value:  263151616);
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  1995071136);
            this.m_WasFired = true;
        }
        public Spine.Unity.WaitForSpineAnimationComplete NowWaitFor(Spine.TrackEntry trackEntry)
        {
            this.SafeSubscribe(trackEntry:  trackEntry);
        }
        private bool System.Collections.IEnumerator.MoveNext()
        {
            var val_1;
            if(this.m_WasFired == false)
            {
                    return true;
            }
            
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this;
            return false;
        }
        private void System.Collections.IEnumerator.Reset()
        {
            this.m_WasFired = false;
        }
        private object System.Collections.IEnumerator.get_Current()
        {
        
        }
    
    }

}
