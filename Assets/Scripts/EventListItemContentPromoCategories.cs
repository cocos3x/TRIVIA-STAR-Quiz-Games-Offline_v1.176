using UnityEngine;
public class EventListItemContentPromoCategories : EventListItemContentProgressbar
{
    // Fields
    private UnityEngine.UI.Image specialCatImage;
    
    // Methods
    public void Init(TRVPromoCategory category)
    {
        string val_1 = System.String.Format(format:  -581751840, arg0:  category.subCategoryName);
        this.SetupSlider(sliderText:  -581751840, sliderValue:  null);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_3 = GetCategoryIcon(category:  category.subCategoryName);
        this.specialCatImage.sprite = -612557856;
    }
    public EventListItemContentPromoCategories()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
