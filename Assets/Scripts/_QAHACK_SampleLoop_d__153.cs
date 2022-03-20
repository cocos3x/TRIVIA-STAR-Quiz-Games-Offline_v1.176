using UnityEngine;
private sealed class Alphabet2Manager.<QAHACK_SampleLoop>d__153 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Alphabet2Manager <>4__this;
    private int <draws>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Alphabet2Manager.<QAHACK_SampleLoop>d__153(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        Alphabet2Manager val_12;
        int val_13;
        val_11 = 0;
        val_12 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
            this.<draws>5__2 = 0;
        }
        
        this.<>1__state = 0;
        if(val_12.IsCurrentCollectionComplete() != false)
        {
                val_12 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_11 = 0;
            UnityEngine.Debug.LogErrorFormat(format:  -1576745344, args:  472754880);
            return (bool)val_11;
        }
        
        int val_11 = this.<draws>5__2;
        val_11 = val_11 + 1;
        this.<draws>5__2 = val_11;
        if(val_12 != 0)
        {
                val_13 = this.<>4__this.tilesPerCollectionBox;
        }
        else
        {
                val_13 = 0;
        }
        
        val_12.FillCollectionBoxRandomly(lettersToCollect:  0);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_4 = currentCollectionBox;
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.Int32>> val_5 = GetRandomSeededPositionsForCollection(collectionBox:  -2100700048);
        List.Enumerator<T> val_6 = val_11.GetEnumerator();
        label_23:
        if(val_11.MoveNext() == false)
        {
            goto label_19;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CollectTileFromBox(word:  R6, letterIndex:  R7);
        goto label_23;
        label_19:
        val_11.Dispose();
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_10 = currentCollectionBox;
        Clear();
        val_11 = 1;
        this.<>1__state = val_11;
        this.<>2__current = 0;
        return (bool)val_11;
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
