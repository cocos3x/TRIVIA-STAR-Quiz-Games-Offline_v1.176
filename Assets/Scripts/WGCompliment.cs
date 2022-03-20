using UnityEngine;
public class WGCompliment : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI displayText;
    private UnityEngine.Animator anim;
    private string[] localizationKeys;
    private string[] localizationDefaults;
    public bool IsEnabled;
    
    // Methods
    public void ShowRandom()
    {
        if(this.IsAvailable2Show() == false)
        {
                return;
        }
        
        int val_2 = UnityEngine.Random.Range(min:  0, max:  0);
        string val_5 = this.localizationKeys[val_2];
        string val_3 = Localization.Localize(key:  val_5, defaultValue:  this.localizationDefaults[val_2], useSingularKey:  false);
        this.displayText.text = val_5;
        if(this.anim == 0)
        {
                return;
        }
        
        this.anim.SetTrigger(name:  -1352033280);
    }
    private bool IsAvailable2Show()
    {
        var val_5;
        UnityEngine.Animator val_6;
        val_5 = 0;
        if(this.IsEnabled == false)
        {
                return (bool)val_2.m_Tag.IsName(name:  -978841760);
        }
        
        val_6 = this.anim;
        val_5 = 1;
        if(val_6 == 0)
        {
                return (bool)val_2.m_Tag.IsName(name:  -978841760);
        }
        
        UnityEngine.AnimatorStateInfo val_2 = GetCurrentAnimatorStateInfo(layerIndex:  this.anim);
        return (bool)val_2.m_Tag.IsName(name:  -978841760);
    }
    public WGCompliment()
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "amazing_upper_ex";
        typeof(System.String[]).__il2cppRuntimeField_14 = "fantastic_upper_ex";
        typeof(System.String[]).__il2cppRuntimeField_18 = "sweet_upper_ex";
        typeof(System.String[]).__il2cppRuntimeField_1C = "whoa_upper_ex";
        typeof(System.String[]).__il2cppRuntimeField_20 = "incredible_upper_ex";
        typeof(System.String[]).__il2cppRuntimeField_24 = "spectacular_upper_ex";
        typeof(System.String[]).__il2cppRuntimeField_28 = "wow_upper_ex";
        typeof(System.String[]).__il2cppRuntimeField_2C = "super_upper_ex";
        typeof(System.String[]).__il2cppRuntimeField_30 = "great_upper_ex";
        typeof(System.String[]).__il2cppRuntimeField_34 = "awesome_upper_ex";
        this.localizationKeys = null;
        typeof(System.String[]).__il2cppRuntimeField_10 = "AMAZING!";
        typeof(System.String[]).__il2cppRuntimeField_14 = "FANTASTIC!";
        typeof(System.String[]).__il2cppRuntimeField_18 = "SWEET!";
        typeof(System.String[]).__il2cppRuntimeField_1C = "WHOA!";
        typeof(System.String[]).__il2cppRuntimeField_20 = "INCREDIBLE!";
        typeof(System.String[]).__il2cppRuntimeField_24 = "SPECTACULAR!";
        typeof(System.String[]).__il2cppRuntimeField_28 = "WOW!";
        typeof(System.String[]).__il2cppRuntimeField_2C = "SUPER!";
        typeof(System.String[]).__il2cppRuntimeField_30 = "GREAT!";
        typeof(System.String[]).__il2cppRuntimeField_34 = "AWESOME!";
        this.localizationDefaults = null;
    }

}
