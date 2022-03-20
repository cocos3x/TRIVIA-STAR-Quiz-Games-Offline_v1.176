using UnityEngine;
public class RandomSet
{
    // Fields
    private static System.Random random;
    public bool replacement;
    private System.Collections.Generic.Dictionary<int, float> items;
    private float totalItemWeight;
    private System.Collections.Generic.Dictionary<int, float> used;
    private float totalUsedWeight;
    
    // Methods
    public void clear()
    {
        this.items.Clear();
        this.used.Clear();
        this.totalItemWeight = 0f;
        this.totalUsedWeight = 0f;
    }
    public int count()
    {
        if(this.items != 0)
        {
                return this.items.Count;
        }
        
        return this.items.Count;
    }
    public void reset()
    {
        int val_4;
        Dictionary.KeyCollection<TKey, TValue> val_1 = this.used.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        this.items.Add(key:  val_4, value:  this.used.Item[val_4]);
        goto label_6;
        label_3:
        Dispose();
        float val_6 = this.totalItemWeight;
        val_6 = val_6 + this.totalUsedWeight;
        this.totalItemWeight = val_6;
        this.used.Clear();
        this.totalUsedWeight = 0f;
    }
    public void add(int item, float weight = 1)
    {
        this.items.Add(key:  item, value:  weight);
        float val_1 = this.totalItemWeight;
        val_1 = val_1 + R2;
        this.totalItemWeight = val_1;
    }
    public void addIntRange(int lowest, int highest)
    {
        if(lowest > highest)
        {
                return;
        }
        
        int val_1 = lowest;
        do
        {
            this.add(item:  val_1, weight:  null);
            val_1 = val_1 + 1;
        }
        while(val_1 <= highest);
    
    }
    public int roll(bool unweighted = False)
    {
        int val_6;
        var val_9;
        float val_10;
        int val_11;
        float val_12;
        if(this.items.Count < 1)
        {
            goto label_2;
        }
        
        val_9 = null;
        val_9 = null;
        if(unweighted == false)
        {
            goto label_6;
        }
        
        val_10 = (float)this.items.Count;
        goto label_8;
        label_2:
        val_11 = 0;
        return (int)val_11;
        label_6:
        val_10 = this.totalItemWeight;
        label_8:
        Dictionary.KeyCollection<TKey, TValue> val_3 = this.items.Keys;
        var val_8 = (float)RandomSet.random;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        label_15:
        if(MoveNext() == false)
        {
            goto label_12;
        }
        
        val_12 = 1f;
        val_11 = val_6;
        if(unweighted != true)
        {
                float val_7 = this.items.Item[val_11];
            val_12 = this.items;
        }
        
        val_8 = val_8 - val_12;
        if(this.items >= 0)
        {
            goto label_15;
        }
        
        goto label_16;
        label_12:
        val_11 = 0;
        label_16:
        Dispose();
        if(this.replacement == true)
        {
                return (int)val_11;
        }
        
        this.use(item:  0);
        return (int)val_11;
    }
    public int remainingCount()
    {
        if(this.items != 0)
        {
                return this.items.Count;
        }
        
        return this.items.Count;
    }
    public static int singleInRange(int lowest, int highest)
    {
        null = null;
        int val_1 = 1 - lowest;
        val_1 = val_1 + highest;
        return (int)val_1 + lowest;
    }
    public static int singleInRange(System.Collections.Generic.List<object> range)
    {
        if(true == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_1 = System.Convert.ToInt32(value:  R1 + 16);
        if(val_1 == 0)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + ((val_1 - 1) << 2);
        return RandomSet.singleInRange(lowest:  val_1, highest:  System.Convert.ToInt32(value:  (0 + ((val_1 - 1)) << 2) + 16));
    }
    public void use(int item)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_4 = this.items;
        if((val_4.ContainsKey(key:  item)) == false)
        {
                return;
        }
        
        this.used.Add(key:  item, value:  this.items.Item[item]);
        val_4 = this.items;
        bool val_3 = val_4.Remove(key:  item);
        float val_4 = this.totalItemWeight;
        float val_5 = this.totalUsedWeight;
        val_4 = val_4 - this.items;
        val_5 = this.items + val_5;
        this.totalUsedWeight = val_5;
        this.totalItemWeight = val_4;
    }
    public void replace(int item)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_4 = this.used;
        if((val_4.ContainsKey(key:  item)) == false)
        {
                return;
        }
        
        this.items.Add(key:  item, value:  this.used.Item[item]);
        val_4 = this.used;
        bool val_3 = val_4.Remove(key:  item);
        float val_4 = this.totalItemWeight;
        float val_5 = this.totalUsedWeight;
        val_4 = this.used + val_4;
        val_5 = val_5 - this.used;
        this.totalUsedWeight = val_5;
        this.totalItemWeight = val_4;
    }
    public float getWeight(int item)
    {
        if((this.items.ContainsKey(key:  item)) == false)
        {
                return (float)S0;
        }
        
        if(this.items != 0)
        {
                return this.items.Item[item];
        }
        
        return this.items.Item[item];
    }
    public System.Collections.Generic.List<int> stream(int count)
    {
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        this.reset();
        goto label_1;
        label_5:
        Add(item:  this.roll(unweighted:  false));
        label_1:
        if(this.items.Count >= 1)
        {
            goto label_5;
        }
    
    }
    public void printBuckets()
    {
        var val_4;
        Dictionary.KeyCollection<TKey, TValue> val_1 = this.items.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        string val_5 = val_4.ToString();
        string val_6 = 1819065968 + 1819086276 + 1370307136;
        goto label_4;
        label_3:
        Dispose();
        string val_7 = 1819065968 + 1009293344;
        UnityEngine.Debug.Log(message:  1819065968);
        Dictionary.KeyCollection<TKey, TValue> val_8 = this.used.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_9 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_9;
        }
        
        string val_11 = val_4.ToString();
        string val_12 = 1819074256 + 1819086272 + 1370307136;
        goto label_10;
        label_9:
        Dispose();
        string val_13 = 1819074256 + 1009293344;
        UnityEngine.Debug.Log(message:  1819074256);
    }
    public RandomSet()
    {
        this.items = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
        this.used = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
    }
    private static RandomSet()
    {
        RandomSet.random = new System.Random();
    }

}
