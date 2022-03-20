using UnityEngine;
public class SlotMachineReel : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> reelObjects;
    private float objectHeight;
    private float spinSpeed;
    private float topEndHeight;
    private float bottomEndHeight;
    private float fullReelDuration;
    
    // Methods
    private void OnEnable()
    {
        float val_3;
        var val_4;
        var val_5;
        if(true == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_1 = 2621443.transform;
        if(2621443 != 0)
        {
                if(406885376 != null)
        {
                val_5 = 0;
        }
        
        }
        else
        {
                val_5 = 0;
        }
        
        UnityEngine.Vector2 val_2 = sizeDelta;
        this.objectHeight = val_3;
        val_4 = val_3;
        float val_6 = -0.5f;
        float val_4 = (float)val_2.x;
        float val_5 = this.spinSpeed;
        val_4 = val_4 * val_4;
        val_5 = val_4 / val_5;
        val_6 = val_4 * val_6;
        val_4 = val_4 * 0.5f;
        this.topEndHeight = val_4;
        this.bottomEndHeight = val_6;
        this.fullReelDuration = val_5;
    }
    public void SpinToIndex(int targetIndex, int extraRounds = 1, System.Action callBack)
    {
        var val_4 = 0;
        goto label_1;
        label_5:
        if(true <= val_4)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        System.Collections.IEnumerator val_2 = this.TweenObjectToHeight(reelObject:  (0 + 0) + 16, targetHeight:  this.GetTargetHeight(objectIndex:  0, reelTargetIndex:  targetIndex), extraRounds:  -1520627728, callBack:  extraRounds);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -1520627728);
        val_4 = 1;
        label_1:
        if(val_4 < this)
        {
            goto label_5;
        }
    
    }
    private System.Collections.IEnumerator TweenObjectToHeight(UnityEngine.GameObject reelObject, float targetHeight, int extraRounds, System.Action callBack)
    {
        var val_1;
        typeof(SlotMachineReel.<TweenObjectToHeight>d__8).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(SlotMachineReel.<TweenObjectToHeight>d__8).__il2cppRuntimeField_10 = reelObject;
            typeof(SlotMachineReel.<TweenObjectToHeight>d__8).__il2cppRuntimeField_14 = extraRounds;
            typeof(SlotMachineReel.<TweenObjectToHeight>d__8).__il2cppRuntimeField_18 = callBack;
            typeof(SlotMachineReel.<TweenObjectToHeight>d__8).__il2cppRuntimeField_1C = this;
        }
        else
        {
                mem[28] = this;
            mem[16] = reelObject;
            mem[20] = extraRounds;
            mem[24] = callBack;
        }
        
        typeof(SlotMachineReel.<TweenObjectToHeight>d__8).__il2cppRuntimeField_20 = val_1;
    }
    private float GetTravelDuration(UnityEngine.GameObject reelObject, float targetHeight)
    {
        var val_3;
        UnityEngine.Transform val_1 = reelObject.transform;
        UnityEngine.Vector3 val_2 = localPosition;
        var val_4 = val_3;
        val_4 = val_4 - R2;
        val_4 = val_4 / this.spinSpeed;
        return (float)val_4;
    }
    private float GetTargetHeight(int objectIndex, int reelTargetIndex)
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_1;
        System.Collections.Generic.List<UnityEngine.GameObject> val_2;
        var val_3;
        val_1 = objectIndex;
        val_2 = this.reelObjects;
        val_3 = reelTargetIndex - val_1;
        if(val_2 == 0)
        {
            goto label_1;
        }
        
        if(val_3 <= 0)
        {
            goto label_2;
        }
        
        label_5:
        val_3 = val_3 - true;
        goto label_6;
        label_1:
        val_1 = this.reelObjects;
        var val_2 = 1;
        val_2 = 0;
        if(val_3 > val_2)
        {
            goto label_5;
        }
        
        label_2:
        val_2 = ((0 - val_2) >> 31) - val_2;
        if(val_3 < (val_2 >> 1))
        {
                val_1 = this.reelObjects;
            val_3 = val_2 + val_3;
        }
        
        label_6:
        float val_3 = (float)val_3;
        val_3 = this.objectHeight * val_3;
        return (float)val_3;
    }
    public SlotMachineReel()
    {
        this.spinSpeed = 3000f;
    }

}
