using UnityEngine;

namespace SRF.UI
{
    public class DragHandle : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
    {
        // Fields
        private UnityEngine.UI.CanvasScaler _canvasScaler;
        private float _delta;
        private float _startValue;
        public UnityEngine.RectTransform.Axis Axis;
        public bool Invert;
        public float MaxSize;
        public UnityEngine.UI.LayoutElement TargetLayoutElement;
        public UnityEngine.RectTransform TargetRectTransform;
        
        // Properties
        private float Mult { get; }
        
        // Methods
        private float get_Mult()
        {
            if(this.Invert == false)
            {
                    -1f = 1f;
            }
            
            return -1f;
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.Verify() == false)
            {
                    return;
            }
            
            float val_2 = R4.GetCurrentValue();
            mem2[0] = 0;
            mem2[0] = R4;
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_6;
            if(this.Verify() == false)
            {
                    return;
            }
            
            if(this.Axis == 0)
            {
                    188 = 184;
            }
            
            val_6 = (eventData.<delta>k__BackingField.x) + 0f;
            if(this._canvasScaler != 0)
            {
                    val_6 = val_6 / this._canvasScaler.m_ScaleFactor;
            }
            
            if(this.Invert == false)
            {
                    -1f = 1f;
            }
            
            this._delta = this._delta;
            float val_3 = this.GetMinSize();
            if(this.Invert > false)
            {
                    3.402823E+38f = this.MaxSize;
            }
            
            this.SetCurrentValue(value:  UnityEngine.Mathf.Clamp(value:  this._startValue + this._delta, min:  null, max:  1f));
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.Verify() == false)
            {
                    return;
            }
            
            float val_2 = this.GetMinSize();
            this.SetCurrentValue(value:  UnityEngine.Mathf.Max(a:  this._startValue + this._delta, b:  null));
            this._delta = 0f;
            this.CommitCurrentValue();
        }
        private void Start()
        {
            bool val_1 = this.Verify();
            object val_2 = this.GetComponentInParent<System.Object>();
            this._canvasScaler = this;
        }
        private bool Verify()
        {
            UnityEngine.RectTransform val_3;
            var val_4;
            val_3 = 1152921504765685760;
            val_4 = 1;
            if(this.TargetLayoutElement != 0)
            {
                    return (bool)val_4;
            }
            
            val_3 = this.TargetRectTransform;
            if(val_3 != 0)
            {
                    return (bool)val_4;
            }
            
            val_4 = 0;
            UnityEngine.Debug.LogWarning(message:  380771744);
            this.enabled = false;
            return (bool)val_4;
        }
        private float GetCurrentValue()
        {
            var val_4;
            var val_6;
            var val_11;
            var val_13;
            val_11 = 1152921504765685760;
            if(this.TargetLayoutElement == 0)
            {
                goto label_3;
            }
            
            if(this.Axis == 0)
            {
                goto typeof(UnityEngine.UI.LayoutElement).__il2cppRuntimeField_1D4;
            }
            
            goto typeof(UnityEngine.UI.LayoutElement).__il2cppRuntimeField_1D4;
            label_3:
            if(this.TargetRectTransform != 0)
            {
                    if(this.Axis != 0)
            {
                    UnityEngine.Vector2 val_3 = sizeDelta;
                val_13 = val_4;
            }
            else
            {
                    UnityEngine.Vector2 val_5 = this.TargetLayoutElement.sizeDelta;
                val_13 = val_6;
            }
            
                var val_7 = FP - 16;
                return (float)val_13;
            }
            
            System.InvalidOperationException val_8 = new System.InvalidOperationException();
        }
        private void SetCurrentValue(float value)
        {
            float val_4;
            float val_5;
            var val_7 = 1152921504765685760;
            if(this.TargetLayoutElement == 0)
            {
                goto label_3;
            }
            
            if(this.Axis == 0)
            {
                goto typeof(UnityEngine.UI.LayoutElement).__il2cppRuntimeField_1DC;
            }
            
            goto typeof(UnityEngine.UI.LayoutElement).__il2cppRuntimeField_1DC;
            label_3:
            if(this.TargetRectTransform != 0)
            {
                    UnityEngine.Vector2 val_3 = sizeDelta;
                if(this.Axis == 0)
            {
                    val_4 = R1;
            }
            
                if(this.Axis != 0)
            {
                    val_5 = R1;
            }
            
                this.TargetRectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_4, y = val_5};
                return;
            }
            
            System.InvalidOperationException val_6 = new System.InvalidOperationException();
        }
        private void CommitCurrentValue()
        {
            var val_7;
            var val_8;
            var val_9;
            if(this.TargetLayoutElement == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.TargetLayoutElement.transform;
            val_7 = this.TargetLayoutElement;
            if(this.TargetLayoutElement != 0)
            {
                    if(null == null)
            {
                goto label_6;
            }
            
            }
            
            label_6:
            if(this.Axis == 0)
            {
                goto label_7;
            }
            
            if(val_7 != 0)
            {
                    if(null == null)
            {
                goto label_9;
            }
            
            }
            
            val_8 = 0;
            label_9:
            UnityEngine.Vector2 val_3 = sizeDelta;
            if(this.TargetLayoutElement != 0)
            {
                    return;
            }
            
            return;
            label_7:
            if(val_7 != 0)
            {
                    if(null == null)
            {
                goto label_13;
            }
            
            }
            
            val_9 = 0;
            label_13:
            UnityEngine.Vector2 val_5 = sizeDelta;
        }
        private float GetMinSize()
        {
            if(this.TargetLayoutElement == 0)
            {
                    return (float)S0;
            }
            
            if(this.Axis != 0)
            {
                
            }
        
        }
        private float GetMaxSize()
        {
            if()
            {
                    3.402823E+38f = this.MaxSize;
            }
            
            return (float)3.402823E+38f;
        }
        public DragHandle()
        {
            this.MaxSize = -1f;
        }
    
    }

}
