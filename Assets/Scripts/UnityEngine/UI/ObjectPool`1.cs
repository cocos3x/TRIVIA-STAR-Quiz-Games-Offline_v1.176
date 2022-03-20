using UnityEngine;

namespace UnityEngine.UI
{
    internal class ObjectPool<T>
    {
        // Fields
        private readonly System.Collections.Generic.Stack<T> m_Stack;
        private readonly UnityEngine.Events.UnityAction<T> m_ActionOnGet;
        private readonly UnityEngine.Events.UnityAction<T> m_ActionOnRelease;
        private int <countAll>k__BackingField;
        
        // Properties
        public int countAll { get; set; }
        public int countActive { get; }
        public int countInactive { get; }
        
        // Methods
        public int get_countAll()
        {
            return (int)this;
        }
        private void set_countAll(int value)
        {
            mem[1152921514379803316] = value;
        }
        public int get_countActive()
        {
            if(this != 0)
            {
                    return (int)0;
            }
            
            return (int)0;
        }
        public int get_countInactive()
        {
            if(R4 == 0)
            {
                
            }
        
        }
        public ObjectPool<T>(UnityEngine.Events.UnityAction<T> actionOnGet, UnityEngine.Events.UnityAction<T> actionOnRelease)
        {
            mem[1152921514380147496] = __RuntimeMethodHiddenParam + 12 + 96 + 12;
            mem[1152921514380147500] = actionOnGet;
            mem[1152921514380147504] = actionOnRelease;
        }
        public T Get()
        {
            var val_1;
            if(R6 != 0)
            {
                    val_1 = R6;
            }
            else
            {
                    val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 20;
            }
            
            if(this == 0)
            {
                    return;
            }
        
        }
        public void Release(T element)
        {
            if((35667680 >= 1) && (35667680 == element))
            {
                    UnityEngine.Debug.LogError(message:  1183578208);
            }
            
            if(this == 0)
            {
                
            }
        
        }
    
    }

}
