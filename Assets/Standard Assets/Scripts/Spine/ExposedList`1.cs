using UnityEngine;

namespace Spine
{
    [Serializable]
    public class ExposedList<T> : IEnumerable<T>, IEnumerable
    {
        // Fields
        public T[] Items;
        public int Count;
        private const int DefaultCapacity = 4;
        private static readonly T[] EmptyArray;
        private int version;
        
        // Properties
        public int Capacity { get; set; }
        
        // Methods
        public ExposedList<T>()
        {
            var val_1;
            var val_2;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96;
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            if((val_2 & 512) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96;
                if((__RuntimeMethodHiddenParam + 12 + 96 + 116) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96;
            }
            
            }
            
            mem[1152921510817023512] = __RuntimeMethodHiddenParam + 12 + 96 + 92;
        }
        public ExposedList<T>(System.Collections.Generic.IEnumerable<T> collection)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_3 = __RuntimeMethodHiddenParam;
            val_4 = this;
            if(this != 0)
            {
                
            }
            
            if(collection == 0)
            {
                goto label_3;
            }
            
            val_5 = collection;
            var val_2 = 0;
            val_8 = 0;
            val_2 = val_2 + 1;
            val_9 = val_5;
            goto label_8;
            label_3:
            val_10 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_10 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_10 == 1)
            {
                    val_10 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_10 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            mem[1152921510817139608] = __RuntimeMethodHiddenParam + 12 + 96 + 92;
            val_7 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 12];
            val_7 = __RuntimeMethodHiddenParam + 12 + 96 + 12;
            val_6 = val_4;
            goto __RuntimeMethodHiddenParam + 12 + 96 + 12;
            label_8:
            mem2[0] = R8 + 12 + 96 + 16;
            if(SB == 0)
            {
                
            }
        
        }
        public ExposedList<T>(int capacity)
        {
            if(capacity > 1)
            {
                    mem[1152921510817256824] = __RuntimeMethodHiddenParam + 12 + 96 + 16;
                return;
            }
            
            System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException(paramName:  1915417424);
        }
        internal ExposedList<T>(T[] data, int size)
        {
            mem[1152921510817405688] = data;
            mem[1152921510817405692] = size;
        }
        public void Add(T item)
        {
            mem[1152921510817558652] = R7 + 1;
            var val_2 = __RuntimeMethodHiddenParam + ((R7) << 2);
            mem2[0] = item;
            val_2 = val_2 + 1;
            mem[1152921510817558656] = val_2;
        }
        public void GrowIfNeeded(int newCount)
        {
            if((true + newCount) <= mem[35665913])
            {
                    return;
            }
            
            int val_2 = System.Math.Max(val1:  System.Math.Max(val1:  -463246368, val2:  4), val2:  true + newCount = true + newCount);
            goto __RuntimeMethodHiddenParam + 12 + 96 + 32;
        }
        public Spine.ExposedList<T> Resize(int newSize)
        {
            mem[1152921510817786748] = newSize;
        }
        public void EnsureCapacity(int min)
        {
            var val_3;
            if((R7 + 12) >= min)
            {
                    return;
            }
            
            if((R7 + 12) != 0)
            {
                    val_3 = (R7 + 12) << 1;
            }
            else
            {
                    val_3 = 4;
            }
            
            if(val_3 < min)
            {
                    val_3 = min;
            }
            
            goto __RuntimeMethodHiddenParam + 12 + 96 + 32;
        }
        private void CheckRange(int idx, int count)
        {
            System.ArgumentOutOfRangeException val_3;
            var val_4;
            if(idx <= 1)
            {
                goto label_1;
            }
            
            if(count <= 1)
            {
                goto label_2;
            }
            
            idx = count + idx;
            if(idx <= true)
            {
                    return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  1916172464);
            label_4:
            label_1:
            val_3 = null;
            val_4 = "index";
            goto label_3;
            label_2:
            val_3 = null;
            val_4 = "count";
            label_3:
            val_3 = new System.ArgumentOutOfRangeException(paramName:  1348647040);
            goto label_4;
        }
        private void AddCollection(System.Collections.Generic.ICollection<T> collection)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8];
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_5 = collection;
            if(collection == 0)
            {
                    return;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_6 = collection;
            System.Collections.Generic.ICollection<T> val_5 = collection;
            val_5 = val_5 + collection;
            mem[1152921510818128012] = val_5;
        }
        private void AddEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
        {
            var val_4;
            var val_5;
            var val_11;
            var val_12;
            var val_13;
            System.Collections.Generic.IEnumerable<T> val_14;
            var val_15;
            var val_16;
            var val_17;
            val_11 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 40];
            val_11 = __RuntimeMethodHiddenParam + 12 + 96 + 40;
            var val_11 = 0;
            val_12 = 0;
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            val_13 = enumerable;
            val_14 = enumerable;
            goto label_7;
            label_20:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_15 = val_14;
            val_12 = val_4;
            val_11 = val_5;
            val_14 = enumerable;
            label_7:
            var val_13 = val_14;
            if((enumerable + 178) == 0)
            {
                goto label_16;
            }
            
            val_11 = 0;
            label_18:
            val_12 = 0;
            if((enumerable + 88 + 0) == null)
            {
                goto label_17;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (enumerable + 178))
            {
                goto label_18;
            }
            
            label_16:
            val_16 = val_14;
            goto label_19;
            label_17:
            var val_9 = (enumerable + 88) + 0;
            val_13 = val_13 + (((enumerable + 88 + 0) + 4) << 3);
            val_16 = val_13 + 188;
            label_19:
            if(val_14 != 0)
            {
                goto label_20;
            }
            
            if(val_14 == 0)
            {
                goto label_21;
            }
            
            var val_14 = val_14;
            if((enumerable + 178) == 0)
            {
                goto label_22;
            }
            
            val_11 = 0;
            label_24:
            val_12 = 0;
            if((enumerable + 88 + 0) == null)
            {
                goto label_23;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (enumerable + 178))
            {
                goto label_24;
            }
            
            label_22:
            val_17 = val_14;
            goto label_25;
            label_23:
            var val_10 = (enumerable + 88) + 0;
            val_14 = val_14 + (((enumerable + 88 + 0) + 4) << 3);
            val_17 = val_14 + 188;
            label_25:
            label_21:
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void AddRange(System.Collections.Generic.IEnumerable<T> collection)
        {
            var val_1;
            if(collection != 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 20];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 20;
            }
            else
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 12];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 12;
            }
            
            mem[1152921510818368400] = 1152921510818368385;
        }
        public int BinarySearch(T item)
        {
            return (int)__RuntimeMethodHiddenParam + 12 + 96;
        }
        public int BinarySearch(T item, System.Collections.Generic.IComparer<T> comparer)
        {
            return (int)__RuntimeMethodHiddenParam + 12 + 96;
        }
        public int BinarySearch(int index, int count, T item, System.Collections.Generic.IComparer<T> comparer)
        {
            if(this != 0)
            {
                    return (int)__RuntimeMethodHiddenParam + 12 + 96;
            }
            
            return (int)__RuntimeMethodHiddenParam + 12 + 96;
        }
        public void Clear(bool clearArray = True)
        {
            if(clearArray != false)
            {
                    System.Array val_1 = R5;
                System.Array.Clear(array:  val_1, index:  0, length:  R5 + 12);
            }
            
            mem[1152921510818836876] = 0;
            val_1 = val_1 + 1;
            mem[1152921510818836880] = val_1;
        }
        public bool Contains(T item)
        {
            if(IP != 1)
            {
                    IP + 1 = 1;
            }
            
            return true;
        }
        public Spine.ExposedList<TOutput> ConvertAll<TOutput>(System.Converter<T, TOutput> converter)
        {
            if(converter != 0)
            {
                    if(R5 >= 1)
            {
                    do
            {
                var val_1 = 4 - 4;
                mem2[0] = converter;
                var val_2 = 4 + 1;
            }
            while((4 - 3) < converter);
            
            }
            
                mem2[0] = converter;
                return;
            }
            
            System.ArgumentNullException val_4 = new System.ArgumentNullException(paramName:  1917234880);
        }
        public void CopyTo(T[] array)
        {
            System.Array.Copy(sourceArray:  array, sourceIndex:  0, destinationArray:  array, destinationIndex:  0, length:  this);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            System.Array.Copy(sourceArray:  array, sourceIndex:  0, destinationArray:  array, destinationIndex:  arrayIndex, length:  this);
        }
        public void CopyTo(int index, T[] array, int arrayIndex, int count)
        {
            System.Array.Copy(sourceArray:  1917784416, sourceIndex:  index, destinationArray:  array, destinationIndex:  arrayIndex, length:  count);
        }
        public bool Exists(System.Predicate<T> match)
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            if(this != 1)
            {
                    1152921510819751649 = 1;
            }
            
            return true;
        }
        public T Find(System.Predicate<T> match)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_5;
            int val_6;
            UnityEngine.Material val_7;
            var val_9;
            val_1 = this;
            val_2 = match;
            val_3 = mem[R3 + 12 + 96 + 186];
            val_3 = R3 + 12 + 96 + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[R3 + 12 + 96 + 186];
                val_3 = R3 + 12 + 96 + 186;
            }
            
            val_5 = 0;
            val_6 = R3 + 12 + 96;
            val_7 = __RuntimeMethodHiddenParam;
            var val_1 = val_2;
            if(val_1 != 1)
            {
                    val_1 = val_1 + (val_1 << 2);
                val_1 = val_2 + (val_1 << 3);
                val_1 = val_1 + 16;
                return new Spine.Unity.SubmeshInstruction() {skeleton = 36, endSlot = val_6, material = val_7, forceSeparate = false, hasClipping = false};
            }
            
            mem[1152921510819871872] = 0;
            val_9 = 36;
            this = 0;
            return new Spine.Unity.SubmeshInstruction() {skeleton = 36, endSlot = val_6, material = val_7, forceSeparate = false, hasClipping = false};
        }
        private static void CheckMatch(System.Predicate<T> match)
        {
            if(match != 0)
            {
                    return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  1918153760);
        }
        public Spine.ExposedList<T> FindAll(System.Predicate<T> match)
        {
            var val_1;
            var val_2;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96;
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            if((val_2 & 512) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96;
                if((__RuntimeMethodHiddenParam + 12 + 96 + 116) == 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96;
            }
            
            }
            
            if(this == 0)
            {
                
            }
        
        }
        private Spine.ExposedList<T> FindAllList(System.Predicate<T> match)
        {
            var val_1;
            var val_2;
            System.Predicate<T> val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 80) < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            var val_1 = 28;
            do
            {
                val_1 = mem[SL + 28];
                val_1 = SL + 28;
                val_3 = match;
                val_4 = mem[SL + 28 + 8];
                val_4 = SL + 28 + 8;
                val_5 = mem[SL + 28 + 12];
                val_5 = SL + 28 + 12;
                val_6 = mem[SL + 28 + 24];
                val_6 = SL + 28 + 24;
                if(val_3 == 0)
            {
                    val_5 = val_5;
                val_4 = val_4;
                val_2 = mem[SL + 28 + (-8)];
                val_3 = match;
            }
            
                val_7 = SL + 28 + 20;
                if(val_3 != 0)
            {
                    val_8 = __RuntimeMethodHiddenParam + 12 + 96 + 80;
                if(mem[1152921510820233528] == 0)
            {
                    val_8 = __RuntimeMethodHiddenParam + 12 + 96 + 80;
            }
            
                if((mem[1152921510820233528] + 12) <= val_2)
            {
                    val_8 = __RuntimeMethodHiddenParam + 12 + 96 + 80;
            }
            
                val_6 = mem[mem[1152921510820233528] + 28 + 12];
                val_6 = mem[1152921510820233528] + 28 + 12;
                val_10 = mem[mem[1152921510820233528] + 28 + 16];
                val_10 = mem[1152921510820233528] + 28 + 16;
                if(val_8 == 0)
            {
                    val_9 = mem[mem[1152921510820233528] + 28 + (8)];
                val_10 = val_10;
            }
            
                val_7 = mem[1152921510820233528] + 28 + 24;
            }
            
                val_1 = val_1 + 40;
                val_2 = val_2 + 1;
            }
            while(val_2 < mem[1152921510820233532]);
        
        }
        public int FindIndex(System.Predicate<T> match)
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            if(this != 0)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public int FindIndex(int startIndex, System.Predicate<T> match)
        {
            var val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            int val_1 = (__RuntimeMethodHiddenParam + 12 + 96) - startIndex;
            return (int)this;
        }
        public int FindIndex(int startIndex, int count, System.Predicate<T> match)
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            if(this == 0)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        private int GetIndex(int startIndex, int count, System.Predicate<T> match)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            System.Predicate<T> val_7;
            val_3 = startIndex;
            startIndex = count + startIndex;
            val_4 = 0;
            if(startIndex <= val_3)
            {
                    return (int)val_4;
            }
            
            val_5 = 28 + ((val_3 + (val_3 << 2)) << 3);
            label_5:
            val_6 = mem[1152921510820714296] + (28 + ((startIndex + (startIndex) << 2)) << 3) + -12;
            val_7 = match;
            if(val_7 == 0)
            {
                    val_6 = val_6;
                val_7 = match;
            }
            
            if(val_7 != 0)
            {
                goto label_4;
            }
            
            val_3 = val_3 + 1;
            val_5 = val_5 + 40;
            if(val_3 < startIndex)
            {
                goto label_5;
            }
            
            val_4 = 0;
            return (int)val_4;
            label_4:
            val_4 = val_3;
            return (int)val_4;
        }
        public T FindLast(System.Predicate<T> match)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_5;
            int val_6;
            UnityEngine.Material val_7;
            var val_9;
            val_1 = this;
            val_2 = match;
            val_3 = mem[R3 + 12 + 96 + 186];
            val_3 = R3 + 12 + 96 + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[R3 + 12 + 96 + 186];
                val_3 = R3 + 12 + 96 + 186;
            }
            
            val_5 = 0;
            val_6 = R3 + 12 + 96;
            val_7 = __RuntimeMethodHiddenParam;
            var val_1 = val_2;
            if(val_1 != 1)
            {
                    val_1 = val_1 + (val_1 << 2);
                val_1 = val_2 + (val_1 << 3);
                val_1 = val_1 + 16;
                return new Spine.Unity.SubmeshInstruction() {skeleton = 36, endSlot = val_6, material = val_7, forceSeparate = false, hasClipping = false};
            }
            
            mem[1152921510820834512] = 0;
            val_9 = 36;
            this = 0;
            return new Spine.Unity.SubmeshInstruction() {skeleton = 36, endSlot = val_6, material = val_7, forceSeparate = false, hasClipping = false};
        }
        public int FindLastIndex(System.Predicate<T> match)
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            if(this != 0)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public int FindLastIndex(int startIndex, System.Predicate<T> match)
        {
            var val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            if(this != 0)
            {
                
            }
            
            int val_1 = startIndex + 1;
            return (int)this;
        }
        public int FindLastIndex(int startIndex, int count, System.Predicate<T> match)
        {
            var val_2;
            int val_2 = startIndex;
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            val_2 = (val_2 - count) + 1;
            if(this == 0)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        private int GetLastIndex(int startIndex, int count, System.Predicate<T> match)
        {
            var val_7;
            var val_8;
            var val_9;
            System.Predicate<T> val_10;
            var val_11;
            int val_1 = count + startIndex;
            startIndex = val_1 + (val_1 << 2);
            int val_2 = val_1 - 1;
            val_7 = 0 - count;
            val_8 = 12 + (startIndex << 3);
            label_4:
            if(val_7 == 0)
            {
                goto label_0;
            }
            
            var val_3 = (mem[1152921510821315256] + (12 + (((count + startIndex) + ((count + startIndex)) << 2)) << 3)) - 32;
            val_9 = mem[1152921510821315256] + (12 + (((count + startIndex) + ((count + startIndex)) << 2)) << 3) + -36;
            val_10 = match;
            if(val_10 == 0)
            {
                    val_9 = val_9;
                val_10 = match;
            }
            
            val_2 = val_2 - 1;
            val_7 = val_7 + 1;
            val_8 = val_8 - 40;
            if(val_10 == 0)
            {
                goto label_4;
            }
            
            val_11 = val_2 + 1;
            return (int)val_11;
            label_0:
            val_11 = 0;
            return (int)val_11;
        }
        public void ForEach(System.Action<T> action)
        {
            if(action != 0)
            {
                    if(action < 1)
            {
                    return;
            }
            
                var val_3 = 0;
                var val_2 = 28;
                do
            {
                val_2 = val_2 + 40;
                val_3 = val_3 + 1;
            }
            while(val_3 < mem[1152921510821436556]);
            
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  1919597168);
        }
        public Spine.ExposedList.Enumerator<T> GetEnumerator()
        {
             = new ExposedList.Enumerator<System.Object>(l:  __RuntimeMethodHiddenParam);
            return (ExposedList.Enumerator<T>);
        }
        public Spine.ExposedList<T> GetRange(int index, int count)
        {
            System.Array.Copy(sourceArray:  __RuntimeMethodHiddenParam + 12 + 96 + 16, sourceIndex:  index, destinationArray:  __RuntimeMethodHiddenParam + 12 + 96 + 16, destinationIndex:  0, length:  count);
            if((__RuntimeMethodHiddenParam + 12 + 96 + 80 + 186) != 1)
            {
                    return;
            }
        
        }
        public int IndexOf(T item)
        {
            return (int)IP;
        }
        public int IndexOf(T item, int index)
        {
            int val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 92;
            val_1 = val_1 - index;
            return (int)__RuntimeMethodHiddenParam + 12 + 96;
        }
        public int IndexOf(T item, int index, int count)
        {
            System.ArgumentOutOfRangeException val_3;
            var val_4;
            if(index <= 1)
            {
                goto label_1;
            }
            
            if(count <= 1)
            {
                goto label_2;
            }
            
            if((count + index) > true)
            {
                goto label_3;
            }
            
            return (int)__RuntimeMethodHiddenParam + 12 + 96;
            label_1:
            val_3 = null;
            val_4 = "index";
            goto label_5;
            label_2:
            val_3 = null;
            val_4 = "count";
            goto label_5;
            label_3:
            val_3 = null;
            val_4 = "index and count exceed length of list";
            label_5:
            val_3 = new System.ArgumentOutOfRangeException(paramName:  1916172464);
        }
        private void Shift(int start, int delta)
        {
            if(delta > start)
            {
                    delta = delta - start;
                System.Array.Copy(sourceArray:  1920307584, sourceIndex:  start = start - delta, destinationArray:  1920307584, destinationIndex:  start + delta, length:  delta);
            }
            
            mem[1152921510822121868] = this + delta;
            var val_3 = 0 - R5;
            var val_4 = FP - 8;
        }
        private void CheckIndex(int index)
        {
            var val_3 = 35648782;
            if(index >= 0)
            {
                    if(true >= index)
            {
                    return;
            }
            
            }
            
            System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException(paramName:  1348647200);
        }
        public void Insert(int index, T item)
        {
            bool val_2;
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            UnityEngine.Material val_7;
            var val_2 = __RuntimeMethodHiddenParam;
            val_2 = item.hasClipping;
            val_3 = item.rawFirstVertexIndex;
            val_4 = item.rawVertexCount;
            val_5 = item.rawTriangleCount;
            val_6 = item.preActiveClippingSlotSource;
            val_7 = item.material;
            if((__RuntimeMethodHiddenParam + 12) <= index)
            {
                    val_7 = val_7;
                val_6 = val_6;
                val_5 = item.rawTriangleCount;
                val_4 = item.rawVertexCount;
                val_3 = item.rawFirstVertexIndex;
                val_2 = item.hasClipping;
            }
            
            int val_1 = index + (index << 2);
            val_1 = val_2 + (val_1 << 3);
            val_2 = val_1 + 20;
            mem2[0] = item.skeleton;
            mem2[0] = item.forceSeparate;
            mem2[0] = val_6;
            mem2[0] = val_5;
            mem2[0] = val_4;
            mem2[0] = val_3;
            mem2[0] = val_2;
            val_1 = val_1 + 1;
            mem[1152921510822346896] = val_1;
        }
        private void CheckCollection(System.Collections.Generic.IEnumerable<T> collection)
        {
            if(collection != 0)
            {
                    return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  1920624704);
        }
        public void InsertRange(int index, System.Collections.Generic.IEnumerable<T> collection)
        {
            var val_1;
            System.Array val_2;
            val_1 = __RuntimeMethodHiddenParam;
            val_2 = collection;
            if(this == val_2)
            {
                goto label_2;
            }
            
            if(val_2 == 0)
            {
                goto label_5;
            }
            
            goto label_10;
            label_2:
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 16;
            System.Array.Copy(sourceArray:  val_2, sourceIndex:  0, destinationArray:  __RuntimeMethodHiddenParam + 12 + 96 + 120, destinationIndex:  index, length:  __RuntimeMethodHiddenParam + 12 + 96 + 16 + 12);
            goto label_10;
            label_5:
            label_10:
            mem[1152921510822584304] = 1152921510822584289;
        }
        private void InsertCollection(int index, System.Collections.Generic.ICollection<T> collection)
        {
            var val_3;
            var val_4;
            var val_6;
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = collection;
            if(this != 0)
            {
                
            }
            
            var val_4 = 0;
            val_3 = 0;
            val_4 = val_4 + 1;
            val_3 = (uint)val_4 & 65535;
            val_6 = collection;
            goto mem[(1152921504687144960 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void InsertEnumeration(int index, System.Collections.Generic.IEnumerable<T> enumerable)
        {
            var val_3;
            var val_6;
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.IEnumerable<T> val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 40];
            val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 40;
            var val_9 = 0;
            val_10 = 0;
            val_9 = val_9 + 1;
            val_10 = (uint)val_9 & 65535;
            val_11 = enumerable;
            val_12 = enumerable;
            goto label_7;
            label_20:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_13 = val_12;
            val_14 = val_3;
            val_9 = val_6;
            if(this == 0)
            {
                    val_14 = val_14;
            }
            
            val_12 = enumerable;
            int val_11 = index;
            val_11 = val_11 + 1;
            label_7:
            var val_12 = val_12;
            if((enumerable + 178) == 0)
            {
                goto label_16;
            }
            
            val_9 = 0;
            label_18:
            val_10 = 0;
            if((enumerable + 88 + 0) == null)
            {
                goto label_17;
            }
            
            val_9 = val_9 + 1;
            val_10 = (uint)val_9 & 65535;
            if(val_10 < (enumerable + 178))
            {
                goto label_18;
            }
            
            label_16:
            val_15 = val_12;
            goto label_19;
            label_17:
            var val_7 = (enumerable + 88) + 0;
            val_12 = val_12 + (((enumerable + 88 + 0) + 4) << 3);
            val_15 = val_12 + 188;
            label_19:
            if(val_12 != 0)
            {
                goto label_20;
            }
            
            if(val_12 == 0)
            {
                goto label_21;
            }
            
            var val_13 = val_12;
            if((enumerable + 178) == 0)
            {
                goto label_22;
            }
            
            val_9 = 0;
            label_24:
            val_10 = 0;
            if((enumerable + 88 + 0) == null)
            {
                goto label_23;
            }
            
            val_9 = val_9 + 1;
            val_10 = (uint)val_9 & 65535;
            if(val_10 < (enumerable + 178))
            {
                goto label_24;
            }
            
            label_22:
            val_16 = val_12;
            goto label_25;
            label_23:
            var val_8 = (enumerable + 88) + 0;
            val_13 = val_13 + (((enumerable + 88 + 0) + 4) << 3);
            val_16 = val_13 + 188;
            label_25:
            label_21:
            if(0 == 0)
            {
                    return;
            }
        
        }
        public int LastIndexOf(T item)
        {
            return (int)__RuntimeMethodHiddenParam + 12 + 96;
        }
        public int LastIndexOf(T item, int index)
        {
            int val_1 = index + 1;
            return (int)__RuntimeMethodHiddenParam + 12 + 96;
        }
        public int LastIndexOf(T item, int index, int count)
        {
            var val_3;
            System.ArgumentOutOfRangeException val_4;
            var val_5;
            var val_6;
            if(index <= 1)
            {
                goto label_1;
            }
            
            if(count <= 1)
            {
                goto label_2;
            }
            
            int val_1 = index + 1;
            val_1 = val_1 - count;
            if(val_1 <= 1)
            {
                goto label_3;
            }
            
            return (int)__RuntimeMethodHiddenParam + 12 + 96;
            label_1:
            val_3 = null;
            val_4 = null;
            val_5 = "index";
            val_6 = "index is negative";
            goto label_5;
            label_2:
            val_3 = null;
            val_4 = null;
            val_5 = "count";
            val_6 = "count is negative";
            goto label_5;
            label_3:
            val_3 = null;
            val_4 = null;
            val_5 = "count";
            val_6 = "count is too large";
            label_5:
            val_4 = new System.ArgumentOutOfRangeException(paramName:  1348647040, actualValue:  13152256, message:  1921326720);
        }
        public bool Remove(T item)
        {
            var val_1;
            int val_2;
            int val_3;
            int val_4;
            bool val_5;
            val_1 = item.endSlot;
            val_2 = item.rawVertexCount;
            val_3 = item.preActiveClippingSlotSource;
            if(this == 0)
            {
                    val_1 = val_1;
                val_3 = item.preActiveClippingSlotSource;
                val_2 = item.rawVertexCount;
                val_4 = item.rawFirstVertexIndex;
                val_5 = item.hasClipping;
            }
            
            if(this != 1)
            {
                    1152921510823278129 = 1;
            }
            
            return true;
        }
        public int RemoveAll(System.Predicate<T> match)
        {
            Spine.ExposedList<T> val_6;
            System.Predicate<T> val_7;
            var val_8;
            var val_9;
            var val_10;
            int val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            int val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_6 = this;
            val_7 = match;
            val_8 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_8 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_8 == 1)
            {
                    val_8 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_8 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            val_11 = 0;
            if(val_7 < 1)
            {
                goto label_11;
            }
            
            var val_9 = 28;
            label_10:
            if(val_7 == 0)
            {
                    val_15 = ???;
                val_13 = IP;
                val_12 = ???;
                val_9 = ???;
            }
            
            if(val_7 != 0)
            {
                goto label_9;
            }
            
            val_6 = val_6;
            val_9 = val_9 + 40;
            val_7 = val_7;
            val_10 = mem[1152921510823394236];
            val_11 = 1;
            if(val_11 < val_10)
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            val_6 = val_6;
            val_7 = val_7;
            val_11 = 0;
            val_10 = mem[1152921510823394236];
            label_11:
            val_18 = 0;
            if(val_11 == val_10)
            {
                    return val_18;
            }
            
            var val_10 = mem[1152921510823394240];
            val_16 = val_11 + 1;
            val_10 = val_10 + 1;
            mem[1152921510823394240] = val_10;
            if(val_16 < val_10)
            {
                    var val_2 = 92 + ((val_11 + 0) << 3);
                do
            {
                var val_3 = (mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3)) - 36;
                val_14 = mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3) + -16;
                val_20 = mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3) + -12;
                val_17 = mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3) + -8;
                if(val_7 == 0)
            {
                    val_19 = mem[(mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3) - 36) + (16)];
                val_20 = val_20;
            }
            
                if(val_7 != 0)
            {
                    val_6 = val_6;
                val_11 = val_11;
                val_21 = val_2;
            }
            else
            {
                    val_6 = val_6;
                val_21 = val_2;
                val_22 = mem[mem[1152921510823394232] + 12];
                val_22 = mem[1152921510823394232] + 12;
                if(val_22 <= val_16)
            {
                    val_22 = mem[mem[1152921510823394232] + 12];
                val_22 = mem[1152921510823394232] + 12;
            }
            
                val_17 = mem[mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3)];
                val_17 = mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3);
                var val_4 = (mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3)) - 20;
                var val_5 = (mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3)) - 36;
                val_14 = mem[1152921510823394232] + (92 + ((val_11 + 0)) << 3) + -4;
                var val_6 = val_11 + 0;
                val_6 = mem[1152921510823394232] + (val_6 << 3);
                val_11 = val_11 + 1;
                var val_8 = val_6 + 32;
                mem2[0] = val_14;
                val_6 = val_6 + 16;
                mem2[0] = val_17;
            }
            
                val_16 = val_16 + 1;
                val_21 = val_21 + 40;
            }
            while(val_16 < mem[1152921510823394236]);
            
            }
            
            val_18 = val_16 - val_11;
            if(val_18 >= 1)
            {
                    System.Array.Clear(array:  mem[1152921510823394232], index:  val_11, length:  val_18);
            }
            
            mem[1152921510823394236] = val_11;
            return val_18;
        }
        public void RemoveAt(int index)
        {
            if((index >= 0) && (true > index))
            {
                    System.Array.Clear(array:  1921697072, index:  index, length:  1);
                mem[1152921510823511360] = 1152921510823511345;
                return;
            }
            
            System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException(paramName:  1348647200);
        }
        public void RemoveRange(int index, int count)
        {
            var val_2 = __RuntimeMethodHiddenParam;
            if(count < 1)
            {
                    return;
            }
            
            int val_1 = 0 - count;
            System.Array.Clear(array:  1921809072, index:  index, length:  count);
            mem[1152921510823623360] = 1152921510823623345;
        }
        public void Reverse()
        {
            System.Array.Reverse(array:  1921921072, index:  0, length:  0);
            mem[1152921510823735360] = 1152921510823735345;
        }
        public void Reverse(int index, int count)
        {
            System.Array.Reverse(array:  1922033072, index:  index, length:  count);
            mem[1152921510823847360] = 1152921510823847345;
        }
        public void Sort()
        {
            var val_1 = R6;
            val_1 = val_1 + 1;
            mem[1152921510823959360] = val_1;
        }
        public void Sort(System.Collections.Generic.IComparer<T> comparer)
        {
            var val_1 = __RuntimeMethodHiddenParam + 12 + 96;
            val_1 = val_1 + 1;
            mem[1152921510824075456] = val_1;
        }
        public void Sort(System.Comparison<T> comparison)
        {
            var val_1 = __RuntimeMethodHiddenParam + 12 + 96;
            val_1 = val_1 + 1;
            mem[1152921510824195648] = val_1;
        }
        public void Sort(int index, int count, System.Collections.Generic.IComparer<T> comparer)
        {
            var val_1 = __RuntimeMethodHiddenParam + 12 + 96;
            val_1 = val_1 + 1;
            mem[1152921510824315840] = val_1;
        }
        public T[] ToArray()
        {
            System.Array.Copy(sourceArray:  __RuntimeMethodHiddenParam + 12 + 96 + 16, destinationArray:  __RuntimeMethodHiddenParam + 12 + 96 + 16, length:  0);
        }
        public void TrimExcess()
        {
            if(this == 0)
            {
                
            }
        
        }
        public bool TrueForAll(System.Predicate<T> match)
        {
            System.Predicate<T> val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            System.Predicate<T> val_6;
            var val_7;
            var val_8;
            val_1 = match;
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_2 == 1)
            {
                    val_1 = match;
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            if((val_2 & 512) == 0)
            {
                    if((__RuntimeMethodHiddenParam + 12 + 96 + 186) == 1)
            {
                    val_1 = match;
            }
            
                if((__RuntimeMethodHiddenParam + 12 + 96 + 116) == 0)
            {
                    val_1 = match;
            }
            
            }
            
            val_3 = 1;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 68) < 1)
            {
                    return (bool)val_3;
            }
            
            val_4 = 0;
            val_5 = 28;
            label_10:
            val_6 = match;
            val_7 = mem[SL + val_5 + 8];
            val_7 = SL + val_5 + 8;
            val_8 = mem[SL + val_5 + 12];
            val_8 = SL + val_5 + 12;
            if(val_6 == 0)
            {
                    val_8 = val_8;
                val_7 = val_7;
                val_6 = match;
            }
            
            if(val_6 == 0)
            {
                goto label_9;
            }
            
            val_4 = val_4 + 1;
            val_5 = val_5 + 40;
            if(val_4 < mem[1152921510824660028])
            {
                goto label_10;
            }
            
            val_3 = 1;
            return (bool)val_3;
            label_9:
            val_3 = 0;
            return (bool)val_3;
        }
        public int get_Capacity()
        {
            if(R4 != 0)
            {
                    return (int)R4 + 12;
            }
            
            return (int)R4 + 12;
        }
        public void set_Capacity(int value)
        {
            if(true <= value)
            {
                
            }
            else
            {
                    System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException();
            }
        
        }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
        
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
        
        }
        private static ExposedList<T>()
        {
            mem2[0] = __RuntimeMethodHiddenParam + 12 + 96 + 16;
        }
    
    }

}
