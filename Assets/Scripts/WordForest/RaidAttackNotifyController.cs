using UnityEngine;

namespace WordForest
{
    public class RaidAttackNotifyController : MonoBehaviour
    {
        // Methods
        public void Notify(WordForest.RaidAttackNotifyType note, System.Collections.Hashtable data)
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.PostNotification(aSender:  259518496, aName:  404738048, aData:  data);
        }
        public RaidAttackNotifyController()
        {
        
        }
    
    }

}
