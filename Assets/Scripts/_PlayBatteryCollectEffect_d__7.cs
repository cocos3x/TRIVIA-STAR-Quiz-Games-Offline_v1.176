using UnityEngine;
private sealed class BatteryCollectEffect.<PlayBatteryCollectEffect>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.BatteryCollectEffect <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BatteryCollectEffect.<PlayBatteryCollectEffect>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_7;
        int val_8;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 8228256 + (8228256 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                8228256 + (this.<>1__state) << 2 = (8228256 + (this.<>1__state) << 2) & ((8228256 + (this.<>1__state) << 2) << (8228256 + (this.<>1__state) << 2));
            8228256 + (this.<>1__state) << 2 = (8228256 + (this.<>1__state) << 2) & (((R8) << (32-(8228256 + (this.<>1__state) << 2 & (8228256 + (this.<>1__state) << 2) << 8228256 + (this.<>1__state) << 2))) | ((R8) << (8228256 + (this.<>1__state) << 2 & (8228256 + (this.<>1__state) << 2) << 8228256 + (this.<>1__state) << 2)));
            8228256 + (this.<>1__state) << 2 = (8228256 + (this.<>1__state) << 2) & ((8228256 + (this.<>1__state) << 2) << 2);
            8228256 + (this.<>1__state) << 2 = (8228256 + (this.<>1__state) << 2) & ((8228256 + (this.<>1__state) << 2) >> 2);
        }
        
            this.<>1__state = 0;
            this.<>4__this.batteryParticles.Play();
            UnityEngine.WaitForSeconds val_2 = null;
            val_7 = val_2;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_8 = 1;
            this.<>1__state = val_8;
        }
        else
        {
                val_8 = 0;
            return (bool);
        }
        
        this.<>2__current = ;
        return (bool);
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
