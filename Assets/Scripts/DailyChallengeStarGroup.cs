using UnityEngine;
public class DailyChallengeStarGroup : MonoBehaviour
{
    // Fields
    private UnityEngine.Sprite star_fill;
    private UnityEngine.Sprite star_empty;
    private UnityEngine.UI.Image[] starImages;
    
    // Methods
    private void ResetStars()
    {
        UnityEngine.Transform val_1 = this.transform;
        T[] val_2 = this.GetComponentsInChildren<System.Object>();
        this.starImages = this;
        goto label_2;
        label_6:
        mem[this.star_empty + 0].sprite = this.star_empty;
        0 = 1;
        label_2:
        if(0 < this.star_fill)
        {
            goto label_6;
        }
    
    }
    public void Setup(int stars)
    {
        UnityEngine.UI.Image[] val_1;
        this.ResetStars();
        if(stars < 1)
        {
                return;
        }
        
        var val_2 = 0;
        do
        {
            val_1 = this.starImages;
            if(val_2 > 1152921511741582815)
        {
                return;
        }
        
            val_1 = this.star_fill;
            this.starImages[val_2].sprite = val_1;
            val_2 = val_2 + 1;
        }
        while(val_2 < stars);
    
    }
    public DailyChallengeStarGroup()
    {
    
    }

}
