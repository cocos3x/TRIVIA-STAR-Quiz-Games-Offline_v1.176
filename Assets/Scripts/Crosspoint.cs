using UnityEngine;
private class Crossword.Crosspoint
{
    // Fields
    public int x;
    public int y;
    public char l;
    public int dir;
    private static System.Collections.Generic.List<CrosswordCreator.Crossword.Crossword.Crosspoint> All;
    
    // Properties
    public static int Count { get; }
    
    // Methods
    public Crossword.Crosspoint(int x, int y, char l, int dir)
    {
        this.x = x;
        this.y = y;
        this.l = l;
        this.dir = dir;
    }
    public static void Add(int x, int y, char l, int dir)
    {
        null = null;
        null = new System.Object();
        typeof(Crossword.Crosspoint).__il2cppRuntimeField_8 = x;
        typeof(Crossword.Crosspoint).__il2cppRuntimeField_C = y;
        typeof(Crossword.Crosspoint).__il2cppRuntimeField_10 = l;
        typeof(Crossword.Crosspoint).__il2cppRuntimeField_14 = dir;
        Crossword.Crosspoint.All.Add(item:  403247104);
    }
    public static CrosswordCreator.Crossword.Crossword.Crosspoint Get(int index)
    {
        null = null;
        if((Crossword.Crosspoint.All + 12) <= index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_1 = Crossword.Crosspoint.All + 8;
        val_1 = val_1 + (index << 2);
    }
    public static CrosswordCreator.Crossword.Crossword.Crosspoint GetAt(int x, int y)
    {
        var val_3;
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        val_5 = val_3;
        if((val_3 + 8) == x)
        {
                val_3 + 8 = mem[val_3 + 12];
            val_3 + 8 = val_3 + 12;
        }
        
        if((val_3 + 8) != y)
        {
            goto label_6;
        }
        
        goto label_7;
        label_4:
        val_5 = 0;
        label_7:
        Dispose();
    }
    public static void Remove(int x, int y)
    {
        var val_3;
        Crosspoint val_1 = Crossword.Crosspoint.GetAt(x:  x, y:  y);
        if(x == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        bool val_2 = Crossword.Crosspoint.All.Remove(item:  x);
    }
    public static void Clear()
    {
        null = null;
        Crossword.Crosspoint.All.Clear();
    }
    public static int get_Count()
    {
        null = null;
        if(Crossword.Crosspoint.All != 0)
        {
                return (int)Crossword.Crosspoint.All + 12;
        }
        
        return (int)Crossword.Crosspoint.All + 12;
    }
    private static Crossword.Crosspoint()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Crossword.Crosspoint.All = null;
    }

}
