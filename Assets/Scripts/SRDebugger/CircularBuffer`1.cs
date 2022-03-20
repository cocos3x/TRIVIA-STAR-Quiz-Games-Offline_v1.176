using UnityEngine;

namespace SRDebugger
{
    public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T>
    {
        // Fields
        private readonly T[] _buffer;
        private int _end;
        private int _count;
        private int _start;
        
        // Properties
        public int Capacity { get; }
        public bool IsFull { get; }
        public bool IsEmpty { get; }
        public int Count { get; }
        public T Item { get; set; }
        
        // Methods
        public CircularBuffer<T>(int capacity)
        {
            if(this == 0)
            {
                
            }
        
        }
        public CircularBuffer<T>(int capacity, T[] items)
        {
            System.ArgumentNullException val_3;
            var val_4;
            var val_5;
            int val_3 = capacity;
            if(val_3 <= 0)
            {
                goto label_2;
            }
            
            if(items == null)
            {
                goto label_3;
            }
            
            if(this > val_3)
            {
                goto label_4;
            }
            
            mem[1152921513607196760] = __RuntimeMethodHiddenParam + 12 + 96;
            System.Array.Copy(sourceArray:  items, destinationArray:  __RuntimeMethodHiddenParam + 12 + 96, length:  items);
            mem[1152921513607196768] = items;
            val_3 = items - val_3;
            mem[1152921513607196772] = 0;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
            {
                    val_3 = items;
            }
            
            mem[1152921513607196764] = val_3;
            return;
            label_2:
            val_3 = null;
            val_4 = "Circular buffer cannot have negative or zero capacity.";
            val_5 = "capacity";
            goto label_7;
            label_3:
            val_3 = null;
            val_3 = new System.ArgumentNullException(paramName:  410389936);
            goto label_8;
            label_4:
            val_3 = null;
            val_4 = "Too many items to fit circular buffer";
            val_5 = "items";
            label_7:
            val_3 = new System.ArgumentException(message:  410390016, paramName:  410389936);
            label_8:
        }
        public int get_Capacity()
        {
            if(R4 != 0)
            {
                    return (int)R4 + 12;
            }
            
            return (int)R4 + 12;
        }
        public bool get_IsFull()
        {
            if(this != 0)
            {
                    return false;
            }
            
            return false;
        }
        public bool get_IsEmpty()
        {
            if(this != 0)
            {
                    return false;
            }
            
            return false;
        }
        public int get_Count()
        {
            return (int)this;
        }
        public T get_Item(int index)
        {
            var val_4;
            if(this != 0)
            {
                goto label_2;
            }
            
            if(this <= index)
            {
                goto label_3;
            }
            
            if(this > this)
            {
                    return;
            }
            
            return;
            label_2:
            val_4 = "Cannot access index {0}. Buffer is empty";
            string val_1 = System.String.Format(format:  410988048, arg0:  13152256);
            goto label_6;
            label_3:
            val_4 = "Cannot access index {0}. Buffer size is {1}";
            string val_2 = System.String.Format(format:  410988208, arg0:  13152256, arg1:  13152256);
            label_6:
            System.IndexOutOfRangeException val_3 = new System.IndexOutOfRangeException(message:  410988208);
        }
        public void set_Item(int index, T value)
        {
            double val_4;
            double val_5;
            double val_6;
            var val_7;
            if(this != 0)
            {
                goto label_2;
            }
            
            if(this <= index)
            {
                goto label_3;
            }
            
            val_4 = value.UpdateTime;
            val_5 = value.UpdateTime;
            val_6 = value.RenderTime;
            if(this <= this)
            {
                    val_6 = value.RenderTime;
                val_5 = value.UpdateTime;
                val_4 = value.UpdateTime;
            }
            
            mem[1152921513879051436] = value.OtherTime;
            mem[1152921513879051440] = value.RenderTime;
            mem[1152921513879051444] = val_6;
            mem[1152921513879051448] = val_5;
            mem[1152921513879051452] = val_4;
            return;
            label_2:
            val_7 = "Cannot access index {0}. Buffer is empty";
            string val_1 = System.String.Format(format:  410988048, arg0:  13152256);
            goto label_6;
            label_3:
            val_7 = "Cannot access index {0}. Buffer size is {1}";
            string val_2 = System.String.Format(format:  410988208, arg0:  13152256, arg1:  13152256);
            label_6:
            System.IndexOutOfRangeException val_3 = new System.IndexOutOfRangeException(message:  410988208);
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
        public T Front()
        {
            var val_1 = __RuntimeMethodHiddenParam + 1645850176;
        }
        public T Back()
        {
            if((__RuntimeMethodHiddenParam + 12) == 0)
            {
                    __RuntimeMethodHiddenParam + 12 = mem[__RuntimeMethodHiddenParam + 16];
                __RuntimeMethodHiddenParam + 12 = __RuntimeMethodHiddenParam + 16;
            }
            
            var val_2 = (__RuntimeMethodHiddenParam + 8) + (((__RuntimeMethodHiddenParam + 12) - 1) << 5);
            val_2 = val_2 + 16;
            return new SRDebugger.Services.ProfilerFrame();
        }
        public void PushBack(T item)
        {
            var val_1 = R5 + ((R7) << 2);
            mem2[0] = item;
            if(this != 0)
            {
                    mem[1152921513608472228] = this;
                return;
            }
            
            mem[1152921513608472224] = 1152921513608472209;
        }
        public void PushFront(T item)
        {
            if(this != 0)
            {
                    mem[1152921513608588316] = this;
                mem[1152921513901502016] = item.RenderTime;
                mem[1152921513901502020] = item.RenderTime;
                mem[1152921513901502024] = item.UpdateTime;
                mem[1152921513901502028] = item.UpdateTime;
                mem[1152921513901502032] = __RuntimeMethodHiddenParam;
                return;
            }
            
            mem[1152921513901502016] = item.RenderTime;
            mem[1152921513901502020] = item.RenderTime;
            mem[1152921513901502024] = item.UpdateTime;
            mem[1152921513901502028] = item.UpdateTime;
            mem[1152921513901502032] = __RuntimeMethodHiddenParam;
            mem[1152921513608588320] = 1152921513901501989;
        }
        public void PopBack()
        {
            var val_1 = __RuntimeMethodHiddenParam + 296503168;
            val_1 = val_1 + 16;
            val_1 = val_1 - 1;
            mem[1152921513608700480] = val_1;
        }
        public void PopFront()
        {
            var val_1 = 35648726 + ((R7) << 2);
            mem2[0] = 0;
            mem[1152921513608812480] = 1152921513608812463;
        }
        public T[] ToArray()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = __RuntimeMethodHiddenParam;
            mem2[0] = val_1;
            mem2[0] = val_2;
            mem2[0] = val_3;
            val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 52 + 12];
            val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 52 + 12;
            if(val_9 <= 1)
            {
                    val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 52 + 12];
                val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 52 + 12;
            }
            
            val_10 = (__RuntimeMethodHiddenParam + 12 + 96 + 52) + 28;
            if(val_9 < 1)
            {
                    return;
            }
            
            val_6 = 0;
            var val_5 = 0;
            do
            {
                if(val_9 <= val_5)
            {
                    val_10 = 0;
            }
            
                System.Array.Copy(sourceArray:  mem[(__RuntimeMethodHiddenParam + 12 + 96 + 52 + 16) + (0)], sourceIndex:  mem[(__RuntimeMethodHiddenParam + 12 + 96 + 52 + 16) + (4)], destinationArray:  __RuntimeMethodHiddenParam + 12 + 96, destinationIndex:  0, length:  mem[(__RuntimeMethodHiddenParam + 12 + 96 + 52 + 16) + (8)]);
                val_5 = val_5 + 1;
                val_7 = (mem[(__RuntimeMethodHiddenParam + 12 + 96 + 52 + 16) + (8)]) + 0;
                val_8 = ((__RuntimeMethodHiddenParam + 12 + 96 + 52) + 16) + 12;
            }
            while(val_5 < (__RuntimeMethodHiddenParam + 12 + 96 + 52 + 12));
        
        }
        private void ThrowIfEmpty(string message = "Cannot access an empty buffer.")
        {
            if(this == 0)
            {
                    return;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  R4);
        }
        private void Increment(ref int index)
        {
            int val_1 = index + 1;
            index = val_1;
            if(val_1 == this)
            {
                    this = 0;
                index = this;
            }
        
        }
        private void Decrement(ref int index)
        {
            int val_1 = index;
            if(val_1 == 0)
            {
                    val_1 = this;
                index = val_1;
            }
            
            index = 1152921513609281727;
        }
        private int InternalIndex(int index)
        {
            int val_1 = index;
            var val_1 = this;
            val_1 = val_1 - (__RuntimeMethodHiddenParam + 12 + 96 + 12);
            if(val_1 <= val_1)
            {
                    var val_2 = this;
                val_1 = val_1 - val_2;
            }
            
            val_2 = val_1 + R7;
            return (int)val_2;
        }
        private System.ArraySegment<T> ArrayOne()
        {
            int val_4;
            var val_5;
            var val_6;
            if((__RuntimeMethodHiddenParam + 12) > (__RuntimeMethodHiddenParam + 20))
            {
                    val_4 = (__RuntimeMethodHiddenParam + 12) - (__RuntimeMethodHiddenParam + 20);
                val_5 = mem[R2 + 12 + 96];
                val_5 = R2 + 12 + 96;
            }
            else
            {
                    val_6 = __RuntimeMethodHiddenParam + 20;
                if((__RuntimeMethodHiddenParam + 8) == 0)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 20];
                val_6 = __RuntimeMethodHiddenParam + 20;
            }
            
                val_5 = mem[R2 + 12 + 96];
                val_5 = R2 + 12 + 96;
                val_4 = (__RuntimeMethodHiddenParam + 8 + 12) - val_6;
            }
            
            System.ArraySegment<SRDebugger.Services.ProfilerFrame> val_1 = new System.ArraySegment<SRDebugger.Services.ProfilerFrame>(array:  __RuntimeMethodHiddenParam + 8, offset:  __RuntimeMethodHiddenParam + 20, count:  val_4);
            mem[1152921513609509752] = 0;
            this = val_1._count;
            return 0;
        }
        private System.ArraySegment<T> ArrayTwo()
        {
            System.ArraySegment<SRDebugger.Services.ProfilerFrame> val_1 = new System.ArraySegment<SRDebugger.Services.ProfilerFrame>(array:  __RuntimeMethodHiddenParam + 8, offset:  0 = __RuntimeMethodHiddenParam + 12, count:  0);
            mem[1152921513609621752] = 0;
            this = val_1._count;
            return 0;
        }
    
    }

}
