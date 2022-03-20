using UnityEngine;

namespace SRF.UI
{
    public class SRNumberButton : Button, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
    {
        // Fields
        private const float ExtraThreshold = 3;
        public const float Delay = 0.4;
        private float _delayTime;
        private float _downTime;
        private bool _isDown;
        public double Amount;
        public SRF.UI.SRNumberSpinner TargetField;
        
        // Methods
        public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerDown(eventData:  eventData);
            if(this == 0)
            {
                    return;
            }
            
            this.Apply();
            this._isDown = true;
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            float val_2 = 0.4f;
            this._downTime = 0f;
            val_2 = 0 + val_2;
            this._delayTime = val_2;
        }
        public override void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerUp(eventData:  eventData);
            this._isDown = false;
        }
        protected virtual void Update()
        {
            float val_6;
            if(this._isDown == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            if(this._isDown > false)
            {
                    return;
            }
            
            this.Apply();
            float val_2 = UnityEngine.Time.realtimeSinceStartup;
            float val_6 = 3f;
            val_6 = (0 - this._downTime) / val_6;
            int val_4 = UnityEngine.Mathf.RoundToInt(f:  val_6);
            val_6 = 0.2f;
            if(val_4 >= 1)
            {
                    do
            {
                val_6 = val_6 * 0.5f;
                val_4 = val_4 - 1;
            }
            while(val_4 != 1);
            
            }
            
            float val_5 = UnityEngine.Time.realtimeSinceStartup;
            uint val_7 = 0;
            val_7 = val_6 + val_7;
            this._delayTime = val_7;
        }
        private void Apply()
        {
            SRF.UI.SRNumberSpinner val_4;
            double val_1 = System.Double.Parse(s:  this.TargetField);
            SRF.UI.SRNumberSpinner val_2 = this.TargetField + this.Amount;
            string val_3 = this.TargetField.MinValue.ToString();
            this.TargetField.text = 385680352;
            val_4 = this.TargetField;
            if(this.TargetField != 0)
            {
                goto label_11;
            }
            
            val_4 = this.TargetField;
            if(val_4 == 0)
            {
                goto label_12;
            }
            
            label_11:
            this.TargetField.Invoke(arg0:  385692384);
            return;
            label_12:
        }
        public SRNumberButton()
        {
            this.Amount = 0;
            mem[1152921513582618916] = 1072693248;
        }
    
    }

}
