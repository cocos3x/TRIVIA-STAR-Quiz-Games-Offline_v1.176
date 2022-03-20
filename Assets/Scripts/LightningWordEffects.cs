using UnityEngine;
public class LightningWordEffects : MonoBehaviour
{
    // Fields
    private UnityEngine.Animation anim;
    
    // Methods
    private void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.anim = this;
    }
    private void OnEnable()
    {
        System.Collections.IEnumerator val_1 = this.PlayLightningEffects();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1167733104);
    }
    private System.Collections.IEnumerator PlayLightningEffects()
    {
        object val_1 = new System.Object();
        typeof(LightningWordEffects.<PlayLightningEffects>d__3).__il2cppRuntimeField_8 = 0;
        typeof(LightningWordEffects.<PlayLightningEffects>d__3).__il2cppRuntimeField_10 = this;
    }
    private void OnDestroy()
    {
        this.StopAllCoroutines();
    }
    public LightningWordEffects()
    {
    
    }

}
