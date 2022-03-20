using UnityEngine;
public class FixedIntervalUpdater : MonoBehaviour
{
    // Fields
    public System.Action updateLogic;
    public float updateInterval;
    
    // Methods
    private void Start()
    {
        System.Collections.IEnumerator val_1 = this.FixedIntervalUpdate();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1781405360);
    }
    protected System.Collections.IEnumerator FixedIntervalUpdate()
    {
        object val_1 = new System.Object();
        typeof(FixedIntervalUpdater.<FixedIntervalUpdate>d__3).__il2cppRuntimeField_8 = 0;
        typeof(FixedIntervalUpdater.<FixedIntervalUpdate>d__3).__il2cppRuntimeField_10 = this;
    }
    protected virtual void UpdateLogic()
    {
    
    }
    public FixedIntervalUpdater()
    {
        var val_2;
        System.Action val_4;
        val_2 = null;
        val_2 = null;
        val_4 = FixedIntervalUpdater.<>c.<>9__5_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Action(object:  FixedIntervalUpdater.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2513873936));
            FixedIntervalUpdater.<>c.<>9__5_0 = val_4;
        }
        
        this.updateLogic = val_4;
        this.updateInterval = 1f;
    }

}
