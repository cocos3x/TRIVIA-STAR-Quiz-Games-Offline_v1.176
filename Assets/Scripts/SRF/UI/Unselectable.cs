using UnityEngine;

namespace SRF.UI
{
    public sealed class Unselectable : SRMonoBehaviour, ISelectHandler, IEventSystemHandler
    {
        // Fields
        private bool _suspectedSelected;
        
        // Methods
        public void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
        {
            this._suspectedSelected = true;
        }
        private void Update()
        {
            if(this._suspectedSelected == false)
            {
                    return;
            }
            
            UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
            UnityEngine.GameObject val_2 = this.CachedGameObject;
            if(35615780 == 392732976)
            {
                    UnityEngine.EventSystems.EventSystem val_4 = UnityEngine.EventSystems.EventSystem.current;
                0.SetSelectedGameObject(selected:  0);
            }
            
            this._suspectedSelected = false;
        }
        public Unselectable()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
