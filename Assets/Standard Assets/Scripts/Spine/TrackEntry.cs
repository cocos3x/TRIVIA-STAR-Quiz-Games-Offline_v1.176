using UnityEngine;

namespace Spine
{
    public class TrackEntry : Pool.IPoolable<Spine.TrackEntry>
    {
        // Fields
        internal Spine.Animation animation;
        internal Spine.TrackEntry next;
        internal Spine.TrackEntry mixingFrom;
        internal int trackIndex;
        internal bool loop;
        internal float eventThreshold;
        internal float attachmentThreshold;
        internal float drawOrderThreshold;
        internal float animationStart;
        internal float animationEnd;
        internal float animationLast;
        internal float nextAnimationLast;
        internal float delay;
        internal float trackTime;
        internal float trackLast;
        internal float nextTrackLast;
        internal float trackEnd;
        internal float timeScale;
        internal float alpha;
        internal float mixTime;
        internal float mixDuration;
        internal float interruptAlpha;
        internal float totalAlpha;
        internal readonly Spine.ExposedList<int> timelineData;
        internal readonly Spine.ExposedList<Spine.TrackEntry> timelineDipMix;
        internal readonly Spine.ExposedList<float> timelinesRotation;
        private Spine.AnimationState.TrackEntryDelegate Start;
        private Spine.AnimationState.TrackEntryDelegate Interrupt;
        private Spine.AnimationState.TrackEntryDelegate End;
        private Spine.AnimationState.TrackEntryDelegate Dispose;
        private Spine.AnimationState.TrackEntryDelegate Complete;
        private Spine.AnimationState.TrackEntryEventDelegate Event;
        
        // Properties
        public int TrackIndex { get; }
        public Spine.Animation Animation { get; }
        public bool Loop { get; set; }
        public float Delay { get; set; }
        public float TrackTime { get; set; }
        public float TrackEnd { get; set; }
        public float AnimationStart { get; set; }
        public float AnimationEnd { get; set; }
        public float AnimationLast { get; set; }
        public float AnimationTime { get; }
        public float TimeScale { get; set; }
        public float Alpha { get; set; }
        public float EventThreshold { get; set; }
        public float AttachmentThreshold { get; set; }
        public float DrawOrderThreshold { get; set; }
        public Spine.TrackEntry Next { get; }
        public bool IsComplete { get; }
        public float MixTime { get; set; }
        public float MixDuration { get; set; }
        public Spine.TrackEntry MixingFrom { get; }
        
        // Methods
        public void Reset()
        {
            this.animation = 0;
            this.next = 0;
            this.mixingFrom = 0;
            this.timelineData.Clear(clearArray:  true);
            this.timelineDipMix.Clear(clearArray:  true);
            this.timelinesRotation.Clear(clearArray:  true);
            this.Complete = 0;
            this.Event = 0;
        }
        internal Spine.TrackEntry SetTimelineData(Spine.TrackEntry to, Spine.ExposedList<Spine.TrackEntry> mixingToArray, System.Collections.Generic.HashSet<int> propertyIDs)
        {
            System.Collections.Generic.HashSet<System.Int32> val_7;
            Spine.TrackEntry val_8;
            var val_9;
            var val_10;
            int val_11;
            var val_12;
            Spine.ExposedList<Spine.TrackEntry> val_13;
            var val_14;
            var val_16;
            val_7 = propertyIDs;
            if(to != 0)
            {
                    mixingToArray.Add(item:  to);
            }
            
            val_8 = this;
            if(this.mixingFrom != 0)
            {
                    val_8 = this.mixingFrom;
            }
            
            if(to != 0)
            {
                    if(mixingToArray != 0)
            {
                
            }
            else
            {
                    val_9 = 0;
            }
            
                mixingToArray.RemoveAt(index:  val_9 - 1);
            }
            
            if(mixingToArray != 0)
            {
                
            }
            else
            {
                    val_10 = 0;
            }
            
            Spine.ExposedList<T> val_2 = this.timelineData.Resize(newSize:  this.animation.timelines);
            val_11 = this.timelineData;
            val_12 = this;
            this.timelineDipMix.Clear(clearArray:  true);
            Spine.ExposedList<T> val_3 = this.timelineDipMix.Resize(newSize:  this.animation.timelines);
            if(this.animation.timelines < 1)
            {
                    return;
            }
            
            goto label_54;
            label_44:
            val_13 = this.timelineDipMix;
            typeof(Spine.TrackEntry).__il2cppRuntimeField_10 = 3;
            if(val_13 == 0)
            {
                    val_13 = this.timelineDipMix;
            }
            
            Spine.ExposedList<Spine.TrackEntry> val_11 = this.timelineDipMix;
            val_11 = val_11 + 0;
            mem2[0] = this.timelineDipMix;
            goto label_26;
            label_54:
            var val_4 = 8 + 0;
            var val_13 = (8 + 0) + 16;
            if(((8 + 0) + 16 + 178) == 0)
            {
                goto label_30;
            }
            
            var val_12 = 0;
            label_32:
            val_12 = mem[(8 + 0) + 16 + 88 + 0];
            val_12 = (8 + 0) + 16 + 88 + 0;
            if(val_12 == null)
            {
                goto label_31;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < ((8 + 0) + 16 + 178))
            {
                goto label_32;
            }
            
            label_30:
            val_14 = (8 + 0) + 16;
            goto label_33;
            label_31:
            var val_5 = ((8 + 0) + 16 + 88) + 0;
            val_13 = val_13 + ((((8 + 0) + 16 + 88 + 0) + 4) << 3);
            val_14 = val_13 + 196;
            label_33:
            val_11 = (8 + 0) + 16;
            if((val_7.Add(item:  val_11)) == false)
            {
                goto label_35;
            }
            
            if((to == 0) || ((to.HasTimeline(id:  val_11)) == false))
            {
                goto label_37;
            }
            
            if(7 >= 0)
            {
                    do
            {
                if((this.HasTimeline(id:  val_11)) != true)
            {
                    if(2621448 > 0)
            {
                goto label_44;
            }
            
            }
            
                var val_9 = 11 - 1;
            }
            while((11 - 5) > 1);
            
            }
            
            val_16 = 2;
            goto label_51;
            label_35:
            val_16 = 0;
            goto label_51;
            label_37:
            val_16 = 1;
            label_51:
            typeof(Spine.TrackEntry).__il2cppRuntimeField_10 = val_16;
            label_26:
            val_7 = 0 + 1;
            if(val_7 != this.animation.timelines)
            {
                goto label_54;
            }
        
        }
        private bool HasTimeline(int id)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            if(SL < 1)
            {
                goto label_5;
            }
            
