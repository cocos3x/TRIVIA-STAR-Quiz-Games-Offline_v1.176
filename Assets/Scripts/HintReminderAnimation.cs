using UnityEngine;
public class HintReminderAnimation : MonoBehaviour
{
    // Fields
    private float idleTriggerTime;
    private bool startHidden;
    private bool doShakeInstead;
    public UnityEngine.UI.Image shineImage;
    private UnityEngine.WaitForSeconds transitionTime;
    private UnityEngine.Vector3 startPos;
    private float nextTime;
    
    // Methods
    private void Start()
    {
        float val_1 = UnityEngine.Time.time;
        float val_5 = this.idleTriggerTime;
        val_5 = 0 + val_5;
        this.nextTime = val_5;
        UnityEngine.Transform val_2 = this.shineImage.transform;
        UnityEngine.Vector3 val_3 = localPosition;
        if(this.startHidden == false)
        {
                return;
        }
        
        if(this.doShakeInstead == true)
        {
                return;
        }
        
        this.shineImage.enabled = false;
        UnityEngine.CanvasRenderer val_4 = this.shineImage.canvasRenderer;
        this.shineImage.SetAlpha(alpha:  val_3.x);
    }
    private void Update()
    {
        var val_8;
        float val_9;
        val_8 = this;
        int val_1 = UnityEngine.Input.touchCount;
        float val_2 = UnityEngine.Time.time;
        if(val_1 >= 1)
        {
                val_9 = 0 + this.idleTriggerTime;
        }
        else
        {
                if(val_1 < 1)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -170065888, clipIndex:  0);
            if((R4 + 17) != 0)
        {
                R4.ShakeTween();
        }
        else
        {
                System.Collections.IEnumerator val_4 = R4.ShineRoutine();
            UnityEngine.Coroutine val_5 = R4.StartCoroutine(routine:  R4);
        }
        
            float val_6 = UnityEngine.Time.time;
            val_9 = 0 + (R4 + 12);
        }
        
        mem2[0] = val_9;
    }
    private void SetNextTime()
    {
        float val_1 = UnityEngine.Time.time;
        float val_2 = this.idleTriggerTime;
        val_2 = 0 + val_2;
        this.nextTime = val_2;
    }
    private void ShakeTween()
    {
        this.shineImage.enabled = true;
        UnityEngine.Transform val_1 = this.shineImage.transform;
        DG.Tweening.Sequence val_2 = DG.Tweening.ShortcutExtensions.DOLocalJump(target:  this.shineImage, endValue:  new UnityEngine.Vector3() {x = mem[this.startPos + (0)], y = mem[this.startPos + (4)], z = mem[this.startPos + (8)]}, jumpPower:  null, numJumps:  1112014848, duration:  null, snapping:  true);
    }
    private System.Collections.IEnumerator ShineRoutine()
    {
        object val_1 = new System.Object();
        typeof(HintReminderAnimation.<ShineRoutine>d__11).__il2cppRuntimeField_8 = 0;
        typeof(HintReminderAnimation.<ShineRoutine>d__11).__il2cppRuntimeField_10 = this;
    }
    private void OnDisable()
    {
        this.StopAllCoroutines();
    }
    public HintReminderAnimation()
    {
        this.startHidden = true;
        this.idleTriggerTime = 13f;
        this.transitionTime = new UnityEngine.WaitForSeconds(seconds:  null);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
    }

}
