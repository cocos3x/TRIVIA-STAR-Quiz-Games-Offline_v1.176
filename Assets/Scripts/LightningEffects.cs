using UnityEngine;
public class LightningEffects : MonoBehaviour
{
    // Fields
    private int numOfSegments;
    private UnityEngine.Color color;
    private float posRange;
    private UnityEngine.LineRenderer lineRenderer;
    private UnityEngine.Vector3 start;
    private UnityEngine.Vector3 end;
    private float length;
    private bool isVertical;
    private float chaoticTen;
    private FrameSkipper frameSkipper;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Transform val_1 = this.transform;
        twelvegigs.Autopilot.WUTAutopilotGameplay val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  -1187470368);
        this.frameSkipper = this;
        System.Action val_3 = new System.Action(object:  -1187470368, method:  new IntPtr(3107467808));
        mem[1152921512009311224] = null;
        this.frameSkipper._framesToSkip = 5;
        float val_4 = UnityEngine.Random.Range(min:  null, max:  null);
        float val_5 = 10f;
        val_5 = 1065353216 * val_5;
        this.chaoticTen = val_5;
    }
    private void UpdateLightningEffects()
    {
        float val_8;
        float val_9;
        if((this.numOfSegments - 1) > 1)
        {
                float val_9 = 1.401298E-45f;
            do
        {
            float val_2 = this.posRange ^ 2147483648;
            float val_3 = UnityEngine.Random.Range(min:  null, max:  null);
            float val_8 = 1f;
            val_8 = this.length * val_8;
            val_8 = val_8 / (float)this.numOfSegments;
            if(this.isVertical != false)
        {
            
        }
        
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  val_8, y:  null, z:  (float)this.numOfSegments);
            val_8 = val_4.x;
            val_9 = val_4.y;
            val_9 = val_9;
            val_8 = val_8;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -0.0001777794f, y = this.start, z = this.numOfSegments}, b:  new UnityEngine.Vector3() {x = SL, y = val_8, z = val_9});
            this.lineRenderer.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_9 = val_9 + 1;
        }
        while(val_9 < (this.numOfSegments - 1));
        
        }
        
        this.lineRenderer.startColor = new UnityEngine.Color() {r = this.color, g = val_9, b = 0f, a = this.numOfSegments};
        this.lineRenderer.endColor = new UnityEngine.Color() {r = this.color, g = val_9, b = 0f, a = this.numOfSegments};
        float val_7 = UnityEngine.Time.deltaTime;
        if(this.lineRenderer <= 0)
        {
                this.length = 1f;
        }
        
        mem[1152921512009439612] = this.length;
    }
    public void Setup(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
    {
        var val_5;
        object val_1 = this.GetComponent<System.Object>();
        this.lineRenderer = this;
        this.positionCount = this.numOfSegments;
        this.start = start;
        mem[1152921512009580300] = start.y;
        mem[1152921512009580304] = start.z;
        this.end = end;
        mem[1152921512009580312] = end.y;
        mem[1152921512009580316] = end.z;
        val_5 = null;
        val_5 = null;
        float val_5 = System.Math.Abs(start.x - end.x);
        if(UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished < 0)
        {
                0 = 1;
        }
        
        this.isVertical = true;
        this.lineRenderer.startWidth = val_5;
        this.lineRenderer.endWidth = val_5;
        float val_3 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z}, b:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z});
        this.length = start.x;
        this.lineRenderer.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = start.z});
        this.lineRenderer.SetPosition(index:  this.numOfSegments - 1, position:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z});
    }
    public LightningEffects()
    {
        this.posRange = 0.2f;
        this.numOfSegments = 10;
        this.chaoticTen = 1f;
    }

}
