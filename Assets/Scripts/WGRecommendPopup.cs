using UnityEngine;
public class WGRecommendPopup : MonoBehaviour
{
    // Fields
    private const string RF_SHOWN_TIMES_KEY = "rf_shown";
    private const string RF_LAST_SHOWN_DATE_KEY = "rf_lastShown";
    public const int DEFAULT_RF_SHOWN_TIMES = -1;
    private const string DEFAULT_LAST_SHOWN_TIME;
    
    // Properties
    public static int ShownTimes { get; set; }
    public static string LastShownDate { get; set; }
    
    // Methods
    public static int get_ShownTimes()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  32261104, defaultValue:  0);
    }
    public static void set_ShownTimes(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  32261104, value:  value);
    }
    public static string get_LastShownDate()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  32485200, defaultValue:  null);
    }
    public static void set_LastShownDate(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  32485200, value:  value);
    }
    public static void ResetRFLogic()
    {
        WGRecommendPopup.ShownTimes = 0;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        string val_2 = ???.ToShortDateString();
        WGRecommendPopup.LastShownDate = 32729464;
    }
    public WGRecommendPopup()
    {
    
    }

}
