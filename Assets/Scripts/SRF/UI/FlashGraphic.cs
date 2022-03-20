using UnityEngine;

namespace SRF.UI
{
    public class FlashGraphic : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        // Fields
        public float DecayTime;
        public UnityEngine.Color DefaultColor;
        public UnityEngine.Color FlashColor;
        public UnityEngine.UI.Graphic Target;
        
        // Methods
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.Target != 0)
            {
                    return;
            }
        
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.Target != 0)
            {
                    return;
            }
        
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this.Target != 0)
            {
                    return;
            }
        
        }
        protected void Update()
        {
        
        }
        public void Flash()
        {
            if(this.Target != 0)
            {
                    return;
            }
        
        }
        public FlashGraphic()
        {
            this.DecayTime = 0.15f;
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            UnityEngine.Color val_2 = UnityEngine.Color.white;
        }
    
    }

}
