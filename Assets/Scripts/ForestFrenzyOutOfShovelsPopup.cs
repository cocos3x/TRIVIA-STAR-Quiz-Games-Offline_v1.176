using UnityEngine;
public class ForestFrenzyOutOfShovelsPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Text playButtonText;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1390621440, method:  new IntPtr(2904303136));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1390621440, method:  new IntPtr(2904312352));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        string val_3 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_4 = App.Player;
        string val_5 = System.String.Format(format:  -1672741904, arg0:  13152256);
        string val_6 = Localization.Localize(key:  -1390645552, defaultValue:  -1390645728, useSingularKey:  false);
        string val_7 = Localization.Localize(key:  1799709296, defaultValue:  1098586544, useSingularKey:  false);
        string val_8 = Localization.Localize(key:  1799696720, defaultValue:  1098586544, useSingularKey:  false);
        string val_9 = System.String.Format(format:  -1390645552, arg0:  1799709296, arg1:  1799696720);
        if(this.description != 0)
        {
                return;
        }
    
    }
    private void OnCloseButtonClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1390484864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnPlayButtonClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1390372864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnPlayLevelButtonClicked();
    }
    public ForestFrenzyOutOfShovelsPopup()
    {
    
    }

}
