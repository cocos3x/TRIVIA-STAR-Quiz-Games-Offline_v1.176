using UnityEngine;
public class WGExtraWordsPopup : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Button button_info;
    protected UnityEngine.UI.Button button_close;
    protected UnityEngine.UI.Text rewardAmount;
    protected UnityEngine.UI.Button button_collect;
    protected GridCoinCollectAnimationInstantiator coinsAnim;
    protected ExtraProgress progress;
    protected UnityEngine.UI.Text text_progress;
    protected UnityEngine.GameObject[] collectable_objects;
    protected UnityEngine.GameObject[] uncollectable_objects;
    protected UnityEngine.GameObject idleAnimation;
    protected UnityEngine.GameObject collectAnimation;
    protected decimal curr_reward;
    
    // Methods
    private void Awake()
    {
        System.Action val_1 = new System.Action(object:  -50139232, method:  new IntPtr(4244776416));
        this.coinsAnim.OnCompleteCallback = null;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -50139232, method:  typeof(WGExtraWordsPopup).__il2cppRuntimeField_E8);
        this.button_collect.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -50139232, method:  new IntPtr(4244793824));
        this.button_info.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -50139232, method:  new IntPtr(4244803040));
        this.button_close.m_OnClick.AddListener(call:  162246656);
    }
    public void OnEnable()
    {
        goto typeof(WGExtraWordsPopup).__il2cppRuntimeField_DC;
    }
    protected virtual void UpdateUI()
    {
        ExtraProgress val_13;
        var val_14;
        var val_15;
        UnityEngine.GameObject[] val_16;
        GameEcon val_1 = App.getGameEcon;
        this.button_collect.interactable = true;
        GameEcon val_2 = App.getGameEcon;
        string val_3 = this.curr_reward.ToString(format:  null);
        GameEcon val_4 = App.getGameEcon;
        this.progress.target = (float)0.ExtraWordsTarget;
        this.progress.current = (float)Prefs.extraProgress;
        string val_7 = 15282176 + 1115175264 + 15282176;
        val_13 = this.progress;
        if(this.progress != 0)
        {
            goto label_13;
        }
        
        val_13 = this.progress;
        if(val_13 == 0)
        {
            goto label_14;
        }
        
        label_13:
        val_14 = 0;
        goto label_15;
        label_20:
        UnityEngine.GameObject val_13 = this.collectable_objects[val_14];
        if(val_13 >= 0)
        {
                0 = 1;
        }
        
        val_13.SetActive(value:  true);
        val_14 = 1;
        label_15:
        if(val_14 < val_13)
        {
            goto label_20;
        }
        
        val_15 = 0;
        if(val_14 < val_13)
        {
                0 = 1;
        }
        
        goto label_21;
        label_26:
        UnityEngine.GameObject val_14 = this.uncollectable_objects[val_15];
        val_14.SetActive(value:  true);
        val_15 = 1;
        label_21:
        val_16 = this.uncollectable_objects;
        if(val_15 < val_14)
        {
            goto label_26;
        }
        
        UnityEngine.GameObject val_8 = this.button_collect.gameObject;
        if(this.button_collect.activeSelf != false)
        {
                val_16 = 1152921504765685760;
            if((UnityEngine.Object.op_Implicit(exists:  this.idleAnimation)) != false)
        {
                object val_11 = this.idleAnimation.GetComponent<System.Object>();
            this.idleAnimation.alpha = (float)Prefs.extraProgress;
        }
        
            if((UnityEngine.Object.op_Implicit(exists:  this.collectAnimation)) == false)
        {
                return;
        }
        
            this.collectAnimation.SetActive(value:  true);
            return;
        }
        
        this.StopExtraAnimation();
        this.ShowIdleAnimation();
        return;
        label_14:
    }
    public virtual void OnClick_Collect()
    {
        int val_6;
        int val_6;
        this.button_collect.interactable = false;
        CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[this.curr_reward + (0)], hi = mem[this.curr_reward + (4)], lo = mem[this.curr_reward + (8)], mid = mem[this.curr_reward + (12)]}, source:  "Extra Words", externalParams:  0, animated:  false);
        MainController val_1 = MainController.instance;
        0.UpdateExtraWordProgress();
        Player val_2 = App.Player;
        var val_3 = 0 + 60;
        val_6 = mem[(0 + 60) + (0)];
        decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -49352436, hi = val_6, lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = mem[this.curr_reward + (0)], lo = mem[this.curr_reward + (4)], mid = mem[this.curr_reward + (8)]});
        Player val_5 = App.Player;
        this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {flags = 52}, textTickTime:  null, delayBeforeComplete:  null);
    }
    public void OnClick_Info()
    {
        var val_5;
        System.Action val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        val_5 = null;
        val_5 = null;
        val_7 = WGExtraWordsPopup.<>c.<>9__16_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Action(object:  WGExtraWordsPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4245723104));
            WGExtraWordsPopup.<>c.<>9__16_0 = val_7;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_C = val_7;
        UnityEngine.GameObject val_4 = this.gameObject;
        this.SetActive(value:  false);
    }
    public void OnClick_Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnCoinsAnimFinished()
    {
        goto typeof(WGExtraWordsPopup).__il2cppRuntimeField_DC;
    }
    private void StopExtraAnimation()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.collectAnimation)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = R4 + 52.transform;
        UnityEngine.Transform val_3 = R4 + 52.Find(n:  -48903072);
        object val_4 = R4 + 52.GetComponent<System.Object>();
        R4 + 52.StopAnimation();
    }
    private void ShowIdleAnimation()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.idleAnimation)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = R4 + 48.transform;
        object val_3 = R4 + 48.GetComponent<System.Object>();
        System.Collections.IEnumerator val_4 = R4.showAnima(cg:  R4 + 48);
        UnityEngine.Coroutine val_5 = R4.StartCoroutine(routine:  R4);
    }
    private System.Collections.IEnumerator showAnima(UnityEngine.CanvasGroup cg)
    {
        typeof(WGExtraWordsPopup.<showAnima>d__21).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGExtraWordsPopup.<showAnima>d__21).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(WGExtraWordsPopup.<showAnima>d__21).__il2cppRuntimeField_10 = cg;
    }
    public WGExtraWordsPopup()
    {
    
    }

}
