using UnityEngine;

namespace UnityEngine.UI
{
    public class LoopScrollArraySource<T> : LoopScrollDataSource
    {
        // Fields
        private T[] objectsToFill;
        
        // Methods
        public LoopScrollArraySource<T>(T[] objectsToFill)
        {
            mem[1152921514363204008] = objectsToFill;
        }
        public override void ProvideData(UnityEngine.Transform transform, int idx)
        {
            UnityEngine.UI.LoopScrollArraySource<T> val_1 = this + (idx << 2);
            transform.SendMessage(methodName:  1166551392, value:  idx);
        }
    
    }

}
