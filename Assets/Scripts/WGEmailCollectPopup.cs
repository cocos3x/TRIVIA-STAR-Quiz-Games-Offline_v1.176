using UnityEngine;
public class WGEmailCollectPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject submitGroup;
    private UnityEngine.UI.InputField input;
    private UnityEngine.UI.Button submitButton;
    private UnityEngine.UI.Text rewardSubmitLabel;
    private UnityEngine.GameObject collectGroup;
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.UI.Text rewardCollectLabel;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private string userEmail;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  -58513264, method:  new IntPtr(4236410576));
        this.input.m_OnEndEdit.AddListener(call:  162353152);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -58513264, method:  new IntPtr(4236419792));
        this.submitButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -58513264, method:  new IntPtr(4236429008));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        this.userEmail = "";
        this.submitGroup.SetActive(value:  true);
        this.submitButton.interactable = false;
        this.collectGroup.SetActive(value:  false);
        this.collectButton.interactable = true;
        string val_1 = Localization.Localize(key:  -58380000, defaultValue:  -58380208, useSingularKey:  false);
        GameEcon val_2 = App.getGameEcon;
        object val_9 = 0;
        val_9 = val_9 + 428;
        GameEcon val_3 = App.getGameEcon;
        string val_4 = val_9.ToString(format:  null);
        string val_5 = System.String.Format(format:  -58380000, arg0:  val_9);
        GameEcon val_6 = App.getGameEcon;
        var val_10 = 0;
        val_10 = val_10 + 428;
        GameEcon val_7 = App.getGameEcon;
        string val_8 = val_10.ToString(format:  null);
        if(this.rewardCollectLabel == 0)
        {
            
        }
    
    }
    private void OnValueChanged_Input(string value)
    {
        UnityEngine.UI.Button val_2 = this.submitButton;
        val_2.interactable = false;
        if(value.m_stringLength == 0)
        {
                return;
        }
        
        if((value.m_stringLength.isValidEmail(email:  value)) == false)
        {
                return;
        }
        
        val_2 = this.submitButton;
        val_2.interactable = true;
        this.userEmail = value;
    }
    private void OnClick_SubmitButton()
    {
        var val_6;
        if((System.String.IsNullOrEmpty(value:  this.userEmail)) != false)
        {
                return;
        }
        
        Player val_2 = App.Player;
        mem[160] = this.userEmail;
        Player val_3 = App.Player;
        0.SaveState();
        val_6 = null;
        val_6 = null;
        if(App.networkManager.Reachable() != false)
        {
                WGBonusRewardsHandler val_5 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            RequestDataFlush(immediate:  false, reset:  false);
        }
        
        this.submitGroup.SetActive(value:  false);
        this.collectGroup.SetActive(value:  true);
    }
    private void OnClick_CollectButton()
    {
        int val_8;
        int val_14;
        var val_15;
        this.collectButton.interactable = false;
        GameEcon val_1 = App.getGameEcon;
        val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_15 == 1)
        {
                val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_2 = System.String.Format(format:  -57953760, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        CurrencyController.CreditBalance(value:  new System.Decimal(), source:  "Email Collection", externalParams:  0, animated:  false);
        if(this.coinsAnim != 0)
        {
                Player val_4 = App.Player;
            GameEcon val_5 = App.getGameEcon;
            var val_6 = 0 + 432;
            decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -57924292, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, lo = mem[(0 + 432) + (0)], mid = mem[(0 + 432) + (4)]});
            this.coinsAnim.Set(instantValue:  new System.Decimal() {mid = val_8});
            System.Action val_9 = new System.Action(object:  -57912240, method:  new IntPtr(4237025936));
            this.coinsAnim.OnCompleteCallback = null;
            Player val_10 = App.Player;
            GameEcon val_11 = App.getGameEcon;
            decimal val_12 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -57924308, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            Player val_13 = App.Player;
            this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_14}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
            return;
        }
        
        UnityEngine.GameObject val_15 = this.gameObject;
        SLCWindow.CloseWindow(window:  -57912240, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private bool isValidEmail(string email)
    {
        System.Text.RegularExpressions.Regex val_1 = new System.Text.RegularExpressions.Regex(pattern:  -216807632, options:  1);
        if(null != 0)
        {
                return IsMatch(input:  email);
        }
        
        return IsMatch(input:  email);
    }
    private void OnCoinsAnimFinished()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -57659568, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnDisable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleResponded();
    }
    public WGEmailCollectPopup()
    {
        this.userEmail = "";
    }

}
