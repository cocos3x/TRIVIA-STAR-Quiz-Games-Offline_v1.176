using UnityEngine;
public abstract class BasedOnResolution : MonoBehaviour
{
    // Fields
    protected float currentWidth;
    protected float currentHeight;
    protected float currentResolution;
    
    // Methods
    protected virtual void Start()
    {
        this.currentWidth = (float)UnityEngine.Screen.width;
        int val_2 = UnityEngine.Screen.height;
        float val_4 = this.currentWidth;
        val_4 = val_4 / (float)val_2;
        this.currentHeight = (float)val_2;
        float val_3 = val_2.ShortenToSigFigs(number:  (float)val_2);
        this.currentResolution = val_2;
        goto typeof(BasedOnResolution).__il2cppRuntimeField_E4;
    }
    protected virtual void Modify()
    {
        if()
        {
            
        }
        else
        {
                if( && )
        {
            
        }
        else
        {
                if( && )
        {
            
        }
        else
        {
                if( && )
        {
            
        }
        else
        {
                if()
        {
                return;
        }
        
        }
        
        }
        
        }
        
        }
    
    }
    protected abstract void Apply17x10(); // 0
    protected abstract void Apply16x9(); // 0
    protected abstract void Apply16x10(); // 0
    protected abstract void Apply3x2(); // 0
    protected abstract void Apply4x3(); // 0
    protected float ShortenToSigFigs(float number)
    {
        int val_3;
        int val_8;
        decimal val_1 = System.Convert.ToDecimal(value:  number);
        decimal val_2 = new System.Decimal(value:  100);
        decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1787495824}, d2:  new System.Decimal() {flags = val_3, hi = val_2.flags, lo = val_2.hi, mid = val_2.lo});
        decimal val_6 = System.Math.Truncate(d:  new System.Decimal() {flags = -1787495840});
        decimal val_7 = new System.Decimal(value:  100);
        decimal val_9 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -1787495872}, d2:  new System.Decimal() {flags = val_8, hi = val_7.flags, lo = val_7.hi, mid = val_7.lo});
        return (float)System.Decimal.op_Explicit(value:  new System.Decimal());
    }
    protected BasedOnResolution()
    {
    
    }

}
