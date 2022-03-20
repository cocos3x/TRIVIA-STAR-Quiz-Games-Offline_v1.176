using UnityEngine;
public class BetterList<T>
{
    // Fields
    public T[] buffer;
    public int size;
    
    // Properties
    public T Item { get; set; }
    
    // Methods
    public System.Collections.Generic.IEnumerator<T> GetEnumerator()
    {
        mem2[0] = this;
    }
    public T get_Item(int i)
    {
        var val_1 = R5 + (i << 2);
    }
    public void set_Item(int i, T value)
    {
        var val_1 = R6 + (i << 2);
        mem2[0] = value;
    }
    private void AllocateMore()
    {
        var val_2;
        System.Array val_3;
        if(35661880 != 0)
        {
                int val_2 = mem[35661892];
            val_2 = val_2 << 1;
            val_2 = UnityEngine.Mathf.Max(a:  val_2, b:  32);
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
        }
        else
        {
                val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
        }
        
        if((val_3 != 0) && (32 >= 1))
        {
                val_3.CopyTo(array:  val_3, index:  0);
        }
        
        mem[1152921510694830920] = val_3;
    }
    private void Trim()
    {
        var val_1;
        if(R4 >= 1)
        {
                if(R4 >= (R6 + 12))
        {
                return;
        }
        
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
            if(val_1 >= 1)
        {
                do
        {
            var val_1 = 4 - 4;
            mem2[0] = R4 + 16;
            val_1 = 4 + 1;
        }
        while((4 - 3) < (__RuntimeMethodHiddenParam + 12 + 96 + 8 + 12));
        
        }
        
            mem[1152921510694942920] = val_1;
            return;
        }
        
        mem[1152921510694942920] = 0;
    }
    public void Clear()
    {
        mem[1152921510695054924] = 0;
    }
    public void Release()
    {
        mem[1152921510695166920] = 0;
        mem[1152921510695166924] = 0;
    }
    public void Add(T item)
    {
        var val_4;
        if(R7 != this)
        {
            goto label_0;
        }
        
        mem[1152921510695283020] = R7 + 1;
        if(R6 != 0)
        {
            goto label_2;
        }
        
        val_4 = 0;
        goto label_2;
        label_0:
        mem[1152921510695283020] = R7 + 1;
        label_2:
        var val_3 = R6 + ((R7) << 2);
        mem2[0] = item;
    }
    public void Insert(int index, T item)
    {
        var val_3;
        var val_5;
        var val_3 = __RuntimeMethodHiddenParam;
        if(this == 0)
        {
            goto label_0;
        }
        
        val_3 = this;
        if(R4 != this)
        {
            goto label_1;
        }
        
        label_0:
        val_3 = this;
        label_1:
        if(R4 > index)
        {
                do
        {
            val_5 = mem[__RuntimeMethodHiddenParam + 12];
            val_5 = __RuntimeMethodHiddenParam + 12;
            var val_1 = R4 - 1;
            if(val_5 <= val_1)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 12];
            val_5 = __RuntimeMethodHiddenParam + 12;
        }
        
            val_3 = val_3 + ((R4) << 2);
            mem2[0] = (__RuntimeMethodHiddenParam + (R4) << 2) + 12;
            val_5 = val_5 >> 5;
        }
        while(val_1 > index);
        
