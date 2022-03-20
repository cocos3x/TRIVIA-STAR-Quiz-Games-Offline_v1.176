using UnityEngine;
public class IgnoreTimeScale : MonoBehaviour
{
    // Fields
    private float mRt;
    private float mTimeStart;
    private float mTimeDelta;
    private float mActual;
    private bool mTimeStarted;
    
    // Properties
    public float realTime { get; }
    public float realTimeDelta { get; }
    
    // Methods
    public float get_realTime()
    {
        return (float)S0;
    }
    public float get_realTimeDelta()
    {
        return (float)S0;
    }
    protected virtual void OnEnable()
    {
        this.mTimeDelta = 0f;
        this.mTimeStarted = true;
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        this.mTimeStart = 0f;
    }
    protected float UpdateRealTimeDelta()
    {
        var val_4;
        var val_7;
        float val_8;
        float val_9;
        var val_10;
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        this.mRt = 0f;
        if(this.mTimeStarted != false)
        {
                float val_8 = this.mActual;
            float val_2 = 0 - this.mTimeStart;
            float val_3 = UnityEngine.Mathf.Max(a:  this.mTimeStart, b:  null);
            uint val_7 = 0;
            val_7 = val_8 + val_7;
            val_8 = val_7 * 1000f;
            this.mActual = val_7;
            val_7 = val_4;
            val_8 = -1f;
        }
        else
        {
                val_9 = 0f;
            this.mTimeStart = 0;
            this.mTimeStarted = true;
            this.mTimeDelta = 0f;
            return val_9;
        }
        
        float val_5 = val_2 + ;
        if((val_2 & (1.401298E-45f)) != 0)
        {
                val_10 = val_2;
        }
        
        float val_11 = 0.001f;
        val_11 =  * val_11;
        this.mTimeDelta = val_11;
        this.mActual = this.mActual - val_11;
        if(UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished > 0)
        {
                 = 1f;
            val_9 = 1f;
            this.mTimeDelta = ;
        }
        
        this.mTimeStart = this.mRt;
        return val_9;
    }
    public IgnoreTimeScale()
    {
    
    }

}
