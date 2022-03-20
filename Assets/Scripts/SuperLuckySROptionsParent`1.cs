using UnityEngine;
public class SuperLuckySROptionsParent<T> : SROptions
{
    // Fields
    protected static T _Instance;
    private System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
    // Properties
    public static T Instance { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_1;
        var val_2;
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 186;
            val_2 = __RuntimeMethodHiddenParam + 12;
            if(val_1 == 1)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 12];
            val_2 = __RuntimeMethodHiddenParam + 12;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
            mem2[0] = __RuntimeMethodHiddenParam + 12 + 96 + 8;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
        {
                return;
        }
    
    }
    public void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
    {
        var val_2;
        do
        {
            val_2 = 0;
            System.Delegate val_1 = System.Delegate.Combine(a:  R6, b:  value);
            if(R6 != 0)
        {
                val_2 = R6;
            if(R6 == 0)
        {
                val_2 = 0;
        }
        
        }
        
        }
        while(R6 != 1152921512406124076);
    
    }
    public void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
    {
        var val_2;
        do
        {
            val_2 = 0;
            System.Delegate val_1 = System.Delegate.Remove(source:  R6, value:  value);
            if(R6 != 0)
        {
                val_2 = R6;
            if(R6 == 0)
        {
                val_2 = 0;
        }
        
        }
        
        }
        while(R6 != 1152921512406244268);
    
    }
    public virtual void DoOnPropertyChanged(string propertyName)
    {
        if(35665971 == 0)
        {
                return;
        }
        
        System.ComponentModel.PropertyChangedEventArgs val_1 = new System.ComponentModel.PropertyChangedEventArgs(propertyName:  propertyName);
        static_value_02203833.Invoke(sender:  -790417120, e:  110755840);
    }
    public SuperLuckySROptionsParent<T>()
    {
    
    }

}
