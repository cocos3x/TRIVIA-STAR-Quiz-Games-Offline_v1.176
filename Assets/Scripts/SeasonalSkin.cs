using UnityEngine;
public class SeasonalSkin
{
    // Fields
    public string assetNameHead;
    public System.DateTime activeDate;
    public int durationInDays;
    
    // Methods
    public bool Active()
    {
        ulong val_2;
        ulong val_7;
        System.DateTime val_1 = DateTimeCheat.Now;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this.activeDate})) == false)
        {
                return (bool)0;
        }
        
        System.DateTime val_5 = DateTimeCheat.Now;
        System.DateTime val_6 = AddDays(value:  null);
        0 = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = val_7});
        return (bool)0;
    }
    public string GetAssetName(string textureId = "")
    {
        return this.assetNameHead + textureId + 1975550080;
    }
    public SeasonalSkin()
    {
    
    }

}
