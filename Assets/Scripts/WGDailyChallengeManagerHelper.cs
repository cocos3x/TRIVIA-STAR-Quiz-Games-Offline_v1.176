using UnityEngine;
public class WGDailyChallengeManagerHelper
{
    // Fields
    private const int MORNING_MIN_HOUR = 0;
    private const int MORNING_MAX_HOUR = 12;
    private const int EVENING_MIN_HOUR = 12;
    private const int EVENING_MAX_HOUR = 24;
    
    // Methods
    public static System.TimeSpan GetTimeSpanToNextChallenge()
    {
        var val_5;
        var val_6;
        var val_9;
        var val_10;
        var val_13;
        var val_14;
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == false)
        {
            goto label_1;
        }
        
        System.DateTime val_2 = WGDailyChallengeManagerHelper.MorningBeginTime();
        goto label_2;
        label_1:
        if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
            goto label_3;
        }
        
        System.DateTime val_4 = WGDailyChallengeManagerHelper.EveningBeginTime();
        label_2:
        val_13 = val_5;
        val_14 = val_6;
        goto label_4;
        label_3:
        System.DateTime val_7 = WGDailyChallengeManagerHelper.EveningEndTime();
        System.DateTime val_8 = AddHours(value:  null);
        val_13 = val_9;
        val_14 = val_10;
        label_4:
        System.DateTime val_11 = DateTimeCheat.Now;
        System.TimeSpan val_12 = 0.Subtract(value:  new System.DateTime() {dateData = 1152921513123133432});
        return new System.TimeSpan() {_ticks = val_12._ticks};
    }
    private static System.DateTime MorningBeginTime()
    {
        System.DateTime val_1 = DateTimeCheat.Today;
        System.DateTime val_4 = 0.AddHours(value:  null);
        return new System.DateTime() {dateData = val_4.dateData};
    }
    public static bool MorningChallengeAvailableNow()
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        if((???.Hour) < 0)
        {
                return true;
        }
        
        System.DateTime val_3 = DateTimeCheat.Now;
        if((???.Hour) < 12)
        {
                0 = 1;
        }
        
        return true;
    }
    private static System.DateTime EveningBeginTime()
    {
        System.DateTime val_1 = DateTimeCheat.Today;
        System.DateTime val_4 = 0.AddHours(value:  null);
        return new System.DateTime() {dateData = val_4.dateData};
    }
    private static System.DateTime EveningEndTime()
    {
        System.DateTime val_1 = DateTimeCheat.Today;
        System.DateTime val_4 = 0.AddHours(value:  null);
        return new System.DateTime() {dateData = val_4.dateData};
    }
    public static bool EveningChallengeAvailableNow()
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        if((???.Hour) < 12)
        {
                return true;
        }
        
        System.DateTime val_3 = DateTimeCheat.Now;
        if((???.Hour) < 24)
        {
                0 = 1;
        }
        
        return true;
    }
    public static string GetLocMorningChallenge()
    {
        return Localization.Localize(key:  -72988000, defaultValue:  -72988112, useSingularKey:  false);
    }
    public static string GetLocEveningChallenge()
    {
        return Localization.Localize(key:  -72875760, defaultValue:  -72875872, useSingularKey:  false);
    }
    public WGDailyChallengeManagerHelper()
    {
    
    }

}
