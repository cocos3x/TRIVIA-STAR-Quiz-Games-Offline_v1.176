using UnityEngine;
[Serializable]
public struct ExposedList.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    private Spine.ExposedList<T> l;
    private int next;
    private int ver;
    private T current;
    
    // Properties
    public T Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    internal ExposedList.Enumerator<T>(Spine.ExposedList<T> l)
    {
        this = l;
        mem[1152921510825341240] = 1152921510825341236;
    }
    public void Dispose()
    {
        this = 0;
    }
    private void VerifyState()
    {
        var val_5 = __RuntimeMethodHiddenParam;
        if((new ExposedList.Enumerator<T>()) != 0)
        {
                System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  1923731056);
        }
        
        System.Type val_2 = R5 + 12 + 96.GetType();
        System.ObjectDisposedException val_3 = new System.ObjectDisposedException(objectName:  R5 + 12 + 96);
    }
    public bool MoveNext()
    {
        var val_2;
        this.VerifyState();
        val_2 = 0;
        if(R6 < 0)
        {
                return (bool)val_2;
        }
        
        mem[1152921510825682564] = val_2 + 1;
        val_2 = 1;
        mem[1152921510825682572] = ExposedList.Enumerator<T>.__il2cppRuntimeField_10;
        return (bool)val_2;
    }
    public T get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        this.VerifyState();
        mem[1152921510825906564] = 0;
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        this.VerifyState();
        if(this > 0)
        {
                return;
        }
        
        System.InvalidOperationException val_1 = new System.InvalidOperationException();
    }

}
