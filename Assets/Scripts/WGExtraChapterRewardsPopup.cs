using UnityEngine;
public class WGExtraChapterRewardsPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button CloseButton;
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Text descriptionText;
    private UnityEngine.UI.Text timeRemainingText;
    private UnityEngine.UI.Text playButtonText;
    
    // Methods
    public void Init(bool particpating)
    {
        var val_6;
        var val_7;
        var val_8;
        if(particpating != false)
        {
                string val_1 = Localization.Localize(key:  -52283072, defaultValue:  -52283248, useSingularKey:  false);
            val_6 = "chapter_rewards_unlocked";
            GameEcon val_2 = App.getGameEcon;
            val_7 = 0;
            val_8 = 1152921504622129152;
        }
        else
        {
                string val_3 = Localization.Localize(key:  -52282768, defaultValue:  -52282944, useSingularKey:  false);
            val_6 = "complete_chapter";
            GameEcon val_4 = App.getGameEcon;
            val_7 = 0;
            val_8 = 1152921504622129152;
        }
        
        string val_5 = System.String.Format(format:  -52282768, arg0:  15282176);
        if(this.descriptionText != 0)
        {
                return;
        }
    
    }
    private void UpdateTimeRemaining()
    {
        var val_6 = 28368612;
        val_6 = 7259572 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        if(ExtraChapterEventHandler._Instance != 0)
        {
                System.TimeSpan val_1 = TimeRemaining;
            double val_2 = ???.TotalSeconds;
            if(ExtraChapterEventHandler._Instance > 0)
        {
                if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
            string val_3 = ExtraChapterEventHandler._Instance.TimeRemainingFormatted;
            if(this.timeRemainingText != 0)
        {
                return;
        }
        
            return;
        }
        
        }
        
        UnityEngine.GameObject val_4 = this.playButton.gameObject;
        this.playButton.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.continueButton.gameObject;
        this.continueButton.SetActive(value:  false);
        this.CancelInvoke(methodName:  -52150096);
    }
    private void OnEnable()
    {
        var val_14;
        var val_15;
        this.InvokeRepeating(methodName:  -52150096, time:  null, repeatRate:  null);
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -51954400, method:  new IntPtr(4242953888));
        this.CloseButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_2 = this.playButton.gameObject;
        GameBehavior val_3 = App.getBehavior;
        this.playButton.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.continueButton.gameObject;
        GameBehavior val_5 = App.getBehavior;
        if(this.continueButton != 0)
        {
                -1 = 1;
        }
        
        this.continueButton.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -51954400, method:  new IntPtr(4242971296));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_7 = null;
        val_14 = val_7;
        val_7 = new UnityEngine.Events.UnityAction(object:  -51954400, method:  new IntPtr(4242971296));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        if(this.playButtonText == 0)
        {
                UnityEngine.Debug.LogError(message:  -51982688);
            return;
        }
        
        GameBehavior val_9 = App.getBehavior;
        if(0 == 1)
        {
                string val_10 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
            Player val_11 = App.Player;
            val_14 = 0;
            val_15 = "level_#_upper";
            string val_12 = System.String.Format(format:  -1672741904, arg0:  13152256);
        }
        else
        {
                val_15 = "continue_upper";
            string val_13 = Localization.Localize(key:  -1468908784, defaultValue:  -1621736080, useSingularKey:  false);
        }
        
        if(this.playButtonText != 0)
        {
                return;
        }
    
    }
    private void PressCloseButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -51801440, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(ExtraChapterEventHandler._Instance == 0)
        {
                return;
        }
        
        goto typeof(ExtraChapterEventHandler).__il2cppRuntimeField_2C4;
    }
    private void PressPlayButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
        GameBehavior val_2 = App.getBehavior;
        if(0 == 2)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public WGExtraChapterRewardsPopup()
    {
    
    }

}
