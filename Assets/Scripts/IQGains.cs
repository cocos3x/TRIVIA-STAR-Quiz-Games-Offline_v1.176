using UnityEngine;
public class IQGains
{
    // Fields
    public float levelClearPoints;
    public float newWordsFoundPoints;
    
    // Properties
    public float Total { get; }
    
    // Methods
    public float get_Total()
    {
        float val_1 = this.levelClearPoints;
        val_1 = val_1 + this.newWordsFoundPoints;
        return (float)val_1;
    }
    public IQGains(float levelClearPts, float newWordPts)
    {
        this.levelClearPoints = R1;
        this.newWordsFoundPoints = R2;
    }

}
