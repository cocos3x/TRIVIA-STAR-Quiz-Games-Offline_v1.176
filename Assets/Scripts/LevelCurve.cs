using UnityEngine;
public class WADataParser.LevelCurve
{
    // Fields
    public string Bucket;
    public string Language;
    public System.Collections.Generic.List<GameLevel> Levels;
    
    // Methods
    public WADataParser.LevelCurve(string language, string bucket, System.Collections.Generic.List<GameLevel> flattenedLevels)
    {
        System.Collections.Generic.List<GameLevel> val_1 = flattenedLevels;
        val_1 = new System.Object();
        this.Bucket = bucket;
        this.Language = language;
        System.Collections.Generic.List<ZooTile> val_2 = new System.Collections.Generic.List<ZooTile>(collection:  val_1);
        this.Levels = null;
    }

}
