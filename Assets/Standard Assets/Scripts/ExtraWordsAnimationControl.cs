using UnityEngine;
public class ExtraWordsAnimationControl : MonoBehaviour
{
    // Fields
    public float WaveSpeed;
    public string AnimationName;
    private bool hasStart;
    private Spine.Unity.SkeletonGraphic skAnima;
    
    // Methods
    private void Awake()
    {
        if(this.skAnima != 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.AnimationName)) == true)
        {
                return;
        }
        
        object val_3 = R4.GetComponent<System.Object>();
        mem2[0] = R4;
    }
    private void OnEnable()
    {
        if(this.hasStart == false)
        {
                return;
        }
        
        this.PlayAnimation();
    }
    private void OnDisable()
    {
        this.skAnima.Clear();
    }
    private void Start()
    {
        this.PlayAnimation();
        this.hasStart = true;
    }
    private void PlayAnimation()
    {
        float val_5;
        if(this.skAnima == 0)
        {
                return;
        }
        
        Spine.TrackEntry val_2 = this.skAnima.state.SetAnimation(trackIndex:  0, animationName:  1814080768, loop:  false);
        Spine.TrackEntry val_3 = this.skAnima.state.AddAnimation(trackIndex:  0, animationName:  1814080768, loop:  true, delay:  null);
        if(this.skAnima.state != 0)
        {
                this.skAnima.state.trackEntryPool = 1066745725;
            val_5 = this.WaveSpeed;
        }
        else
        {
                mem[40] = 1066745725;
            val_5 = this.WaveSpeed;
        }
        
        mem2[0] = val_5;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.skAnima.color = new UnityEngine.Color() {a = ???};
    }
    public void StopAnimation()
    {
        if(this.skAnima == 0)
        {
                return;
        }
        
        R4 + 24 + 144.ClearTracks();
        System.Collections.IEnumerator val_2 = R4.Fadeout();
        UnityEngine.Coroutine val_3 = R4.StartCoroutine(routine:  R4);
    }
    private System.Collections.IEnumerator Fadeout()
    {
        object val_1 = new System.Object();
        typeof(ExtraWordsAnimationControl.<Fadeout>d__10).__il2cppRuntimeField_8 = 0;
        typeof(ExtraWordsAnimationControl.<Fadeout>d__10).__il2cppRuntimeField_10 = this;
    }
    public ExtraWordsAnimationControl()
    {
        this.WaveSpeed = 0.7f;
        this.AnimationName = "";
    }

}
