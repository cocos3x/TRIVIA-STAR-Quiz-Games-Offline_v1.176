using UnityEngine;
public class TheLibraryBookProgressElement : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image image_background;
    private UnityEngine.GameObject obj_background_highlight;
    private UnityEngine.GameObject obj_darken_overlay;
    private UnityEngine.GameObject obj_progress;
    private UnityEngine.UI.Text text_progress;
    private UnityEngine.UI.Text text_chapter_numeral;
    private UnityEngine.GameObject obj_checkmark;
    private UnityEngine.UI.Button button_chapter_click;
    private UnityEngine.UI.Graphic[] graphics_to_darken;
    private UnityEngine.UI.Outline[] outlines_to_darken;
    private System.Collections.Generic.List<UnityEngine.Color> colors_graphics;
    private System.Collections.Generic.List<UnityEngine.Color> colors_texts;
    private System.Collections.Generic.List<UnityEngine.Color> colors_outlines;
    private int chapterDisplayed;
    private System.Action<int> ChapterClickAction;
    
    // Methods
    private void Awake()
    {
        float val_3;
        TheLibraryBookProgressElement val_6;
        UnityEngine.Events.UnityAction val_7;
        var val_8;
        float val_9;
        float val_11;
        var val_12;
        val_6 = this;
        val_7 = null;
        val_8 = 0;
        val_7 = new UnityEngine.Events.UnityAction(object:  -1679033088, method:  new IntPtr(2615782208));
        this.button_chapter_click.m_OnClick.AddListener(call:  162246656);
        System.Collections.Generic.List<UnityEngine.Color> val_2 = null;
        val_9 = 1152921511058209296;
        val_2 = new System.Collections.Generic.List<UnityEngine.Color>();
        this.colors_graphics = val_2;
        val_11 = 1152921510707268192;
        goto label_3;
        label_9:
        val_7 = this.colors_graphics;
        UnityEngine.UI.Graphic val_6 = this.graphics_to_darken[val_8];
        val_7.Add(item:  new UnityEngine.Color() {a = val_3});
        val_8 = 1;
        label_3:
        if(val_8 < val_7)
        {
            goto label_9;
        }
        
        this.colors_outlines = new System.Collections.Generic.List<UnityEngine.Color>();
        val_12 = 0;
        goto label_10;
        label_16:
        val_9 = this.colors_outlines;
        val_11 = this.outlines_to_darken[val_12];
        UnityEngine.UI.Outline val_5 = val_11 + 16;
        val_9.Add(item:  new UnityEngine.Color() {r = mem[(this.outlines_to_darken[0x0][0] + 16) + (0)], g = mem[(this.outlines_to_darken[0x0][0] + 16) + (4)], b = mem[(this.outlines_to_darken[0x0][0] + 16) + (8)], a = this.outlines_to_darken});
        val_6 = val_6;
        val_12 = 1;
        label_10:
        if(val_12 < val_9)
        {
            goto label_16;
        }
    
    }
    public void Setup(int chapter, float completeProgress, int lastChapterInBook, TheLibrary.ProgressState state, bool interactable, System.Action<int> chapterClickAction)
    {
        System.Action<System.Int32> val_1;
        var val_10;
        this.chapterDisplayed = chapter;
        this.ChapterClickAction = val_1;
        this.button_chapter_click.interactable = chapterClickAction;
        if((UnityEngine.Object.op_Implicit(exists:  this.obj_darken_overlay)) != false)
        {
                val_10 = this.obj_darken_overlay;
            val_10.SetActive(value:  (interactable - 2) >> 5);
        }
        
        string val_5 = val_10.RomanNumeralize(num:  chapter);
        this.obj_checkmark.SetActive(value:  this.text_chapter_numeral >> 5);
        bool val_8 = (interactable - 1) >> 5;
        this.obj_progress.SetActive(value:  val_8);
        string val_9 = lastChapterInBook.ToString(format:  -1678773056);
        this.ToggleChapterSelected(isOn:  val_8, dimOthers:  false);
    }
    public void ToggleChapterSelected(bool isOn, bool dimOthers = False)
    {
        UnityEngine.GameObject val_4;
        UnityEngine.GameObject val_5;
        val_4 = this.obj_background_highlight;
        if(val_4 != 0)
        {
                val_4 = this.obj_background_highlight;
            val_4.SetActive(value:  isOn);
        }
        
        if(dimOthers == false)
        {
                return;
        }
        
        val_5 = this.obj_darken_overlay;
        if(val_5 != 0)
        {
                val_5 = this.obj_darken_overlay;
            val_5.SetActive(value:  isOn ^ 1);
        }
        
        if(isOn != false)
        {
                this.LightenEverything();
            return;
        }
        
        this.DarkenEverything();
    }
    private void OnElementClickAction()
    {
        if(this.ChapterClickAction == 0)
        {
                return;
        }
        
        this.ChapterClickAction.Invoke(obj:  this.chapterDisplayed);
    }
    private string RomanNumeralize(int num)
    {
        var val_4;
        int val_1 = num - 1;
        if(val_1 <= 4)
        {
                var val_2 = 8343052 + (8343052 + ((num - 1)) << 2);
            if(val_1 == 4)
        {
                8343052 + ((num - 1)) << 2 = (8343052 + ((num - 1)) << 2) & (num << (8343052 + ((num - 1)) << 2));
            8343052 + ((num - 1)) << 2 = (8343052 + ((num - 1)) << 2) & ((8343052 + ((num - 1)) << 2) >> (8343052 + ((num - 1)) << 2));
            8343052 + ((num - 1)) << 2 = (8343052 + ((num - 1)) << 2) & ((IP) >> ((8343052 + ((num - 1)) << 2 & (num) << 8343052 + ((num - 1)) << 2) & ((8343052 + ((num - 1)) << 2 & (num) << 8343052 + ((num - 1)) << 2)) >> (8343052 + ((num - 1)) << 2 & (num) << 8343052 + ((num - 1);
            8343052 + ((num - 1)) << 2 = (8343052 + ((num - 1)) << 2) & (((int)R8) >> 32);
            8343052 + ((num - 1)) << 2 = (8343052 + ((num - 1)) << 2) & (num >> (8343052 + ((num - 1)) << 2));
        }
        
            val_4 = "I";
            return;
        }
        
        string val_3 = num.ToString();
    }
    private void DarkenEverything()
    {
        float val_3;
        var val_4;
        System.Collections.Generic.List<UnityEngine.Color> val_5;
        var val_6;
        val_4 = 0;
        goto label_1;
        label_8:
        if(this.graphics_to_darken[val_4] <= val_4)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 0;
        UnityEngine.Color val_1 = DarkenColor(originalColor:  new UnityEngine.Color() {r = (0 + 0) + 24, g = (0 + 0) + 16, b = (0 + 0) + 20, a = (0 + 0) + 24}, normalizedPercent:  null);
        val_4 = 1;
        label_1:
        if(val_4 < this.graphics_to_darken[val_4])
        {
            goto label_8;
        }
        
        val_6 = 0;
        goto label_9;
        label_16:
        val_5 = this.colors_outlines;
        UnityEngine.UI.Outline val_6 = this.outlines_to_darken[val_6];
        if(this.outlines_to_darken[val_6] <= val_6)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + 0;
        UnityEngine.Color val_2 = DarkenColor(originalColor:  new UnityEngine.Color() {r = (0 + 0) + 24, g = (0 + 0) + 16, b = (0 + 0) + 20, a = (0 + 0) + 24}, normalizedPercent:  val_1.r);
        val_6.effectColor = new UnityEngine.Color() {a = val_3};
        val_6 = 1;
        label_9:
        if(val_6 < val_6)
        {
            goto label_16;
        }
    
    }
    private void LightenEverything()
    {
        TheLibraryBookProgressElement val_3;
        var val_4;
        float val_5;
        var val_6;
        var val_7;
        var val_9;
        val_3 = this;
        val_4 = 0;
        goto label_1;
        label_8:
        if(this.graphics_to_darken[val_4] <= val_4)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        val_5 = mem[(0 + 0) + 16];
        val_5 = (0 + 0) + 16;
        val_6 = mem[(0 + 0) + 24];
        val_6 = (0 + 0) + 24;
        val_7 = mem[(0 + 0) + 28];
        val_7 = (0 + 0) + 28;
        val_3 = val_3;
        val_4 = 1;
        label_1:
        if(val_4 < this.graphics_to_darken[val_4])
        {
            goto label_8;
        }
        
        val_9 = 0;
        goto label_9;
        label_16:
        var val_1 = mem[1152921511519043200] + 0;
        if((mem[1152921511519043212] + 12) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = mem[1152921511519043212] + 8;
        val_5 = val_5 + 0;
        var val_2 = val_5 + 20;
        val_5 = mem[(mem[1152921511519043212] + 8 + 0) + 16];
        val_5 = (mem[1152921511519043212] + 8 + 0) + 16;
        (mem[1152921511519043200] + 0) + 16.effectColor = new UnityEngine.Color() {r = val_5, g = mem[((mem[1152921511519043212] + 8 + 0) + 20) + (0)], b = mem[((mem[1152921511519043212] + 8 + 0) + 20) + (4)], a = mem[((mem[1152921511519043212] + 8 + 0) + 20) + (8)]};
        val_9 = 1;
        label_9:
        if(val_9 < (mem[1152921511519043200] + 12))
        {
            goto label_16;
        }
    
    }
    private UnityEngine.Color DarkenColor(UnityEngine.Color originalColor, float normalizedPercent)
    {
        float val_1;
        float val_5;
        UnityEngine.Color.RGBToHSV(rgbColor:  new UnityEngine.Color() {r = originalColor.g, g = originalColor.b, b = originalColor.a, a = val_1}, H: out  0f, S: out  float val_3 = -4.299893E-22f, V: out  float val_4 = -4.299891E-22f);
        float val_7 = val_5;
        val_7 = 0f * val_7;
        UnityEngine.Color val_6 = UnityEngine.Color.HSVToRGB(H:  val_7, S:  null, V:  0f);
        return new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
    }
    public TheLibraryBookProgressElement()
    {
    
    }

}
