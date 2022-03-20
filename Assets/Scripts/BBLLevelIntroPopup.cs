using UnityEngine;
public class BBLLevelIntroPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text levelLabel;
    private BlockPuzzleMagic.GoalDisplayIcon goalDisplayIconPrefab;
    private UnityEngine.RectTransform displayContainer;
    private UnityEngine.UI.Button buttonClose;
    private UnityEngine.UI.Button buttonProceed;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  2126940800, method:  new IntPtr(2126906560));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  2126940800, method:  new IntPtr(2126915776));
        this.buttonProceed.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        this.Init();
    }
    private void Init()
    {
        UnityEngine.UI.Text val_8;
        var val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = this.levelLabel;
        string val_2 = System.String.Format(format:  2127161280, arg0:  13152256);
        val_9 = 4;
        var val_8 =  - 4;
    }
    private void OnCloseClicked()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnProceedClicked()
    {
        var val_9;
        System.Action val_11;
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        bool val_2 = 0.RefreshPlayerLives();
        BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
        if(33453552 >= 1)
        {
                UnityEngine.GameObject val_4 = this.gameObject;
            this.SetActive(value:  false);
            return;
        }
        
        GameBehavior val_5 = App.getBehavior;
        val_9 = null;
        val_9 = null;
        val_11 = BBLLevelIntroPopup.<>c.<>9__9_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Action(object:  BBLLevelIntroPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2127406880));
            BBLLevelIntroPopup.<>c.<>9__9_0 = val_11;
        }
        
        0.Init(onCloseAction:  7454720);
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  2127431904, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private bool IsFirstTimeGoalShown(BlockPuzzleMagic.Goal goal)
    {
        bool val_4;
        var val_5;
        var val_6;
        val_4 = 35642314;
        val_5 = 0;
        Player val_1 = App.Player;
        if(0 != 0)
        {
                val_4 = mem[1179403827];
        }
        
        GoalType val_4 = goal.goalType;
        val_4 = val_4 - 1;
        if(val_4 > 4)
        {
                return false;
        }
        
        var val_2 = 14741344 + (14741344 + ((goal.goalType - 1)) << 2);
        if(val_4 == 4)
        {
                14741344 + ((goal.goalType - 1)) << 2 = (14741344 + ((goal.goalType - 1)) << 2) & (val_4 << (14741344 + ((goal.goalType - 1)) << 2));
            14741344 + ((goal.goalType - 1)) << 2 = (14741344 + ((goal.goalType - 1)) << 2) & (val_4 >> 32);
            14741344 + ((goal.goalType - 1)) << 2 = (14741344 + ((goal.goalType - 1)) << 2) & ((IP) >> 32);
            14741344 + ((goal.goalType - 1)) << 2 = (14741344 + ((goal.goalType - 1)) << 2) & (val_4 >> (14741344 + ((goal.goalType - 1)) << 2));
            14741344 + ((goal.goalType - 1)) << 2 = (14741344 + ((goal.goalType - 1)) << 2) & ((IP) >> ((((14741344 + ((goal.goalType - 1)) << 2 & (mem[1179403827]) << 14741344 + ((goal.goalType - 1)) << 2) & (mem[1179403827]) >> 32) & (IP) >> 32) & (mem[1179403827]) >> (((14741344 + ((goal.goalType - );
        }
        
        val_6 = 10;
        bool val_3 = R6.GetFtuxStatus(ftuxId:  8);
        val_3 = val_3 ^ 1;
        return (bool)val_3;
    }
    public BBLLevelIntroPopup()
    {
    
    }

}
