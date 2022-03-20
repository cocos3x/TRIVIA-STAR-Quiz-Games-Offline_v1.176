using UnityEngine;
private sealed class RESRevengePopup.<>c__DisplayClass7_0
{
    // Fields
    public RestaurantRivals.UserRestaurantProfile targetRestaurant;
    
    // Methods
    public RESRevengePopup.<>c__DisplayClass7_0()
    {
    
    }
    internal void <OnItemRevengeClicked>b__1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowUserRestaurant(targetRestaurant:  this.targetRestaurant, opponType:  1);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.IEnumerator val_4 = ShowAttackSpots(delay:  null);
        UnityEngine.Coroutine val_5 = StartCoroutine(routine:  519134400);
    }

}
