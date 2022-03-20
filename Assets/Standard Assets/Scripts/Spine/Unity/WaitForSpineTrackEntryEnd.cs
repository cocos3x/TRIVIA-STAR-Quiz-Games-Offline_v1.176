using UnityEngine;

namespace Spine.Unity
{
    public class WaitForSpineTrackEntryEnd : IEnumerator
    {
        // Fields
        private bool m_WasFired;
        
        // Properties
        private object System.Collections.IEnumerator.Current { get; }
        
        // Methods
        public WaitForSpineTrackEntryEnd(Spine.TrackEntry trackEntry)
        {
            Spine.TrackEntry val_1 = trackEntry;
            val_1 = new System.Object();
            this.SafeSubscribe(trackEntry:  val_1);
        }
        private void HandleEnd(Spine.TrackEntry trackEntry)
        {
            this.m_WasFired = true;
        }
        private void SafeSubscribe(Spine.TrackEntry trackEntry)
        {
            if(trackEntry != 0)
            {
                    AnimationState.TrackEntryDelegate val_1 = new AnimationState.TrackEntryDelegate(object:  1997945376, method:  new IntPtr(1997920352));
                trackEntry.add_End(value:  263151616);
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  1995071136);
            this.m_WasFired = true;
        }
        public Spine.Unity.WaitForSpineTrackEntryEnd NowWaitFor(Spine.TrackEntry trackEntry)
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
