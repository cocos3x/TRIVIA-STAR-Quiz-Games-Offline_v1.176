using UnityEngine;
public class InstallRecapture : MonoSingleton<InstallRecapture>
{
    // Fields
    private bool isFeatureEnabled;
    private int levelThreshold;
    private string urlImage;
    private string message;
    private string urlStore;
    private bool notifBlasted;
    
    // Methods
    public override void InitMonoSingleton()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -239276224, name:  -1898880160);
    }
    private void OnServerSync()
    {
        var val_14;
        twelvegigs.storage.KnobsModel val_15;
        var val_16;
        var val_17;
        var val_14 = 24166111;
        val_14 = 11461304 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = mem[App.storageManager + 12];
        val_15 = App.storageManager.knobsModel;
        System.Collections.IDictionary val_1 = getInstallRecapture();
        if(val_15 == 0)
        {
                return;
        }
        
        val_15 = val_15;
        if(((mem[null + 100] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_15 = 0;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        label_13:
        if(0.MoveNext() == false)
        {
            goto label_12;
        }
        
        if((System.String.op_Inequality(a:  null, b:  -239188224)) == true)
        {
            goto label_13;
        }
        
        twelvegigs.storage.JsonDictionary val_6 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  R6);
        0.Dispose();
        if(null == 0)
        {
                return;
        }
        
        val_16 = 0;
        if((getBool(key:  -1386268656)) != false)
        {
                var val_15 = 24164011;
            val_15 = 11461776 + val_15;
            if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
            val_17 = null;
            val_17 = null;
            if(App.game == 17)
        {
                Player val_8 = App.Player;
            val_15 = 0;
            if(34483956 < 2)
        {
                val_16 = 1;
        }
        
        }
        
        }
        
        this.isFeatureEnabled = true;
        this.levelThreshold = getInt(key:  -1988561632, defaultValue:  0);
        string val_10 = getString(key:  -1852101328, defaultValue:  null);
        this.urlImage = null;
        string val_11 = getString(key:  1614311920, defaultValue:  1098586544);
        this.urlStore = null;
        string val_12 = getString(key:  1495692992, defaultValue:  1098586544);
        this.message = null;
        NotificationCenter val_13 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -239164128, name:  -1898880160);
        return;
        label_12:
        0.Dispose();
    }
    private void OnApplicationPause(bool pause)
    {
        if((InAppPurchasesManager.<inPurchaseIntent>k__BackingField) == true)
        {
                return;
        }
        
        if(pause == false)
        {
                return;
        }
        
        this.BlastRecaptureNotification();
    }
    public void OnApplicationQuit()
    {
        this.BlastRecaptureNotification();
    }
    private void BlastRecaptureNotification()
    {
        twelvegigs.plugins.NotificationInterval val_8;
        string val_9;
        var val_10;
        if(this.isFeatureEnabled == false)
        {
                return;
        }
        
        if(this.notifBlasted == true)
        {
                return;
        }
        
        Player val_1 = App.Player;
        if(0 > this.levelThreshold)
        {
                return;
        }
        
        val_9 = 11462744 + 24173795;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        if(TrackingComponent.currentIntent != 0)
        {
                return;
        }
        
        System.DateTime val_2 = System.DateTime.UtcNow;
        System.DateTime val_5 = AddSeconds(value:  null);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  1614311920, value:  this.urlStore);
        }
        else
        {
                Add(key:  1614311920, value:  this.urlStore);
        }
        
        Add(key:  -1953384384, value:  -238843936);
        val_9 = this.urlImage;
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotifWithImage(type:  14, when:  new System.DateTime() {dateData = twelvegigs.plugins.LocalNotificationsPlugin.__il2cppRuntimeField_cctor_finished}, interval:  val_8, title:  0, message:  0, extraData:  this.message, imageUrl:  null, priority:  val_9, useTimeModifier:  false);
        this.notifBlasted = true;
    }
    public InstallRecapture()
    {
    
    }

}
