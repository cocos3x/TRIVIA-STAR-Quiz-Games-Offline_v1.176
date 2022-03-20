using UnityEngine;
public class TRVPromoCategoriesProxyEventHandler : WGEventHandler
{
    // Fields
    public const string EVENT_ID = "Special Categories";
    public TRVPromoCategory PromoCategory;
    
    // Properties
    public override bool IsEventHidden { get; }
    
    // Methods
    public override string GetEventDisplayName()
    {
        string val_1 = this.PromoCategory.subCategoryName.ToUpper();
        return System.String.Format(format:  -568469520, arg0:  this.PromoCategory.subCategoryName);
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = this.PromoCategory.subCategoryName.ToUpper();
        return System.String.Format(format:  -568341024, arg0:  this.PromoCategory.subCategoryName);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        GameBehavior val_1 = App.getBehavior;
        0.SetupWithPromo(promo:  this.PromoCategory, hidePaidEntry:  false, returnToCategorySelectOnButtonClose:  false, continueToNextLevel:  true);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        GameBehavior val_1 = App.getBehavior;
        0.SetupWithPromo(promo:  this.PromoCategory, hidePaidEntry:  true, returnToCategorySelectOnButtonClose:  true, continueToNextLevel:  true);
    }
    public override UnityEngine.Sprite GetEventIcon()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVPromoCategoriesHandler MonoSingleton<TRVPromoCategoriesHandler>::get_Instance()) != 0)
        {
                return GetIcon(promoCategory:  this.PromoCategory);
        }
        
        return GetIcon(promoCategory:  this.PromoCategory);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        loader.Init(category:  this.PromoCategory);
    }
    public override bool get_IsEventHidden()
    {
        var val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = 1;
        if((-581136352) == 0)
        {
                return (bool)val_10;
        }
        
        if(this.PromoCategory.promoCategoryType == 1)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(EventShouldShow() == false)
        {
                return (bool)val_10;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((GetRemainingLevelsForPromo(currentPromo:  this.PromoCategory)) < 1)
        {
                return (bool)val_10;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = EventShouldShow() ^ 1;
        return (bool)val_10;
    }
    public TRVPromoCategoriesProxyEventHandler()
    {
    
    }

}
