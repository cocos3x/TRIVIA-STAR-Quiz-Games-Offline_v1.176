using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class ProfilerGraphControl : Graphic
    {
        // Fields
        public SRDebugger.UI.Controls.ProfilerGraphControl.VerticalAlignments VerticalAlignment;
        private static readonly float[] ScaleSteps;
        public bool FloatingScale;
        public bool TargetFpsUseApplication;
        public bool DrawAxes;
        public int TargetFps;
        public bool Clip;
        public const float DataPointMargin = 2;
        public const float DataPointVerticalMargin = 2;
        public const float DataPointWidth = 4;
        public int VerticalPadding;
        public const int LineCount = 3;
        public UnityEngine.Color[] LineColours;
        private SRDebugger.Services.IProfilerService _profilerService;
        private SRDebugger.UI.Controls.ProfilerGraphAxisLabel[] _axisLabels;
        private UnityEngine.Rect _clipBounds;
        private readonly System.Collections.Generic.List<UnityEngine.Vector3> _meshVertices;
        private readonly System.Collections.Generic.List<UnityEngine.Color32> _meshVertexColors;
        private readonly System.Collections.Generic.List<int> _meshTriangles;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            this._profilerService = public static SRDebugger.Services.IProfilerService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IProfilerService>();
        }
        protected override void Start()
        {
            this.Start();
        }
        protected void Update()
        {
            this.SetVerticesDirty();
        }
        protected override void OnPopulateMesh(UnityEngine.Mesh m)
        {
            double val_28;
            double val_30;
            int val_37;
            float val_38;
            SRDebugger.UI.Controls.ProfilerGraphAxisLabel val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            int val_48;
            int val_49;
            var val_50;
            System.Collections.Generic.List<System.Int32> val_51;
            this._meshVertices.Clear();
            this._meshVertexColors.Clear();
            this._meshTriangles.Clear();
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.Rect val_2 = rect;
            float val_3 = width;
            UnityEngine.RectTransform val_4 = this.rectTransform;
            UnityEngine.Rect val_5 = rect;
            val_38 = ;
            UnityEngine.Rect val_7 = new UnityEngine.Rect(x:  height, y:  val_5.m_YMin, width:  val_5.m_Width, height:  val_5.m_Height);
            bool val_8 = UnityEngine.Application.isPlaying;
            if(val_8 == true)
            {
                    val_8 = this.TargetFpsUseApplication;
                goto label_6;
            }
            
            label_31:
            val_39 = 1f / (float)this.TargetFps;
            if(this.FloatingScale == false)
            {
                goto label_8;
            }
            
            float val_9 = this.CalculateMaxFrameTime();
            if(this.FloatingScale == false)
            {
                goto label_8;
            }
            
            val_40 = 0;
            goto label_9;
            label_18:
            val_41 = null;
            val_41 = null;
            int val_10 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 16;
            int val_11 = LineCount * 1.1f;
            if((SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 12) < 0)
            {
                goto label_14;
            }
            
            val_40 = 1;
            label_9:
            val_42 = null;
            val_42 = null;
            if(val_40 < (SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 12))
            {
                goto label_18;
            }
            
            goto label_19;
            label_8:
            val_43 = 0;
            val_44 = 0;
            goto label_20;
            label_28:
            val_45 = null;
            val_45 = null;
            int val_12 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 16;
            if((SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 12) > val_44)
            {
                    val_43 = val_44;
            }
            
            val_44 = 1;
            label_20:
            val_46 = null;
            val_46 = null;
            val_37 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount;
            if(val_44 < (SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 12))
            {
                goto label_28;
            }
            
            goto label_32;
            label_6:
            if(UnityEngine.Application.targetFrameRate < 1)
            {
                goto label_31;
            }
            
            int val_14 = UnityEngine.Application.targetFrameRate;
            goto label_31;
            label_14:
            if(val_40 > 1)
            {
                goto label_32;
            }
            
            label_19:
            val_47 = null;
            val_47 = null;
            val_48 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount;
            if(SRDebugger.UI.Controls.ProfilerGraphControl.LineCount != 0)
            {
                goto label_35;
            }
            
            val_48 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount;
            if(val_48 == 0)
            {
                goto label_36;
            }
            
            label_35:
            var val_34 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 12;
            val_43 = val_34 - 1;
            val_34 = val_48 + (val_43 << 2);
            val_39 = mem[(SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + ((SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 12 - 1)) << 2) + 16];
            val_39 = (SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + ((SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + 12 - 1)) << 2) + 16;
            label_32:
            int val_35 = this.VerticalPadding;
            uint val_36 = 456068856;
            val_35 = val_35 << 1;
            val_36 = val_36 - (float)val_35;
            float val_15 = val_36 / val_39;
            int val_16 = this.CalculateVisibleDataPointCount();
            int val_17 = this.GetFrameBufferCurrentSize();
            if(val_17 >= 1)
            {
                    val_17 = val_16;
                goto label_38;
            }
            
            label_54:
            if(mem[1152921513652862566] == false)
            {
                goto label_48;
            }
            
            val_49 = 0;
            if(this.FloatingScale != true)
            {
                    SRDebugger.UI.Controls.ProfilerGraphAxisLabel val_18 = this.GetAxisLabel(index:  0);
                val_36 = val_39 * val_15;
                this.DrawAxis(frameTime:  val_36, yPosition:  val_5.m_YMin, label:  val_39);
                val_49 = this.FloatingScale >> 5;
            }
            
            if(val_43 < 0)
            {
                goto label_48;
            }
            
            var val_19 = 16 + (val_43 << 2);
            val_38 = 1152921505025110016;
            label_49:
            val_50 = null;
            val_50 = null;
            int val_20 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount + val_19;
            val_37 = SRDebugger.UI.Controls.ProfilerGraphControl.LineCount;
            int val_21 = val_37 + val_19;
            SRDebugger.UI.Controls.ProfilerGraphAxisLabel val_22 = this.GetAxisLabel(index:  val_49);
            this.DrawAxis(frameTime:  val_15 * LineCount, yPosition:  val_5.m_YMin, label:  13152256);
            if(val_43 < 1)
            {
                goto label_48;
            }
            
            val_19 = val_19 - 4;
            val_43 = val_43 - 1;
            if(val_49 == false)
            {
                goto label_49;
            }
            
            label_48:
            if(m != 0)
            {
                    m.Clear();
                m.SetVertices(inVertices:  this._meshVertices);
                m.SetColors(inColors:  this._meshVertexColors);
                val_51 = this._meshTriangles;
            }
            else
            {
                    0.Clear();
                0.SetVertices(inVertices:  this._meshVertices);
                0.SetColors(inColors:  this._meshVertexColors);
                val_51 = this._meshTriangles;
            }
            
            m.SetTriangles(triangles:  val_51, submesh:  0);
            return;
            label_38:
            int val_24 = val_17 - 1;
            var val_37 = 0;
            label_53:
            SRDebugger.Services.ProfilerFrame val_26 = GetFrame(i:  456080912);
            float val_33 = 456068856 + (-4f);
            val_33 = val_33 - (456068856 * 0.5f);
            this.DrawDataPoint(xPosition:  val_33, verticalScale:  val_5.m_YMin, frame:  new SRDebugger.Services.ProfilerFrame() {FrameTime = val_33, OtherTime = 1.28823234147866E-231, RenderTime = val_30, UpdateTime = val_28});
            val_37 = val_37 + 1;
            if(val_17 <= val_37)
            {
                goto label_54;
            }
            
            val_24 = val_24 - 1;
            if(val_37 < val_16)
            {
                goto label_53;
            }
            
            goto label_54;
            label_36:
        }
        protected void DrawDataPoint(float xPosition, float verticalScale, SRDebugger.Services.ProfilerFrame frame)
        {
            SRDebugger.UI.Controls.ProfilerGraphControl val_28;
            float val_29;
            float val_30;
            var val_31;
            var val_32;
            float val_33;
            var val_36;
            val_28 = this;
            float val_1 = this._clipBounds.width;
            float val_25 = 4f;
            val_25 = frame.FrameTime + val_25;
            UnityEngine.Rect val_2 = this._clipBounds * 0.5f;
            val_25 = val_25 + (-2f);
            float val_3 = UnityEngine.Mathf.Min(a:  val_25, b:  verticalScale);
            var val_32 = 0;
            uint val_31 = 0;
            goto label_19;
            label_14:
            val_32 = (S27 - S23) + 2f;
            goto label_4;
            label_19:
            if(0 == 2)
            {
                goto label_5;
            }
            
            val_33 = this._clipBounds;
            if(0 == 1)
            {
                goto label_7;
            }
            
            if(0 == 0)
            {
                    val_33 = S26;
            }
            
            goto label_7;
            label_5:
            val_33 = frame.FrameTime;
            label_7:
            double val_6 = val_33 * R2;
            bool val_7 = SRF.SRFFloatExtensions.ApproxZero(f:  val_33);
            if(val_7 == true)
            {
                goto label_9;
            }
            
            val_33 = val_6 + (-4f);
            if(val_7 < 0)
            {
                goto label_9;
            }
            
            UnityEngine.RectTransform val_8 = val_28.rectTransform;
            UnityEngine.Rect val_9 = rect;
            float val_10 = height;
            if(this.VerticalAlignment == 0)
            {
                goto label_11;
            }
            
            float val_11 = val_31 + 2f;
            goto label_12;
            label_11:
            UnityEngine.RectTransform val_12 = val_28.rectTransform;
            UnityEngine.Rect val_13 = rect;
            float val_14 = height;
            val_36 = 0 + (-2f);
            if(this.VerticalAlignment == 0)
            {
                goto label_14;
            }
            
            label_12:
            val_32 = (val_6 + val_36) + (-2f);
            label_4:
            UnityEngine.Color val_27 = this.LineColours[val_32];
            UnityEngine.Color val_28 = this.LineColours[val_32];
            UnityEngine.Color val_29 = this.LineColours[val_32];
            float val_16 = this._clipBounds.width;
            UnityEngine.Vector3 val_19 = new UnityEngine.Vector3(x:  UnityEngine.Mathf.Max(a:  this._clipBounds * (-0.5f), b:  val_13.m_YMin), y:  val_13.m_YMin);
            float val_20 = this._clipBounds.width;
            UnityEngine.Rect val_30 = this._clipBounds;
            val_30 = val_30 * (-0.5f);
            float val_21 = UnityEngine.Mathf.Max(a:  val_30, b:  val_13.m_YMin);
            UnityEngine.Vector3 val_22 = new UnityEngine.Vector3(x:  val_21, y:  val_13.m_YMin);
            UnityEngine.Vector3 val_23 = new UnityEngine.Vector3(x:  val_21, y:  val_13.m_YMin);
            UnityEngine.Vector3 val_24 = new UnityEngine.Vector3(x:  val_21, y:  val_13.m_YMin);
            val_29 = val_22.y;
            val_31 = ;
            val_30 = val_24.y;
            val_28 = val_28;
            this.AddRect(tl:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, tr:  new UnityEngine.Vector3() {x = val_22.x, y = val_29, z = val_22.z}, bl:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, br:  new UnityEngine.Vector3() {x = val_24.x, y = val_30, z = val_24.z}, c:  new UnityEngine.Color() {r = this.LineColours[val_32], g = val_19.z, b = val_19.y, a = val_19.x});
            val_31 = val_31 + val_6;
            label_9:
            val_32 = val_32 + 1;
            if(val_32 != 3)
            {
                goto label_19;
            }
        
        }
        protected void DrawAxis(float frameTime, float yPosition, SRDebugger.UI.Controls.ProfilerGraphAxisLabel label)
        {
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.Rect val_2 = rect;
            float val_3 = width;
            uint val_18 = 456403384;
            float val_19 = 0.5f;
            UnityEngine.RectTransform val_4 = this.rectTransform;
            float val_5 = val_18 * val_19;
            val_18 = val_18 * (-0.5f);
            UnityEngine.Rect val_6 = rect;
            float val_7 = height;
            val_19 = R2 + val_19;
            UnityEngine.RectTransform val_8 = this.rectTransform;
            UnityEngine.Rect val_9 = rect;
            UnityEngine.Color val_11 = new UnityEngine.Color(r:  height, g:  val_9.m_YMin, b:  val_9.m_Width, a:  val_9.m_Height);
            float val_12 = R2 + (-0.5f);
            UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_12, y:  val_9.m_YMin);
            UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_12, y:  val_9.m_YMin);
            UnityEngine.Vector3 val_15 = new UnityEngine.Vector3(x:  val_12, y:  val_9.m_YMin);
            UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  val_12, y:  val_9.m_YMin);
            this.AddRect(tl:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, tr:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, bl:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, br:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, c:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a});
            if((???) == 0)
            {
                    return;
            }
            
            ???.SetValue(frameTime:  val_12, yPosition:  val_9.m_YMin);
        }
        protected void AddRect(UnityEngine.Vector3 tl, UnityEngine.Vector3 tr, UnityEngine.Vector3 bl, UnityEngine.Vector3 br, UnityEngine.Color c)
        {
            this._meshVertices.Add(item:  new UnityEngine.Vector3() {x = tl.x, y = tl.y, z = tl.z});
            this._meshVertices.Add(item:  new UnityEngine.Vector3() {x = tr.x, y = tr.y, z = tr.z});
            this._meshVertices.Add(item:  new UnityEngine.Vector3() {x = bl.x, y = bl.y, z = bl.z});
            this._meshVertices.Add(item:  new UnityEngine.Vector3() {x = br.x, y = br.y, z = br.z});
            this._meshTriangles.Add(item:  1152921513653313744);
            this._meshTriangles.Add(item:  this._meshVertices - 3);
            this._meshTriangles.Add(item:  this._meshVertices - 1);
            this._meshTriangles.Add(item:  this._meshVertices - 2);
            this._meshTriangles.Add(item:  this._meshVertices - 1);
            this._meshTriangles.Add(item:  this._meshVertices - 3);
            UnityEngine.Color32 val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = c.a});
            this._meshVertexColors.Add(item:  new UnityEngine.Color32() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
            UnityEngine.Color32 val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = c.a});
            this._meshVertexColors.Add(item:  new UnityEngine.Color32() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
            UnityEngine.Color32 val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = c.a});
            this._meshVertexColors.Add(item:  new UnityEngine.Color32() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
            UnityEngine.Color32 val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = c.a});
            this._meshVertexColors.Add(item:  new UnityEngine.Color32() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
        }
        protected SRDebugger.Services.ProfilerFrame GetFrame(int i)
        {
            var val_3;
            var val_4;
            var val_4 = i + 104;
            if((i + 104 + 178) == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            val_3 = 0;
            if((i + 104 + 88 + 0) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            if(val_3 < (i + 104 + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_4 = i + 104;
            goto label_5;
            label_3:
            var val_1 = (i + 104 + 88) + 0;
            val_4 = val_4 + (((i + 104 + 88 + 0) + 4) << 3);
            val_4 = val_4 + 204;
            label_5:
            SRDebugger.Services.ProfilerFrame val_2 = this.Item[i + 104];
            return new SRDebugger.Services.ProfilerFrame() {FrameTime = val_2.FrameTime, OtherTime = val_2.OtherTime, RenderTime = val_2.RenderTime, UpdateTime = val_2.UpdateTime};
        }
        protected int CalculateVisibleDataPointCount()
        {
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.Rect val_2 = rect;
            float val_3 = width;
            float val_5 = 0.25f;
            val_5 = 456910472 * val_5;
            return (int)UnityEngine.Mathf.RoundToInt(f:  val_5);
        }
        protected int GetFrameBufferCurrentSize()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this._profilerService;
            if(this._profilerService != 0)
            {
                    return (int)this._profilerService;
            }
            
            return (int)this._profilerService;
        }
        protected int GetFrameBufferMaxSize()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this._profilerService;
            if(this._profilerService != 0)
            {
                    return this._profilerService.Capacity;
            }
            
            return this._profilerService.Capacity;
        }
        protected float CalculateMaxFrameTime()
        {
            int val_6;
            float val_7;
            int val_6 = this.GetFrameBufferCurrentSize();
            val_6 = this.CalculateVisibleDataPointCount();
            int val_3 = UnityEngine.Mathf.Min(a:  val_6, b:  val_6);
            if(val_3 >= 1)
            {
                    val_6 = val_6 - 1;
                do
            {
                SRDebugger.Services.ProfilerFrame val_4 = GetFrame(i:  457275920);
                val_6 = val_6 - 1;
                val_6 = val_3 - 1;
            }
            while(val_3 != 1);
            
                return val_7;
            }
            
            val_7 = 0f;
            return val_7;
        }
        private SRDebugger.UI.Controls.ProfilerGraphAxisLabel GetAxisLabel(int index)
        {
            SRDebugger.UI.Controls.ProfilerGraphAxisLabel[] val_3;
            SRDebugger.UI.Controls.ProfilerGraphAxisLabel val_4;
            if((this._axisLabels != null) && (UnityEngine.Application.isPlaying != false))
            {
                    val_3 = this._axisLabels;
            }
            else
            {
                    T[] val_2 = this.GetComponentsInChildren<System.Object>();
                val_3 = this;
                this._axisLabels = this;
            }
            
            if(this > index)
            {
                    val_4 = this._axisLabels[index];
                return;
            }
            
            val_4 = 0;
            UnityEngine.Debug.LogWarning(message:  457479632);
        }
        public ProfilerGraphControl()
        {
            this.DrawAxes = true;
            this.VerticalAlignment = true;
            this.TargetFps = 60;
            this.Clip = true;
            this.VerticalPadding = 10;
            this.LineColours = null;
            System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this._meshVertices = null;
            System.Collections.Generic.List<UnityEngine.Color32> val_2 = new System.Collections.Generic.List<UnityEngine.Color32>();
            this._meshVertexColors = null;
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            this._meshTriangles = null;
        }
        private static ProfilerGraphControl()
        {
            SRDebugger.UI.Controls.ProfilerGraphControl.LineCount = null;
        }
    
    }

}
