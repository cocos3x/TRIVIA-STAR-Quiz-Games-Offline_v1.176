using UnityEngine;
public class TRVCategoryDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text categoryNameText;
    private UnityEngine.UI.Image categoryImage;
    private UnityEngine.UI.Text crownText;
    private UnityEngine.UI.Text completedText;
    
    // Methods
    public void DisplayCategory(string name, UnityEngine.Sprite catSprite, bool grayOut = False)
    {
        UnityEngine.Sprite val_3;
        UnityEngine.UI.Image val_4;
        val_3 = catSprite;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.categoryNameText, y:  0);
        val_4 = this.categoryImage;
        val_4.sprite = val_3;
        if(grayOut == false)
        {
                return;
        }
        
        UnityEngine.Color val_2 = UnityEngine.Color.gray;
        this.categoryImage.color = new UnityEngine.Color() {a = ???};
    }
    public void DisplayCategoryDetails(int crowns, int completedPercentage)
    {
        string val_1 = crowns.ToString();
        string val_2 = completedPercentage.ToString();
        string val_3 = System.String.Format(format:  2124591920, arg0:  -558233728);
        if(this.completedText != 0)
        {
                return;
        }
    
    }
    public TRVCategoryDisplay()
    {
    
    }

}
