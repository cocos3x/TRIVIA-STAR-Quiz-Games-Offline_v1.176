using UnityEngine;
public class SyncShakeExtraWords : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator extraWordAnimator;
    
    // Methods
    private void OnEnable()
    {
        this.extraWordAnimator.SetTrigger(name:  113607248);
    }
    private void OnDisable()
    {
        this.extraWordAnimator.SetTrigger(name:  113727552);
    }
    public SyncShakeExtraWords()
    {
    
    }

}
