using UnityEngine;
public class WordIQFoundWordsMenu : MonoBehaviour
{
    // Fields
    private readonly int[] buttonIndexToLetterCounts;
    private UnityEngine.UI.Text iqStat;
    private WordIQMilestoneDisplay milestoneDisplay;
    private UnityEngine.UI.Text wordsFound;
    private ExtraProgress wordsFoundProgressBar;
    private UnityEngine.UI.Text[] buttonTexts;
    private UnityEngine.UI.Button[] buttons;
    private WordIQFoundWordsScreen foundWordsScreen;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button infoButton;
    
    // Methods
    public void OnButtonClicked(int buttonIndex)
    {
        this.foundWordsScreen.ShowFoundWordsList(numLetters:  this.buttonIndexToLetterCounts[buttonIndex]);
    }
    private void Start()
    {
        UnityEngine.Events.UnityAction val_3;
        var val_4;
        UnityEngine.Events.UnityAction val_6;
        val_3 = null;
        val_3 = new UnityEngine.Events.UnityAction(object:  -933827312, method:  new IntPtr(3361105744));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        val_4 = null;
        val_4 = null;
        val_6 = WordIQFoundWordsMenu.<>c.<>9__11_1;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new UnityEngine.Events.UnityAction(object:  WordIQFoundWordsMenu.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3361114960));
            WordIQFoundWordsMenu.<>c.<>9__11_1 = val_6;
        }
        
        this.infoButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        int val_31;
        var val_32;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_3 = WordIQManagerUI.FormatPoints(iqPoints:  PlayerIQ);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.milestoneDisplay.UpdateMilestoneDisplay(newMilestoneIndex:  GetMilestone(iqPoints:  PlayerIQ));
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_8 = GetTotalFoundWordsCount();
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_10 = GetTotalPossibleFoundWordsCount();
        val_10 = (val_10 >> 6) + (val_10 >> 31);
        val_10 = val_10 * 1000;
        string val_12 = val_8.ToString();
        string val_13 = val_10.ToString();
        string val_14 = -933532584(-933532584) + -1316508080(-1316508080) + -933532588(-933532588);
        this.wordsFoundProgressBar.target = (float)val_10;
        val_31 = val_8;
        this.wordsFoundProgressBar.current = (float)val_31;
        val_32 = 4;
        goto label_12;
        label_28:
        int val_32 = this.buttonIndexToLetterCounts[0];
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_16 = GetFoundWords(numLetters:  val_32);
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.UI.Text val_33 = this.buttonTexts[0];
        string val_19 = Localization.Localize(key:  -933627584, defaultValue:  -933627696, useSingularKey:  false);
        string val_20 = val_32.ToString();
        string val_21 = System.String.Format(format:  -933627584, arg0:  -933532592);
        string val_22 = public static WordIQManager MonoSingleton<WordIQManager>::get_Instance().__il2cppRuntimeField_C.ToString();
        string val_23 = GetPossibleWordsCount(numLetters:  val_32).ToString();
        string val_24 = System.String.Format(format:  -1694782544, arg0:  -933627584, arg1:  -933532596, arg2:  -933532600);
        UnityEngine.UI.Button val_34 = this.buttons[0];
        UnityEngine.GameObject val_25 = val_34.gameObject;
        if((public static WordIQManager MonoSingleton<WordIQManager>::get_Instance().__il2cppRuntimeField_C) > 0)
        {
                0 = 1;
        }
        
        val_34.SetActive(value:  true);
        val_32 = 5;
        label_12:
        if((val_32 - 4) < val_34)
        {
            goto label_28;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsFtuxSeen == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        IsFtuxSeen = true;
        GameBehavior val_30 = App.getBehavior;
    }
    public WordIQFoundWordsMenu()
    {
        this.buttonIndexToLetterCounts = null;
    }
    private void <Start>b__11_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -933116288, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
