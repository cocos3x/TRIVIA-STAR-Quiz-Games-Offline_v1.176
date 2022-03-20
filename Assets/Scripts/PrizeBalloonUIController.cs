using UnityEngine;
public class PrizeBalloonUIController : MonoSingleton<PrizeBalloonUIController>
{
    // Fields
    private UnityEngine.UI.Button balloon;
    private UnityEngine.Transform start;
    private UnityEngine.Transform end;
    private int coinReward;
    private DG.Tweening.Tweener balloonTweener;
    private UnityEngine.Coroutine balloonShowingCoroutine;
    private System.Action onClose;
    
    // Methods
    public override void InitMonoSingleton()
    {
        this.HideBalloon();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1084402304, method:  new IntPtr(3210539968));
        this.balloon.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(int amount, System.Action onClose)
    {
        if(this.balloonShowingCoroutine != 0)
        {
                return;
        }
        
        mem2[0] = onClose;
        mem2[0] = amount;
        System.Collections.IEnumerator val_1 = R4.StartShowingBalloon();
        UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  R4);
        mem2[0] = R4;
    }
    private System.Collections.IEnumerator StartShowingBalloon()
    {
        object val_1 = new System.Object();
        typeof(PrizeBalloonUIController.<StartShowingBalloon>d__9).__il2cppRuntimeField_8 = 0;
        typeof(PrizeBalloonUIController.<StartShowingBalloon>d__9).__il2cppRuntimeField_10 = this;
    }
    private void OnBalloonTapped()
    {
        int val_12;
        this.balloon.interactable = false;
        if(this.balloonTweener != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.balloonTweener, complete:  false);
        }
        
        this.StopCoroutine(routine:  this.balloonShowingCoroutine);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CollectReward(amount:  this.coinReward);
        System.Collections.IEnumerator val_2 = this.HideBalloonCoroutine();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -1084024320);
        MainController val_4 = MainController.instance;
        Player val_5 = App.Player;
        decimal val_6 = System.Decimal.op_Implicit(value:  -1084036372);
        decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1084036388, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        int val_8 = System.Decimal.op_Explicit(value:  new System.Decimal());
        decimal val_9 = System.Decimal.op_Implicit(value:  -1084036404);
        Player val_10 = App.Player;
        UnityEngine.Transform val_11 = this.balloon.transform;
        0.Play(startCoins:  new System.Decimal() {mid = val_12}, finalCoins:  new System.Decimal() {mid = 256}, particleStart:  this.balloon, forceTextTween:  true);
    }
    private System.Collections.IEnumerator HideBalloonCoroutine()
    {
        object val_1 = new System.Object();
        typeof(PrizeBalloonUIController.<HideBalloonCoroutine>d__11).__il2cppRuntimeField_8 = 0;
        typeof(PrizeBalloonUIController.<HideBalloonCoroutine>d__11).__il2cppRuntimeField_10 = this;
    }
    private void HideBalloon()
    {
        this.balloon.interactable = true;
        UnityEngine.GameObject val_1 = this.balloon.gameObject;
        this.balloon.SetActive(value:  false);
        if(this.balloonShowingCoroutine != 0)
        {
                this.StopCoroutine(routine:  this.balloonShowingCoroutine);
            this.balloonShowingCoroutine = 0;
        }
        
        if(this.onClose == 0)
        {
                return;
        }
        
        this.onClose.Invoke();
        this.onClose = 0;
    }
    public PrizeBalloonUIController()
    {
    
    }

}
