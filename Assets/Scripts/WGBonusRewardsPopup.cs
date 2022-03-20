using UnityEngine;
public class WGBonusRewardsPopup : MonoBehaviour
{
    // Fields
    private WGBonusRewardsRow rowObject;
    private UnityEngine.UI.VerticalLayoutGroup rowParent;
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button infoPopupCloseButton;
    private UnityEngine.GameObject infoPopup;
    private UnityEngine.GameObject primaryPopup;
    private UnityEngine.UI.Text bonusLevelText;
    private UnityEngine.UI.Text bonusPointsText;
    
    // Methods
    private void OnEnable()
    {
        this.SetupRequirements();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -360472192, method:  new IntPtr(3934444480));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -360472192, method:  new IntPtr(3934453696));
        this.infoButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -360472192, method:  new IntPtr(3934453696));
        this.infoPopupCloseButton.m_OnClick.AddListener(call:  162246656);
        this.primaryPopup.SetActive(value:  true);
        this.infoPopup.SetActive(value:  false);
        this.SetupText();
    }
    private void SetupRequirements()
    {
        BonusRewardsContainer val_4;
        WGBonusRewardsRow val_7;
        GameEcon val_1 = App.getGameEcon;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_13:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        if((val_4 + 8) == 0)
        {
            goto label_13;
        }
        
        val_7 = this.rowObject;
        if((val_4 + 8) != 1)
        {
                UnityEngine.Transform val_5 = this.rowParent.transform;
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  val_7, parent:  this.rowParent);
            val_7 = val_7;
        }
        
        val_7.Setup(myData:  val_4);
        goto label_13;
        label_5:
        Dispose();
    }
    private void SetupText()
    {
        var val_16;
        UnityEngine.UI.Text val_17;
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        BonusRewardsContainer val_2 = GetNextRewards();
        if((public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance()) != 0)
        {
                val_16 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance();
            val_17 = this.bonusLevelText;
        }
        else
        {
                WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            BonusRewardsContainer val_4 = GetCurrentRewards();
            val_17 = this.bonusLevelText;
            val_16 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance();
        }
        
        string val_5 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance().__il2cppRuntimeField_8.ToString();
        WGBonusRewardsHandler val_6 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        GameEcon val_8 = App.getGameEcon;
        string val_9 = GetProgressThroughCurrentTier().ToString(format:  null);
        GameEcon val_10 = App.getGameEcon;
        string val_11 = public static WGBonusRewardsHandler DefaultHandler<WGBonusRewardsHandler>::get_Instance().__il2cppRuntimeField_C.ToString(format:  null);
        string val_12 = System.String.Format(format:  -1222347616, arg0:  -360193668, arg1:  -360193668);
        WGBonusRewardsHandler val_13 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if(MaxPointsGained() == false)
        {
                return;
        }
    
    }
    private void ToggleInfo()
    {
        UnityEngine.GameObject val_1 = this.primaryPopup.gameObject;
        UnityEngine.GameObject val_2 = this.infoPopup.gameObject;
        this.primaryPopup.SetActive(value:  this.infoPopup.activeSelf);
        UnityEngine.GameObject val_4 = this.infoPopup.gameObject;
        UnityEngine.GameObject val_5 = this.infoPopup.gameObject;
        this.infoPopup.SetActive(value:  this.infoPopup.activeSelf ^ 1);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -359908480, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGBonusRewardsPopup()
    {
    
    }

}
