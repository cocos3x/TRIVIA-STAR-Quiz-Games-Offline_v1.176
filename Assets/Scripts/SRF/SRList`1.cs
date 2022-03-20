using UnityEngine;

namespace SRF
{
    [Serializable]
    public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
    {
        // Fields
        private T[] _buffer;
        private int _count;
        private System.Collections.Generic.EqualityComparer<T> _equalityComparer;
        private System.Collections.ObjectModel.ReadOnlyCollection<T> _readOnlyWrapper;
        
        // Properties
        public T[] Buffer { get; set; }
        private System.Collections.Generic.EqualityComparer<T> EqualityComparer { get; }
        public int Count { get; set; }
        public bool IsReadOnly { get; }
        public T Item { get; set; }
        
        // Methods
        public SRList<T>()
        {
            if(this != 0)
            {
                    return;
            }
        
        }
        public SRList<T>(int capacity)
        {
            if(this == 0)
            {
                
            }
        
        }
        public SRList<T>(System.Collections.Generic.IEnumerable<T> source)
        {
            if(this != 0)
            {
                
            }
        
        }
        public T[] get_Buffer()
        {
        
        }
        private void set_Buffer(T[] value)
        {
            mem[1152921513559390936] = value;
        }
        private System.Collections.Generic.EqualityComparer<T> get_EqualityComparer()
        {
            if(this != 0)
            {
                    return;
            }
            
            mem2[0] = __RuntimeMethodHiddenParam + 12 + 96 + 12;
        }
        public int get_Count()
        {
            return (int)this;
        }
        private void set_Count(int value)
        {
            mem[1152921513559763804] = value;
        }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            mem2[0] = this;
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if(this == 0)
            {
                
            }
        
        }
        public void Add(T item)
        {
            if(this != 0)
            {
                    if(this != this)
            {
                goto label_5;
            }
            
            }
            
            label_5:
            mem[1152921515013393184] = item;
        }
        public void Clear()
        {
            if(this == 0)
            {
                
            }
        
        }
        public bool Contains(T item)
        {
            var val_1;
            if(this == 0)
            {
                goto label_3;
            }
            
            var val_1 = 0;
            label_9:
            if(val_1 >= this)
            {
                goto label_3;
            }
            
            val_1 = val_1 + 1;
            if(this == 0)
            {
                goto label_9;
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_3:
            val_1 = 0;
            return (bool)val_1;
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            this.CopyTo(array:  array, index:  arrayIndex);
        }
        public bool Remove(T item)
        {
            var val_1;
            var val_2;
            val_1 = item;
            val_2 = 0;
            if(this == 0)
            {
                    return (bool)val_2;
            }
            
            if(this < 0)
            {
                    return (bool)val_2;
            }
            
            val_1 = this;
            val_2 = 1;
            return (bool)val_2;
        }
        public bool get_IsReadOnly()
        {
            return false;
        }
        public int IndexOf(T item)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            if(this == 0)
            {
                    return (int)val_1;
            }
            
            val_2 = 0;
            goto label_2;
            label_10:
            if(this != 0)
            {
                    return (int)val_1;
            }
            
            val_2 = 1;
            label_2:
            if(val_2 < this)
            {
                goto label_10;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public void Insert(int index, T item)
        {
            var val_2;
            int val_3;
            SRF.SRList<T> val_4;
            var val_5;
            var val_6;
            SRF.SRList<T> val_7;
            var val_8;
            var val_9;
            val_2 = __RuntimeMethodHiddenParam;
            val_3 = item;
            val_4 = this;
            if(val_4 == 0)
            {
                goto label_1;
            }
            
            val_5 = val_4;
            val_4 = val_4;
            if(val_4 != val_4)
            {
                goto label_5;
            }
            
            label_1:
            label_5:
            val_6 = val_4;
            if(val_6 <= index)
            {
                goto label_9;
            }
            
            val_7 = val_4;
            val_8 = val_7;
            goto label_10;
            label_17:
            val_3 = 1152921513560982095;
            val_8 = 1152921513560982095;
            val_7 = val_4;
            mem[1152921515017784224] = mem[1152921515017784220];
            val_2 = val_2;
            label_10:
            val_5 = val_7;
            if(val_8 > index)
            {
                goto label_17;
            }
            
            SRF.SRList<T> val_1 = val_5 + (index << 2);
            mem2[0] = val_3;
            val_6 = 1152921513560982097;
            val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 44];
            val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 44;
            goto __RuntimeMethodHiddenParam + 12 + 96 + 68;
            label_9:
            val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 68];
            val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 68;
            goto __RuntimeMethodHiddenParam + 12 + 96 + 68;
        }
        public void RemoveAt(int index)
        {
            int val_3 = index;
            if(this == 0)
            {
                    return;
            }
            
            if(this <= val_3)
            {
                    return;
            }
            
            if(this != 0)
            {
                
            }
            
            var val_3 = this;
            val_3 = val_3 + (val_3 << 2);
            mem2[0] = 0;
            goto label_9;
            label_17:
            SRF.SRList<T> val_4 = this;
            int val_1 = val_3 + 1;
            val_4 = val_4 + (val_3 << 2);
            val_1 = val_1 - 1;
            SRF.SRList<T> val_2 = this + (val_3 << 2);
            val_3 = val_1 + 1;
            mem2[0] = val_4;
            label_9:
            if(val_3 < this)
            {
                goto label_17;
            }
        
        }
        public T get_Item(int index)
        {
            if(this != 0)
            {
                    var val_2 = this;
                val_2 = val_2 + (index << 2);
                return;
            }
            
            System.IndexOutOfRangeException val_1 = new System.IndexOutOfRangeException();
        }
        public void set_Item(int index, T value)
        {
            if(this != 0)
            {
                    var val_2 = this;
                val_2 = val_2 + (index << 2);
                mem2[0] = value;
                return;
            }
            
            System.IndexOutOfRangeException val_1 = new System.IndexOutOfRangeException();
        }
        public void OnBeforeSerialize()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            string val_1 = SRF.SRFStringExtensions.Fmt(formatString:  364626576, args:  472754880);
            UnityEngine.Debug.Log(message:  364626576);
        }
        public void OnAfterDeserialize()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            string val_1 = SRF.SRFStringExtensions.Fmt(formatString:  364738704, args:  472754880);
            UnityEngine.Debug.Log(message:  364738704);
        }
        public void AddRange(System.Collections.Generic.IEnumerable<T> range)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_7 = this;
            val_8 = __RuntimeMethodHiddenParam;
            val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 76];
            val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 76;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_10 = (uint)val_6 & 65535;
            val_11 = range;
            label_20:
            val_9 = 0;
            val_10 = 0;
            val_9 = val_9 + 1;
            val_10 = (uint)val_9 & 65535;
            val_12 = range;
            if(range == 0)
            {
                goto label_12;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_13 = range;
            if(val_7 != 0)
            {
                goto label_20;
            }
            
            goto label_20;
            label_12:
            val_14 = 0;
            if(range != 0)
            {
                    val_9 = 0;
                val_10 = 0;
                val_9 = val_9 + 1;
                val_10 = (uint)val_9 & 65535;
                val_15 = range;
            }
            
            var val_5 = FP - 28;
        }
        public void Clear(bool clean)
        {
            if(clean == false)
            {
                    return;
            }
            
            if(this == 0)
            {
                
            }
        
        }
        public void Clean()
        {
            var val_2;
            if(this == 0)
            {
                    return;
            }
            
            val_2 = this;
            goto label_3;
            label_7:
            var val_1 = R7 + 1460428160;
            val_2 = 1152921513561888609;
            mem2[0] = 0;
            label_3:
            if(val_2 < (R7 + 12))
            {
                goto label_7;
            }
        
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly()
        {
            var val_1;
            if(R6 != 0)
            {
                    return;
            }
            
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 88;
            mem[1152921513562000628] = val_1;
        }
        private void Expand()
        {
            var val_2;
            System.Array val_3;
            if(this != 0)
            {
                    int val_1 = UnityEngine.Mathf.Max(a:  310861824, b:  32);
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96];
                val_2 = __RuntimeMethodHiddenParam + 12 + 96;
                val_3 = val_2;
            }
            else
            {
                    val_3 = __RuntimeMethodHiddenParam + 12 + 96;
            }
            
            if((this != 0) && (this >= 1))
            {
                    val_2 = this;
                this.CopyTo(array:  val_3, index:  0);
            }
            
            if(this == 0)
            {
                
            }
        
        }
        public void Trim()
        {
            var val_2;
            SRF.SRList<T> val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_2 = __RuntimeMethodHiddenParam;
            val_3 = this;
            if(val_3 < 1)
            {
                goto label_1;
            }
            
            val_4 = val_3;
            val_5 = val_3;
            if(val_4 >= val_3)
            {
                    return;
            }
            
            val_6 = __RuntimeMethodHiddenParam + 12 + 96;
            val_7 = 4;
            goto label_8;
            label_15:
            mem2[0] = val_3;
            val_7 = 5;
            label_8:
            val_8 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_8 = __RuntimeMethodHiddenParam + 12 + 96;
            if((val_7 - 4) < val_3)
            {
                goto label_15;
            }
            
            goto __RuntimeMethodHiddenParam + 12 + 96 + 4;
            label_1:
            val_6 = __RuntimeMethodHiddenParam + 12 + 96;
            val_8 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_8 = __RuntimeMethodHiddenParam + 12 + 96;
            goto __RuntimeMethodHiddenParam + 12 + 96 + 4;
        }
        public void Sort(System.Comparison<T> comparer)
        {
            System.Comparison<T> val_1;
            var val_5 = 1;
            label_23:
            if(val_5 >= this)
            {
                goto label_1;
            }
            
            var val_2 = this;
            var val_1 = val_5 - 1;
            val_2 = val_2 + (val_1 << 2);
            val_1 = comparer;
            if(val_1 == 0)
            {
                    val_1 = comparer;
            }
            
            if(val_1 >= 1)
            {
                    SRF.SRList<T> val_3 = this;
                val_3 = val_3 + (val_1 << 2);
                mem[1152921513562340724] = val_3;
                var val_4 = this;
                val_4 = val_4 + (val_1 << 2);
                mem2[0] = 0;
            }
            
            val_5 = val_5 + 1;
            goto label_23;
            label_1:
            if(0 != 1)
            {
                goto label_23;
            }
        
        }
    
    }

}
