using UnityEngine;
public class WPTAnimationTester : MonoBehaviour
{
    // Fields
    private WordPets.WordPet[] wordpets;
    public UnityEngine.GameObject allpets;
    public WordPets.WordPet wordPet;
    public UnityEngine.UI.Text displayText;
    public UnityEngine.Transform petTransform;
    private int currentAnim;
    
    // Properties
    private float LandingDelay { get; }
    
    // Methods
    private float get_LandingDelay()
    {
        object val_1 = this.wordPet.GetComponent<System.Object>();
        Spine.SkeletonData val_2 = this.wordPet.GetSkeletonData(quiet:  true);
        Spine.Animation val_3 = this.wordPet.FindAnimation(animationName:  116792144);
        if(this.wordPet != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private void Start()
    {
        T[] val_1 = this.allpets.GetComponentsInChildren<System.Object>();
        this.wordpets = this.allpets;
        this.ChangePet();
    }
    public void ChangePet()
    {
        goto label_1;
        label_9:
        if((-838555472) != this.wordPet)
        {
                UnityEngine.GameObject val_2 = 1152921508063258800.gameObject;
            1152921508063258800.SetActive(value:  false);
        }
        
        0 = 1;
        label_1:
        if(0 < 1152921508063258800)
        {
            goto label_9;
        }
        
        UnityEngine.GameObject val_3 = this.wordPet.gameObject;
        this.wordPet.SetActive(value:  true);
        UnityEngine.Transform val_4 = this.wordPet.transform;
        UnityEngine.Vector3 val_5 = position;
        this.wordPet.position = new UnityEngine.Vector3();
        this.wordPet.AnimateIdle();
        this.currentAnim = 0;
    }
    public void Next()
    {
        int val_1 = this.currentAnim + 1;
        this.currentAnim = val_1;
        if(val_1 >= 3)
        {
            goto label_1;
        }
        
        if(this.currentAnim == 1)
        {
            goto label_2;
        }
        
        if(this.currentAnim == 0)
        {
            goto label_3;
        }
        
        if(this.currentAnim != 1)
        {
                return;
        }
        
        goto label_4;
        label_1:
        this.currentAnim = 0;
        label_4:
        this.StopAllCoroutines();
        this.wordPet.AnimateIdle();
        return;
        label_2:
        this.StopAllCoroutines();
        this.wordPet.AnimateRun();
        return;
        label_3:
        this.StopAllCoroutines();
        System.Collections.IEnumerator val_2 = this.AnimateFallSquash();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  117300960);
    }
    public void AnimateIdle()
    {
        this.wordPet.AnimateIdle();
    }
    public void AnimateRun()
    {
        this.wordPet.AnimateRun();
    }
    public System.Collections.IEnumerator AnimateFallSquash()
    {
        object val_1 = new System.Object();
        typeof(WPTAnimationTester.<AnimateFallSquash>d__13).__il2cppRuntimeField_8 = 0;
        typeof(WPTAnimationTester.<AnimateFallSquash>d__13).__il2cppRuntimeField_10 = this;
    }
    public WPTAnimationTester()
    {
    
    }

}
