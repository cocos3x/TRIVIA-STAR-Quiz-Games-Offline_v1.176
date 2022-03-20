using UnityEngine;
public class InputEventsHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // Fields
    public System.Action<float> HandleDragAction;
    
    // Methods
    public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
    
    }
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        if(this.HandleDragAction == 0)
        {
                return;
        }
        
        float val_2 = (float)UnityEngine.Screen.width;
        val_2 = (eventData.<delta>k__BackingField) / val_2;
        this.HandleDragAction.Invoke(obj:  val_2);
    }
    public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
    
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
    
    }
    public InputEventsHandler()
    {
    
    }

}
