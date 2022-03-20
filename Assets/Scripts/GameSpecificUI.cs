using UnityEngine;
[Serializable]
public class GameSpecificUI : ScriptableObject
{
    // Fields
    private static GameSpecificUI m_currentGame;
    public UnityEngine.GameObject statViewPrefab;
    public GridCoinCollectAnimation gridCoinCollectAnimation;
    public AnimatedCoin animatedCoin;
    public UnityEngine.GameObject coinsGainedAnimContents;
    
    // Properties
    public static GameSpecificUI currentGame { get; }
    public AnimatedCoin AnimatedCoin { get; }
    public UnityEngine.GameObject CoinsGainedAnimContents { get; }
    
    // Methods
    public static GameSpecificUI get_currentGame()
    {
        if(GameSpecificUI.m_currentGame != 0)
        {
                return;
        }
        
        UnityEngine.Texture val_2 = WGResources.Load<UnityEngine.Texture>(fileName:  -172145744, extension:  -1053832112, errorLog:  true);
        GameSpecificUI.m_currentGame = "UI/GameSpecificUI";
    }
    public AnimatedCoin get_AnimatedCoin()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(0 == 0)
        {
                return;
        }
        
        ThemesHandler val_3 = App.ThemesHandler;
        if(2621443 == 0)
        {
                return;
        }
        
        ThemesHandler val_5 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.AnimatedCoin;
        }
        
        return 2621443.AnimatedCoin;
    }
    public UnityEngine.GameObject get_CoinsGainedAnimContents()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(0 == 0)
        {
                return;
        }
        
        ThemesHandler val_3 = App.ThemesHandler;
        if(2621443 == 0)
        {
                return;
        }
        
        ThemesHandler val_5 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.CoinsGainedAnimContents;
        }
        
        return 2621443.CoinsGainedAnimContents;
    }
    public GameSpecificUI()
    {
    
    }

}
