using UnityEngine;
public class WFOLevelCompletePopup : LevelCompletePopup
{
    // Fields
    private bool isChapterCleared;
    private System.Nullable<SceneType> <sceneToLoadOnClosed>k__BackingField;
    
    // Properties
    public System.Nullable<SceneType> sceneToLoadOnClosed { get; set; }
    
    // Methods
    public System.Nullable<SceneType> get_sceneToLoadOnClosed()
    {
        this = R1 + 88;
        mem[1152921512827774228] = R1 + 92;
        return (System.Nullable<SceneType>)this;
    }
    public void set_sceneToLoadOnClosed(System.Nullable<SceneType> value)
    {
        this.<sceneToLoadOnClosed>k__BackingField = value;
        mem[1152921512827886316] = ???;
    }
    public override void ShowWithEffects()
    {
        Player val_1 = App.Player;
        this.isChapterCleared = ChapterBookLogic.ShowChapterComplete(playerLevel:  0);
        0.Setup(shouldBeShowing:  true);
    }
    public override void HandleWindowClose(bool isChapterClearWindowClosed)
    {
        var val_9;
        var val_10;
        val_9 = isChapterClearWindowClosed;
        if((R2 & 255) == 0)
        {
                SceneType val_1 = this.<sceneToLoadOnClosed>k__BackingField.Value;
            val_10 = ;
        }
        else
        {
                val_10 = 2;
        }
        
        if((this.isChapterCleared != false) && (val_9 != true))
        {
                val_10.blocksRaycasts = true;
            val_10.Setup(shouldBeShowing:  false);
            val_10.Setup(shouldBeShowing:  true, showRewards:  true);
            this.PlayStartAnims();
            return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -368670320, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        GameBehavior val_3 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_5 = ShowInterstitial(context:  2);
        SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
        if(0 == 0)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
        0.UpdateMyProfileInfo(force:  false);
    }
    public WFOLevelCompletePopup()
    {
    
    }

}
