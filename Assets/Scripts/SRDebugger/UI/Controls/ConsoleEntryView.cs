using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class ConsoleEntryView : SRMonoBehaviourEx, IVirtualView
    {
        // Fields
        public const string ConsoleBlobInfo = "Console_Info_Blob";
        public const string ConsoleBlobWarning = "Console_Warning_Blob";
        public const string ConsoleBlobError = "Console_Error_Blob";
        private int _count;
        private bool _hasCount;
        private SRDebugger.Services.ConsoleEntry _prevData;
        private UnityEngine.RectTransform _rectTransform;
        public UnityEngine.UI.Text Count;
        public UnityEngine.CanvasGroup CountContainer;
        public SRF.UI.StyleComponent ImageStyle;
        public UnityEngine.UI.Text Message;
        public UnityEngine.UI.Text StackTrace;
        
        // Methods
        public void SetDataContext(object data)
        {
            UnityEngine.CanvasGroup val_12;
            bool val_15;
            var val_16;
            var val_18;
            float val_19;
            var val_20;
            SRF.UI.StyleComponent val_21;
            var val_22;
            val_12 = 35632407;
            if(data == 0)
            {
                goto label_3;
            }
            
            if(null >= 2)
            {
                goto label_4;
            }
            
            if(this._hasCount == false)
            {
                goto label_10;
            }
            
            val_12 = this.CountContainer;
            val_15 = false;
            val_12.alpha = null;
            this._hasCount = val_15;
            goto label_10;
            label_4:
            if(this._hasCount != true)
            {
                    val_12 = this.CountContainer;
                val_12.alpha = null;
                this._hasCount = true;
            }
            
            if(true != this._count)
            {
                    val_12 = this.Count;
                string val_1 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  1, max:  999, exceedsMaxString:  425984512);
                val_15 = true;
                this._count = val_12;
            }
            
            label_10:
            if(this._prevData == data)
            {
                    return;
            }
            
            this._prevData = data;
            string val_2 = data.MessagePreview;
            string val_3 = data.StackTracePreview;
            UnityEngine.RectTransform val_5 = this.Message.rectTransform;
            val_15 = this._rectTransform;
            if((System.String.IsNullOrEmpty(value:  this.StackTrace)) != false)
            {
                    val_16 = 0;
                UnityEngine.Rect val_6 = rect;
                float val_7 = height;
                val_18 = 443593992;
                val_19 = -4f;
                val_20 = 3;
            }
            else
            {
                    val_16 = 0;
                UnityEngine.Rect val_8 = rect;
                float val_9 = height;
                val_18 = 443593992;
                val_19 = -14f;
                val_20 = 3;
            }
            
            val_19 = val_18 + val_19;
            this.Message.SetInsetAndSizeFromParentEdge(edge:  3, inset:  val_19, size:  val_8.m_YMin);
            if(this.Message > 4)
            {
                    return;
            }
            
            var val_10 = 9500936 + (9500936 + (this.Message) << 2);
            if(this.Message == 4)
            {
                    9500936 + (this.Message) << 2 = (9500936 + (this.Message) << 2) & (this << (9500936 + (this.Message) << 2));
                9500936 + (this.Message) << 2 = (9500936 + (this.Message) << 2) & (this << (9500936 + (this.Message) << 2));
                9500936 + (this.Message) << 2 = (9500936 + (this.Message) << 2) & (((int)IP) >> 32);
                9500936 + (this.Message) << 2 = (9500936 + (this.Message) << 2) & ((9500936 + (this.Message) << 2) >> (9500936 + (this.Message) << 2));
                9500936 + (this.Message) << 2 = (9500936 + (this.Message) << 2) & (this << (9500936 + (this.Message) << 2));
            }
            
            val_21 = this.ImageStyle;
            val_22 = "Console_Error_Blob";
            StyleKey = 443580784;
            return;
            label_3:
            System.Exception val_11 = new System.Exception(message:  443580896);
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Transform val_1 = this.CachedTransform;
            if(this != 0)
            {
                    if(null != null)
            {
                    this = 0;
            }
            
                0 = this;
            }
            
            this._rectTransform = 0;
            this.CountContainer.alpha = null;
            SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
            if(this.CountContainer != 0)
            {
                    this.CountContainer = 1;
            }
            
            this.Message.supportRichText = true;
        }
        public ConsoleEntryView()
        {
        
        }
    
    }

}
