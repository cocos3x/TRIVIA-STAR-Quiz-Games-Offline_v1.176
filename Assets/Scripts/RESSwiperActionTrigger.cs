using UnityEngine;
public class RESSwiperActionTrigger : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
    // Fields
    public bool swipeUp;
    public System.Action swipeAction;
    private UnityEngine.Vector2 touchDownPos;
    
    // Methods
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.touchDownPos = eventData.<position>k__BackingField;
        mem[1152921512542266024] = eventData;
    }
    public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
    {
        float val_4;
        float val_5;
        float val_9;
        float val_10;
        RESSwiperActionTrigger val_13 = this;
        if(this.swipeUp != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        }
        else
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
        }
        
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = -2.238914E+15f, y = eventData.<position>k__BackingField}, b:  new UnityEngine.Vector2() {x = 1.173057E-37f, y = this.touchDownPos});
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = -2.238913E+15f, y = val_4, z = val_5});
        float val_11 = UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_4, y = val_5}, to:  new UnityEngine.Vector2() {x = val_9, y = val_10});
        float val_13 = System.Math.Abs(val_4);
        float val_12 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = eventData.<position>k__BackingField, y = 1.173057E-37f}, b:  new UnityEngine.Vector2() {x = this.touchDownPos, y = R5});
        if(mem[1152921512542386208] == 0)
        {
                return;
        }
        
        mem[1152921512542386208].Invoke();
    }
    public RESSwiperActionTrigger()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.touchDownPos = new UnityEngine.Vector2();
        mem[1152921512542502312] = ???;
    }

}
