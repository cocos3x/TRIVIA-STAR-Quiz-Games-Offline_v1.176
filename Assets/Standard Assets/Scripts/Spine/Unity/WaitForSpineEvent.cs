using UnityEngine;

namespace Spine.Unity
{
    public class WaitForSpineEvent : IEnumerator
    {
        // Fields
        private Spine.EventData m_TargetEvent;
        private string m_EventName;
        private Spine.AnimationState m_AnimationState;
        private bool m_WasFired;
        private bool m_unsubscribeAfterFiring;
        
        // Properties
        public bool WillUnsubscribeAfterFiring { get; set; }
        private object System.Collections.IEnumerator.Current { get; }
        
        // Methods
        private void Subscribe(Spine.AnimationState state, Spine.EventData eventDataReference, bool unsubscribe)
        {
            var val_2;
            if(state == 0)
            {
                goto label_1;
            }
            
            if(eventDataReference == 0)
            {
                goto label_2;
            }
            
            this.m_TargetEvent = eventDataReference;
            this.m_AnimationState = state;
            AnimationState.TrackEntryEventDelegate val_1 = new AnimationState.TrackEntryEventDelegate(object:  1995677264, method:  new IntPtr(1995651808));
            state.add_Event(value:  263204864);
            this.m_unsubscribeAfterFiring = unsubscribe;
            return;
            label_1:
            val_2 = "AnimationState argument was null. Coroutine will continue immediately.";
            goto label_5;
            label_2:
            val_2 = "eventDataReference argument was null. Coroutine will continue immediately.";
            label_5:
            UnityEngine.Debug.LogWarning(message:  1995653040);
            this.m_WasFired = true;
        }
        private void SubscribeByName(Spine.AnimationState state, string eventName, bool unsubscribe)
        {
            var val_3;
            if(state == 0)
            {
                goto label_1;
            }
            
            if((System.String.IsNullOrEmpty(value:  eventName)) == false)
            {
                goto label_2;
            }
            
            val_3 = "eventName argument was null. Coroutine will continue immediately.";
            goto label_5;
            label_1:
            val_3 = "AnimationState argument was null. Coroutine will continue immediately.";
            label_5:
            UnityEngine.Debug.LogWarning(message:  1995652832);
            this.m_WasFired = true;
            return;
            label_2:
            this.m_EventName = eventName;
            this.m_AnimationState = state;
            AnimationState.TrackEntryEventDelegate val_2 = new AnimationState.TrackEntryEventDelegate(object:  1995806880, method:  new IntPtr(1995781856));
            state.add_Event(value:  263204864);
            this.m_unsubscribeAfterFiring = unsubscribe;
        }
        public WaitForSpineEvent(Spine.AnimationState state, Spine.EventData eventDataReference, bool unsubscribeAfterFiring = True)
        {
            val_1 = new System.Object();
            this.Subscribe(state:  state, eventDataReference:  Spine.EventData val_1 = eventDataReference, unsubscribe:  unsubscribeAfterFiring);
        }
        public WaitForSpineEvent(Spine.Unity.SkeletonAnimation skeletonAnimation, Spine.EventData eventDataReference, bool unsubscribeAfterFiring = True)
        {
            val_1 = new System.Object();
            this.Subscribe(state:  skeletonAnimation.state, eventDataReference:  Spine.EventData val_1 = eventDataReference, unsubscribe:  unsubscribeAfterFiring);
        }
        public WaitForSpineEvent(Spine.AnimationState state, string eventName, bool unsubscribeAfterFiring = True)
        {
            val_1 = new System.Object();
            this.SubscribeByName(state:  state, eventName:  string val_1 = eventName, unsubscribe:  unsubscribeAfterFiring);
        }
        public WaitForSpineEvent(Spine.Unity.SkeletonAnimation skeletonAnimation, string eventName, bool unsubscribeAfterFiring = True)
        {
            val_1 = new System.Object();
            this.SubscribeByName(state:  skeletonAnimation.state, eventName:  string val_1 = eventName, unsubscribe:  unsubscribeAfterFiring);
        }
        private void HandleAnimationStateEventByName(Spine.TrackEntry trackEntry, Spine.Event e)
        {
            bool val_1 = System.String.op_Equality(a:  e.data.name, b:  this.m_EventName);
            if(this.m_WasFired == true)
            {
                    this.m_WasFired = 1;
            }
            
            val_1 = 1 | val_1;
            this.m_WasFired = val_1;
            if(val_1 != true)
            {
                    return;
            }
            
            if(this.m_unsubscribeAfterFiring == false)
            {
                    return;
            }
            
            AnimationState.TrackEntryEventDelegate val_2 = new AnimationState.TrackEntryEventDelegate(object:  1996481568, method:  new IntPtr(1995781856));
            this.m_AnimationState.remove_Event(value:  263204864);
        }
        private void HandleAnimationStateEvent(Spine.TrackEntry trackEntry, Spine.Event e)
        {
            var val_4;
            bool val_5;
            val_4 = this;
            val_5 = this.m_WasFired;
            Spine.EventData val_1 = e.data - this.m_TargetEvent;
            val_1 = val_1 >> 5;
            val_1 = val_5 | val_1;
            this.m_WasFired = val_1;
            if(val_5 != true)
            {
                    if(e.data != this.m_TargetEvent)
            {
                    return;
            }
            
            }
            
            if((R4 + 21) == 0)
            {
                    return;
            }
            
            AnimationState.TrackEntryEventDelegate val_2 = new AnimationState.TrackEntryEventDelegate(object:  R4, method:  new IntPtr(1995651808));
            R4 + 16.remove_Event(value:  263204864);
        }
        public bool get_WillUnsubscribeAfterFiring()
        {
            return (bool)this.m_unsubscribeAfterFiring;
        }
        public void set_WillUnsubscribeAfterFiring(bool value)
        {
            this.m_unsubscribeAfterFiring = value;
        }
        public Spine.Unity.WaitForSpineEvent NowWaitFor(Spine.AnimationState state, Spine.EventData eventDataReference, bool unsubscribeAfterFiring = True)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this;
            this.Clear(state:  state);
            this.Subscribe(state:  state, eventDataReference:  eventDataReference, unsubscribe:  unsubscribeAfterFiring);
        }
        public Spine.Unity.WaitForSpineEvent NowWaitFor(Spine.AnimationState state, string eventName, bool unsubscribeAfterFiring = True)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this;
            this.Clear(state:  state);
            this.SubscribeByName(state:  state, eventName:  eventName, unsubscribe:  unsubscribeAfterFiring);
        }
        private void Clear(Spine.AnimationState state)
        {
            AnimationState.TrackEntryEventDelegate val_1 = new AnimationState.TrackEntryEventDelegate(object:  1997247776, method:  new IntPtr(1995651808));
            state.remove_Event(value:  263204864);
            AnimationState.TrackEntryEventDelegate val_2 = new AnimationState.TrackEntryEventDelegate(object:  1997247776, method:  new IntPtr(1995781856));
            state.remove_Event(value:  263204864);
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
