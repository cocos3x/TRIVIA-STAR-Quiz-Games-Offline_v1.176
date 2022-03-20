using UnityEngine;
public class LetterTile : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text letterText;
    protected UnityEngine.UI.Image highlight;
    protected UnityEngine.RectTransform bgRect;
    public bool isHiglighted;
    
    // Properties
    public virtual string letter { get; set; }
    public UnityEngine.RectTransform CollisionRect { get; }
    
    // Methods
    public virtual string get_letter()
    {
        if(this.letterText == 0)
        {
            
        }
    
    }
    public virtual void set_letter(string value)
    {
        if(this.letterText == 0)
        {
            
        }
    
    }
    protected virtual void Start()
    {
        var val_6 = 1152921511112248256;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2084533312) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.highlight.color = new UnityEngine.Color() {r = mem[(public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 24) + (0)], g = mem[(public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 24) + (4)], b = mem[(public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 24) + (8)], a = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 36};
        }
        
        UnityEngine.CanvasRenderer val_5 = this.highlight.canvasRenderer;
        this.highlight.SetAlpha(alpha:  null);
    }
    public virtual void SetHighlight(bool state)
    {
        this.isHiglighted = state;
        if(state == true)
        {
                0f = 1f;
        }
        
        this.highlight.CrossFadeAlpha(alpha:  1f, duration:  null, ignoreTimeScale:  1f);
    }
    public UnityEngine.RectTransform get_CollisionRect()
    {
    
    }
    public virtual void SetLetter(string letterString)
    {
        if(this.letterText == 0)
        {
            
        }
    
    }
    public LetterTile()
    {
    
    }

}
