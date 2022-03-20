using UnityEngine;
public class SROptions
{
    // Fields
    private static readonly SROptions _current;
    private SROptionsPropertyChanged PropertyChanged;
    
    // Properties
    public static SROptions Current { get; }
    
    // Methods
    public static SROptions get_Current()
    {
        null = null;
    }
    public void add_PropertyChanged(SROptionsPropertyChanged value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  this.PropertyChanged, b:  value);
        if(this.PropertyChanged == 0)
        {
            goto label_1;
        }
        
        val_2 = this.PropertyChanged;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(this.PropertyChanged != 1152921512404838824)
        {
            goto label_3;
        }
    
    }
    public void remove_PropertyChanged(SROptionsPropertyChanged value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  this.PropertyChanged, value:  value);
        if(this.PropertyChanged == 0)
        {
            goto label_1;
        }
        
        val_2 = this.PropertyChanged;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(this.PropertyChanged != 1152921512404967208)
        {
            goto label_3;
        }
    
    }
    public void OnPropertyChanged(string propertyName)
    {
        if(this.PropertyChanged == 0)
        {
                return;
        }
        
        this.PropertyChanged.Invoke(sender:  -791685984, propertyName:  propertyName);
    }
    public SROptions()
    {
    
    }
    private static SROptions()
    {
        SROptions._current = new System.Object();
    }

}