            var val_4 = 0;
            label_14:
            var val_1 = SB + 0;
            if(((SB + 0) + 16 + 178) == 0)
            {
                goto label_9;
            }
            
            val_3 = 0;
            label_11:
            val_4 = 0;
            if(((SB + 0) + 16 + 88 + 0) == null)
            {
                goto label_10;
            }
            
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            if(val_4 < ((SB + 0) + 16 + 178))
            {
                goto label_11;
            }
            
            label_9:
            val_5 = (SB + 0) + 16;
            goto label_12;
            label_10:
            var val_2 = ((SB + 0) + 16 + 88) + 0;
            var val_3 = ((SB + 0) + 16 + 88 + 0) + 4;
            val_3 = ((SB + 0) + 16) + (val_3 << 3);
            val_5 = val_3 + 196;
            label_12:
            if(((SB + 0) + 16) == id)
            {
                goto label_13;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < SL)
            {
                goto label_14;
            }
            
            label_5:
            val_6 = 0;
            return (bool)val_6;
            label_13:
            val_6 = 1;
            return (bool)val_6;
        }
        public int get_TrackIndex()
        {
            return (int)this.trackIndex;
        }
        public Spine.Animation get_Animation()
        {
        
        }
        public bool get_Loop()
        {
            return (bool)this.loop;
        }
        public void set_Loop(bool value)
        {
            this.loop = value;
        }
        public float get_Delay()
        {
            return (float)S0;
        }
        public void set_Delay(float value)
        {
            this.delay = ;
        }
        public float get_TrackTime()
        {
            return (float)S0;
        }
        public void set_TrackTime(float value)
        {
            this.trackTime = ;
        }
        public float get_TrackEnd()
        {
            return (float)S0;
        }
        public void set_TrackEnd(float value)
        {
            this.trackEnd = ;
        }
        public float get_AnimationStart()
        {
            return (float)S0;
        }
        public void set_AnimationStart(float value)
        {
            this.animationStart = ;
        }
        public float get_AnimationEnd()
        {
            return (float)S0;
        }
        public void set_AnimationEnd(float value)
        {
            this.animationEnd = ;
        }
        public float get_AnimationLast()
        {
            return (float)S0;
        }
        public void set_AnimationLast(float value)
        {
            this.animationLast = ;
            this.nextAnimationLast = ;
        }
        public float get_AnimationTime()
        {
            float val_2;
            var val_3;
            if(this.loop == false)
            {
                    return System.Math.Min(val1:  this.trackTime + this.animationStart, val2:  null);
            }
            
            val_2 = this.animationStart;
            float val_2 = this.animationEnd;
            val_2 = val_2 - val_2;
            if(this.loop == false)
            {
                    return (float)val_3;
            }
            
            val_3 = this.trackTime;
            val_2 = val_2 + val_3;
            return (float)val_3;
        }
        public float get_TimeScale()
        {
            return (float)S0;
        }
        public void set_TimeScale(float value)
        {
            this.timeScale = ;
        }
        public float get_Alpha()
        {
            return (float)S0;
        }
        public void set_Alpha(float value)
        {
            this.alpha = ;
        }
        public float get_EventThreshold()
        {
            return (float)S0;
        }
        public void set_EventThreshold(float value)
        {
            this.eventThreshold = ;
        }
        public float get_AttachmentThreshold()
        {
            return (float)S0;
        }
        public void set_AttachmentThreshold(float value)
        {
            this.attachmentThreshold = ;
        }
        public float get_DrawOrderThreshold()
        {
            return (float)S0;
        }
        public void set_DrawOrderThreshold(float value)
        {
            this.drawOrderThreshold = ;
        }
        public Spine.TrackEntry get_Next()
        {
        
        }
        public bool get_IsComplete()
        {
            float val_1 = this.animationStart;
            val_1 = this.animationEnd - val_1;
            if()
            {
                    0 = 1;
            }
            
            return true;
        }
        public float get_MixTime()
        {
            return (float)S0;
        }
        public void set_MixTime(float value)
        {
            this.mixTime = ;
        }
        public float get_MixDuration()
        {
            return (float)S0;
        }
        public void set_MixDuration(float value)
        {
            this.mixDuration = ;
        }
        public Spine.TrackEntry get_MixingFrom()
        {
        
        }
        public void add_Start(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.Start, b:  value);
            if(this.Start == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Start;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Start != 1152921510779038160)
            {
                goto label_3;
            }
        
        }
        public void remove_Start(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.Start, value:  value);
            if(this.Start == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Start;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Start != 1152921510779166544)
            {
                goto label_3;
            }
        
        }
        public void add_Interrupt(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.Interrupt, b:  value);
            if(this.Interrupt == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Interrupt;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Interrupt != 1152921510779294932)
            {
                goto label_3;
            }
        
        }
        public void remove_Interrupt(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.Interrupt, value:  value);
            if(this.Interrupt == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Interrupt;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Interrupt != 1152921510779423316)
            {
                goto label_3;
            }
        
        }
        public void add_End(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.End, b:  value);
            if(this.End == 0)
            {
                goto label_1;
            }
            
            val_2 = this.End;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.End != 1152921510779551704)
            {
                goto label_3;
            }
        
        }
        public void remove_End(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.End, value:  value);
            if(this.End == 0)
            {
                goto label_1;
            }
            
            val_2 = this.End;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.End != 1152921510779680088)
            {
                goto label_3;
            }
        
        }
        public void add_Dispose(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.Dispose, b:  value);
            if(this.Dispose == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Dispose;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Dispose != 1152921510779808476)
            {
                goto label_3;
            }
        
        }
        public void remove_Dispose(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.Dispose, value:  value);
            if(this.Dispose == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Dispose;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Dispose != 1152921510779936860)
            {
                goto label_3;
            }
        
        }
        public void add_Complete(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.Complete, b:  value);
            if(this.Complete == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Complete;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Complete != 1152921510780065248)
            {
                goto label_3;
            }
        
        }
        public void remove_Complete(Spine.AnimationState.TrackEntryDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.Complete, value:  value);
            if(this.Complete == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Complete;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Complete != 1152921510780193632)
            {
                goto label_3;
            }
        
        }
        public void add_Event(Spine.AnimationState.TrackEntryEventDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.Event, b:  value);
            if(this.Event == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Event;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Event != 1152921510780322020)
            {
                goto label_3;
            }
        
        }
        public void remove_Event(Spine.AnimationState.TrackEntryEventDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.Event, value:  value);
            if(this.Event == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Event;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Event != 1152921510780450404)
            {
                goto label_3;
            }
        
        }
        internal void OnStart()
        {
            if(this.Start == 0)
            {
                    return;
            }
            
            this.Start.Invoke(trackEntry:  1878760288);
        }
        internal void OnInterrupt()
        {
            if(this.Interrupt == 0)
            {
                    return;
            }
            
            this.Interrupt.Invoke(trackEntry:  1878880480);
        }
        internal void OnEnd()
        {
            if(this.End == 0)
            {
                    return;
            }
            
            this.End.Invoke(trackEntry:  1879000672);
        }
        internal void OnDispose()
        {
            if(this.Dispose == 0)
            {
                    return;
            }
            
            this.Dispose.Invoke(trackEntry:  1879120864);
        }
        internal void OnComplete()
        {
            if(this.Complete == 0)
            {
                    return;
            }
            
            this.Complete.Invoke(trackEntry:  1879241056);
        }
        internal void OnEvent(Spine.Event e)
        {
            if(this.Event == 0)
            {
                    return;
            }
            
            this.Event.Invoke(trackEntry:  1879365344, e:  e);
        }
        public void ResetRotationDirections()
        {
            this.timelinesRotation.Clear(clearArray:  true);
        }
        public override string ToString()
        {
            if(this.animation != 0)
            {
                    "<none>" = this.animation.name;
            }
        
        }
        public TrackEntry()
        {
            this.timeScale = 1f;
            Spine.ExposedList<System.Int32> val_1 = new Spine.ExposedList<System.Int32>();
            this.timelineData = null;
            Spine.ExposedList<UnityEngine.Material> val_2 = new Spine.ExposedList<UnityEngine.Material>();
            this.timelineDipMix = null;
            Spine.ExposedList<System.Single> val_3 = new Spine.ExposedList<System.Single>();
            this.timelinesRotation = null;
        }
    
    }

}
