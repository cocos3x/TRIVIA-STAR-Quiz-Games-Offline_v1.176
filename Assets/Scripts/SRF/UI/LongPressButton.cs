using UnityEngine;

namespace SRF.UI
{
    public class LongPressButton : Button
    {
        // Fields
        private bool _handled;
        private UnityEngine.UI.Button.ButtonClickedEvent _onLongPress;
        private bool _pressed;
        private float _pressedTime;
        public float LongPressDuration;
        
        // Properties
        public UnityEngine.UI.Button.ButtonClickedEvent onLongPress { get; set; }
        
        // Methods
        public UnityEngine.UI.Button.ButtonClickedEvent get_onLongPress()
        {
        
        }
        public void set_onLongPress(UnityEngine.UI.Button.ButtonClickedEvent value)
        {
            this._onLongPress = value;
        }
        public override void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerExit(eventData:  eventData);
            this._pressed = false;
        }
        public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerDown(eventData:  eventData);
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            mem2[0] = 0;
            mem2[0] = 1;
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            mem2[0] = 0;
        }
        public override void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this._handled != true)
            {
                    this.OnPointerUp(eventData:  eventData);
            }
            
            this._pressed = false;
        }
        public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this._handled == true)
            {
                    return;
            }
            
            this.OnPointerClick(eventData:  eventData);
        }
        private void Update()
        {
            if(this._pressed == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            float val_2 = this._pressedTime;
            val_2 = 0 - val_2;
            if(this._pressed < false)
            {
                    return;
            }
            
            this._handled = true;
            this._pressed = false;
            this._onLongPress.Invoke();
        }
        public LongPressButton()
        {
            this.LongPressDuration = 0.9f;
            this._onLongPress = new Button.ButtonClickedEvent();
        }
    
    }

}
