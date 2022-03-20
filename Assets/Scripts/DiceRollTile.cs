using UnityEngine;
public class DiceRollTile : MonoBehaviour
{
    // Fields
    private UnityEngine.ParticleSystem particles;
    private const float flyToPreDelay = 0.2;
    private const float flyToDuration = 1;
    private const float flyToAfterDelay = 0.2;
    private UnityEngine.GameObject eventButtonGO;
    
    // Methods
    public void Init(UnityEngine.GameObject eventButton)
    {
        this.eventButtonGO = eventButton;
    }
    public void PlayEndingAnimation()
    {
        System.Collections.IEnumerator val_1 = this.FlyAndHide();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1037994080);
    }
    private System.Collections.IEnumerator FlyAndHide()
    {
        object val_1 = new System.Object();
        typeof(DiceRollTile.<FlyAndHide>d__7).__il2cppRuntimeField_8 = 0;
        typeof(DiceRollTile.<FlyAndHide>d__7).__il2cppRuntimeField_10 = this;
    }
    public DiceRollTile()
    {
    
    }

}
