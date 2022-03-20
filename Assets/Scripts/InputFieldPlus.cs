using UnityEngine;
public class InputFieldPlus : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.InputField inputField;
    private bool LetterOrDigit;
    private bool WhiteSpace;
    private bool Punctuation;
    private char[] Additional;
    
    // Methods
    private void Start()
    {
        UnityEngine.UI.InputField val_6;
        var val_7;
        if(this.inputField == 0)
        {
                UnityEngine.GameObject val_2 = this.gameObject;
            object val_3 = this.GetComponent<System.Object>();
            val_6 = this;
            this.inputField = this;
        }
        else
        {
                val_6 = this.inputField;
        }
        
        InputField.OnValidateInput val_4 = new InputField.OnValidateInput(object:  -2008352320, method:  new IntPtr(2286589952));
        System.Delegate val_5 = System.Delegate.Combine(a:  this.inputField.m_OnValidateInput, b:  205058048);
        val_7 = this.inputField.m_OnValidateInput;
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_9;
        }
        
        }
        
        val_7 = 0;
        label_9:
        val_6.onValidateInput = 0;
    }
    private char MyValidate(char c)
    {
        if(this.LetterOrDigit != false)
        {
                if((System.Char.IsLetterOrDigit(c:  c)) == true)
        {
                return (char)c;
        }
        
        }
        
        if(this.WhiteSpace != false)
        {
                if((System.Char.IsWhiteSpace(c:  c)) == true)
        {
                return (char)c;
        }
        
        }
        
        if(this.Punctuation != false)
        {
                if((System.Char.IsPunctuation(c:  c)) != false)
        {
                return (char)c;
        }
        
        }
        
        bool val_4 = this.MatchesAdds(c:  c);
        if(val_4 == true)
        {
                val_4 = c;
        }
        
        return (char)val_4;
    }
    private bool MatchesAdds(char c)
    {
        var val_2;
        var val_3;
        var val_4;
        if(this == 0)
        {
            goto label_3;
        }
        
        val_2 = 0;
        val_3 = 16;
        label_6:
        if(val_2 >= this)
        {
            goto label_3;
        }
        
        val_3 = val_3 + 2;
        val_2 = val_2 + 1;
        if((c.Equals(obj:  '╀')) == false)
        {
            goto label_6;
        }
        
        val_4 = 1;
        return (bool)val_4;
        label_3:
        val_4 = 0;
        return (bool)val_4;
    }
    public InputFieldPlus()
    {
        this.Punctuation = true;
        this.LetterOrDigit = true;
        this.WhiteSpace = true;
    }
    private char <Start>b__5_0(string input, int charIndex, char addedChar)
    {
        return this.MyValidate(c:  addedChar);
    }

}
