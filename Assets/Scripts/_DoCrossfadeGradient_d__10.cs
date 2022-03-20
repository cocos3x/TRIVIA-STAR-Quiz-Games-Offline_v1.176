using UnityEngine;
private sealed class GradientButton.<DoCrossfadeGradient>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GradientButton <>4__this;
    public UIGradient gradient;
    public GradientInfo newGradientInfo;
    private float <startTime>5__2;
    private float <endTime>5__3;
    private UnityEngine.Color <m_color1_start>5__4;
    private UnityEngine.Color <m_color2_start>5__5;
    private float <m_angle_start>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GradientButton.<DoCrossfadeGradient>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GradientButton val_9;
        int val_10;
        UIGradient val_11;
        UIGradient val_12;
        float val_13;
        val_9 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_10 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
            this.<>1__state = 0;
            float val_1 = UnityEngine.Time.time;
            this.<startTime>5__2 = 0f;
            float val_9 = this.<>4__this.duration;
            val_9 = 0 + val_9;
            val_11 = this.gradient;
            this.<endTime>5__3 = val_9;
            if(this.gradient == 0)
        {
                val_11 = this.gradient;
        }
        
            val_12 = val_11;
            if(val_11 == 0)
        {
                val_12 = this.gradient;
        }
        
            val_13 = this.<endTime>5__3;
            this.<m_angle_start>5__6 = this.gradient.m_angle;
        }
        else
        {
                val_13 = this.<endTime>5__3;
            this.<>1__state = 0;
        }
        
        float val_2 = UnityEngine.Time.time;
        if((this.<>1__state) > 1)
        {
                val_9 = this.newGradientInfo.m_angle;
            this.gradient.m_angle = val_9;
            val_10 = 0;
            this.gradient.Refresh();
            return (bool)val_10;
        }
        
        float val_3 = UnityEngine.Time.time;
        float val_10 = this.<startTime>5__2;
        float val_4 = 0 - val_10;
        val_10 = val_4 / (this.<>4__this.duration);
        UnityEngine.Color val_5 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = -5.346245E+32f, g = this.<m_color1_start>5__4, b = SL, a = R8}, b:  new UnityEngine.Color() {r = val_9, g = mem[this.newGradientInfo.m_color1 + (0)], b = mem[this.newGradientInfo.m_color1 + (4)], a = mem[this.newGradientInfo.m_color1 + (8)]}, t:  val_4);
        val_12 = 0;
        UnityEngine.Color val_6 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = -5.346239E+32f, g = this.<m_color2_start>5__5, b = SL, a = R8}, b:  new UnityEngine.Color() {r = -5.346245E+32f, g = mem[this.newGradientInfo.m_color2 + (0)], b = mem[this.newGradientInfo.m_color2 + (4)], a = mem[this.newGradientInfo.m_color2 + (8)]}, t:  val_5.r);
        float val_7 = UnityEngine.Mathf.Lerp(a:  val_6.r, b:  val_6.g, t:  val_6.b);
        this.gradient.m_angle = this.<m_angle_start>5__6;
        this.gradient.Refresh();
        UnityEngine.WaitForEndOfFrame val_8 = null;
        val_9 = val_8;
        val_8 = new UnityEngine.WaitForEndOfFrame();
        val_10 = 1;
        this.<>1__state = val_10;
        this.<>2__current = val_9;
        return (bool)val_10;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
