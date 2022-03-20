using UnityEngine;
public class TRVExpertEntryButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button entryButton;
    private UnityEngine.UI.Image upgradeArrow;
    
    // Methods
    private void Start()
    {
        this.entryButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -613020768, method:  new IntPtr(3681921504));
        this.entryButton.m_OnClick.AddListener(call:  162246656);
        this.CheckUpgradeArrow();
    }
    private void OnClick()
    {
        GameBehavior val_1 = App.getBehavior;
        object val_3 = 0.GetComponent<System.Object>();
        System.Action val_4 = new System.Action(object:  -612890336, method:  new IntPtr(3682051936));
        mem[20] = null;
    }
    private void CheckUpgradeArrow()
    {
        UnityEngine.GameObject val_1 = this.upgradeArrow.gameObject;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.upgradeArrow.SetActive(value:  AnyExpertReadyToUpgrade());
    }
    public TRVExpertEntryButton()
    {
    
    }

}
