using UnityEngine;
public class MinigamesAdsController : MonoSingleton<MinigamesAdsController>
{
    // Methods
    public override void InitMonoSingleton()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1745505968, method:  new IntPtr(2549436304));
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_30 = null;
    }
    public bool ShowIncentivizedVideo(HeyZapAdTag heyZapAdTag)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance()) != 0)
        {
                return ShowVideo(heyZapAdTag:  heyZapAdTag);
        }
        
        return ShowVideo(heyZapAdTag:  heyZapAdTag);
    }
    public void OnVideoAdWatched(bool success)
    {
        if(success != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AdWatched();
        }
        
        System.Collections.Hashtable val_2 = new System.Collections.Hashtable();
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1745272752, aName:  2128120864, aData:  75878400);
    }
    public MinigamesAdsController()
    {
    
    }

}
