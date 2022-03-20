using UnityEngine;

namespace Spine
{
    public class AnimationState
    {
        // Fields
        private static readonly Spine.Animation EmptyAnimation;
        internal const int SUBSEQUENT = 0;
        internal const int FIRST = 1;
        internal const int DIP = 2;
        internal const int DIP_MIX = 3;
        private Spine.AnimationStateData data;
        private readonly Spine.ExposedList<Spine.TrackEntry> tracks;
        private readonly System.Collections.Generic.HashSet<int> propertyIDs;
        private readonly Spine.ExposedList<Spine.Event> events;
        private readonly Spine.EventQueue queue;
        private readonly Spine.ExposedList<Spine.TrackEntry> mixingTo;
        private bool animationsChanged;
        private float timeScale;
        private Spine.Pool<Spine.TrackEntry> trackEntryPool;
        private Spine.AnimationState.TrackEntryDelegate Start;
        private Spine.AnimationState.TrackEntryDelegate Interrupt;
        private Spine.AnimationState.TrackEntryDelegate End;
        private Spine.AnimationState.TrackEntryDelegate Dispose;
        private Spine.AnimationState.TrackEntryDelegate Complete;
        private Spine.AnimationState.TrackEntryEventDelegate Event;
        
        // Properties
        public Spine.AnimationStateData Data { get; }
        public Spine.ExposedList<Spine.TrackEntry> Tracks { get; }
        public float TimeScale { get; set; }
        
