using UnityEngine;
public class ReturnGameGiftManager : MonoSingleton<ReturnGameGiftManager>
{
    // Fields
    private const string LASTPLAYEDTIMEKEY = "rrv_returngametime";
    private bool hackedNotifications;
    
    // Methods
    public override void InitMonoSingleton()
    {
        this.CheckReturnGameGiftReward();
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        pauseStatus = pauseStatus ^ 1;
        this.OnPauseGame(returnedToGame:  pauseStatus);
    }
    private void OnApplicationQuit()
    {
        this.OnPauseGame(returnedToGame:  false);
    }
    public static void Reset()
    {
        UnityEngine.PlayerPrefs.DeleteKey(key:  -211072048);
    }
    private void OnPauseGame(bool returnedToGame)
    {
        if(returnedToGame != false)
        {
                this.CheckReturnGameGiftReward();
            return;
        }
        
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        string val_2 = SLCDateTime.SerializeInvariant(dateTime:  new System.DateTime());
        UnityEngine.PlayerPrefs.SetString(key:  -210959936, value:  R0);
        this.ScheduleNotifications();
    }
    private void CheckReturnGameGiftReward()
    {
        this.KillNotifications();
        System.Collections.IEnumerator val_1 = this.CheckReturnGameGiftAvailable();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -210823824);
    }
    private System.Collections.IEnumerator CheckReturnGameGiftAvailable()
    {
        object val_1 = new System.Object();
        typeof(ReturnGameGiftManager.<CheckReturnGameGiftAvailable>d__8).__il2cppRuntimeField_8 = 0;
    }
    private void KillNotifications()
    {
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  32);
    }
    private void ScheduleNotifications()
    {
        var val_12;
        if(this.hackedNotifications == true)
        {
                return;
        }
        
        this.hackedNotifications.KillNotifications();
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if(null != 0)
        {
                Add(item:  16);
            Add(item:  24);
            Add(item:  48);
        }
        else
        {
                Add(item:  16);
            Add(item:  24);
            Add(item:  48);
        }
        
        Add(item:  168);
        val_12 = 4;
    }
    private string GetNotificationTitle()
    {
    
    }
    private string GetNotificationMessage(ReturnGameGiftReward reward)
    {
        var val_5;
        string val_1 = RestaurantRivals.RESGameEconHelper.GetAbbreviatedFormat(num:  new System.Decimal() {flags = mem[reward.<coins>k__BackingField + (0)], hi = mem[reward.<coins>k__BackingField + (4)], lo = mem[reward.<coins>k__BackingField + (8)], mid = mem[reward.<coins>k__BackingField + (12)]});
        int val_5 = reward.<tier>k__BackingField;
        val_5 = val_5 - 1;
        if(val_5 > 3)
        {
                return;
        }
        
        var val_2 = 9939352 + (9939352 + ((reward.<tier>k__BackingField - 1)) << 2);
        if(val_5 == 3)
        {
                9939352 + ((reward.<tier>k__BackingField - 1)) << 2 = (9939352 + ((reward.<tier>k__BackingField - 1)) << 2) & ((9939352 + ((reward.<tier>k__BackingField - 1)) << 2) << (9939352 + ((reward.<tier>k__BackingField - 1)) << 2));
            9939352 + ((reward.<tier>k__BackingField - 1)) << 2 = (9939352 + ((reward.<tier>k__BackingField - 1)) << 2) & ((IP) >> 32);
            9939352 + ((reward.<tier>k__BackingField - 1)) << 2 = (9939352 + ((reward.<tier>k__BackingField - 1)) << 2) & (((int)IP) >> ((9939352 + ((reward.<tier>k__BackingField - 1)) << 2 & (9939352 + ((reward.<tier>k__BackingField - 1)) << 2) << 9939352 + ((reward.<tier>k__BackingField - 1)) << 2) & (IP) >> 32));
            9939352 + ((reward.<tier>k__BackingField - 1)) << 2 = (9939352 + ((reward.<tier>k__BackingField - 1)) << 2) & ((9939352 + ((reward.<tier>k__BackingField - 1)) << 2) >> 1);
        }
        
        val_5 = "We just sent you {0} coins!";
        var val_4 = FP - 8;
    }
    private System.Collections.Generic.Dictionary<string, object> GetExtraData(int tier)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = System.String.Format(format:  -210167040, arg0:  13152256);
        Add(key:  -1953384384, value:  -210167040);
    }
    public void TestReturnGameGiftNotifications()
    {
        var val_13;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_14;
        twelvegigs.plugins.NotificationPriority val_15;
        var val_16;
        var val_17;
        var val_19;
        this.hackedNotifications = true;
        this.KillNotifications();
        val_13 = 1152921504687730688;
        System.Collections.Generic.List<System.Int32> val_1 = null;
        val_14 = 1152921510253141440;
        val_1 = new System.Collections.Generic.List<System.Int32>();
        if(val_1 != 0)
        {
                Add(item:  16);
            Add(item:  24);
            Add(item:  48);
        }
        else
        {
                Add(item:  16);
            Add(item:  24);
            Add(item:  48);
        }
        
        val_15 = 1152921510720759024;
        Add(item:  168);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  15);
            Add(item:  30);
            Add(item:  45);
        }
        else
        {
                Add(item:  15);
            Add(item:  30);
            Add(item:  45);
        }
        
        Add(item:  60);
        val_16 = 4;
        val_17 = 0;
        val_19 = val_1;
        var val_13 =  - 4;
        if(val_19 != 0)
        {
                return;
        }
        
        val_19 = val_1;
    }
    public void TestReturnGameGiftNotifications2()
    {
        var val_13;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_14;
        twelvegigs.plugins.NotificationPriority val_15;
        var val_16;
        var val_17;
        var val_19;
        this.hackedNotifications = true;
        this.KillNotifications();
        val_13 = 1152921504687730688;
        System.Collections.Generic.List<System.Int32> val_1 = null;
        val_14 = 1152921510253141440;
        val_1 = new System.Collections.Generic.List<System.Int32>();
        if(val_1 != 0)
        {
                Add(item:  16);
            Add(item:  24);
            Add(item:  48);
        }
        else
        {
                Add(item:  16);
            Add(item:  24);
            Add(item:  48);
        }
        
        val_15 = 1152921510720759024;
        Add(item:  168);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  1);
            Add(item:  2);
            Add(item:  3);
        }
        else
        {
                Add(item:  1);
            Add(item:  2);
            Add(item:  3);
        }
        
        val_16 = 4;
        Add(item:  4);
        val_17 = 0;
        val_19 = val_1;
        var val_13 =  - 4;
        if(val_19 != 0)
        {
                return;
        }
        
        val_19 = val_1;
    }
    public void TestReturnGameGiftNotifications3()
    {
        var val_13;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_14;
        twelvegigs.plugins.NotificationPriority val_15;
        var val_16;
        var val_17;
        var val_19;
        this.hackedNotifications = true;
        this.KillNotifications();
        val_13 = 1152921504687730688;
        System.Collections.Generic.List<System.Int32> val_1 = null;
        val_14 = 1152921510253141440;
        val_1 = new System.Collections.Generic.List<System.Int32>();
        if(val_1 != 0)
        {
                Add(item:  16);
            Add(item:  24);
            Add(item:  48);
        }
        else
        {
                Add(item:  16);
            Add(item:  24);
            Add(item:  48);
        }
        
        val_15 = 1152921510720759024;
        Add(item:  168);
        if((new System.Collections.Generic.List<System.Int32>()) != 0)
        {
                Add(item:  5);
            Add(item:  10);
            Add(item:  15);
        }
        else
        {
                Add(item:  5);
            Add(item:  10);
            Add(item:  15);
        }
        
        Add(item:  20);
        val_16 = 4;
        val_17 = 0;
        val_19 = val_1;
        var val_13 =  - 4;
        if(val_19 != 0)
        {
                return;
        }
        
        val_19 = val_1;
    }
    public void ClearHacks()
    {
        this.KillNotifications();
        this.hackedNotifications = false;
    }
    public ReturnGameGiftManager()
    {
    
    }

}
