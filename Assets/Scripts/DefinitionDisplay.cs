using UnityEngine;
public class DefinitionDisplay : MonoBehaviour
{
    // Fields
    private float waitTime;
    private float fadeTime;
    private UnityEngine.CanvasGroup group;
    
    // Methods
    public void OnEnable()
    {
        System.Collections.IEnumerator val_1 = this.WaitThenFade();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -957575872);
    }
    private System.Collections.IEnumerator WaitThenFade()
    {
        object val_1 = new System.Object();
        typeof(DefinitionDisplay.<WaitThenFade>d__4).__il2cppRuntimeField_8 = 0;
        typeof(DefinitionDisplay.<WaitThenFade>d__4).__il2cppRuntimeField_10 = this;
    }
    public DefinitionDisplay()
    {
        this.waitTime = 2f;
        this.fadeTime = 0.5f;
    }

}
