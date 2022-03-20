using UnityEngine;

namespace Spine
{
    internal class EventQueue
    {
        // Fields
        private readonly System.Collections.Generic.List<Spine.EventQueue.EventQueueEntry> eventQueueEntries;
        public bool drainDisabled;
        private readonly Spine.AnimationState state;
        private readonly Spine.Pool<Spine.TrackEntry> trackEntryPool;
        private System.Action AnimationsChanged;
        
        // Methods
        public void add_AnimationsChanged(System.Action value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.AnimationsChanged, b:  value);
            if(this.AnimationsChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.AnimationsChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.AnimationsChanged != 1152921510781662456)
            {
                goto label_3;
            }
        
        }
        public void remove_AnimationsChanged(System.Action value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.AnimationsChanged, value:  value);
            if(this.AnimationsChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.AnimationsChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.AnimationsChanged != 1152921510781790840)
            {
                goto label_3;
            }
        
        }
        public EventQueue(Spine.AnimationState state, System.Action HandleAnimationsChanged, Spine.Pool<Spine.TrackEntry> trackEntryPool)
        {
            Spine.Pool<Spine.TrackEntry> val_2 = trackEntryPool;
            System.Collections.Generic.List<EventQueueEntry> val_1 = new System.Collections.Generic.List<EventQueueEntry>();
            this.eventQueueEntries = null;
            val_2 = new System.Object();
            this.state = state;
            this.add_AnimationsChanged(value:  HandleAnimationsChanged);
            this.trackEntryPool = val_2;
        }
        public void Start(Spine.TrackEntry entry)
        {
            this.eventQueueEntries.Add(item:  new EventQueueEntry() {entry = entry});
            if(this.AnimationsChanged == 0)
            {
                    return;
            }
            
            this.AnimationsChanged.Invoke();
        }
        public void Interrupt(Spine.TrackEntry entry)
        {
            this.eventQueueEntries.Add(item:  new EventQueueEntry() {type = 1, entry = entry});
        }
        public void End(Spine.TrackEntry entry)
        {
            this.eventQueueEntries.Add(item:  new EventQueueEntry() {type = 2, entry = entry});
            if(this.AnimationsChanged == 0)
            {
                    return;
            }
            
            this.AnimationsChanged.Invoke();
        }
        public void Dispose(Spine.TrackEntry entry)
        {
            this.eventQueueEntries.Add(item:  new EventQueueEntry() {type = 3, entry = entry});
        }
        public void Complete(Spine.TrackEntry entry)
        {
            this.eventQueueEntries.Add(item:  new EventQueueEntry() {type = 4, entry = entry});
        }
        public void Event(Spine.TrackEntry entry, Spine.Event e)
        {
            this.eventQueueEntries.Add(item:  new EventQueueEntry() {type = 5, entry = entry, e = e});
        }
        public void Drain()
        {
            var val_1;
            TrackEntryDelegate val_2;
            if(this.drainDisabled == true)
            {
                    return;
            }
            
            this.drainDisabled = true;
            val_1 = 0;
            goto label_2;
            label_24:
            if(true <= val_1)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            if(((0 + 0) + 16) <= 5)
            {
                    var val_1 = 20389024 + (20389024 + ((0 + 0) + 16) << 2);
                if(((0 + 0) + 16) == 5)
            {
                    val_2 = val_2 & (this << val_2);
                val_2 = val_2 & 0;
                val_2 = val_2 & ((((((0 + 0) & (this) << (0 + 0)) & 0)) << (32-(((0 + 0) & (this) << (0 + 0)) & 0))) | (((((0 + 0) & (this) << (0 + 0)) & 0)) << (((0 + 0) & (this) << (0 + 0)) & 0)));
                val_2 = val_2 & 0;
                val_2 = val_2 & 0;
                val_2 = val_2 & (val_2 >> 2);
            }
            
                (0 + 0) + 20.OnStart();
                val_2 = this.state.Start;
                if( != 0)
            {
                    Invoke(trackEntry:  (0 + 0) + 20);
            }
            
            }
            
            val_1 = 1;
            label_2:
            if(val_1 < this.state.Event)
            {
                goto label_24;
            }
            
            this.eventQueueEntries.Clear();
            this.drainDisabled = false;
        }
        public void Clear()
        {
            this.eventQueueEntries.Clear();
        }
    
    }

}
