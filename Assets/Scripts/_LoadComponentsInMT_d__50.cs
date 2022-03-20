using UnityEngine;
private sealed class App.<LoadComponentsInMT>d__50 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Collections.Generic.List<AppComponent> componentsInMT;
    private System.Collections.Generic.List.Enumerator<AppComponent> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public App.<LoadComponentsInMT>d__50(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.<>1__state;
        val_1 = val_1 + 3;
        if(val_1 > 6)
        {
                return;
        }
        
        if((113 & (1 << val_1)) != 0)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        int val_8;
        object val_10;
        int val_11;
        val_8 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool)val_8;
        }
        
        var val_1 = 9295056 + (9295056 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                9295056 + (this.<>1__state) << 2 = (9295056 + (this.<>1__state) << 2) & (val_8 << (9295056 + (this.<>1__state) << 2));
            9295056 + (this.<>1__state) << 2 = (9295056 + (this.<>1__state) << 2) & ((IP) << 2);
            9295056 + (this.<>1__state) << 2 = (9295056 + (this.<>1__state) << 2) & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
            9295056 + (this.<>1__state) << 2 = R8 * (9295056 + (this.<>1__state) << 2);
            9295056 + (this.<>1__state) << 2 = (9295056 + (this.<>1__state) << 2) & ((((R8 * (((9295056 + (this.<>1__state) << 2 & (val_8) << 9295056 + (this.<>1__state) << 2) & (IP) << 2) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )))) << (32-as. 
            
        
        
        
        
        
           
        )) | (((R8 * (((9295056 + (this.<>1__state) << 2 & (val_8) << 9295056 + (this.<>1__state) << 2) & (IP) << 2) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )))) << as. 
            
        
        
        
        
        
           
        ));
        }
        
        this.<>1__state = 0;
        List.Enumerator<T> val_2 = GetEnumerator();
        this.<>1__state = 2;
        if(MoveNext() != false)
        {
                UnityEngine.WaitForEndOfFrame val_5 = null;
            val_10 = val_5;
            val_5 = new UnityEngine.WaitForEndOfFrame();
            val_8 = 1;
            this.<>1__state = val_8;
        }
        else
        {
                this.<>m__Finally1();
            UnityEngine.WaitForEndOfFrame val_7 = null;
            val_10 = val_7;
            val_7 = new UnityEngine.WaitForEndOfFrame();
            val_11 = 4;
            this.<>1__state = val_11;
            val_8 = 1;
        }
        
        this.<>2__current = val_10;
        return (bool)val_8;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Dispose();
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
