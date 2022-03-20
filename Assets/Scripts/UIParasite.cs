using UnityEngine;
public class UIParasite : MonoBehaviour
{
    // Fields
    private UIParasite.UIType toOverride;
    private string bundleName;
    private string assetName;
    
    // Methods
    public void Setup(UIParasite.UIType uiToOverride, string bundleName, string assetName)
    {
    
    }
    private void Awake()
    {
        var val_13;
        string val_14;
        var val_15;
        if(this.toOverride == 0)
        {
            goto label_1;
        }
        
        if(this.toOverride == 1)
        {
            goto label_2;
        }
        
        if(this.toOverride != 2)
        {
            goto label_15;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        val_13 = this;
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_14 = this.bundleName;
        val_15 = public static ResourceLoader MonoSingletonSelfGenerating<ResourceLoader>::get_Instance();
        UnityEngine.Font val_4 = GetFontFromBundle(bundleName:  val_14, fontName:  this.assetName);
        this.font = -676860272;
        goto label_15;
        label_1:
        UnityEngine.GameObject val_5 = this.gameObject;
        object val_6 = this.GetComponent<System.Object>();
        val_13 = this;
        WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_14 = this.bundleName;
        val_15 = public static ResourceLoader MonoSingletonSelfGenerating<ResourceLoader>::get_Instance();
        UnityEngine.Sprite val_8 = GetSpriteFromBundle(bundleName:  val_14, spriteName:  this.assetName);
        this.sprite = -676860272;
        goto label_15;
        label_2:
        UnityEngine.GameObject val_9 = this.gameObject;
        object val_10 = this.GetComponent<System.Object>();
        val_13 = this;
        WordPets.WPTDataParser val_11 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_14 = this.bundleName;
        val_15 = public static ResourceLoader MonoSingletonSelfGenerating<ResourceLoader>::get_Instance();
        UnityEngine.Texture val_12 = GetTextureFromBundle(bundleName:  val_14, textureName:  this.assetName);
        this.texture = -676860272;
        label_15:
        UnityEngine.Object.Destroy(obj:  -676810672);
    }
    public UIParasite()
    {
    
    }

}
