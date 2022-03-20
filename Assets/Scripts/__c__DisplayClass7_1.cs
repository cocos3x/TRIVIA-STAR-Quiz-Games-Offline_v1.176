using UnityEngine;
private sealed class RESEventPointsGainAnimator.<>c__DisplayClass7_1
{
    // Fields
    public UnityEngine.UI.Image currPointImage;
    public UnityEngine.GameObject iconParentObj;
    public int currIter;
    public int currPtGain;
    public RestaurantRivals.RESEventPointsGainAnimator.<>c__DisplayClass7_0 CS$<>8__locals1;
    
    // Methods
    public RESEventPointsGainAnimator.<>c__DisplayClass7_1()
    {
    
    }
    internal void <ShowPointGainAnimationCoroutine>b__0()
    {
        UnityEngine.RectTransform val_1 = this.currPointImage.rectTransform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.currPointImage, endValue:  null, duration:  null, snapping:  false);
        object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.currPointImage, ease:  20);
    }
    internal void <ShowPointGainAnimationCoroutine>b__1()
    {
        RESEventPointsGainAnimator.<>c__DisplayClass7_0 val_10;
        int val_11;
        DG.Tweening.TweenCallback val_12;
        DG.Tweening.TweenCallback val_13;
        this.CS$<>8__locals1.<>4__this.OnIndividualPointIconAnimComplete(pointObj:  this.iconParentObj);
        val_10 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != 0)
        {
            goto label_3;
        }
        
        val_10 = this.CS$<>8__locals1;
        if(val_10 == 0)
        {
            goto label_4;
        }
        
        label_3:
        if(this.currIter == ((this.CS$<>8__locals1.qty) - 1))
        {
                UnityEngine.GameObject val_2 = this.CS$<>8__locals1.<>4__this.radialRayTransform.gameObject;
            this.CS$<>8__locals1.<>4__this.radialRayTransform.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this.CS$<>8__locals1.<>4__this.pointsIconRootTransform.gameObject;
            this.CS$<>8__locals1.<>4__this.pointsIconRootTransform.SetActive(value:  false);
            RestaurantRivals.RESEventProgressBar val_4 = this.CS$<>8__locals1.<>4__this.EventProgressBar;
            val_11 = this.CS$<>8__locals1.desiredQty;
            this.CS$<>8__locals1.<>4__this.SetPointsGainText(value:  val_11);
            val_12 = this.CS$<>8__locals1.<>9__2;
            if(val_12 == 0)
        {
                val_11 = this.CS$<>8__locals1;
            val_12 = null;
            val_12 = new DG.Tweening.TweenCallback(object:  val_11, method:  new IntPtr(535782880));
            this.CS$<>8__locals1.<>9__2 = val_12;
        }
        
            DG.Tweening.Tween val_6 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1058642330, ignoreTimeScale:  false);
            val_13 = this.CS$<>8__locals1.<>9__3;
            if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new DG.Tweening.TweenCallback(object:  this.CS$<>8__locals1, method:  new IntPtr(535796192));
            this.CS$<>8__locals1.<>9__3 = val_13;
        }
        
            DG.Tweening.Tween val_8 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1065353216, ignoreTimeScale:  false);
            return;
        }
        
        RestaurantRivals.RESEventProgressBar val_9 = val_10.EventProgressBar;
        val_10.SetPointsGainText(value:  this.currPtGain);
        return;
        label_4:
    }

}
