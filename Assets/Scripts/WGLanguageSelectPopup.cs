using UnityEngine;
public class WGLanguageSelectPopup : MonoBehaviour
{
    // Fields
    private LanguageSelectToggle _toggleButtonPrefab;
    private UnityEngine.UI.ToggleGroup togglesParent;
    private System.Collections.Generic.List<UnityEngine.Sprite> flags;
    private UnityEngine.GameObject bottom_confirm_group;
    private UnityEngine.UI.Button button_confirm;
    private UnityEngine.UI.Button button_close;
    private UnityEngine.GameObject main_vertical_group;
    private System.Collections.Generic.List<UnityEngine.UI.Toggle> toggleButtons;
    private System.Collections.Generic.List<LanguageSelectToggle> languageSelections;
    private System.Collections.Generic.List<string> languageNames;
    private bool hasInitialized;
    private string useLanguage;
    private System.Collections.Generic.Dictionary<string, string> defaultLanguageNames;
    
    // Properties
    private LanguageSelectToggle toggleButtonPrefab { get; }
    
    // Methods
    private LanguageSelectToggle get_toggleButtonPrefab()
    {
        if(this._toggleButtonPrefab != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -6024736);
        this._toggleButtonPrefab = "LanguageSelect";
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = null;
        val_11 = new UnityEngine.Events.UnityAction(object:  -5825152, method:  new IntPtr(4289075136));
        this.button_close.m_OnClick.AddListener(call:  162246656);
        LanguageSelectToggle val_2 = this.toggleButtonPrefab;
        if((-5825152) == 0)
        {
                return;
        }
        
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -5825152, name:  -134211440);
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -5825152, name:  1799422256);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -5825152, method:  new IntPtr(4289084352));
        this.button_confirm.m_OnClick.AddListener(call:  162246656);
        this.main_vertical_group.SetActive(value:  false);
        System.Collections.Generic.List<System.String> val_7 = Localization.GetLanguageNames();
        this.languageNames = 0;
        if(0 != 1)
        {
            goto label_14;
        }
        
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Sprite val_8 = this.GetFlagSpriteByIndex(index:  0);
        this.GenerateToggleableButton(language:  2621443, isSolo:  true, flag:  -5825152);
        val_12 = 0;
        goto label_18;
        label_14:
        val_13 = 0;
        goto label_19;
        label_23:
        if(0 <= val_13)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + 0;
        UnityEngine.Sprite val_9 = this.GetFlagSpriteByIndex(index:  0);
        this.GenerateToggleableButton(language:  (0 + 0) + 16, isSolo:  false, flag:  -5825152);
        val_13 = 1;
        label_19:
        if(val_13 < this)
        {
            goto label_23;
        }
        
        val_12 = 1;
        label_18:
        this.bottom_confirm_group.SetActive(value:  true);
        this.main_vertical_group.SetActive(value:  true);
        val_14 = 0;
        UnityEngine.Transform val_10 = this.main_vertical_group.transform;
        val_11 = this.main_vertical_group;
        if(val_11 != 0)
        {
                if(null != null)
        {
                val_11 = 0;
        }
        
            val_14 = val_11;
        }
        
        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  0);
        this.hasInitialized = true;
    }
    private UnityEngine.Sprite GetFlagSpriteByIndex(int index)
    {
        if(this.flags == 0)
        {
                return;
        }
        
        if(index <= index)
        {
                return;
        }
        
        if(index <= index)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (index << 2);
    }
    private void GenerateToggleableButton(string language, bool isSolo, UnityEngine.Sprite flag)
    {
        if(flag == 0)
        {
                return;
        }
        
        LanguageSelectToggle val_2 = this.toggleButtonPrefab;
        UnityEngine.Transform val_3 = this.togglesParent.transform;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  -5498752, parent:  this.togglesParent);
        string val_5 = this.FormatNameToKey(fileName:  language);
        string val_6 = this.FormatNameToKey(fileName:  language);
        string val_7 = this.defaultLanguageNames.Item[-5498752];
        string val_8 = Localization.Localize(key:  -5498752, defaultValue:  this.defaultLanguageNames, useSingularKey:  false);
        if(this != 0)
        {
                this.Setup(locLanguage:  -5498752, isSolo:  (this.languageNames - 1) >> 5, flag:  flag);
        }
        else
        {
                this.Setup(locLanguage:  -5498752, isSolo:  (this.languageNames - 1) >> 5, flag:  flag);
        }
        
        if(this._toggleButtonPrefab != 0)
        {
                this._toggleButtonPrefab.name = language;
            this._toggleButtonPrefab.group = this.togglesParent;
        }
        else
        {
                0.name = language;
            0.group = this.togglesParent;
        }
        
        UnityEngine.Events.UnityAction<System.Boolean> val_13 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  -5498752, method:  new IntPtr(4289433280));
        this.AddListener(call:  162353152);
        if(isSolo == true)
        {
            goto label_14;
        }
        
        GameBehavior val_14 = App.getBehavior;
        string val_15 = 0.GetCurrentLanguage();
        if((System.String.op_Equality(a:  language, b:  null)) == false)
        {
            goto label_19;
        }
        
        label_14:
        this._toggleButtonPrefab.isOn = true;
        this.useLanguage = language;
        goto label_20;
        label_19:
        this._toggleButtonPrefab.isOn = false;
        label_20:
        this.toggleButtons.Add(item:  this._toggleButtonPrefab);
        this.languageSelections.Add(item:  -5498752);
    }
    private string FormatNameToKey(string fileName)
    {
        return System.String.Format(format:  -5365696, arg0:  fileName);
    }
    private void OnLocalize()
    {
        goto label_1;
        label_12:
        if(true <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_1 = this.FormatNameToKey(fileName:  2621443);
        if(0 <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_2 = this.FormatNameToKey(fileName:  2621443);
        string val_3 = this.defaultLanguageNames.Item[null];
        string val_4 = Localization.Localize(key:  null, defaultValue:  this.defaultLanguageNames, useSingularKey:  false);
        2621443.Setup(locLanguage:  null, isSolo:  (this.languageNames - 1) >> 5, flag:  0);
        4 = 5;
        label_1:
        if((4 - 4) < 2621443)
        {
            goto label_12;
        }
    
    }
    private void OnValueChanged(bool isOn)
    {
        var val_2;
        if(isOn != true)
        {
                return;
        }
        
        val_2 = 4;
        goto label_2;
        label_8:
        if(this.hasInitialized <= 35627342)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2 != 0)
        {
            goto label_6;
        }
        
        val_2 = 5;
        label_2:
        if((val_2 - 4) < 2)
        {
            goto label_8;
        }
        
        return;
        label_6:
        if(2 <= 35627342)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_2 = 2621443.name;
        this.useLanguage = 2621443;
    }
    private void OnClick_Confirm()
    {
        UnityEngine.PlayerPrefs.SetString(key:  1798542544, value:  this.useLanguage);
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if((System.String.op_Inequality(a:  null, b:  this.useLanguage)) != false)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  -1845445440, value:  1);
        }
        
        var val_6 = 28719207;
        val_6 = 6908216 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        if(Localization.GAME_NAME != null)
        {
                Localization.GAME_NAME.__unknownFiledOffset_1C = this.useLanguage;
        }
        else
        {
                Localization.GAME_NAME.__unknownFiledOffset_1C = this.useLanguage;
            if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        Localization.GAME_NAME.currentLanguage = this.useLanguage;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        GameBehavior val_4 = App.getBehavior;
        Localization.GAME_NAME.setLocalizedCurrency(currencyKey:  null);
        WordApp.LanguageChanged();
        CUtils.ReloadScene(useScreenFader:  false);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -4911392, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -4783008, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGLanguageSelectPopup()
    {
        this.useLanguage = "";
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -4694912, value:  -4695008);
        }
        else
        {
                Add(key:  -4694912, value:  -4695008);
        }
        
        Add(key:  -4694720, value:  -4694816);
        if(null != 0)
        {
                Add(key:  -4694544, value:  -4694624);
        }
        else
        {
                Add(key:  -4694544, value:  -4694624);
        }
        
        Add(key:  -4694368, value:  -4694448);
        this.defaultLanguageNames = null;
    }

}
