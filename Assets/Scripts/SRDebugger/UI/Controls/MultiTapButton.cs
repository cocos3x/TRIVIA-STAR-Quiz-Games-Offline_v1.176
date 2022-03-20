using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class MultiTapButton : Button
    {
        // Fields
        private float _lastTap;
        private int _tapCount;
        public int RequiredTapCount;
        public float ResetTime;
        
        // Methods
        public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_1 = UnityEngine.Time.unscaledTime;
            float val_3 = this._lastTap;
            val_3 = 0 - val_3;
            if()
            {
                    this._tapCount = 0;
            }
            
            float val_2 = UnityEngine.Time.unscaledTime;
            int val_4 = this._tapCount;
            val_4 = val_4 + 1;
            this._lastTap = 0f;
            this._tapCount = val_4;
            if(val_4 != this.RequiredTapCount)
            {
                    return;
            }
            
            this.OnPointerClick(eventData:  eventData);
            this._tapCount = 0;
        }
        public MultiTapButton()
        {
            this.RequiredTapCount = 3;
            this.ResetTime = 0.5f;
        }
    
    }

}
