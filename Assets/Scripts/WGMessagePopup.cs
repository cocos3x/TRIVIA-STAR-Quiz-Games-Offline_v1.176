using UnityEngine;
public class WGMessagePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text title;
    private UnityEngine.UI.Text message;
    private UnityEngine.UI.Button close_button;
    private UnityEngine.UI.Button[] response_buttons;
    private UnityEngine.UI.Text[] response_buttons_text;
    private GemsCollectAnimationInstantiator gemsCollectAnimation;
    private WADPetFoodAnimationInstantiator petFoodCollectAnimation;
    private GridCoinCollectAnimationInstantiator coinCollectAnimation;
    private System.Func<bool>[] current_button_callbacks;
    private decimal showCollectAmount;
    private string showCollectType;
    private int dialogClickedIndex;
    
    // Methods
    private void Awake()
    {
        var val_3 = 0;
        goto label_1;
        label_9:
        if(new System.Object() != 0)
        {
                typeof(WGMessagePopup.<>c__DisplayClass11_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        typeof(WGMessagePopup.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = val_3;
        UnityEngine.UI.Button val_3 = this.response_buttons[val_3];
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  391692288, method:  new IntPtr(20262000));
        this.response_buttons[0x0][0].m_OnClick.AddListener(call:  162246656);
        val_3 = 1;
        label_1:
        if(val_3 < this.response_buttons[0x0][0].m_OnClick)
        {
            goto label_9;
        }
    
    }
    public void SetupMessage(string titleTxt, string messageTxt, bool[] shownButtons, string[] buttonTexts, bool showClose = True, System.Func<bool>[] buttonCallbacks, decimal collectAmount, string collectType = "credits")
    {
        float val_43;
        float val_44;
        WGMessagePopup val_54;
        var val_55;
        UnityEngine.GameObject val_56;
        var val_57;
        var val_58;
        string val_59;
        val_54 = this;
        if((System.String.IsNullOrEmpty(value:  titleTxt)) != false)
        {
                UnityEngine.Transform val_2 = this.title.transform;
            UnityEngine.Transform val_3 = this.title.parent;
            if(this.title != 0)
        {
                UnityEngine.Transform val_5 = this.title.transform;
            UnityEngine.Transform val_6 = this.title.parent;
            val_54 = this;
            UnityEngine.GameObject val_7 = this.title.gameObject;
            this.title.SetActive(value:  false);
        }
        else
        {
                UnityEngine.GameObject val_8 = this.title.gameObject;
            this.title.SetActive(value:  false);
            val_54 = this;
        }
        
        }
        
        mem[1152921513217473644] = buttonCallbacks;
        val_55 = 0;
        mem[1152921513217473648] = collectAmount.flags;
        mem[1152921513217473652] = collectAmount.hi;
        mem[1152921513217473656] = collectAmount.lo;
        mem[1152921513217473660] = collectAmount.mid;
        mem[1152921513217473664] = collectType;
        goto label_15;
        label_31:
        var val_9 = mem[1152921513217473624] + 0;
        UnityEngine.GameObject val_10 = (mem[1152921513217473624] + 0) + 16.gameObject;
        (mem[1152921513217473624] + 0) + 16.SetActive(value:  true);
        var val_11 = mem[1152921513217473628] + 0;
        val_54 = this;
        var val_12 = mem[1152921513217473624] + 0;
        (mem[1152921513217473624] + 0) + 16.interactable = true;
        val_55 = 1;
        label_15:
        if(val_55 < (mem[1152921513217473624] + 12))
        {
            goto label_31;
        }
        
        UnityEngine.GameObject val_13 = mem[1152921513217473620].gameObject;
        val_56 = 0;
        mem[1152921513217473620].SetActive(value:  showClose);
        val_57 = null;
        val_57 = null;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = mem[1152921513217473648], hi = mem[1152921513217473652], lo = mem[1152921513217473656], mid = mem[1152921513217473660]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                val_58 = 1152921504765685760;
            val_59 = collectType;
            if(mem[1152921513217473640] != 0)
        {
                UnityEngine.GameObject val_16 = mem[1152921513217473640].gameObject;
            if(mem[1152921513217473640] != 0)
        {
                UnityEngine.GameObject val_18 = mem[1152921513217473640].gameObject;
            mem[1152921513217473640].SetActive(value:  false);
        }
        
        }
        
            if(((System.String.op_Inequality(a:  val_59, b:  -1930648496)) != false) && (mem[1152921513217473632] != 0))
        {
                UnityEngine.GameObject val_21 = mem[1152921513217473632].gameObject;
            if(mem[1152921513217473632] != 0)
        {
                UnityEngine.GameObject val_23 = mem[1152921513217473632].gameObject;
            mem[1152921513217473632].SetActive(value:  false);
        }
        
        }
        
            if(((System.String.op_Inequality(a:  val_59, b:  -1827757824)) != false) && (mem[1152921513217473636] != 0))
        {
                UnityEngine.GameObject val_26 = mem[1152921513217473636].gameObject;
            if(mem[1152921513217473636] != 0)
        {
                UnityEngine.GameObject val_28 = mem[1152921513217473636].gameObject;
            mem[1152921513217473636].SetActive(value:  false);
        }
        
        }
        
            System.Action val_29 = new System.Action(object:  20692032, method:  new IntPtr(20665840));
            DeviceKeypressManager.AddBackAction(backAction:  7454720);
            return;
        }
        
        val_59 = this;
        if((System.String.op_Equality(a:  collectType, b:  2129282688)) != false)
        {
                if(mem[1152921513217473640] == 0)
        {
                val_56 = null;
            val_56 = new UnityEngine.GameObject(name:  20666864);
            UnityEngine.Transform val_33 = transform;
            UnityEngine.Transform val_34 = this.transform;
            SetParent(p:  20692032);
            UnityEngine.Transform val_35 = transform;
            SetAsLastSibling();
            UnityEngine.Transform val_36 = transform;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.zero;
            localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_38 = transform;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.one;
            localScale = new UnityEngine.Vector3();
            object val_40 = AddComponent<System.Object>();
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.zero;
            UnityEngine.Vector2 val_42 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 3.444765E-38f});
            sizeDelta = new UnityEngine.Vector2() {x = val_43, y = val_44};
            UnityEngine.Vector2 val_45 = new UnityEngine.Vector2(x:  val_42.x, y:  val_42.y);
            anchorMax = new UnityEngine.Vector2() {x = val_45.x, y = val_45.y};
            anchorMin = new UnityEngine.Vector2() {x = val_45.x, y = val_45.y};
            UnityEngine.Vector2 val_46 = new UnityEngine.Vector2(x:  val_42.x, y:  val_42.y);
            anchoredPosition = new UnityEngine.Vector2() {x = val_46.x, y = val_46.y};
            val_59 = this;
            object val_47 = AddComponent<System.Object>();
            mem[1152921513217473640] = val_56;
            typeof(UnityEngine.GameObject).__il2cppRuntimeField_10 = 0;
        }
        
        }
        
        val_58 = 1152921504765685760;
        if(157720576 != 0)
        {
                if(typeof(UnityEngine.GameObject).__il2cppRuntimeField_14 != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(mem[1152921513217473632] != 0)
        {
                if((mem[1152921513217473632] + 20) != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(mem[1152921513217473636] == 0)
        {
                return;
        }
        
        if((mem[1152921513217473636] + 20) == 0)
        {
                return;
        }
        
        mem2[0] = 0;
    }
    public void OnDialogClick(int index)
    {
        int val_16;
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        float val_28;
        int val_29;
        decimal val_30;
        UnityEngine.GameObject val_31;
        var val_32;
        UnityEngine.GameObject val_33;
        int val_34;
        int val_35;
        int val_36;
        int val_37;
        var val_38;
        val_28 = this;
        val_29 = index;
        val_30 = this.showCollectAmount;
        mem[1152921513217836548] = val_29;
        val_32 = null;
        val_32 = null;
        val_33 = 0;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_30, hi = R7, lo = 35630556, mid = R5}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_3;
        }
        
        this.response_buttons[val_29].interactable = false;
        if((System.String.op_Equality(a:  this.showCollectType, b:  2129282688)) == false)
        {
            goto label_7;
        }
        
        System.Action val_3 = new System.Action(object:  21054912, method:  new IntPtr(20956160));
        this.coinCollectAnimation.OnCompleteCallback = null;
        UnityEngine.Transform val_4 = this.response_buttons[val_29].transform;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  val_5.x, y:  val_5.y, z:  val_5.z);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 3.546475E-38f}, b:  new UnityEngine.Vector3() {y = val_6.x, z = val_6.y});
        this.coinCollectAnimation.SetCoinStartPosition(pos:  new UnityEngine.Vector3());
        val_30 = this.coinCollectAnimation;
        Player val_8 = App.Player;
        Player val_9 = App.Player;
        var val_30 = 0;
        val_28 = 7.286752E-44f;
        val_30 = val_30 + 64;
        val_35 = mem[(0 + 64) + (4)];
        val_34 = mem[(0 + 64) + (0)];
        decimal val_10 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 21042836, hi = 52, lo = val_34, mid = val_35}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = this.showCollectAmount, lo = ???, mid = ???});
        val_31 = 1048576000;
        val_33 = 1056964608;
        val_30.Play(fromValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, toValue:  new System.Decimal(), textTickTime:  val_7.x, delayBeforeComplete:  val_7.y);
        return;
        label_3:
        this.DoCloseCallbacks();
        return;
        label_7:
        if((System.String.op_Equality(a:  this.showCollectType, b:  -1930648496)) != false)
        {
                System.Action val_12 = new System.Action(object:  21054912, method:  new IntPtr(20956160));
            mem2[0] = null;
            Player val_13 = App.Player;
            val_30 = 0f;
            Player val_14 = App.Player;
            decimal val_15 = System.Convert.ToDecimal(value:  21042836);
            decimal val_17 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 21042820}, d2:  new System.Decimal() {flags = val_16, hi = mem[this.showCollectAmount + (0)], lo = mem[this.showCollectAmount + (4)], mid = mem[this.showCollectAmount + (8)]});
            val_31 = 0;
            val_36 = val_19;
            val_33 = 1048576000;
            val_37 = val_20;
            val_38 = val_30;
        }
        else
        {
                if((System.String.op_Equality(a:  this.showCollectType, b:  -1827757824)) == false)
        {
                return;
        }
        
            System.Action val_23 = new System.Action(object:  21054912, method:  new IntPtr(20956160));
            mem2[0] = null;
            val_30 = this.petFoodCollectAnimation;
            Player val_24 = App.Player;
            Player val_25 = App.Player;
            val_29 = 0;
            decimal val_26 = System.Decimal.op_Implicit(value:  21042836);
            decimal val_27 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 21042820}, d2:  new System.Decimal() {flags = ???, hi = mem[this.showCollectAmount + (0)], lo = mem[this.showCollectAmount + (4)], mid = mem[this.showCollectAmount + (8)]});
            val_31 = 1048576000;
            val_33 = 1056964608;
            val_36 = val_19;
            val_37 = val_20;
            val_38 = 1;
        }
        
        val_30.Play(fromValue:  1, toValue:  new System.Decimal() {flags = val_36, hi = val_37, lo = val_21, mid = val_18}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  val_33, originObject:  val_31);
    }
    private void DoCloseCallbacks()
    {
        int val_4;
        if(this.current_button_callbacks == null)
        {
            goto label_1;
        }
        
        val_4 = this;
        if(this.current_button_callbacks[this.dialogClickedIndex].Invoke() == false)
        {
            goto label_5;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  21330752, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        goto label_5;
        label_1:
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  21330752, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        val_4 = this.dialogClickedIndex;
        label_5:
        mem2[0] = 0;
    }
    public void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  21483712, method:  new IntPtr(20665840));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        this.dialogClickedIndex = 0;
        this.current_button_callbacks = 0;
    }
    public void SetupInternetRequired(System.Func<bool>[] buttonCallbacks)
    {
        var val_4;
        string val_1 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_2 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_3 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_4 = null;
        val_4 = null;
        this.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  buttonCallbacks, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    public void SetupPurchaseFail(System.Func<bool>[] buttonCallbacks)
    {
        var val_4;
        string val_1 = Localization.Localize(key:  -1349324784, defaultValue:  1098586544, useSingularKey:  false);
        string val_2 = Localization.Localize(key:  -1349324672, defaultValue:  1098586544, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_3 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        val_4 = null;
        val_4 = null;
        this.SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  buttonCallbacks, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  21967168, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void HandleBackPressed()
    {
        var val_7 = this;
        UnityEngine.GameObject val_1 = this.close_button.gameObject;
        if((this.close_button.activeInHierarchy != true) && (0 != 0))
        {
                if(this.current_button_callbacks[0].Invoke() == false)
        {
                return;
        }
        
            UnityEngine.GameObject val_4 = R4.gameObject;
            SLCWindow.CloseWindow(window:  R4, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        
        UnityEngine.GameObject val_5 = R4.gameObject;
        SLCWindow.CloseWindow(window:  R4, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGMessagePopup()
    {
        null = null;
        this.showCollectType = "";
        this.dialogClickedIndex = 0;
    }

}
