using UnityEngine;
public class WFLetter : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image border;
    private UnityEngine.UI.Text letter;
    private int <gridX>k__BackingField;
    private int <gridY>k__BackingField;
    private bool <IsAvailable>k__BackingField;
    private bool <IsSelected>k__BackingField;
    private bool <IsUsed>k__BackingField;
    private UnityEngine.Color borderAvl;
    private UnityEngine.Color borderSel;
    private UnityEngine.Color borderUse;
    private UnityEngine.Color letterAvl;
    private UnityEngine.Color letterSel;
    private UnityEngine.Color letterUse;
    
    // Properties
    public char Letter { get; set; }
    public int gridX { get; set; }
    public int gridY { get; set; }
    public bool IsAvailable { get; set; }
    public bool IsSelected { get; set; }
    public bool IsUsed { get; set; }
    
    // Methods
    public char get_Letter()
    {
        if(this.letter != 0)
        {
                return this.letter.Chars[0];
        }
        
        return this.letter.Chars[0];
    }
    public void set_Letter(char value)
    {
        string val_1 = value.ToString();
        if(this.letter != 0)
        {
                return;
        }
    
    }
    public int get_gridX()
    {
        return (int)this.<gridX>k__BackingField;
    }
    protected void set_gridX(int value)
    {
        this.<gridX>k__BackingField = value;
    }
    public int get_gridY()
    {
        return (int)this.<gridY>k__BackingField;
    }
    protected void set_gridY(int value)
    {
        this.<gridY>k__BackingField = value;
    }
    public bool get_IsAvailable()
    {
        return (bool)this.<IsAvailable>k__BackingField;
    }
    protected void set_IsAvailable(bool value)
    {
        this.<IsAvailable>k__BackingField = value;
    }
    public bool get_IsSelected()
    {
        return (bool)this.<IsSelected>k__BackingField;
    }
    protected void set_IsSelected(bool value)
    {
        this.<IsSelected>k__BackingField = value;
    }
    public bool get_IsUsed()
    {
        return (bool)this.<IsUsed>k__BackingField;
    }
    protected void set_IsUsed(bool value)
    {
        this.<IsUsed>k__BackingField = value;
    }
    private void Start()
    {
        this.SetAvailable();
    }
    private void Update()
    {
    
    }
    public void SetGridPos(int x, int y)
    {
        this.<gridX>k__BackingField = x;
        this.<gridY>k__BackingField = y;
    }
    public bool IsAdjacent(WFLetter otherLetter)
    {
        int val_3;
        var val_4;
        val_3 = otherLetter.<gridY>k__BackingField;
        if((otherLetter.<gridX>k__BackingField) == (this.<gridX>k__BackingField))
        {
                int val_1 = (this.<gridY>k__BackingField) - 1;
            val_4 = 1;
            if(val_3 != val_1)
        {
                val_1 = (this.<gridY>k__BackingField) + 1;
        }
        
            if(val_3 == val_1)
        {
                return (bool)val_4;
        }
        
        }
        
        if(val_3 != (this.<gridY>k__BackingField))
        {
                return false;
        }
        
        val_4 = 1;
        if((otherLetter.<gridX>k__BackingField) != ((this.<gridX>k__BackingField) - 1))
        {
                this.<gridX>k__BackingField = (this.<gridX>k__BackingField) + 1;
        }
        
        if((otherLetter.<gridX>k__BackingField) != (this.<gridX>k__BackingField))
        {
                return false;
        }
        
        return (bool)val_4;
    }
    public void SetAvailable()
    {
        this.SetSize(size:  null);
        this.border.color = new UnityEngine.Color() {r = this.borderAvl, g = SL, b = R8, a = ???};
        this.letter.color = new UnityEngine.Color() {r = this.letterAvl, g = SL, b = R8, a = ???};
        this.<IsUsed>k__BackingField = false;
        this.<IsAvailable>k__BackingField = true;
        this.<IsSelected>k__BackingField = false;
    }
    public void SetSelected()
    {
        this.SetSize(size:  null);
        this.border.color = new UnityEngine.Color() {r = this.borderSel, g = SL, b = R8, a = ???};
        this.letter.color = new UnityEngine.Color() {r = this.letterSel, g = SL, b = R8, a = ???};
        this.<IsUsed>k__BackingField = false;
        this.<IsAvailable>k__BackingField = true;
        this.<IsSelected>k__BackingField = true;
    }
    public void SetUsed()
    {
        this.SetSize(size:  null);
        this.border.color = new UnityEngine.Color() {r = this.borderUse, g = SL, b = R8, a = ???};
        this.letter.color = new UnityEngine.Color() {r = this.letterUse, g = SL, b = R8, a = ???};
        this.<IsUsed>k__BackingField = true;
        this.<IsAvailable>k__BackingField = false;
        this.<IsSelected>k__BackingField = false;
    }
    private void SetSize(float size)
    {
        UnityEngine.Transform val_1 = this.border.transform;
        PluginExtension.SetLocalScaleX(transform:  this.border, x:  size);
        UnityEngine.Transform val_2 = this.border.transform;
        PluginExtension.SetLocalScaleY(transform:  this.border, y:  size);
        UnityEngine.Transform val_3 = this.letter.transform;
        PluginExtension.SetLocalScaleX(transform:  this.letter, x:  size);
        UnityEngine.Transform val_4 = this.letter.transform;
        PluginExtension.SetLocalScaleY(transform:  this.letter, y:  size);
    }
    public WFLetter()
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        UnityEngine.Color val_4 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        UnityEngine.Color val_5 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        UnityEngine.Color val_6 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
    }

}
