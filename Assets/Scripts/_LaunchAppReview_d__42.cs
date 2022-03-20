using UnityEngine;
private sealed class WGReviewManager.<LaunchAppReview>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGReviewManager <>4__this;
    private Google.Play.Common.PlayAsyncOperation<Google.Play.Common.VoidResult, Google.Play.Review.ReviewErrorCode> <launchFlowOperation>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGReviewManager.<LaunchAppReview>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        WGReviewManager val_6;
        Google.Play.Review.ReviewManager val_7;
        val_5 = 0;
        val_6 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        if(val_6 == 0)
        {
            goto label_3;
        }
        
        val_7 = this.<>4__this.reviewManager;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        this.<>4__this._playReviewInfo = 0;
        if(0 == 0)
        {
            goto label_7;
        }
        
        AppConfigs val_1 = App.Configuration;
        string val_2 = 0.Key(key:  -305927568);
        twelvegigs.plugins.SharePlugin.OpenURL(url:  null);
        val_6 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        val_5 = 0;
        string val_3 = -304398624(-304398624) + 247816192;
        UnityEngine.Debug.LogError(message:  -304398624);
        return (bool)val_5;
        label_3:
        val_7 = 0;
        label_4:
        val_6 = this.<>4__this._playReviewInfo;
        Google.Play.Common.PlayAsyncOperation<Google.Play.Common.VoidResult, Google.Play.Review.ReviewErrorCode> val_4 = val_7.LaunchReviewFlow(reviewInfo:  val_6);
        val_5 = 1;
        this.<launchFlowOperation>5__2 = val_7;
        this.<>1__state = val_5;
        this.<>2__current = val_7;
        return (bool)val_5;
        label_7:
        val_5 = 0;
        UnityEngine.PlayerPrefs.SetInt(key:  -306044000, value:  1);
        return (bool)val_5;
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
