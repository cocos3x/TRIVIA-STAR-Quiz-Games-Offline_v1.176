using UnityEngine;
public class EventListItemContentSpecialCategories : EventListItemContentProgressbar
{
    // Fields
    private UnityEngine.UI.Image specialCatImage;
    
    // Methods
    public void Init(string category)
    {
        string val_1 = System.String.Format(format:  -432892896, arg0:  category);
        this.SetupSlider(sliderText:  -432892896, sliderValue:  null);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_3 = GetCategoryIcon(category:  category);
        this.specialCatImage.sprite = -612557856;
    }
    public EventListItemContentSpecialCategories()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
