using UnityEngine;
private sealed class WGReviewManager.<InitReviewManager>d__41 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGReviewManager <>4__this;
    private Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> <requestFlowOperation>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGReviewManager.<InitReviewManager>d__41(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> val_5;
        val_4 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return val_4;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.initializingRManager = true;
        goto label_4;
        label_1:
        val_5 = this.<requestFlowOperation>5__2;
        this.<>1__state = 0;
        if(val_5 == 0)
        {
            goto label_5;
        }
        
        if(0 != 0)
        {
            goto label_6;
        }
        
        goto label_11;
        label_3:
        mem[28] = 1;
        label_4:
        Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> val_1 = this.<>4__this.reviewManager.RequestReviewFlow();
        val_4 = 1;
        this.<requestFlowOperation>5__2 = this.<>4__this.reviewManager;
        this.<>1__state = val_4;
        this.<>2__current = this.<>4__this.reviewManager;
        return val_4;
        label_5:
        if((this.<requestFlowOperation>5__2) == 0)
        {
            goto label_10;
        }
        
        val_5 = this.<requestFlowOperation>5__2;
        if(R1 == 0)
        {
            goto label_11;
        }
        
        label_6:
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_2 = -305121968(-305121968) + 247816192;
        val_4 = 0;
        UnityEngine.Debug.LogError(message:  -305121968);
        if((this.<>4__this) != 0)
        {
            goto label_17;
        }
        
        goto label_17;
        label_10:
        val_5 = 0;
        label_11:
        object val_3 = val_5.GetResult();
        if((this.<>4__this) != 0)
        {
                this.<>4__this._playReviewInfo = val_5;
        }
        else
        {
                mem[32] = val_5;
        }
        
        val_4 = false;
        label_17:
        this.<>4__this.initializingRManager = val_4;
        return val_4;
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
