using UnityEngine;
public class RestaurantMasterEconDataHelper
{
    // Methods
    public static RestaurantMasterRewardData ParseCSV()
    {
        var val_1;
        var val_1 = 27413883;
        val_1 = 8211904 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(App.game != 18)
        {
                return RestaurantMasterEconDataHelper.ParseCSV_RRV();
        }
        
        return RestaurantMasterEconDataHelper.ParseCSV_WFO();
    }
    private static RestaurantMasterRewardData ParseCSV_RRV()
    {
        var val_21;
        UnityEngine.Texture val_1 = WGResources.Load<UnityEngine.Texture>(fileName:  -661484912, extension:  -663337856, errorLog:  true);
        string val_2 = text;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        System.String[] val_3 = Split(separator:  478563824);
        object val_4 = new System.Object();
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_5 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        val_21 = 10;
        typeof(RestaurantMasterRewardData).__il2cppRuntimeField_8 = null;
        var val_21 =  - 4;
        if(("GameEvents/RestaurantMaster/RestaurantMasterEcon") != 0)
        {
                return;
        }
    
    }
    private static RestaurantMasterRewardData ParseCSV_WFO()
    {
        var val_21;
        UnityEngine.Texture val_1 = WGResources.Load<UnityEngine.Texture>(fileName:  -661370688, extension:  -663337856, errorLog:  true);
        string val_2 = text;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        System.String[] val_3 = Split(separator:  478563824);
        object val_4 = new System.Object();
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_5 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        val_21 = 10;
        typeof(RestaurantMasterRewardData).__il2cppRuntimeField_8 = null;
        var val_21 =  - 4;
        if(("GameEvents/ForestMaster/ForestMasterEcon") != 0)
        {
                return;
        }
    
    }
    public RestaurantMasterEconDataHelper()
    {
    
    }

}
