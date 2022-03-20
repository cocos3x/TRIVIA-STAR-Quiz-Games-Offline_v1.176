using UnityEngine;
public class TRVCategoryRankDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image categoryIcon;
    private UnityEngine.UI.Image progressBar;
    
    // Methods
    public void DisplayCategoryRank(UnityEngine.Sprite categorySp, float startProgress, float endProgress)
    {
        twelvegigs.Autopilot.WUTAutopilotGameplay val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  -556341696);
        this.alpha = startProgress;
        this.categoryIcon.sprite = categorySp;
        this.Show();
        if(this.categoryIcon < 0)
        {
                System.Collections.IEnumerator val_2 = this.PlayProgressAnimation(from:  startProgress, to:  endProgress, duration:  null);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -556341696);
        }
        
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  -556341696, endValue:  startProgress, duration:  endProgress);
    }
    public void Hide()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private System.Collections.IEnumerator PlayProgressAnimation(float from, float to, float duration)
    {
        typeof(TRVCategoryRankDisplay.<PlayProgressAnimation>d__4).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TRVCategoryRankDisplay.<PlayProgressAnimation>d__4).__il2cppRuntimeField_10 = this;
            typeof(TRVCategoryRankDisplay.<PlayProgressAnimation>d__4).__il2cppRuntimeField_14 = R1;
            typeof(TRVCategoryRankDisplay.<PlayProgressAnimation>d__4).__il2cppRuntimeField_18 = R2;
        }
        else
        {
                mem[16] = this;
            mem[20] = R1;
            mem[24] = R2;
        }
        
        typeof(TRVCategoryRankDisplay.<PlayProgressAnimation>d__4).__il2cppRuntimeField_1C = R3;
    }
    private void Show()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  true);
    }
    public TRVCategoryRankDisplay()
    {
    
    }

}
