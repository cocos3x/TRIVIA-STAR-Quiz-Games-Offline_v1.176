using UnityEngine;
public class UITheme : ScriptableObject
{
    // Fields
    public Themes themeType;
    public ThemeSettings themeSettings;
    public System.Collections.Generic.List<UnityEngine.Sprite> sprites;
    public System.Collections.Generic.List<UnityEngine.Texture> textures;
    public System.Collections.Generic.List<UnityEngine.Font> fonts;
    public System.Collections.Generic.List<ThemeTextSettings> themeTextSettings;
    private UnityEngine.GameObject statViewPrefab;
    private UnityEngine.GameObject _statViewPrefab;
    private UnityEngine.GameObject _statViewPrefab_anchored;
    private GridCoinCollectAnimation gridCoinCollectAnimation;
    private GridCoinCollectAnimation _gridCoinCollectAnimation;
    private AnimatedCoin animatedCoin;
    private AnimatedCoin _animatedCoin;
    private UnityEngine.GameObject coinsGainedAnimContents;
    private UnityEngine.GameObject _coinsGainedAnimContents;
    private UnityEngine.GameObject goldenCurrencyStatViewPrefab;
    private UnityEngine.GameObject _goldenCurrencyStatViewPrefab;
    private UnityEngine.GameObject _goldenCurrencyStatViewPrefab_anchored;
    private UnityEngine.GameObject goldCurrencyParticleSystem;
    private UnityEngine.GameObject _goldCurrencyParticleSystem;
    private UnityEngine.GameObject gemCurrencyStatViewPrefab;
    private UnityEngine.GameObject _gemCurrencyStatViewPrefab;
    private UnityEngine.GameObject _gemCurrencyStatViewPrefab_anchored;
    private UnityEngine.GameObject gemCurrencyParticleSystem;
    private UnityEngine.GameObject _gemCurrencyParticleSystem;
    private UnityEngine.GameObject coinCurrencyStatViewPrefab;
    private UnityEngine.GameObject _coinCurrencyStatViewPrefab;
    private UnityEngine.GameObject _coinCurrencyStatViewPrefab_anchored;
    private UnityEngine.GameObject coinCurrencyParticleSystem;
    private UnityEngine.GameObject _coinCurrencyParticleSystem;
    private UnityEngine.GameObject petsFoodStatViewPrefab;
    private UnityEngine.GameObject _petsFoodStatViewPrefab;
    private UnityEngine.GameObject _petsFoodStatViewPrefab_anchored;
    private UnityEngine.GameObject petsFoodCurrencyParticleSystem;
    private UnityEngine.GameObject _petsFoodCurrencyParticleSystem;
    private UnityEngine.GameObject _spinCurrencyStatViewPrefab;
    private UnityEngine.GameObject _spinCurrencyStatViewPrefab_anchored;
    private UnityEngine.GameObject _spinCurrencyParticleSystem;
    private UnityEngine.GameObject _streakCurrencyStatViewPrefab;
    private UnityEngine.GameObject _streakCurrencyStatViewPrefab_anchored;
    private UnityEngine.GameObject _diceRollStatViewPrefab;
    private UnityEngine.GameObject _diceRollStatViewPrefab_anchored;
    private UnityEngine.GameObject _diceRollCurrencyParticleSystem;
    private UnityEngine.GameObject _petsCardStatViewPrefab;
    private UnityEngine.GameObject _petsCardStatViewPrefab_anchored;
    private UnityEngine.GameObject _petsCardCurrencyParticleSystem;
    public WordIQCellOverlay wordIQCell;
    public WordIQLineAnim wordIQNewWordTag;
    private WordIQLineAnim wordIQNewWordAnswered;
    private WordIQLineAnim _wordIQNewWordAnswered;
    public UnityEngine.Sprite wordIQMilestoneColorableSprite;
    public UnityEngine.Sprite wordIQMilestoneMasterSprite;
    public UnityEngine.UI.Image categoryLetterCell;
    public UIThemeTemplate[] graphicTemplates;
    
