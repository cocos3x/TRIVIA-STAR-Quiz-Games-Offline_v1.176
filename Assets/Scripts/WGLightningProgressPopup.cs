using UnityEngine;
public class WGLightningProgressPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject windowGroup;
    private UnityEngine.UI.Image lightningIcon;
    private UnityEngine.Sprite lightningWordsSp;
    private UnityEngine.Sprite lightningLevelsSp;
    private const float DEFAULT_POPUP_DURATION_IN_SECONDS = 2.5;
    
    // Methods
    private void Awake()
    {
        this.windowGroup.SetActive(value:  false);
    }
    private void OnEnable()
    {
        System.Collections.IEnumerator val_1 = this.ShowPopup();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  8242784);
    }
    private System.Collections.IEnumerator ShowPopup()
    {
        object val_1 = new System.Object();
        typeof(WGLightningProgressPopup.<ShowPopup>d__7).__il2cppRuntimeField_8 = 0;
        typeof(WGLightningProgressPopup.<ShowPopup>d__7).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator PlayFallAnimation()
    {
        object val_1 = new System.Object();
        typeof(WGLightningProgressPopup.<PlayFallAnimation>d__8).__il2cppRuntimeField_8 = 0;
        typeof(WGLightningProgressPopup.<PlayFallAnimation>d__8).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.Generic.Dictionary<LightningEvents, UnityEngine.Sprite> GetLightningIcons()
    {
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        Add(key:  0, value:  this.lightningWordsSp);
        Add(key:  1, value:  this.lightningLevelsSp);
    }
    public void Setup(LightningEvents e)
    {
        System.Collections.Generic.Dictionary<LightningEvents, UnityEngine.Sprite> val_1 = this.GetLightningIcons();
        object val_2 = this.Item[e];
        this.lightningIcon.sprite = 8718432;
    }
    public void ClosePopup()
    {
        this.StopAllCoroutines();
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  8838624, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGLightningProgressPopup()
    {
    
    }

}
