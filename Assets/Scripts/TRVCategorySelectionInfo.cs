using UnityEngine;
public class TRVCategorySelectionInfo
{
    // Fields
    public string categoryName;
    public System.Collections.Generic.List<WGEventHandler> associatedEvents;
    
    // Methods
    public TRVCategorySelectionInfo()
    {
        this.categoryName = "";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.associatedEvents = null;
    }

}
