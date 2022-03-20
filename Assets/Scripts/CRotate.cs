using UnityEngine;
public class CRotate : MonoBehaviour
{
    // Fields
    public float speed;
    public bool counterClockwise;
    
    // Methods
    private void Update()
    {
        float val_4;
        if(static_value_021F9ECE < false)
        {
                this.speed = -this.speed;
        }
        
        this.speed = this.speed;
        UnityEngine.Transform val_1 = this.transform;
        if(this.counterClockwise == false)
        {
                1f = -1f;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_2.x, a:  new UnityEngine.Vector3() {x = -3.970042E-38f, y = -1f, z = val_4});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -3.970039E-38f}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -3.970035E-38f}, d:  this.speed);
        this.Rotate(eulers:  new UnityEngine.Vector3());
    }
    public CRotate()
    {
    
    }

}
