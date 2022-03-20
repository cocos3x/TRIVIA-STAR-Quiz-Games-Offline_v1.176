using UnityEngine;
private sealed class AttackMadnessEventHandler.<>c__DisplayClass73_1
{
    // Fields
    public UnityEngine.GameObject point;
    public AttackMadnessEventHandler.<>c__DisplayClass73_0 CS$<>8__locals1;
    
    // Methods
    public AttackMadnessEventHandler.<>c__DisplayClass73_1()
    {
    
    }
    internal void <PlayPointCollectionSequence>b__3()
    {
        UnityEngine.Object.Destroy(obj:  this.point);
        this.CS$<>8__locals1.attackMadnessButton.Play();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1541987328, clipIndex:  0);
    }

}