            var val_2 = val_3 + (index << 2);
            mem2[0] = item;
            val_2 = val_2 + 1;
            mem[1152921510695403212] = val_2;
        }
    
    }
    public bool Contains(T item)
    {
        var val_3;
        var val_4;
        val_3 = 0;
        if(R7 == 0)
        {
                return (bool)val_3;
        }
        
        if(item < 1)
        {
                return (bool)val_3;
        }
        
        val_4 = 0;
        goto label_2;
        label_8:
        val_4 = 1;
        if(val_4 >= val_3)
        {
            goto label_3;
        }
        
        label_2:
        var val_1 = R7 + 4;
        if(((R7 + 4) + 16) == 0)
        {
            goto label_8;
        }
        
        return true;
        label_3:
        val_3 = 0;
        return (bool)val_3;
    }
    public bool Remove(T item)
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        val_1 = 0;
        if(this == 0)
        {
                return (bool)val_1;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 24) < 1)
        {
                return (bool)val_1;
        }
        
        label_6:
        val_2 = 4 - 4;
        var val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 24;
        if(val_4 != 0)
        {
            goto label_5;
        }
        
        var val_1 = 4 + 1;
        if((4 - 3) < (R5 + 16))
        {
            goto label_6;
        }
        
        val_1 = 0;
        return (bool)val_1;
        label_5:
        val_4 = val_4 - 1;
        mem[1152921510695643596] = val_4;
        mem2[0] = 0;
        val_1 = 1;
        if(val_2 >= 0)
        {
                return (bool)val_1;
        }
        
        do
        {
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 24 + 252 + 12];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 24 + 252 + 12;
            var val_3 = val_2 + 1;
            if(val_4 <= val_3)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 24 + 252 + 12];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 24 + 252 + 12;
        }
        
            val_3 = (__RuntimeMethodHiddenParam + 12 + 96 + 24 + 252) + (val_2 << 2);
            mem2[0] = (__RuntimeMethodHiddenParam + 12 + 96 + 24 + 252 + ((4 - 4)) << 2) + 20;
            val_2 = val_3;
        }
        while(val_3 < val_4);
        
        val_1 = 1;
        return (bool)val_1;
    }
    public void RemoveAt(int index)
    {
        var val_4;
        var val_5;
        if(R6 == 0)
        {
                return;
        }
        
        if(this <= index)
        {
                return;
        }
        
        mem[1152921510695759692] = 1152921510695759679;
        mem2[0] = 0;
        if((R6 + (index << 2)) <= index)
        {
                return;
        }
        
        do
        {
            val_5 = mem[R7 + 12];
            val_5 = R7 + 12;
            val_4 = index + 1;
            if(val_5 <= val_4)
        {
                val_5 = mem[R7 + 12];
            val_5 = R7 + 12;
        }
        
            var val_2 = R7 + (index << 2);
            mem2[0] = (R7 + (index) << 2) + 20;
        }
        while(val_4 < val_5);
    
    }
    public T Pop()
    {
        var val_3;
        var val_4;
        BetterList<T> val_5;
        val_4 = 0;
        if(this == 0)
        {
                return;
        }
        
        val_5 = 1152921510695871679;
        mem[1152921510695871692] = val_5;
        if((R6 + 12) > val_5)
        {
                var val_1 = R6 + 2881262332;
            val_4 = mem[(R6 + 2881262332) + 16];
            val_4 = (R6 + 2881262332) + 16;
        }
        else
        {
                var val_2 = R6 + 2881262332;
            val_4 = mem[(R6 + 2881262332) + 16];
            val_4 = (R6 + 2881262332) + 16;
            if((R6 + 12) != 0)
        {
                val_3 = R6 + 12;
        }
        else
        {
                val_3 = 0;
        }
        
            val_5 = this;
        }
        
        var val_3 = val_3 + 2881262336;
        mem2[0] = 0;
    }
    public T[] ToArray()
    {
        if(this != 0)
        {
                return;
        }
    
    }
    public void Sort(System.Comparison<T> comparer)
    {
        var val_7;
        var val_8 = 1;
        label_15:
        if(val_8 >= this)
        {
            goto label_0;
        }
        
        var val_1 = val_8 - 1;
        var val_2 = R4 + (val_1 << 2);
        System.Comparison<T> val_3 = comparer + 4;
        if(comparer >= 1)
        {
                var val_4 = R4 + 4;
            val_7 = mem[(R4 + ((1 - 1)) << 2) + 16 + 12];
            val_7 = (R4 + ((1 - 1)) << 2) + 16 + 12;
            if(val_7 <= val_1)
        {
                val_7 = mem[(R4 + ((1 - 1)) << 2) + 16 + 12];
            val_7 = (R4 + ((1 - 1)) << 2) + 16 + 12;
        }
        
            var val_5 = ((R4 + ((1 - 1)) << 2) + 16) + (val_1 << 2);
            var val_6 = ((R4 + ((1 - 1)) << 2) + 16) + 4;
            mem2[0] = ((R4 + ((1 - 1)) << 2) + 16 + ((1 - 1)) << 2) + 16;
            var val_7 = ((R4 + ((1 - 1)) << 2) + 16) + (val_1 << 2);
            mem2[0] = (R4 + 4) + 16;
        }
        
        val_8 = val_8 + 1;
        goto label_15;
        label_0:
        if(0 != 1)
        {
            goto label_15;
        }
    
    }
    public BetterList<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }

}
