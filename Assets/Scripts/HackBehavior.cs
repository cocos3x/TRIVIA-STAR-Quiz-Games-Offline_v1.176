using UnityEngine;
public class HackBehavior
{
    // Methods
    public virtual string SR_ChapterName()
    {
    
    }
    public virtual void ReloadGameplayLevel()
    {
        UnityEngine.Debug.LogError(message:  -756980416);
    }
    public virtual void Hack_CompleteLevelBehavior()
    {
        UnityEngine.Debug.LogError(message:  -756868240);
    }
    public virtual void Hack_CompleteChapterBehavior()
    {
        UnityEngine.Debug.LogError(message:  -756756096);
    }
    public virtual void Hack_RestartLevel()
    {
        UnityEngine.Debug.LogError(message:  -756643952);
    }
    public virtual void Hack_OnLevelChanged()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100701168) == 0)
        {
                return;
        }
        
        if(WGChallengeWordsManager.IsFeatureUnlocked == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_OnLevelChanged();
    }
    public virtual SROptions GetGameSpecificSROptions()
    {
        return SuperLuckySROptionsParent<System.Object>.Instance;
    }
    public virtual void SetInfinityMode(bool setTo)
    {
        var val_2;
        var val_2 = 21228887;
        val_2 = 14396900 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        string val_1 = -756307808(-756307808) + 295313408;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -756307808, displayTime:  null);
    }
    public virtual void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        UnityEngine.Debug.LogWarning(message:  -756191616);
    }
    public virtual void AppendCategoriesInfo(ref System.Text.StringBuilder builder)
    {
        UnityEngine.Debug.LogWarning(message:  -756071344);
    }
    public virtual void ResetPlayer()
    {
    
    }
    public HackBehavior()
    {
    
    }

}
