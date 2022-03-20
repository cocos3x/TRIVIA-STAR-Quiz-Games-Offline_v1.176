using UnityEngine;
public class shake : MonoBehaviour
{
    // Fields
    public bool shakePosition;
    public UnityEngine.Vector3 positionMagnitude;
    public UnityEngine.GameObject positionEventReceiver;
    public string positionCallWhenFinished;
    public bool shakeRotate;
    public UnityEngine.Vector3 rotationMagnitude;
    public UnityEngine.GameObject rotationEventReceiver;
    public string rotationCallWhenFinished;
    public bool shakeOnEnable;
    public int iterations;
    public int shakeSpeed;
    public float delayInbetweens;
    public float duration;
    public float startDelay;
    public bool randomDelay;
    public UnityEngine.Vector2 minMaxDelay;
    public float shakeNowDuration;
    private UnityEngine.Vector3 initialPosition;
    private UnityEngine.Quaternion initialRotation;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = localPosition;
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Quaternion val_4 = localRotation;
        if(this.shakeOnEnable == true)
        {
                this.shakeOnEnable = this;
        }
        
        if(this.shakeOnEnable == true)
        {
                this.Shake();
        }
    
    }
    private void OnDisable()
    {
        this.Stop();
    }
    private void OnDestroy()
    {
        UnityEngine.Transform val_1 = this.transform;
        int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  1812539200, complete:  false);
        this.StopAllCoroutines();
    }
    public void Stop()
    {
        UnityEngine.Transform val_1 = this.transform;
        int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  1812651200, complete:  false);
        this.StopAllCoroutines();
        this.RestoreInitialTransformSpecs();
    }
    public void Shake()
    {
        float val_17;
        float val_18;
        if(this.shakeRotate != false)
        {
                UnityEngine.Transform val_1 = this.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  1812769344, duration:  null, strength:  new UnityEngine.Vector3() {x = this.duration, y = mem[this.rotationMagnitude + (0)], z = mem[this.rotationMagnitude + (4)]}, vibrato:  mem[this.rotationMagnitude + (8)], randomness:  null, fadeOut:  true);
            if(this.randomDelay != false)
        {
                float val_3 = UnityEngine.Random.Range(min:  null, max:  null);
            val_17 = this.minMaxDelay;
        }
        else
        {
                val_17 = this.startDelay;
        }
        
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  1812769344, delay:  val_17);
            object val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  1812769344, loops:  this.iterations);
            DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  1812769344, method:  new IntPtr(1812741248));
            object val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  1812769344, action:  190734336);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  1812769344, autoKillOnCompletion:  true);
        }
        
        if(this.shakePosition == false)
        {
                return;
        }
        
        UnityEngine.Transform val_9 = this.transform;
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  1812769344, duration:  val_17, strength:  null, vibrato:  this.duration, randomness:  null, snapping:  false, fadeOut:  true);
        if(this.randomDelay != false)
        {
                float val_11 = UnityEngine.Random.Range(min:  val_17, max:  null);
            val_18 = this.minMaxDelay;
        }
        else
        {
                val_18 = this.startDelay;
        }
        
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  1812769344, delay:  val_18);
        object val_13 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  1812769344, loops:  this.iterations);
        DG.Tweening.TweenCallback val_14 = new DG.Tweening.TweenCallback(object:  1812769344, method:  new IntPtr(1812744320));
        object val_15 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  1812769344, action:  190734336);
        object val_16 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  1812769344, autoKillOnCompletion:  true);
    }
    public void ShakeNow()
    {
        if(this.shakeRotate != false)
        {
                UnityEngine.Transform val_1 = this.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  1812881344, duration:  null, strength:  new UnityEngine.Vector3() {x = this.shakeNowDuration, y = mem[this.rotationMagnitude + (0)], z = mem[this.rotationMagnitude + (4)]}, vibrato:  mem[this.rotationMagnitude + (8)], randomness:  null, fadeOut:  true);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  1812881344, delay:  null);
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  1812881344, loops:  1);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  1812881344, method:  new IntPtr(1812741248));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  1812881344, action:  190734336);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  1812881344, autoKillOnCompletion:  true);
        }
        
        if(this.shakePosition == false)
        {
                return;
        }
        
        UnityEngine.Transform val_8 = this.transform;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  1812881344, duration:  null, strength:  new UnityEngine.Vector3() {x = this.shakeNowDuration, y = mem[this.positionMagnitude + (0)], z = mem[this.positionMagnitude + (4)]}, vibrato:  mem[this.positionMagnitude + (8)], randomness:  null, snapping:  true, fadeOut:  false);
        object val_10 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  1812881344, delay:  null);
        object val_11 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  1812881344, loops:  1);
        DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  1812881344, method:  new IntPtr(1812744320));
        object val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  1812881344, action:  190734336);
        object val_14 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  1812881344, autoKillOnCompletion:  true);
    }
    private void RotationOnComplete()
    {
        this.RestoreInitialTransformSpecs();
        if(this.rotationEventReceiver == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.rotationCallWhenFinished)) == true)
        {
                return;
        }
        
        this.rotationEventReceiver.SendMessage(methodName:  this.rotationCallWhenFinished, value:  1813009728, options:  1);
    }
    private void PositionOnComplete()
    {
        this.RestoreInitialTransformSpecs();
        if(this.positionEventReceiver == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.positionCallWhenFinished)) == true)
        {
                return;
        }
        
        this.positionEventReceiver.SendMessage(methodName:  this.positionCallWhenFinished, value:  1813154496, options:  1);
    }
    private void RestoreInitialTransformSpecs()
    {
        UnityEngine.Transform val_1 = this.transform;
        this.localPosition = new UnityEngine.Vector3() {x = mem[this.initialPosition + (0)], y = mem[this.initialPosition + (4)], z = mem[this.initialPosition + (8)]};
        UnityEngine.Transform val_2 = this.transform;
        this.localRotation = new UnityEngine.Quaternion() {x = mem[this.initialRotation + (0)], y = mem[this.initialRotation + (4)], z = mem[this.initialRotation + (8)], w = this};
    }
    public void setInitialValues()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = localPosition;
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Quaternion val_4 = localRotation;
    }
    public shake()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.positionCallWhenFinished = "";
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.shakeOnEnable = true;
        this.rotationCallWhenFinished = "";
        this.iterations = true;
        this.shakeSpeed = true;
        this.duration = 1f;
        this.startDelay = 1f;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.y);
    }

}