    // Properties
    public UnityEngine.GameObject StatViewPrefab { get; }
    public UnityEngine.GameObject StatViewPrefab_anchored { get; }
    public GridCoinCollectAnimation GridCoinCollectAnimation { get; }
    public AnimatedCoin AnimatedCoin { get; }
    public UnityEngine.GameObject CoinsGainedAnimContents { get; }
    public UnityEngine.GameObject GoldenCurrencyStatViewPrefab { get; }
    public UnityEngine.GameObject GoldenCurrencyStatViewPrefab_anchored { get; }
    public UnityEngine.GameObject GoldCurrencyParticleSystem { get; }
    public UnityEngine.GameObject GemCurrencyStatViewPrefab { get; }
    public UnityEngine.GameObject GemCurrencyStatViewPrefab_anchored { get; }
    public UnityEngine.GameObject GemCurrencyParticleSystem { get; }
    public UnityEngine.GameObject CoinCurrencyStatViewPrefab { get; }
    public UnityEngine.GameObject CoinCurrencyStatViewPrefab_anchored { get; }
    public UnityEngine.GameObject CoinCurrencyParticleSystem { get; }
    public UnityEngine.GameObject PetsFoodStatViewPrefab { get; }
    public UnityEngine.GameObject PetsFoodStatViewPrefab_anchored { get; }
    public UnityEngine.GameObject PetsFoodCurrencyParticleSystem { get; }
    public UnityEngine.GameObject SpinCurrencyStatViewPrefab { get; }
    public UnityEngine.GameObject SpinCurrencyStatViewPrefab_anchored { get; }
    public UnityEngine.GameObject SpinCurrencyParticleSystem { get; }
    public UnityEngine.GameObject StreakStatViewPrefab { get; }
    public UnityEngine.GameObject StreakStatViewPrefab_anchored { get; }
    public UnityEngine.GameObject DiceRollStatViewPrefab { get; }
    public UnityEngine.GameObject DiceRollStatViewPrefab_anchored { get; }
    public UnityEngine.GameObject DiceRollCurrencyParticleSystem { get; }
    public UnityEngine.GameObject PetsCardStatViewPrefab { get; }
    public UnityEngine.GameObject PetCardsStatViewPrefab_anchored { get; }
    public UnityEngine.GameObject PetsCardCurrencyParticleSystem { get; }
    public WordIQLineAnim WordIQNewWordAnswered { get; }
    
