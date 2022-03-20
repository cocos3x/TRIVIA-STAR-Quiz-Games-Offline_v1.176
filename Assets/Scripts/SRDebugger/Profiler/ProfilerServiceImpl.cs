using UnityEngine;

namespace SRDebugger.Profiler
{
    public class ProfilerServiceImpl : SRServiceBase<SRDebugger.Services.IProfilerService>, IProfilerService
    {
        // Fields
        private const int FrameBufferSize = 400;
        private readonly SRF.SRList<SRDebugger.Profiler.ProfilerCameraListener> _cameraListeners;
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> _frameBuffer;
        private UnityEngine.Camera[] _cameraCache;
        private SRDebugger.Profiler.ProfilerLateUpdateListener _lateUpdateListener;
        private double _renderDuration;
        private int _reportedCameras;
        private System.Diagnostics.Stopwatch _stopwatch;
        private double _updateDuration;
        private double _updateToRenderDuration;
        private float <AverageFrameTime>k__BackingField;
        private float <LastFrameTime>k__BackingField;
        
        // Properties
        public float AverageFrameTime { get; set; }
        public float LastFrameTime { get; set; }
        public SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> FrameBuffer { get; }
        
        // Methods
        public float get_AverageFrameTime()
        {
            return (float)S0;
        }
        private void set_AverageFrameTime(float value)
        {
            this.<AverageFrameTime>k__BackingField = ;
        }
        public float get_LastFrameTime()
        {
            return (float)S0;
        }
        private void set_LastFrameTime(float value)
        {
            this.<LastFrameTime>k__BackingField = ;
        }
        public SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer()
        {
        
        }
        protected void PushFrame(double totalTime, double updateTime, double renderTime)
        {
            var val_1;
            var val_2;
            double val_3 = R2 - val_2;
            val_3 = val_3 - val_1;
            this._frameBuffer.PushBack(item:  new SRDebugger.Services.ProfilerFrame() {RenderTime = ???, UpdateTime = ???});
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.AddComponent<System.Object>();
            this._lateUpdateListener = this;
            System.Action val_3 = new System.Action(object:  489135920, method:  new IntPtr(489110896));
            mem[1152921513685917500] = null;
            UnityEngine.GameObject val_4 = this.CachedGameObject;
            this.hideFlags = 8;
            UnityEngine.Transform val_5 = this.CachedTransform;
            UnityEngine.Transform val_6 = SRF.Hierarchy.Get(key:  466780208);
            this.SetParent(parent:  466780208, worldPositionStays:  true);
        }
        protected override void Update()
        {
            double val_2;
            double val_3;
            double val_7;
            var val_13;
            SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> val_14;
            float val_15;
            var val_16;
            float val_17;
            this.Update();
            if(this >= 1)
            {
                    SRDebugger.Services.ProfilerFrame val_1 = Back();
                float val_8 = UnityEngine.Time.deltaTime;
                val_14 = this._frameBuffer;
                if(val_14 != 0)
            {
                
            }
            else
            {
                    val_15 = 3.673424E-39f;
            }
            
                val_14.set_Item(index:  val_15 - 1, value:  new SRDebugger.Services.ProfilerFrame() {FrameTime = this._frameBuffer, OtherTime = val_2, RenderTime = val_3, UpdateTime = val_7});
            }
            
            float val_10 = UnityEngine.Time.deltaTime;
            this.<LastFrameTime>k__BackingField = 0f;
            val_16 = 0;
            int val_11 = UnityEngine.Mathf.Min(a:  20, b:  this._frameBuffer);
            if(val_11 >= 1)
            {
                    val_15 = 1152921513653567056;
                do
            {
                SRDebugger.Services.ProfilerFrame val_12 = Item[this._frameBuffer];
                val_16 = val_16 + 1;
                double val_14 = D8 + val_13;
            }
            while(val_11 != val_16);
            
            }
            else
            {
                    val_17 = 0f;
            }
            
            val_17 = val_17 / (float)val_11;
            this.<AverageFrameTime>k__BackingField = val_17;
            if(this._stopwatch.is_running != false)
            {
                    this._stopwatch.Stop();
                this._stopwatch.Reset();
            }
            
            this._renderDuration = 0;
            mem[1152921513686071532] = 0;
            this._reportedCameras = 0;
            this.CameraCheck();
            this._stopwatch.Start();
        }
        private void OnLateUpdate()
        {
            System.TimeSpan val_1 = Elapsed;
            double val_2 = ???.TotalSeconds;
            this._updateDuration = ???;
        }
        private void EndFrame()
        {
            var val_2;
            if(this._stopwatch.is_running == false)
            {
                    return;
            }
            
            System.TimeSpan val_1 = Elapsed;
            this.PushFrame(totalTime:  val_2.TotalSeconds, updateTime:  null, renderTime:  null);
            this._stopwatch.Reset();
            this._stopwatch.Start();
        }
        private void CameraDurationCallback(SRDebugger.Profiler.ProfilerCameraListener listener, double duration)
        {
            int val_4 = this._reportedCameras;
            val_4 = val_4 + 1;
            this._reportedCameras = val_4;
            System.TimeSpan val_1 = Elapsed;
            double val_2 = ???.TotalSeconds;
            double val_5 = this._updateDuration;
            val_5 = 489703992 - val_5;
            val_5 = val_5 - this._updateToRenderDuration;
            this._renderDuration = val_5;
            int val_3 = this.GetExpectedCameraCount();
            if(this._reportedCameras >= val_3)
            {
                    val_3 = this;
                this.EndFrame();
            }
        
        }
        private int GetExpectedCameraCount()
        {
            var val_8;
            var val_9;
            val_8 = 0;
            val_9 = 0;
            goto label_1;
            label_14:
            SRDebugger.Profiler.ProfilerCameraListener val_1 = this._cameraListeners.Item[0];
            bool val_2 = UnityEngine.Object.op_Inequality(x:  this._cameraListeners, y:  0);
            if(val_2 == false)
            {
                goto label_5;
            }
            
            SRDebugger.Profiler.ProfilerCameraListener val_3 = this._cameraListeners.Item[0];
            if(this._cameraListeners.isActiveAndEnabled == false)
            {
                goto label_12;
            }
            
            SRDebugger.Profiler.ProfilerCameraListener val_5 = this._cameraListeners.Item[0];
            UnityEngine.Camera val_6 = this._cameraListeners.Camera;
            if(this._cameraListeners.isActiveAndEnabled == true)
            {
                    val_9 = 1;
            }
            
            goto label_12;
            label_5:
            val_9 = 1;
            label_12:
            val_8 = 1;
            label_1:
            if(val_8 < val_2)
            {
                goto label_14;
            }
            
            return (int)val_9;
        }
        private void CameraCheck()
        {
            var val_13;
            var val_14;
            float val_15;
            SRF.SRList<SRDebugger.Profiler.ProfilerCameraListener> val_16;
            UnityEngine.Camera[] val_17;
            int val_1 = true - 1;
            if(val_1 >= 0)
            {
                    val_13 = 1152921513686593776;
                val_14 = 1152921504765685760;
                val_15 = 1152921513686743664;
                do
            {
                SRDebugger.Profiler.ProfilerCameraListener val_2 = this._cameraListeners.Item[val_1];
                if(this._cameraListeners == 0)
            {
                    this._cameraListeners.RemoveAt(index:  val_1);
            }
            
                val_1 = val_1 - 1;
            }
            while(val_1 > 1);
            
            }
            
            val_16 = this._cameraListeners;
            if(UnityEngine.Camera.allCamerasCount == UnityEngine.Camera.allCamerasCount)
            {
                    return;
            }
            
            val_16 = this._cameraCache;
            if(UnityEngine.Camera.allCamerasCount > UnityEngine.Camera.allCamerasCount)
            {
                    int val_6 = UnityEngine.Camera.allCamerasCount;
                val_17 = null;
                this._cameraCache = val_17;
            }
            else
            {
                    val_17 = this._cameraCache;
            }
            
            val_15 = 0;
            int val_7 = UnityEngine.Camera.GetAllCameras(cameras:  val_17);
            if(val_7 < 1)
            {
                    return;
            }
            
            val_13 = 1152921504765685760;
            label_30:
            val_14 = 0;
            val_16 = this._cameraCache[val_15];
            label_23:
            if(val_14 >= this._cameraCache[val_15])
            {
                goto label_18;
            }
            
            SRDebugger.Profiler.ProfilerCameraListener val_8 = this._cameraListeners.Item[0];
            UnityEngine.Camera val_9 = this._cameraListeners.Camera;
            val_14 = val_14 + 1;
            if(this._cameraListeners != val_16)
            {
                goto label_23;
            }
            
            goto label_24;
            label_18:
            UnityEngine.GameObject val_11 = val_16.gameObject;
            object val_12 = val_16.AddComponent<System.Object>();
            val_16 = val_16;
            val_16.hideFlags = 60;
            System.Action<System.Object, System.Double> val_13 = new System.Action<System.Object, System.Double>(object:  490130480, method:  new IntPtr(490099312));
            mem2[0] = null;
            this._cameraListeners.Add(item:  val_16);
            label_24:
            val_15 = val_15 + 1;
            if(val_15 != val_7)
            {
                goto label_30;
            }
        
        }
        public ProfilerServiceImpl()
        {
            SRF.SRList<System.Object> val_1 = new SRF.SRList<System.Object>();
            this._cameraListeners = null;
            SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> val_2 = new SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame>(capacity:  400);
            this._frameBuffer = null;
            this._cameraCache = null;
            this._stopwatch = new System.Diagnostics.Stopwatch();
        }
    
    }

}