        // Methods
        public Spine.AnimationStateData get_Data()
        {
        
        }
        public Spine.ExposedList<Spine.TrackEntry> get_Tracks()
        {
        
        }
        public float get_TimeScale()
        {
            return (float)S0;
        }
        public void set_TimeScale(float value)
        {
            this.timeScale = ;
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
            if(this.Start != 1152921510767592124)
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
            if(this.Start != 1152921510767720508)
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
            if(this.Interrupt != 1152921510767848896)
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
            if(this.Interrupt != 1152921510767977280)
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
            if(this.End != 1152921510768105668)
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
            if(this.End != 1152921510768234052)
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
            if(this.Dispose != 1152921510768362440)
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
            if(this.Dispose != 1152921510768490824)
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
            if(this.Complete != 1152921510768619212)
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
            if(this.Complete != 1152921510768747596)
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
            if(this.Event != 1152921510768875984)
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
            if(this.Event != 1152921510769004368)
            {
                goto label_3;
            }
        
        }
        public AnimationState(Spine.AnimationStateData data)
        {
            this.tracks = new Spine.ExposedList<UnityEngine.Material>();
            System.Collections.Generic.HashSet<System.Int32> val_2 = new System.Collections.Generic.HashSet<System.Int32>();
            this.propertyIDs = null;
            Spine.ExposedList<UnityEngine.Material> val_3 = new Spine.ExposedList<UnityEngine.Material>();
            this.events = null;
            this.timeScale = 1f;
            this.mixingTo = new Spine.ExposedList<UnityEngine.Material>();
            Spine.Pool<System.Object> val_5 = new Spine.Pool<System.Object>(initialCapacity:  16, max:  -2147483648);
            this.trackEntryPool = null;
            if(data != 0)
            {
                    this.data = data;
                System.Action val_6 = new System.Action(object:  1867324672, method:  new IntPtr(1867294416));
                this.queue = new Spine.EventQueue(state:  1867324672, HandleAnimationsChanged:  7454720, trackEntryPool:  this.trackEntryPool);
                return;
            }
            
            System.ArgumentNullException val_8 = new System.ArgumentNullException(paramName:  1658600960, message:  1867299536);
        }
        private void HandleAnimationsChanged()
        {
            this.animationsChanged = true;
        }
        public void Update(float delta)
        {
            Spine.ExposedList<Spine.TrackEntry> val_4;
            var val_5;
            float val_6;
            float val_7;
            Spine.TrackEntry val_8;
            float val_3 = this.timeScale;
            val_4 = this.tracks;
            if(this.tracks != 0)
            {
                goto label_0;
            }
            
            val_4 = this.tracks;
            if(val_4 == 0)
            {
                goto label_1;
            }
            
            label_0:
            if(SL <= 0)
            {
                goto label_2;
            }
            
            var val_8 = 0;
            val_3 = val_3 * R1;
            val_5 = 1152921510769379352;
            goto label_24;
            label_18:
            mem2[0] = 0;
            this.queue.End(entry:  R7);
            this.DisposeNext(entry:  R7);
            goto label_16;
            label_24:
            var val_1 = SB + 0;
            if(((SB + 0) + 16) == 0)
            {
                goto label_16;
            }
            
            float val_4 = (SB + 0) + 16 + 56;
            val_6 = val_3 * ((SB + 0) + 16 + 76);
            mem2[0] = (SB + 0) + 16 + 52;
            mem2[0] = (SB + 0) + 16 + 68;
            if(((SB + 0) + 16) <= 0)
            {
                goto label_10;
            }
            
            val_4 = val_4 - val_6;
            mem2[0] = val_4;
            if(((SB + 0) + 16) > 0)
            {
                goto label_16;
            }
            
            val_6 = -val_4;
            mem2[0] = 0;
            label_10:
            val_7 = (SB + 0) + 16 + 68;
            if(((SB + 0) + 16 + 12) == 0)
            {
                goto label_12;
            }
            
            val_7 = val_7 - ((SB + 0) + 16 + 12 + 56);
            if(((SB + 0) + 16 + 12) < 0)
            {
                goto label_17;
            }
            
            mem2[0] = 0;
            mem2[0] = val_7;
            float val_5 = (SB + 0) + 16 + 60;
            val_5 = val_6 + val_5;
            mem2[0] = val_5;
            this.SetCurrent(index:  0, current:  (SB + 0) + 16 + 12, interrupt:  true);
            if(((SB + 0) + 16 + 12 + 16) == 0)
            {
                goto label_16;
            }
            
            do
            {
                float val_6 = (SB + 0) + 16 + 12 + 84;
                val_6 = val_6 + val_6;
                mem2[0] = val_6;
            }
            while(((SB + 0) + 16 + 12 + 16 + 16) != 0);
            
            goto label_16;
            label_12:
            if(((SB + 0) + 16 + 12) <= 0)
            {
                    if(((SB + 0) + 16 + 16) == 0)
            {
                goto label_18;
            }
            
            }
            
            label_17:
            if((((SB + 0) + 16 + 16) == 0) || ((this.UpdateMixingFrom(to:  (SB + 0) + 16, delta:  val_7)) == false))
            {
                goto label_20;
            }
            
            val_8 = mem[(SB + 0) + 16 + 16];
            val_8 = (SB + 0) + 16 + 16;
            mem2[0] = 0;
            goto label_21;
            label_23:
            this.queue.End(entry:  val_8);
            val_8 = mem[(SB + 0) + 16 + 16 + 16];
            val_8 = (SB + 0) + 16 + 16 + 16;
            label_21:
            if(val_8 != 0)
            {
                goto label_23;
            }
            
            label_20:
            float val_7 = (SB + 0) + 16 + 60;
            val_7 = val_6 + val_7;
            mem2[0] = val_7;
            label_16:
            val_8 = val_8 + 1;
            if(val_8 != SL)
            {
                goto label_24;
            }
            
            goto label_25;
            label_2:
            val_5 = 1152921510769379352;
            label_25:
            val_5.Drain();
            return;
            label_1:
        }
        private bool UpdateMixingFrom(Spine.TrackEntry to, float delta)
        {
            var val_1;
            if(to.mixingFrom == 0)
            {
                goto label_1;
            }
            
            if(to.mixingFrom <= 0)
            {
                goto label_5;
            }
            
            val_1 = this;
            if(to.mixingFrom < 0)
            {
                    if(to.mixingFrom != 0)
            {
                goto label_5;
            }
            
            }
            
            if(to.mixingFrom != 0)
            {
                    return (bool)val_1;
            }
            
            to.mixingFrom = to.mixingFrom.mixingFrom;
            to.interruptAlpha = to.mixingFrom.interruptAlpha;
            this.queue.End(entry:  to.mixingFrom);
            return (bool)val_1;
            label_1:
            val_1 = 1;
            return (bool)val_1;
            label_5:
            val_1 = 0;
            to.mixingFrom.trackLast = to.mixingFrom.nextTrackLast;
            to.mixingFrom.animationLast = to.mixingFrom.nextAnimationLast;
            to.mixingFrom.trackTime = to.mixingFrom.trackTime;
            to.mixTime = to.mixTime;
            return (bool)val_1;
        }
        public bool Apply(Spine.Skeleton skeleton)
        {
            var val_9;
            Spine.AnimationState val_13;
            Spine.Skeleton val_14;
            Spine.ExposedList<Spine.Event> val_15;
            Spine.ExposedList<Spine.TrackEntry> val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_22;
            val_13 = this;
            val_14 = skeleton;
            if(val_14 == 0)
            {
                goto label_1;
            }
            
            if(this.animationsChanged == true)
            {
                    this.animationsChanged = val_13;
                this.AnimationsChanged();
            }
            
            val_15 = this.events;
            val_16 = this.tracks;
            if(this.tracks != 0)
            {
                goto label_2;
            }
            
            val_16 = this.tracks;
            if(val_16 == 0)
            {
                goto label_3;
            }
            
            label_2:
            if(R7 >= 1)
            {
                    val_18 = 0;
                val_19 = 0;
                do
            {
                float val_12 = Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 80;
                if(val_19 == 0)
            {
                    2 = 1;
            }
            
                float val_1 = this.ApplyMixingFrom(to:  Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg, skeleton:  val_14, currentPose:  1);
                val_12 = val_12 * 1867853568;
                var val_14 = 0;
                val_15 = mem[(Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 8 + 8 + 8 + 0) + 16];
                val_15 = (Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 8 + 8 + 8 + 0) + 16;
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_22 = val_15;
                val_14 = val_14 + 1;
                val_13 = val_13;
                this.QueueEvents(entry:  Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg, animationTime:  Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg.AnimationTime);
                val_15.Clear(clearArray:  false);
                mem2[0] = Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg;
                val_17 = val_9;
                val_19 = val_19;
                mem2[0] = Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 60;
                val_18 = 1;
                val_19 = val_19 + 1;
            }
            while(val_19 != val_17);
            
            }
            else
            {
                    val_18 = 0;
            }
            
            this.queue.Drain();
            return (bool)val_18 & 1;
            label_1:
            System.ArgumentNullException val_11 = new System.ArgumentNullException(paramName:  1843048096, message:  1843048192);
            label_3:
        }
        private float ApplyMixingFrom(Spine.TrackEntry to, Spine.Skeleton skeleton, Spine.MixPose currentPose)
        {
            Spine.TrackEntry val_10;
            var val_12;
            Spine.ExposedList<Spine.TrackEntry> val_13;
            Spine.MixPose val_14;
            System.Single[] val_15;
            var val_18;
            var val_19;
            float val_20;
            val_10 = to.mixingFrom;
            if(to.mixingFrom.mixingFrom == 0)
            {
                
            }
            else
            {
                    if(to.mixingFrom.mixingFrom > 0)
            {
                    to.mixTime / to.mixDuration = 1f;
            }
            
            }
            
            if(to.mixingFrom.mixingFrom < 0)
            {
                    0 = this.events;
            }
            
            float val_2 = val_10.AnimationTime;
            if(to.mixingFrom.animation.timelines != 0)
            {
                    val_12 = to.mixingFrom.animation.timelines;
            }
            else
            {
                    val_12 = 12;
            }
            
            val_13 = to.mixingFrom.timelineDipMix;
            if(0 == 0)
            {
                    Spine.ExposedList<T> val_3 = to.mixingFrom.timelinesRotation.Resize(newSize:  0);
                val_10 = val_10;
            }
            
            var val_14 = 0;
            mem2[0] = val_14;
            if(0 < 1)
            {
                goto label_16;
            }
            
            label_53:
            var val_6 = 0 + 0;
            val_14 = 0;
            val_15 = 0f * ((to.mixingFrom + 80) * (to + 92));
            if(val_10 != 0)
            {
                    val_18 = mem[to.mixingFrom + 96];
                val_18 = to.mixingFrom + 96;
            }
            else
            {
                    val_18 = mem[to.mixingFrom + 96];
                val_18 = to.mixingFrom + 96;
            }
            
             =  + val_18;
            mem2[0] = ;
            if(((0 + 0) + 16) == 0)
            {
                goto label_43;
            }
            
            Spine.AnimationState.ApplyRotateTimeline(rotateTimeline:  (0 + 0) + 16, skeleton:  skeleton, time:  null, alpha:  null, pose:  val_10, timelinesRotation:  null, i:  null, firstFrame:  to.mixingFrom + 108 + 8);
            goto label_48;
            label_43:
            var val_13 = (0 + 0) + 16;
            if(((0 + 0) + 16 + 178) == 0)
            {
                goto label_49;
            }
            
            var val_12 = 0;
            label_51:
            val_13 = 0;
            if(((0 + 0) + 16 + 88 + 0) == null)
            {
                goto label_50;
            }
            
            val_12 = val_12 + 1;
            val_13 = (uint)val_12 & 65535;
            if(val_13 < ((0 + 0) + 16 + 178))
            {
                goto label_51;
            }
            
            label_49:
            val_19 = (0 + 0) + 16;
            goto label_52;
            label_50:
            var val_9 = ((0 + 0) + 16 + 88) + 0;
            val_13 = val_13 + ((((0 + 0) + 16 + 88 + 0) + 4) << 3);
            val_19 = val_13 + 188;
            label_52:
            val_10 = val_10;
            label_48:
            val_14 = val_14 + 1;
            if(val_14 != 0)
            {
                goto label_53;
            }
            
            label_16:
            if(to > 0)
            {
                    this.QueueEvents(entry:  val_10, animationTime:  to + 88);
            }
            
            0.Clear(clearArray:  false);
            if(val_10 != 0)
            {
                    val_20 = mem[to.mixingFrom + 60];
                val_20 = to.mixingFrom + 60;
                mem2[0] = val_10;
            }
            else
            {
                    mem[52] = val_10;
                val_20 = 7.286752E-44f;
            }
            
            mem2[0] = val_20;
            return (float)to + 88;
        }
        private static void ApplyRotateTimeline(Spine.RotateTimeline rotateTimeline, Spine.Skeleton skeleton, float time, float alpha, Spine.MixPose pose, float[] timelinesRotation, int i, bool firstFrame)
        {
            var val_1;
            var val_2;
            var val_18;
            float val_20;
            var val_21;
            var val_22;
            if(val_1 != 0)
            {
                    bool val_3 = firstFrame + (val_2 << 2);
                mem2[0] = 0;
            }
            
            if((firstFrame + 12) != val_2)
            {
                goto label_4;
            }
            
            if(rotateTimeline != 0)
            {
                goto label_18;
            }
            
            goto label_18;
            label_4:
            val_18 = val_2;
            float val_16 = timelinesRotation[rotateTimeline.boneIndex];
            float val_17 = rotateTimeline.frames[0];
            if(timelinesRotation[rotateTimeline.boneIndex] <= null)
            {
                goto label_14;
            }
            
            if(i != 0)
            {
                goto label_18;
            }
            
            mem2[0] = timelinesRotation[rotateTimeline.boneIndex][0] + 8 + 32;
            goto label_18;
            label_14:
            System.Single[] val_4 = timelinesRotation[rotateTimeline.boneIndex] - 2;
            if(timelinesRotation[rotateTimeline.boneIndex] > 1)
            {
                    int val_22 = Spine.Animation.BinarySearch(values:  rotateTimeline.frames, target:  rotateTimeline.frames[val_4], step:  pose);
                val_4 = val_22 - 1;
                float val_19 = rotateTimeline.frames[val_4];
                float val_20 = rotateTimeline.frames[val_22];
                float val_21 = rotateTimeline.frames[val_22 - 2];
                val_21 = val_21 - val_20;
                val_21 = (pose - val_20) / val_21;
                val_21 = 1f - val_21;
                float val_9 = rotateTimeline.GetCurvePercent(frameIndex:  0 + (val_22 >> 1), percent:  val_21);
                val_22 = val_22 + 1;
                float val_23 = rotateTimeline.frames[val_22];
                float val_10 = val_23 - val_19;
                val_23 = val_10 / (-360f);
                double val_11 = D16 + (2.12199579047121E-314);
                if(rotateTimeline == val_22)
            {
                    val_11 = -val_11;
            }
            
                var val_24 = val_23;
                val_24 = 16384 - val_24;
                val_24 = val_24 * 360;
                val_20 = val_16;
                val_10 = val_10 - (float)val_24;
                val_18 = val_2;
                var val_25 = timelinesRotation[rotateTimeline.boneIndex][0] + 8 + 32;
                val_25 = val_19 + val_25;
                val_11 = val_11 + (2.12199579047121E-314);
                if((timelinesRotation[rotateTimeline.boneIndex][0] + 8) == 0)
            {
                    val_11 = -val_11;
            }
            
                var val_26 = val_25 / (-360f);
                val_26 = 16384 - val_26;
                val_26 = val_26 * 360;
                val_21 = val_25 - (float)val_26;
            }
            else
            {
                    val_20 = val_16;
                val_21 = (timelinesRotation[rotateTimeline.boneIndex][0] + 8 + 32) + (rotateTimeline.frames[rotateTimeline.frames[val_4] - 1]);
            }
            
            if(i != 0)
            {
                    val_22 = val_20 + 32;
            }
            else
            {
                    val_22 = (timelinesRotation[rotateTimeline.boneIndex][0] + 8) + 32;
            }
            
            val_21 = val_21 - val_22;
            if((timelinesRotation[rotateTimeline.boneIndex][0] + 8) == 0)
            {
                    bool val_14 = firstFrame + (val_18 << 2);
            }
            else
            {
                    float val_28 = -360f;
                val_28 = val_21 / val_28;
                double val_15 = D16 + (2.12199579047121E-314);
                if((timelinesRotation[rotateTimeline.boneIndex][0] + 8) == 0)
            {
                    val_15 = -val_15;
            }
            
                var val_29 = val_28;
                val_29 = 16384 - val_29;
                val_29 = val_29 * 360;
                val_21 = val_21 - (float)val_29;
                if(val_1 != 0)
            {
                
            }
            
            }
        
        }
        private void QueueEvents(Spine.TrackEntry entry, float animationTime)
        {
            float val_3;
            float val_4;
            float val_5;
            Spine.ExposedList<Spine.Event> val_6;
            Spine.Event val_7;
            var val_8;
            var val_9;
            if(entry != 0)
            {
                    val_3 = entry.animationStart;
                val_4 = entry.animationEnd;
                val_5 = val_4 - val_3;
            }
            else
            {
                    val_3 = 2.938809E-39f;
                val_4 = 3.673431E-39f;
                val_5 = val_4 - val_3;
            }
            
            val_6 = this.events;
            val_7 = entry.trackLast;
            if(val_6 != 0)
            {
                
            }
            else
            {
                    val_8 = 0;
            }
            
            if(R2 < 1)
            {
                goto label_4;
            }
            
            var val_1 = val_8 + 16;
            val_9 = 0;
            label_11:
            val_7 = mem[(val_8 + 16) + 0];
            val_7 = (val_8 + 16) + 0;
            if(val_7 < 0)
            {
                goto label_12;
            }
            
            if(val_7 <= 0)
            {
                    val_6 = mem[1152921510770320280];
                val_6.Event(entry:  entry, e:  val_7);
            }
            
            val_9 = val_9 + 1;
            if(val_9 < R2)
            {
                goto label_11;
            }
            
            goto label_12;
            label_4:
            val_9 = 0;
            label_12:
            if(entry.loop == false)
            {
                goto label_14;
            }
            
            if(entry.loop > false)
            {
                goto label_15;
            }
            
            goto label_18;
            label_14:
            if((entry.loop > false) || (entry.loop >= 0))
            {
                goto label_18;
            }
            
            label_15:
            val_7 = mem[1152921510770320280];
            val_7.Complete(entry:  entry);
            label_18:
            if(val_9 >= R2)
            {
                    return;
            }
            
            do
            {
                val_6 = val_8 + 0;
                val_7 = mem[(val_8 + 0) + 16];
                val_7 = (val_8 + 0) + 16;
                if(val_7 >= 0)
            {
                    val_7 = mem[1152921510770320280];
                val_6 = mem[(val_8 + 0) + 16];
                val_6 = (val_8 + 0) + 16;
                val_7.Event(entry:  entry, e:  val_6);
            }
            
                val_9 = val_9 + 1;
            }
            while(R2 != val_9);
        
        }
        public void ClearTracks()
        {
            if(this.queue != 0)
            {
                goto label_1;
            }
            
            this.queue = this.queue;
            if(this.queue == 0)
            {
                goto label_2;
            }
            
            label_1:
            this.queue.drainDisabled = true;
            if(R7 >= 1)
            {
                    var val_1 = 0;
                do
            {
                this.ClearTrack(trackIndex:  0);
                val_1 = val_1 + 1;
            }
            while(R7 != val_1);
            
            }
            
            this.tracks.Clear(clearArray:  true);
            this.queue.drainDisabled = this.queue.drainDisabled;
            this.queue.Drain();
            return;
            label_2:
        }
        public void ClearTrack(int trackIndex)
        {
            var val_3;
            if(this <= trackIndex)
            {
                    return;
            }
            
            Spine.ExposedList<Spine.TrackEntry> val_1 = this.tracks + (trackIndex << 2);
            if(R8 == 0)
            {
                    return;
            }
            
            this.queue.End(entry:  R8);
            this.DisposeNext(entry:  R8);
            val_3 = R8;
            if((R8 + 16) != 0)
            {
                    do
            {
                this.queue.End(entry:  R8 + 16);
                mem2[0] = 0;
                val_3 = R8 + 16;
            }
            while((R8 + 16 + 16) != 0);
            
            }
            
            Spine.ExposedList<Spine.TrackEntry> val_2 = this.tracks + ((R8 + 20) << 2);
            mem2[0] = 0;
            this.queue.Drain();
        }
        private void SetCurrent(int index, Spine.TrackEntry current, bool interrupt)
        {
            int val_5;
            Spine.TrackEntry val_6;
            val_5 = index;
            Spine.TrackEntry val_1 = this.ExpandToIndex(index:  val_5);
            val_6 = this;
            Spine.ExposedList<Spine.TrackEntry> val_2 = this.tracks + (val_5 << 2);
            mem2[0] = current;
            if(val_6 != 0)
            {
                    if(interrupt != false)
            {
                    val_5 = this.queue;
                val_5.Interrupt(entry:  1868969984);
            }
            
                if(current != 0)
            {
                    current.mixingFrom = val_6;
            }
            else
            {
                    mem[16] = val_6;
            }
            
                current.mixTime = 0f;
                if((this.propertyIDs != 0) && (this.propertyIDs > 0))
            {
                    float val_4 = System.Math.Min(val1:  S20 / S18, val2:  null);
                uint val_5 = 1065353216;
                val_5 = current.interruptAlpha * val_5;
                current.interruptAlpha = val_5;
            }
            
                this.tracks.Clear(clearArray:  true);
            }
            
            this.queue.Start(entry:  current);
        }
        public Spine.TrackEntry SetAnimation(int trackIndex, string animationName, bool loop)
        {
            Spine.Animation val_1 = this.data.skeletonData.FindAnimation(animationName:  animationName);
            if(this.data.skeletonData != 0)
            {
                    Spine.TrackEntry val_2 = this.SetAnimation(trackIndex:  trackIndex, animation:  this.data.skeletonData, loop:  loop);
                return;
            }
            
            string val_3 = 1869090752 + animationName;
            System.ArgumentException val_4 = new System.ArgumentException(message:  1869090752, paramName:  1869090864);
        }
        public Spine.TrackEntry SetAnimation(int trackIndex, Spine.Animation animation, bool loop)
        {
            var val_5;
            System.Collections.Generic.HashSet<System.Int32> val_6;
            if(animation == 0)
            {
                goto label_1;
            }
            
            Spine.TrackEntry val_1 = this.ExpandToIndex(index:  trackIndex);
            val_5 = 1;
            if(this == 0)
            {
                goto label_2;
            }
            
            val_6 = this;
            if(this != 0)
            {
                goto label_3;
            }
            
            Spine.ExposedList<Spine.TrackEntry> val_2 = this.tracks + (trackIndex << 2);
            mem2[0] = this.propertyIDs;
            this.queue.Interrupt(entry:  1869270192);
            this.queue.End(entry:  1869270192);
            this.DisposeNext(entry:  1869270192);
            val_6 = this.propertyIDs;
            val_5 = 0;
            goto label_12;
            label_2:
            val_6 = 0;
            goto label_12;
            label_3:
            this.DisposeNext(entry:  1869270192);
            label_12:
            Spine.TrackEntry val_3 = this.NewTrackEntry(trackIndex:  trackIndex, animation:  animation, loop:  loop, last:  this);
            this.SetCurrent(index:  trackIndex, current:  1869270192, interrupt:  true);
            this.queue.Drain();
            return;
            label_1:
            System.ArgumentNullException val_4 = new System.ArgumentNullException(paramName:  1869244944, message:  1869245040);
        }
        public Spine.TrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay)
        {
            float val_2;
            Spine.Animation val_1 = this.data.skeletonData.FindAnimation(animationName:  animationName);
            if(this.data.skeletonData != 0)
            {
                    Spine.TrackEntry val_3 = this.AddAnimation(trackIndex:  trackIndex, animation:  this.data.skeletonData, loop:  loop, delay:  val_2);
                return;
            }
            
            string val_4 = 1869090752 + animationName;
            System.ArgumentException val_5 = new System.ArgumentException(message:  1869090752, paramName:  1869090864);
        }
        public Spine.TrackEntry AddAnimation(int trackIndex, Spine.Animation animation, bool loop, float delay)
        {
            var val_1;
            Spine.AnimationState val_9;
            int val_10;
            float val_11;
            var val_12;
            val_9 = this;
            val_10 = trackIndex;
            if(animation == 0)
            {
                goto label_1;
            }
            
            val_11 = val_1;
            Spine.TrackEntry val_2 = this.ExpandToIndex(index:  val_10);
            if(val_9 == 0)
            {
                goto label_2;
            }
            
            do
            {
            
            }
            while(this.tracks != 0);
            
            Spine.TrackEntry val_3 = this.NewTrackEntry(trackIndex:  val_10, animation:  animation, loop:  loop, last:  this);
            val_12 = val_9;
            this.tracks = val_9;
            if(this.tracks > 0)
            {
                goto label_8;
            }
            
            if(this.tracks != 0)
            {
                goto label_5;
            }
            
            val_11 = 0f;
            goto label_8;
            label_2:
            Spine.TrackEntry val_5 = this.NewTrackEntry(trackIndex:  val_10, animation:  animation, loop:  loop, last:  0);
            val_12 = val_9;
            this.SetCurrent(index:  val_10, current:  1869582256, interrupt:  true);
            this.queue.Drain();
            goto label_8;
            label_5:
            val_9 = this.data;
            val_10 = this.data;
            float val_6 = val_9.GetMix(from:  val_10, to:  animation);
            var val_9 = this.Complete / (this.Start - this.trackEntryPool);
            val_9 = val_9 + 1;
            val_11 = val_9 + val_11;
            label_8:
            this.Dispose = val_11;
            return;
            label_1:
            System.ArgumentNullException val_8 = new System.ArgumentNullException(paramName:  1869244944, message:  1869245040);
        }
        public Spine.TrackEntry SetEmptyAnimation(int trackIndex, float mixDuration)
        {
            null = null;
            Spine.TrackEntry val_1 = this.SetAnimation(trackIndex:  trackIndex, animation:  Spine.AnimationState.DIP_MIX, loop:  false);
            if(this != 0)
            {
                    mem[1152921510771541384] = R2;
            }
            else
            {
                    mem[88] = R2;
            }
            
            mem[1152921510771541368] = R2;
        }
        public Spine.TrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay)
        {
            var val_3;
            float val_1 = R3 - R2;
            val_3 = null;
            if(static_value_022008F4 <= false)
            {
                    R3 = val_1;
            }
            
            val_3 = null;
            Spine.TrackEntry val_2 = this.AddAnimation(trackIndex:  trackIndex, animation:  Spine.AnimationState.DIP_MIX, loop:  false, delay:  val_1);
            if(this != 0)
            {
                    mem[1152921510771653384] = R2;
            }
            else
            {
                    mem[88] = R2;
            }
            
            mem[1152921510771653368] = R2;
        }
        public void SetEmptyAnimations(float mixDuration)
        {
            if(this.queue != 0)
            {
                goto label_0;
            }
            
            this.queue = this.queue;
            if(this.queue == 0)
            {
                goto label_1;
            }
            
            label_0:
            this.queue.drainDisabled = true;
            if(R7 >= 1)
            {
                    var val_2 = 0;
                do
            {
                Spine.TrackEntry val_1 = this.SetEmptyAnimation(trackIndex:  0, mixDuration:  mixDuration);
                val_2 = val_2 + 1;
            }
            while(R7 != val_2);
            
            }
            
            this.queue.drainDisabled = this.queue.drainDisabled;
            this.queue.Drain();
            return;
            label_1:
        }
        private Spine.TrackEntry ExpandToIndex(int index)
        {
            if(true <= index)
            {
                goto label_6;
            }
            
            Spine.ExposedList<Spine.TrackEntry> val_1 = this.tracks + (index << 2);
            return;
            label_9:
            this.tracks.Add(item:  0);
            label_6:
            if(this.tracks <= index)
            {
                goto label_9;
            }
        
        }
        private Spine.TrackEntry NewTrackEntry(int trackIndex, Spine.Animation animation, bool loop, Spine.TrackEntry last)
        {
            Spine.AnimationStateData val_5;
            float val_6;
            Spine.TrackEntry val_1 = this.trackEntryPool.Obtain();
            if(this.trackEntryPool != 0)
            {
                    mem2[0] = animation;
                mem2[0] = trackIndex;
                mem2[0] = loop;
                mem2[0] = 0;
                mem2[0] = 0;
                mem2[0] = 0;
            }
            else
            {
                    mem[20] = trackIndex;
                mem[8] = animation;
                mem[24] = loop;
                mem[28] = 0;
                mem[32] = 0;
                mem[36] = 0;
            }
            
            val_5 = 0;
            mem2[0] = val_5;
            mem2[0] = animation.duration;
            mem2[0] = 1065353216;
            mem2[0] = 1065353216;
            Spine.Pool<Spine.TrackEntry> val_2 = this.trackEntryPool + 48;
            mem2[0] = val_5;
            Spine.Pool<Spine.TrackEntry> val_3 = this.trackEntryPool + 64;
            if(last != 0)
            {
                    val_5 = this.data;
                float val_4 = val_5.GetMix(from:  last.animation, to:  animation);
                val_6 = val_5;
            }
            else
            {
                    val_6 = 0f;
            }
            
            mem2[0] = val_6;
        }
        private void DisposeNext(Spine.TrackEntry entry)
        {
            Spine.TrackEntry val_1 = entry.next;
            goto label_1;
            label_3:
            this.queue.Dispose(entry:  val_1 = entry.next);
            val_1 = entry.next.next;
            label_1:
            if(val_1 != 0)
            {
                goto label_3;
            }
            
            entry.next = 0;
        }
        private void AnimationsChanged()
        {
            var val_3;
            Spine.ExposedList<Spine.TrackEntry> val_4;
            val_3 = this;
            this.animationsChanged = false;
            this.propertyIDs.Clear();
            val_4 = this.tracks;
            if(this.tracks != 0)
            {
                goto label_2;
            }
            
            val_4 = this.tracks;
            if(val_4 == 0)
            {
                goto label_3;
            }
            
            label_2:
            if(SL < 1)
            {
                    return;
            }
            
            val_3 = 0;
            var val_3 = 0;
            var val_1 = R5 + 16;
            do
            {
                if(((R5 + 16) + 0) != 0)
            {
                    Spine.TrackEntry val_2 = (R5 + 16) + 0.SetTimelineData(to:  0, mixingToArray:  this.mixingTo, propertyIDs:  this.propertyIDs);
                val_3 = (R5 + 16) + 0;
            }
            
                val_3 = val_3 + 1;
            }
            while(SL != val_3);
            
            return;
            label_3:
        }
        public Spine.TrackEntry GetCurrent(int trackIndex)
        {
            if(trackIndex <= trackIndex)
            {
                    return;
            }
            
            Spine.ExposedList<Spine.TrackEntry> val_1 = this.tracks + (trackIndex << 2);
        }
        public override string ToString()
        {
            var val_7;
            float val_9;
            string val_10;
            val_7 = this;
            if(R7 >= 1)
            {
                    var val_6 = 0;
                val_9 = ", ";
                do
            {
                if(Length >= 1)
            {
                    System.Text.StringBuilder val_3 = Append(value:  1370307136);
            }
            
                val_10 = Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg;
                System.Text.StringBuilder val_4 = Append(value:  val_10);
                val_6 = val_6 + 1;
            }
            while(R7 != val_6);
            
            }
            
            if(Length == 0)
            {
                    return;
            }
            
            if(new System.Text.StringBuilder() == 0)
            {
                
            }
        
        }
        internal void OnStart(Spine.TrackEntry entry)
        {
            if(this.Start == 0)
            {
                    return;
            }
            
            this.Start.Invoke(trackEntry:  entry);
        }
        internal void OnInterrupt(Spine.TrackEntry entry)
        {
            if(this.Interrupt == 0)
            {
                    return;
            }
            
            this.Interrupt.Invoke(trackEntry:  entry);
        }
        internal void OnEnd(Spine.TrackEntry entry)
        {
            if(this.End == 0)
            {
                    return;
            }
            
            this.End.Invoke(trackEntry:  entry);
        }
        internal void OnDispose(Spine.TrackEntry entry)
        {
            if(this.Dispose == 0)
            {
                    return;
            }
            
            this.Dispose.Invoke(trackEntry:  entry);
        }
        internal void OnComplete(Spine.TrackEntry entry)
        {
            if(this.Complete == 0)
            {
                    return;
            }
            
            this.Complete.Invoke(trackEntry:  entry);
        }
        internal void OnEvent(Spine.TrackEntry entry, Spine.Event e)
        {
            if(this.Event == 0)
            {
                    return;
            }
            
            this.Event.Invoke(trackEntry:  entry, e:  e);
        }
        private static AnimationState()
        {
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            Spine.Animation val_2 = new Spine.Animation(name:  1871714880, timelines:  265015296, duration:  null);
            Spine.AnimationState.DIP_MIX = null;
        }
    
    }

}
