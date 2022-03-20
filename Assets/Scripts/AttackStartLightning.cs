using UnityEngine;
public class AttackStartLightning : MonoBehaviour
{
    // Fields
    public float duration;
    public float lineWidth;
    public float maxLength;
    public UnityEngine.LineRenderer electricity;
    public UnityEngine.Transform[] electricityPositions;
    private System.Collections.Generic.List<UnityEngine.Vector3> linePoints;
    private float displayLength;
    
    // Methods
    private void OnEnable()
    {
        this.RefreshLine();
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_2 = R4.AnimateLightning();
        UnityEngine.Coroutine val_3 = R4.StartCoroutine(routine:  R4);
    }
    private void Update()
    {
        if(UnityEngine.Application.isPlaying == true)
        {
                return;
        }
        
        R4.RefreshLine();
    }
    private System.Collections.IEnumerator AnimateLightning()
    {
        object val_1 = new System.Object();
        typeof(AttackStartLightning.<AnimateLightning>d__9).__il2cppRuntimeField_8 = 0;
        typeof(AttackStartLightning.<AnimateLightning>d__9).__il2cppRuntimeField_10 = this;
    }
    private void RefreshLine()
    {
        var val_4;
        var val_5;
        UnityEngine.Transform[] val_6;
        System.Collections.Generic.List<UnityEngine.Vector3> val_7;
        float val_8;
        var val_9;
        System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.linePoints = null;
        val_4 = 0;
        goto label_1;
        label_7:
        UnityEngine.Transform val_4 = this.electricityPositions[val_4];
        UnityEngine.Vector3 val_2 = position;
        R6.Add(item:  new UnityEngine.Vector3());
        val_4 = 1;
        label_1:
        val_6 = this.electricityPositions;
        val_7 = this.linePoints;
        if(val_4 < R6)
        {
            goto label_7;
        }
        
        if(R6 == 0)
        {
            goto label_9;
        }
        
        float val_3 = UnityEngine.Mathf.Clamp(value:  val_2.x, min:  val_2.y, max:  val_2.z);
        this.displayLength = this.displayLength;
        if(this.linePoints == 0)
        {
            goto label_12;
        }
        
        val_8 = this.displayLength;
        goto label_13;
        label_9:
        this.electricity.positionCount = 0;
        return;
        label_12:
        val_8 = this.displayLength;
        label_13:
        val_8 = val_8 * (float)val_2.z;
        val_6 = 0;
        this.electricity.positionCount = val_8;
        val_9 = null;
        if(val_8 >= (1.401298E-45f))
        {
                do
        {
            if(this.linePoints == 0)
        {
                val_9 = null;
        }
        
            if(this.electricity <= 0)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = null;
        }
        
            val_5 = val_5 + val_6;
            val_5 = mem[(0 + val_6) + 24];
            val_5 = (0 + val_6) + 24;
            if(val_9 == 0)
        {
                val_9 = null;
        }
        
            val_9 = null;
            val_7 = 0 + 1;
            val_6 = val_6 + 12;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_10 = (0 + val_6) + 16;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_14 = (0 + val_6) + 20;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_18 = val_5;
        }
        while(val_8 != val_7);
        
        }
        
        if(this.electricity == 0)
        {
                val_9 = null;
        }
        
        this.electricity.SetPositions(positions:  533912224);
    }
    private System.Collections.IEnumerator FadeSize(float from, float to, float duration)
    {
        if((new AttackStartLightning.<FadeSize>d__11(<>1__state:  0)) != 0)
        {
                typeof(AttackStartLightning.<FadeSize>d__11).__il2cppRuntimeField_1C = this;
            typeof(AttackStartLightning.<FadeSize>d__11).__il2cppRuntimeField_14 = R1;
            typeof(AttackStartLightning.<FadeSize>d__11).__il2cppRuntimeField_18 = R2;
        }
        else
        {
                mem[28] = this;
            mem[20] = R1;
            mem[24] = R2;
        }
        
        typeof(AttackStartLightning.<FadeSize>d__11).__il2cppRuntimeField_10 = R3;
    }
    public AttackStartLightning()
    {
        this.duration = 0.8f;
        this.lineWidth = 0.2f;
        this.maxLength = 1f;
        this.displayLength = 1f;
    }

}
