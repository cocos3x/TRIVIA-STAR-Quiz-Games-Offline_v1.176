using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenAnimationExtensions
    {
        // Methods
        public static bool IsSameOrSubclassOf<T>(UnityEngine.Component t)
        {
            if(t != 0)
            {
                    t = 1;
            }
            
            return true;
        }
    
    }

}
