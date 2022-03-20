using UnityEngine;
public abstract class UGUILocalizeComponent : MonoBehaviour
{
    // Fields
    public string key;
    public string[] keyParams;
    public bool localizeKeyParams;
    public bool isTitle;
    protected string mLanguage;
    protected bool mStarted;
    private bool hasFormattedUnlocalizedText;
    
    // Methods
    private void OnLocalize()
    {
        var val_6;
        var val_5 = 28223731;
        val_5 = 7403692 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        if(Localization.GAME_NAME == 0)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        val_6 = 0;
        string val_3 = val_6.GetCurrentLanguage();
        if((System.String.op_Inequality(a:  this.mLanguage, b:  null)) == false)
        {
                return;
        }
        
        goto typeof(UGUILocalizeComponent).__il2cppRuntimeField_DC;
    }
    private void OnEnable()
    {
        if(this.mStarted == false)
        {
                return;
        }
        
        if(Localization.GAME_NAME == 0)
        {
                return;
        }
        
        goto R4 + 220;
    }
    private void Awake()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1999694016, name:  1799422256);
    }
    private void Start()
    {
        bool val_3;
        var val_2 = 28222947;
        val_3 = true;
        this.mStarted = val_3;
        val_2 = 7404476 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = val_3;
        }
        
        if(Localization.GAME_NAME == 0)
        {
                return;
        }
        
        goto typeof(UGUILocalizeComponent).__il2cppRuntimeField_DC;
    }
    public virtual void Localize()
    {
        var val_17 = 28222715;
        val_17 = 7404708 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        this.mLanguage = Localization.GAME_NAME + 40;
        if((System.String.IsNullOrEmpty(value:  Localization.GAME_NAME + 40)) != false)
        {
                if((System.String.IsNullOrEmpty(value:  this.key)) != false)
        {
                this.key = this;
        }
        
        }
        
        string val_3 = this.getLocalizedValue(k:  this.key);
        if(this == 0)
        {
            goto label_5;
        }
        
        if(this.isTitle == false)
        {
            goto label_6;
        }
        
        GameEcon val_4 = App.getGameEcon;
        string val_5 = 0.titleFormat;
        string val_6 = System.String.Format(format:  null, arg0:  -1999351232);
        goto label_10;
        label_5:
        if((this.isTitle == false) || (this.hasFormattedUnlocalizedText == true))
        {
            goto label_17;
        }
        
        GameEcon val_7 = App.getGameEcon;
        string val_8 = 0.titleFormat;
        string val_9 = System.String.Format(format:  null, arg0:  -1999351232);
        this.hasFormattedUnlocalizedText = true;
        goto label_17;
        label_6:
        label_10:
        label_17:
        if(UnityEngine.Application.isPlaying != false)
        {
                return;
        }
        
        UnityEngine.GameObject val_11 = this.gameObject;
        this.SetActive(value:  false);
        UnityEngine.GameObject val_12 = this.gameObject;
        this.SetActive(value:  true);
    }
    protected abstract string getCurrentText(); // 0
    public abstract void updateLabel(string val); // 0
    private string getLocalizedValue(string k)
    {
        string val_8;
        var val_9;
        var val_10;
        string val_12;
        System.String[] val_13;
        val_8 = this;
        var val_8 = 28221835;
        val_8 = 7405588 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        bool val_1 = System.String.IsNullOrEmpty(value:  k);
        val_9 = "";
        string val_2 = Localization.GAME_NAME.Get(key:  k, defaultValue:  1098586544, useSingularKey:  false);
        if((System.String.op_Equality(a:  Localization.GAME_NAME, b:  k)) != false)
        {
                return;
        }
        
        if(k == null)
        {
                string val_4 = Localization.GAME_NAME.Get(key:  k, defaultValue:  1098586544, useSingularKey:  false);
            return;
        }
        
        if(this.localizeKeyParams != false)
        {
                val_9 = null;
            System.Array.Copy(sourceArray:  this.keyParams, destinationArray:  477709520, length:  0);
            val_10 = 0;
            val_12 = Localization.GAME_NAME;
            string val_6 = val_12.Get(key:  k, defaultValue:  1098586544, useSingularKey:  false);
            val_13 = val_9;
            return System.String.Format(format:  val_12 = Localization.GAME_NAME, args:  val_13 = this.keyParams);
        }
        
        string val_7 = val_12.Get(key:  k, defaultValue:  1098586544, useSingularKey:  false);
        return System.String.Format(format:  val_12, args:  val_13);
    }
    protected UGUILocalizeComponent()
    {
    
    }

}
