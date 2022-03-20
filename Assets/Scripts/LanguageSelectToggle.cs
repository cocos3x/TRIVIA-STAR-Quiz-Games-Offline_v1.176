using UnityEngine;
public class LanguageSelectToggle : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Toggle toggle;
    private UnityEngine.GameObject english_only_group;
    private UnityEngine.GameObject selectable_group;
    private System.Collections.Generic.List<UnityEngine.UI.Text> language_texts;
    private System.Collections.Generic.List<UnityEngine.UI.Image> image_flags;
    
    // Methods
    public void Setup(string locLanguage, bool isSolo, UnityEngine.Sprite flag)
    {
        System.Collections.Generic.List<UnityEngine.UI.Image> val_3;
        var val_4;
        var val_5;
        val_3 = locLanguage;
        val_4 = 0;
        this.english_only_group.SetActive(value:  isSolo);
        this.selectable_group.SetActive(value:  isSolo ^ 1);
        goto label_3;
        label_8:
        if(this.selectable_group <= val_4)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        val_4 = 1;
        label_3:
        if(val_4 < ((0 + 0) + 16))
        {
            goto label_8;
        }
        
        val_5 = 0;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  flag, y:  0);
        if(val_2 == true)
        {
            goto label_11;
        }
        
        return;
        label_17:
        if(val_2 <= val_5)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        (0 + 0) + 16.sprite = flag;
        val_5 = 1;
        label_11:
        val_3 = this.image_flags;
        if(val_5 < ((0 + 0) + 16))
        {
            goto label_17;
        }
    
    }
    public LanguageSelectToggle()
    {
    
    }

}
