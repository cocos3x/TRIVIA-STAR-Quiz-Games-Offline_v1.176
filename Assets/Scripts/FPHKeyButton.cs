using UnityEngine;
public class FPHKeyButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text letterText;
    private UnityEngine.UI.Image buttonImage;
    private UnityEngine.UI.Button myButton;
    private UnityEngine.CanvasGroup powerupRemovedGroup;
    private UnityEngine.Color buttonCorrectColor;
    private UnityEngine.Color buttonWrongColor;
    private UnityEngine.ParticleSystem glowAnim;
    private char <KeyChar>k__BackingField;
    public System.Action onClickAction;
    private FPHKeyButton.KeyState myState;
    
    // Properties
    public char KeyChar { get; set; }
    
    // Methods
    public char get_KeyChar()
    {
        return (char)this.<KeyChar>k__BackingField;
    }
    private void set_KeyChar(char value)
    {
        this.<KeyChar>k__BackingField = value;
    }
    public void Init(char myCharacter, FPHKeyButton.KeyState state)
    {
        char val_5 = myCharacter;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1634533008, method:  new IntPtr(2660405168));
        this.myButton.m_OnClick.AddListener(call:  162246656);
        this.<KeyChar>k__BackingField = val_5;
        if((FPHKeyboard.IsLetter(value:  val_5 = myCharacter)) != false)
        {
                string val_3 = myCharacter.ToString();
            val_5;
        }
        
        if(state > 3)
        {
                return;
        }
        
        var val_4 = 13257688 + (13257688 + (state) << 2);
        if(state == 3)
        {
                13257688 = 13257688;
            13257688 = 13257688 & ((IP) << 13257688);
            13257688 = 13257688 & (state >> 32);
            13257688 = 13257688 & (state >> 13257688);
        }
        
        this.SetInactive();
    }
    private void OnClick()
    {
        if(this.onClickAction == 0)
        {
                return;
        }
        
        this.onClickAction.Invoke();
    }
    public void SetPurchased(bool isCorrectLetter)
    {
        char val_2;
        var val_3;
        var val_4;
        var val_5;
        UnityEngine.Color val_6;
        val_2 = this.<KeyChar>k__BackingField;
        if((FPHKeyboard.IsLetter(value:  val_2)) == false)
        {
                return;
        }
        
        this.glowAnim.Stop();
        val_2 = this.buttonImage;
        if(isCorrectLetter != false)
        {
                val_3 = 1152921511562509464;
            val_4 = 1152921511562509460;
            val_5 = 1152921511562509456;
            val_6 = this.buttonCorrectColor;
        }
        else
        {
                val_3 = 1152921511562509480;
            val_4 = 1152921511562509476;
            val_5 = 1152921511562509472;
            val_6 = this.buttonWrongColor;
        }
        
        val_2.color = new UnityEngine.Color() {r = this.buttonWrongColor.r, g = 4.823884E-28f, b = 4.823884E-28f};
        this.myButton.interactable = false;
        this.myState = 2;
    }
    public void SetPowerupRemoved()
    {
        if((FPHKeyboard.IsLetter(value:  this.<KeyChar>k__BackingField)) == false)
        {
                return;
        }
        
        R4 + 20.interactable = false;
        mem2[0] = 3;
        R4 + 24.alpha = null;
    }
    public void SetInactive()
    {
        this.glowAnim.Stop();
        this.myButton.interactable = false;
        this.myState = 0;
        this.powerupRemovedGroup.alpha = null;
    }
    public void SetActive()
    {
        this.glowAnim.Stop();
        this.myButton.interactable = true;
        this.myState = 1;
        this.powerupRemovedGroup.alpha = null;
    }
    public void SetHighlight()
    {
        this.glowAnim.Play();
    }
    public void StopHighlight()
    {
        this.glowAnim.Stop();
    }
    public FPHKeyButton()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.myState = 1;
    }

}
