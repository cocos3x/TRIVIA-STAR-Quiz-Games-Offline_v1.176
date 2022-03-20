using UnityEngine;

namespace RestaurantRivals
{
    public abstract class ARESUIController : MonoBehaviour
    {
        // Methods
        protected virtual void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  513219728, name:  -1275408672);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  513219728, name:  -1275408576);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  513219728, name:  -1275408480);
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  513219728, name:  -1275408384);
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  513219728, name:  -1275408272);
            NotificationCenter val_6 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  513219728, name:  -1275408160);
            NotificationCenter val_7 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  513219728, name:  -843944304);
        }
        protected virtual void OnSpinStarted()
        {
        
        }
        protected virtual void OnSpinEnded()
        {
        
        }
        protected virtual void OnReelStopped(Notification notif)
        {
        
        }
        protected virtual void OnAllReelsStopped()
        {
        
        }
        protected virtual void OnSpinAmountUpdate()
        {
        
        }
        protected virtual void OnSpinBetUpdate()
        {
        
        }
        protected virtual void OnLevelUp()
        {
        
        }
        protected virtual void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  514123920, name:  -1275408672);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  514123920, name:  -1275408576);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  514123920, name:  -1275408480);
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  514123920, name:  -1275408384);
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  514123920, name:  -1275408272);
            NotificationCenter val_6 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  514123920, name:  -1275408160);
            NotificationCenter val_7 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  514123920, name:  -843944304);
        }
        protected ARESUIController()
        {
        
        }
    
    }

}
