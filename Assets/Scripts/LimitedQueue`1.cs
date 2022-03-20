using UnityEngine;
public class LimitedQueue<T> : Queue<T>
{
    // Fields
    private int <Limit>k__BackingField;
    
    // Properties
    public int Limit { get; set; }
    
    // Methods
    public int get_Limit()
    {
        return (int)this;
    }
    public void set_Limit(int value)
    {
        mem[1152921511164546096] = value;
    }
    public LimitedQueue<T>(int limit)
    {
        if(this == 0)
        {
            
        }
    
    }
    public void Enqueue(T item)
    {
        goto label_0;
        label_4:
        label_0:
        if(this >= this)
        {
            goto label_4;
        }
        
        goto __RuntimeMethodHiddenParam + 12 + 96 + 24;
    }

}
