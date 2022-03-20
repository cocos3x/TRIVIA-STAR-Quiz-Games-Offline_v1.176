using UnityEngine;
public class UIDragObjectSimple : MonoBehaviour, IDragHandler, IEventSystemHandler
{
    // Fields
    private UnityEngine.RectTransform m_transform;
    
    // Methods
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        UnityEngine.Vector2 val_4;
        UnityEngine.Vector3 val_1 = position;
        if(eventData != 0)
        {
                val_4 = eventData.<delta>k__BackingField;
        }
        else
        {
                val_4 = 4.315999E-43f;
        }
        
        UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  val_1.x, y:  val_1.y);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -5.28607E+10f, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {y = val_2.x, z = val_2.y});
        this.m_transform.position = new UnityEngine.Vector3();
    }
    public UIDragObjectSimple()
    {
    
    }

}
