using UnityEngine;
public class SetLangugeFromOS : MonoBehaviour
{
    // Fields
    public bool disableLanguageSelection;
    public bool active;
    private Localization localization;
    private string previousLanguage;
    private static System.Collections.Generic.List<string> unlocalizedInWeb;
    
    // Methods
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.localization = this;
        if(this.disableLanguageSelection == true)
        {
                this = false;
            this.active = this;
        }
        
        if(this.SetupLanguage() == true)
        {
                return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        R4 + 16.setLocalizedCurrency(currencyKey:  null);
    }
    private void SetLanguage(string useLanguage)
    {
        UnityEngine.PlayerPrefs.SetString(key:  1798542544, value:  useLanguage);
        this.localization.startingLanguage = useLanguage;
        this.localization.currentLanguage = useLanguage;
        AppConfigs val_1 = App.Configuration;
        Localization.SetGameName(gameName:  null);
        GameBehavior val_2 = App.getBehavior;
        this.localization.setLocalizedCurrency(currencyKey:  null);
    }
    private bool SetupLanguage()
    {
        var val_8 = 0;
        if((UnityEngine.PlayerPrefs.GetInt(key:  -1845445440, defaultValue:  0)) > 0)
        {
                return (bool)val_8;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.localization)) != true)
        {
                UnityEngine.GameObject val_3 = this.gameObject;
            object val_4 = this.GetComponent<System.Object>();
            this.localization = this;
        }
        
        val_8 = 0;
        string val_5 = DeviceProperties.LocaleFromDevice;
        string val_6 = this.checkIfLanguageExists(deviceLanguage:  null);
        if(0 != 0)
        {
                "en" = 0;
        }
        
        if(("en".Equals(value:  this.previousLanguage)) == true)
        {
                return (bool)val_8;
        }
        
        this.previousLanguage = "en";
        this.SetLanguage(useLanguage:  null);
        val_8 = 1;
        return (bool)val_8;
    }
    private string checkIfLanguageExists(string deviceLanguage)
    {
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_9;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_10;
        object val_1 = new System.Object();
        typeof(SetLangugeFromOS.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = deviceLanguage;
        GameBehavior val_2 = App.getBehavior;
        val_9 = null;
        val_9 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  290521088, method:  new IntPtr(2449654464));
        object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  0, predicate:  7720960);
        if(0 != 0)
        {
                return;
        }
        
        val_9 = 0;
        val_10 = null;
        val_10 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  290521088, method:  new IntPtr(2449656512));
        object val_6 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  0, predicate:  7720960);
        if(0 != 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  290521088, method:  new IntPtr(2449657536));
        object val_8 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  0, predicate:  7720960);
        if(0 == 0)
        {
                0 = val_9;
        }
    
    }
    private void OnApplicationPause(bool pause)
    {
        if(pause == true)
        {
                return;
        }
        
        if(this.active == false)
        {
                return;
        }
        
        bool val_1 = this.SetupLanguage();
    }
    public SetLangugeFromOS()
    {
        this.disableLanguageSelection = true;
        this.active = true;
        this.previousLanguage = "";
    }
    private static SetLangugeFromOS()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  -1844968640);
        }
        else
        {
                Add(item:  -1844968640);
        }
        
        Add(item:  -1844968560);
        if(null != 0)
        {
                Add(item:  -1844968480);
        }
        else
        {
                Add(item:  -1844968480);
        }
        
        Add(item:  -1844968400);
        if(null != 0)
        {
                Add(item:  -1844968320);
        }
        else
        {
                Add(item:  -1844968320);
        }
        
        Add(item:  -1844968240);
        SetLangugeFromOS.unlocalizedInWeb = null;
    }

}