    // Methods
    public UnityEngine.GameObject get_StatViewPrefab()
    {
        if(this._statViewPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -676225520);
        this._statViewPrefab = "StatViews";
    }
    public UnityEngine.GameObject get_StatViewPrefab_anchored()
    {
        if(this._statViewPrefab_anchored != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -676096944);
        this._statViewPrefab_anchored = "StatViews";
    }
    public GridCoinCollectAnimation get_GridCoinCollectAnimation()
    {
        if(this._gridCoinCollectAnimation != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -676225424);
        this._gridCoinCollectAnimation = "StatViews";
    }
    public AnimatedCoin get_AnimatedCoin()
    {
        if(this._animatedCoin != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -676225424);
        this._animatedCoin = "StatViews";
    }
    public UnityEngine.GameObject get_CoinsGainedAnimContents()
    {
        if(this._coinsGainedAnimContents != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -675709616);
        this._coinsGainedAnimContents = "StatViews";
    }
    public UnityEngine.GameObject get_GoldenCurrencyStatViewPrefab()
    {
        if(this._goldenCurrencyStatViewPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -675581136);
        this._goldenCurrencyStatViewPrefab = "StatViews";
    }
    public UnityEngine.GameObject get_GoldenCurrencyStatViewPrefab_anchored()
    {
        if(this._goldenCurrencyStatViewPrefab_anchored != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -675452640);
        this._goldenCurrencyStatViewPrefab_anchored = "StatViews";
    }
    public UnityEngine.GameObject get_GoldCurrencyParticleSystem()
    {
        if(this._goldCurrencyParticleSystem != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -675324128);
        this._goldCurrencyParticleSystem = "StatViews";
    }
    public UnityEngine.GameObject get_GemCurrencyStatViewPrefab()
    {
        if(this._gemCurrencyStatViewPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -675195616);
        this._gemCurrencyStatViewPrefab = "StatViews";
    }
    public UnityEngine.GameObject get_GemCurrencyStatViewPrefab_anchored()
    {
        if(this._gemCurrencyStatViewPrefab_anchored != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -675067136);
        this._gemCurrencyStatViewPrefab_anchored = "StatViews";
    }
    public UnityEngine.GameObject get_GemCurrencyParticleSystem()
    {
        if(this._gemCurrencyParticleSystem != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -674938640);
        this._gemCurrencyParticleSystem = "StatViews";
    }
    public UnityEngine.GameObject get_CoinCurrencyStatViewPrefab()
    {
        if(this._coinCurrencyStatViewPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -674810144);
        this._coinCurrencyStatViewPrefab = "StatViews";
    }
    public UnityEngine.GameObject get_CoinCurrencyStatViewPrefab_anchored()
    {
        if(this._coinCurrencyStatViewPrefab_anchored != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -674681632);
        this._coinCurrencyStatViewPrefab_anchored = "StatViews";
    }
    public UnityEngine.GameObject get_CoinCurrencyParticleSystem()
    {
        if(this._coinCurrencyParticleSystem != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -674553104);
        this._coinCurrencyParticleSystem = "StatViews";
    }
    public UnityEngine.GameObject get_PetsFoodStatViewPrefab()
    {
        if(this._petsFoodStatViewPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -674424608);
        this._petsFoodStatViewPrefab = "StatViews";
    }
    public UnityEngine.GameObject get_PetsFoodStatViewPrefab_anchored()
    {
        if(this._petsFoodStatViewPrefab_anchored != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -674296112);
        this._petsFoodStatViewPrefab_anchored = "StatViews";
    }
    public UnityEngine.GameObject get_PetsFoodCurrencyParticleSystem()
    {
        if(this._petsFoodCurrencyParticleSystem != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -674167600);
        this._petsFoodCurrencyParticleSystem = "StatViews";
    }
    public UnityEngine.GameObject get_SpinCurrencyStatViewPrefab()
    {
        if(this._spinCurrencyStatViewPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -674039104);
        this._spinCurrencyStatViewPrefab = "StatViews";
    }
    public UnityEngine.GameObject get_SpinCurrencyStatViewPrefab_anchored()
    {
        if(this._spinCurrencyStatViewPrefab_anchored != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -673910624);
        this._spinCurrencyStatViewPrefab_anchored = "StatViews";
    }
    public UnityEngine.GameObject get_SpinCurrencyParticleSystem()
    {
        if(this._spinCurrencyParticleSystem != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -673782112);
        this._spinCurrencyParticleSystem = "StatViews";
    }
    public UnityEngine.GameObject get_StreakStatViewPrefab()
    {
        if(this._streakCurrencyStatViewPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -673653616);
        this._streakCurrencyStatViewPrefab = "StatViews";
    }
    public UnityEngine.GameObject get_StreakStatViewPrefab_anchored()
    {
        if(this._streakCurrencyStatViewPrefab_anchored != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -673525120);
        this._streakCurrencyStatViewPrefab_anchored = "StatViews";
    }
    public UnityEngine.GameObject get_DiceRollStatViewPrefab()
    {
        if(this._diceRollStatViewPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -673396608);
        this._diceRollStatViewPrefab = "StatViews";
    }
    public UnityEngine.GameObject get_DiceRollStatViewPrefab_anchored()
    {
        if(this._diceRollStatViewPrefab_anchored != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -673268112);
        this._diceRollStatViewPrefab_anchored = "StatViews";
    }
    public UnityEngine.GameObject get_DiceRollCurrencyParticleSystem()
    {
        if(this._diceRollCurrencyParticleSystem != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -673139600);
        this._diceRollCurrencyParticleSystem = "StatViews";
    }
    public UnityEngine.GameObject get_PetsCardStatViewPrefab()
    {
        if(this._petsCardStatViewPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -673011088);
        this._petsCardStatViewPrefab = "StatViews";
    }
    public UnityEngine.GameObject get_PetCardsStatViewPrefab_anchored()
    {
        if(this._petsCardStatViewPrefab_anchored != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -672882592);
        this._petsCardStatViewPrefab_anchored = "StatViews";
    }
    public UnityEngine.GameObject get_PetsCardCurrencyParticleSystem()
    {
        if(this._petsCardCurrencyParticleSystem != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -676225424, prefabName:  -672754080);
        this._petsCardCurrencyParticleSystem = "StatViews";
    }
    public WordIQLineAnim get_WordIQNewWordAnswered()
    {
        if(this._wordIQNewWordAnswered != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -672624544);
        this._wordIQNewWordAnswered = "WordIQ";
    }
    public UITheme()
    {
        this.themeSettings = new ThemeSettings();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.themeTextSettings = null;
    }

}
