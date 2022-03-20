using UnityEngine;
public class TRVExtraLifeAwarded : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Text extraLifeText;
    private UnityEngine.ParticleSystem trailParticles;
    private UnityEngine.Vector3 offSetVector;
    private float statViewDelay;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -527259120, method:  new IntPtr(3767679056));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_3 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.TotalFreeLivesAvailable();
        val_3 = val_3 - 1;
        string val_4 = val_3.ToString();
        if(this.extraLifeText != 0)
        {
                return;
        }
    
    }
    private System.Collections.IEnumerator Continue()
    {
        object val_1 = new System.Object();
        typeof(TRVExtraLifeAwarded.<Continue>d__6).__il2cppRuntimeField_8 = 0;
        typeof(TRVExtraLifeAwarded.<Continue>d__6).__il2cppRuntimeField_10 = this;
    }
    public TRVExtraLifeAwarded()
    {
        UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
    }
    private void <OnEnable>b__5_0()
    {
        System.Collections.IEnumerator val_1 = this.Continue();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -526910832);
    }

}
