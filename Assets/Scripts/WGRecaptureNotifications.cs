using UnityEngine;
public class WGRecaptureNotifications : MonoBehaviour
{
    // Fields
    private const string SENT_NOTIF = "wg_recapture_installed_sent_notif";
    public static System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> recaptureNotifications;
    private System.Collections.Generic.List<int> sentNotif;
    private System.DateTime lastPause;
    
    // Methods
    private void Awake()
    {
        var val_7;
        int val_8;
        var val_9;
        var val_10;
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_7 = 0;
        if(0.CompanyDevice() != false)
        {
                string val_4 = WGRecaptureNotifications.IsFirstDay().ToString();
            val_8;
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_8;
            UnityEngine.Debug.LogFormat(format:  -234750736, args:  472754880);
        }
        
        string val_5 = UnityEngine.PlayerPrefs.GetString(key:  -234750560, defaultValue:  -2141227328);
        object val_6 = MiniJSON.Json.Deserialize(json:  -234750560);
        if("wg_recapture_installed_sent_notif" != 0)
        {
                if(null != null)
        {
                "wg_recapture_installed_sent_notif" = 0;
        }
        
            val_7 = "wg_recapture_installed_sent_notif";
        }
        
        val_10 = 0;
        goto label_15;
        label_21:
        if("wg_recapture_installed_sent_notif" <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = 0;
        val_7 = val_7 + 0;
        val_8 = mem[(0 + 0) + 16];
        val_8 = (0 + 0) + 16;
        val_9 = null;
        val_8.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem[1152921512962055164].Add(item:  val_8);
        val_10 = 1;
        label_15:
        if(val_10 < 0)
        {
            goto label_21;
        }
    
    }
    private void OnApplicationPause(bool pause)
    {
    
    }
    public static bool IsFirstDay()
    {
        ulong val_4;
        ulong val_6;
        Player val_1 = App.Player;
        System.DateTime val_2 = AddDays(value:  null);
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_6}, t2:  new System.DateTime() {dateData = val_4});
    }
    public void OnApplicationQuit()
    {
    
    }
    public void BlastRecaptureNotification()
    {
    
    }
    public int GetRandonNotif()
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = 0;
        goto label_1;
        label_7:
        if((new System.Collections.Generic.List<System.Int32>().CanShowNotif(type:  0)) != false)
        {
                Add(item:  0);
        }
        
        val_9 = 1;
        label_1:
        val_10 = null;
        val_10 = null;
        if(val_9 < (WGRecaptureNotifications.recaptureNotifications + 12))
        {
            goto label_7;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Except<System.Int32>(first:  80883712, second:  this.sentNotif);
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Int32>(source:  80883712);
        int val_5 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_11 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16];
        val_11 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16;
        return (int);
    }
    private bool CanShowNotif(WGRecaptureNotifications.RecaptureType type)
    {
        var val_17;
        if(type <= 4)
        {
                var val_1 = 6945496 + (6945496 + (type) << 2);
            if(type == 4)
        {
                6945496 = 6945496 & (type >> 32);
            6945496 = 6945496 & (((IP) << (32-1)) | ((IP) << 1));
            6945496 = 6945496 & (type << 6945496);
            6945496 = 6945496 & (type << 6945496);
            6945496 = 6945496 & (((int)R8) >> R2);
        }
        
            val_17 = 1;
            return true;
        }
        
        val_17 = 0;
        return true;
    }
    public WGRecaptureNotifications()
    {
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        this.sentNotif = null;
        System.DateTime val_2 = System.DateTime.UtcNow;
        this.lastPause = new System.DateTime();
    }
    private static WGRecaptureNotifications()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_2 != 0)
        {
                Add(key:  1610240272, value:  -233820624);
        }
        else
        {
                Add(key:  1610240272, value:  -233820624);
        }
        
        Add(key:  1638199008, value:  -233820512);
        if(val_2 != 0)
        {
                Add(key:  -233820272, value:  -233820384);
        }
        else
        {
                Add(key:  -233820272, value:  -233820384);
        }
        
        Add(key:  -1953384464, value:  1788750208);
        Add(item:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_3 != 0)
        {
                Add(key:  1610240272, value:  -233820192);
        }
        else
        {
                Add(key:  1610240272, value:  -233820192);
        }
        
        Add(key:  1638199008, value:  -233820080);
        if(val_3 != 0)
        {
                Add(key:  -233820272, value:  -233819920);
        }
        else
        {
                Add(key:  -233820272, value:  -233819920);
        }
        
        Add(key:  -1953384464, value:  -1486103232);
        Add(item:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_4 != 0)
        {
                Add(key:  1610240272, value:  -233819792);
        }
        else
        {
                Add(key:  1610240272, value:  -233819792);
        }
        
        Add(key:  1638199008, value:  -233819680);
        if(val_4 != 0)
        {
                Add(key:  -233820272, value:  -233819552);
        }
        else
        {
                Add(key:  -233820272, value:  -233819552);
        }
        
        Add(key:  -1953384464, value:  -233819456);
        Add(item:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_5 != 0)
        {
                Add(key:  1610240272, value:  -233819376);
        }
        else
        {
                Add(key:  1610240272, value:  -233819376);
        }
        
        Add(key:  1638199008, value:  -233819280);
        if(val_5 != 0)
        {
                Add(key:  -233820272, value:  -233819152);
        }
        else
        {
                Add(key:  -233820272, value:  -233819152);
        }
        
        Add(key:  -1953384464, value:  -233819456);
        Add(item:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_6 != 0)
        {
                Add(key:  1610240272, value:  -233819040);
        }
        else
        {
                Add(key:  1610240272, value:  -233819040);
        }
        
        Add(key:  1638199008, value:  -233818944);
        if(val_6 != 0)
        {
                Add(key:  -233820272, value:  -233818816);
        }
        else
        {
                Add(key:  -233820272, value:  -233818816);
        }
        
        Add(key:  -1953384464, value:  -233819456);
        Add(item:  78753792);
        WGRecaptureNotifications.recaptureNotifications = null;
    }

}
