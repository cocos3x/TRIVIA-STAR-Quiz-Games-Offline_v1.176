using UnityEngine;
private sealed class WPTGameUIController.<FlyAway>d__150 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    public UnityEngine.Transform transformToFly;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<FlyAway>d__150(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_4;
        var val_7;
        int val_12 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
            this.<>1__state = 0;
            UnityEngine.Vector3 val_1 = localPosition;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  val_1.x, y:  val_1.y, z:  val_1.z);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 2.833509E-32f}, b:  new UnityEngine.Vector3() {y = val_2.x, z = val_2.y});
            UnityEngine.Transform val_5 = this.<>4__this.transform;
            UnityEngine.Vector3 val_6 = localPosition;
            float val_12 = System.Math.Abs(val_7 - val_4);
            val_12 = val_12 / 700f;
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.transformToFly, endValue:  val_12, duration:  val_6.y, snapping:  val_4);
            object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.transformToFly, ease:  5);
            val_12 = 1;
            this.<>1__state = val_12;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_12);
            return (bool)val_12;
        }
        
        this.<>1__state = 0;
        return (bool)val_12;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
