using UnityEngine;
public class WGSnakesAndLaddersDiceRollAnim : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image pointImg;
    private System.Collections.Generic.List<UnityEngine.Sprite> pointSp;
    
    // Methods
    public void Play(int result)
    {
        System.Collections.IEnumerator val_1 = this.AnimateRandomPointSp(result:  result);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1019842160);
    }
    private System.Collections.IEnumerator AnimateRandomPointSp(int result)
    {
        typeof(WGSnakesAndLaddersDiceRollAnim.<AnimateRandomPointSp>d__3).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGSnakesAndLaddersDiceRollAnim.<AnimateRandomPointSp>d__3).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(WGSnakesAndLaddersDiceRollAnim.<AnimateRandomPointSp>d__3).__il2cppRuntimeField_14 = result;
    }
    public WGSnakesAndLaddersDiceRollAnim()
    {
    
    }

}
