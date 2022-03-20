using UnityEngine;
public class DailyChallengeZooTilesConfig : ScriptableObject
{
    // Fields
    private UnityEngine.Sprite[] smallTiles;
    private UnityEngine.Sprite[] largeTiles;
    
    // Properties
    private System.Collections.Generic.Dictionary<DailyChallengeZooTilesConfig.DailyChallengeZooTileType, UnityEngine.Sprite[]> zooTilesPool { get; }
    
    // Methods
    private System.Collections.Generic.Dictionary<DailyChallengeZooTilesConfig.DailyChallengeZooTileType, UnityEngine.Sprite[]> get_zooTilesPool()
    {
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        Add(key:  0, value:  this.smallTiles);
        Add(key:  1, value:  this.largeTiles);
    }
    public UnityEngine.Sprite GetSprite(DailyChallengeZooTilesConfig.DailyChallengeZooTileType type, string name)
    {
        var val_7;
        System.Collections.Generic.Dictionary<DailyChallengeZooTileType, UnityEngine.Sprite[]> val_1 = this.zooTilesPool;
        object val_2 = this.Item[type];
        var val_7 = 0;
        label_9:
        if(val_7 >= this.smallTiles)
        {
            goto label_3;
        }
        
        val_7 = mem[this.largeTiles + 0];
        string val_3 = val_7.name;
        string val_4 = val_7.ToLower();
        string val_5 = name.ToLower();
        val_7 = val_7 + 1;
        if((val_7.Contains(value:  name)) == false)
        {
            goto label_9;
        }
        
        return;
        label_3:
        val_7 = 0;
    }
    public DailyChallengeZooTilesConfig()
    {
    
    }

}
