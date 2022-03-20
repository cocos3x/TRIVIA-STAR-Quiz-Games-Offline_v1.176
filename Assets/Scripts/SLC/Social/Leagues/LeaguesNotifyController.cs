using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesNotifyController : LeaguesServerController
    {
        // Methods
        public void Notify(SLC.Social.Leagues.LeaguesNotifyType note)
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.PostNotification(aSender:  835363424, aName:  442544128);
        }
        public LeaguesNotifyController()
        {
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
