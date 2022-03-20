using UnityEngine;

namespace SRF.UI
{
    public class SRSpinner : Selectable, IDragHandler, IEventSystemHandler, IBeginDragHandler
    {
        // Fields
        private float _dragDelta;
        private SRF.UI.SRSpinner.SpinEvent _onSpinDecrement;
        private SRF.UI.SRSpinner.SpinEvent _onSpinIncrement;
        public float DragThreshold;
        
        // Properties
        public SRF.UI.SRSpinner.SpinEvent OnSpinIncrement { get; set; }
        public SRF.UI.SRSpinner.SpinEvent OnSpinDecrement { get; set; }
        
        // Methods
        public SRF.UI.SRSpinner.SpinEvent get_OnSpinIncrement()
        {
        
        }
        public void set_OnSpinIncrement(SRF.UI.SRSpinner.SpinEvent value)
        {
            this._onSpinIncrement = value;
        }
        public SRF.UI.SRSpinner.SpinEvent get_OnSpinDecrement()
        {
        
        }
        public void set_OnSpinDecrement(SRF.UI.SRSpinner.SpinEvent value)
        {
            this._onSpinDecrement = value;
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._dragDelta = 0f;
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(true == 0)
            {
                    return;
            }
            
            float val_3 = this._dragDelta;
            val_3 = val_3 + (eventData.<delta>k__BackingField);
            this._dragDelta = val_3;
            float val_1 = UnityEngine.Mathf.Sign(f:  System.Math.Abs(val_3));
            float val_5 = System.Math.Abs(this._dragDelta);
            val_5 = val_5 / this.DragThreshold;
            int val_2 = UnityEngine.Mathf.FloorToInt(f:  val_5);
            this.OnIncrement(amount:  val_2);
            float val_6 = (float)val_2;
            val_6 = this.DragThreshold * val_6;
            this._dragDelta = this._dragDelta;
        }
        private void OnIncrement(int amount)
        {
            if(amount < 1)
            {
                    return;
            }
            
            int val_1 = amount;
            do
            {
                this._onSpinIncrement.Invoke();
                val_1 = val_1 - 1;
            }
            while(this._onSpinIncrement != 0);
        
        }
        private void OnDecrement(int amount)
        {
            if(amount < 1)
            {
                    return;
            }
            
            int val_1 = amount;
            do
            {
                this._onSpinDecrement.Invoke();
                val_1 = val_1 - 1;
            }
            while(this._onSpinDecrement != 0);
        
        }
        public SRSpinner()
        {
            this._onSpinDecrement = new UnityEngine.Events.UnityEvent();
            this._onSpinIncrement = new UnityEngine.Events.UnityEvent();
            this.DragThreshold = 20f;
        }
    
    }

}
