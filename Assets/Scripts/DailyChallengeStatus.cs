using UnityEngine;
public class DailyChallengeStatus : Progression
{
    // Fields
    private const string pref_oa_date = "DailyChallengeOADate";
    public int playingMonth;
    public int playingDay;
    public bool playingDayMorning;
    public bool playingPersistentLevel;
    public int todayOnCalendar;
    public DailyChallengeLastPlayedLevel lastPlayedLevel;
    public double oa_date;
    private int today;
    private int thisMonth;
    
    // Methods
    public DailyChallengeStatus(bool isMorning)
    {
        var val_2;
        System.DateTime val_1 = DateTimeCheat.Now;
        this.today = val_2.Day;
        System.DateTime val_5 = DateTimeCheat.Now;
        this.thisMonth = ???.Month;
        this.playingDayMorning = true;
        this.playingPersistentLevel = false;
        this.todayOnCalendar = this.today;
        this.playingMonth = this.thisMonth;
        this.oa_date = 0;
        mem[1152921512846899332] = 0;
        this.lastPlayedLevel = new DailyChallengeLastPlayedLevel(isMorning:  isMorning);
    }
    public override void Load()
    {
        double val_5;
        if(this.playingDay != this.today)
        {
                return;
        }
        
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -349790176, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -349790176)) != true)
        {
                string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -349790176, defaultValue:  1098586544);
            double val_4 = System.Convert.ToDouble(value:  -349790176);
            val_5 = 3945177120;
        }
        
        this.oa_date = val_5;
    }
    public override void Save()
    {
        if(this.playingDay != this.today)
        {
                return;
        }
        
        string val_1 = R4 + 32;
        string val_2 = val_1.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -349790176, value:  val_1);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
