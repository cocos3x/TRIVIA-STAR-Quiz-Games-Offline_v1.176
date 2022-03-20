using UnityEngine;
public class ParticleEffectsLibrary : MonoBehaviour
{
    // Fields
    public static ParticleEffectsLibrary GlobalAccess;
    public int TotalEffects;
    public int CurrentParticleEffectIndex;
    public int CurrentParticleEffectNum;
    public UnityEngine.Vector3[] ParticleEffectSpawnOffsets;
    public float[] ParticleEffectLifetimes;
    public UnityEngine.GameObject[] ParticleEffectPrefabs;
    private string effectNameString;
    private System.Collections.Generic.List<UnityEngine.Transform> currentActivePEList;
    private UnityEngine.Vector3 spawnPosition;
    
    // Methods
    private void Awake()
    {
        int val_6;
        ParticleEffectsLibrary.GlobalAccess = this;
        this.currentActivePEList = null;
        this.TotalEffects = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem[1152921511434241940] = 1;
        if(this.ParticleEffectSpawnOffsets == null)
        {
                val_6 = this.TotalEffects;
        }
        
        if(1 != val_6)
        {
                UnityEngine.Debug.LogError(message:  -1762642096);
        }
        
        if(0 != this.TotalEffects)
        {
                UnityEngine.Debug.LogError(message:  -1762604960);
        }
        
        UnityEngine.GameObject val_6 = this.ParticleEffectPrefabs[this.CurrentParticleEffectIndex];
        string val_2 = val_6.name;
        typeof(System.String[]).__il2cppRuntimeField_10 = val_6;
        typeof(System.String[]).__il2cppRuntimeField_14 = " (";
        string val_3 = mem[1152921511434241940].ToString();
        typeof(System.String[]).__il2cppRuntimeField_18 = 1152921511434241940;
        typeof(System.String[]).__il2cppRuntimeField_1C = " of ";
        string val_4 = this.TotalEffects.ToString();
        typeof(System.String[]).__il2cppRuntimeField_20 = 1152921511434241932;
        typeof(System.String[]).__il2cppRuntimeField_24 = ")";
        string val_5 = +477709520;
        this.effectNameString = null;
    }
    private void Start()
    {
    
    }
    public string GetCurrentPENameString()
    {
        UnityEngine.GameObject val_4 = this.ParticleEffectPrefabs[this.CurrentParticleEffectIndex];
        string val_1 = val_4.name;
        typeof(System.String[]).__il2cppRuntimeField_10 = val_4;
        typeof(System.String[]).__il2cppRuntimeField_14 = " (";
        string val_2 = this.CurrentParticleEffectNum.ToString();
        typeof(System.String[]).__il2cppRuntimeField_18 = this.CurrentParticleEffectNum;
        typeof(System.String[]).__il2cppRuntimeField_1C = " of ";
        string val_3 = this.TotalEffects.ToString();
        typeof(System.String[]).__il2cppRuntimeField_20 = this.TotalEffects;
        typeof(System.String[]).__il2cppRuntimeField_24 = ")";
        return +477709520;
    }
    public void PreviousParticleEffect()
    {
        var val_7;
        System.Collections.Generic.List<UnityEngine.Transform> val_8;
        float val_8 = this.ParticleEffectLifetimes[this.CurrentParticleEffectIndex];
        if((true != this.CurrentParticleEffectIndex) || (this.ParticleEffectLifetimes[this.CurrentParticleEffectIndex] < 1))
        {
            goto label_5;
        }
        
        val_7 = 4;
        goto label_6;
        label_18:
        val_8 = this.currentActivePEList;
        if(val_8 == 0)
        {
                val_8 = 0;
        }
        
        if(this.currentActivePEList >= R7)
        {
            goto label_8;
        }
        
        label_19:
        if(0 <= this.currentActivePEList)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_1 = UnityEngine.Object.op_Inequality(x:  2621443, y:  0);
        if(val_1 != false)
        {
                if(val_1 <= this.currentActivePEList)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.GameObject val_2 = 2621443.gameObject;
            UnityEngine.Object.Destroy(obj:  2621443);
        }
        
        val_7 = 5;
        label_6:
        val_8 = this.currentActivePEList;
        if(val_8 == 0)
        {
            goto label_18;
        }
        
        if((val_7 - 4) < 2621443)
        {
            goto label_19;
        }
        
        label_8:
        val_8.Clear();
        label_5:
        if(this.CurrentParticleEffectIndex <= 0)
        {
                this.CurrentParticleEffectIndex = this.TotalEffects;
        }
        
        this.CurrentParticleEffectNum = this.CurrentParticleEffectIndex;
        this.CurrentParticleEffectIndex = this.CurrentParticleEffectIndex - 1;
        this.CurrentParticleEffectIndex = this.CurrentParticleEffectIndex;
        UnityEngine.GameObject val_9 = this.ParticleEffectPrefabs[this.CurrentParticleEffectIndex];
        string val_4 = val_9.name;
        typeof(System.String[]).__il2cppRuntimeField_10 = val_9;
        typeof(System.String[]).__il2cppRuntimeField_14 = " (";
        string val_5 = this.CurrentParticleEffectNum.ToString();
        typeof(System.String[]).__il2cppRuntimeField_18 = 1152921511434906644;
        typeof(System.String[]).__il2cppRuntimeField_1C = " of ";
        string val_6 = this.TotalEffects.ToString();
        typeof(System.String[]).__il2cppRuntimeField_20 = this.TotalEffects;
        typeof(System.String[]).__il2cppRuntimeField_24 = ")";
        string val_7 = +477709520;
        this.effectNameString = null;
    }
    public void NextParticleEffect()
    {
        var val_8;
        System.Collections.Generic.List<UnityEngine.Transform> val_9;
        float val_9 = this.ParticleEffectLifetimes[this.CurrentParticleEffectIndex];
        if((true != this.CurrentParticleEffectIndex) || (this.ParticleEffectLifetimes[this.CurrentParticleEffectIndex] < 1))
        {
            goto label_5;
        }
        
        val_8 = 4;
        goto label_6;
        label_18:
        val_9 = this.currentActivePEList;
        if(val_9 == 0)
        {
                val_9 = 0;
        }
        
        if(this.currentActivePEList >= R7)
        {
            goto label_8;
        }
        
        label_19:
        if(0 <= this.currentActivePEList)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_1 = UnityEngine.Object.op_Inequality(x:  2621443, y:  0);
        if(val_1 != false)
        {
                if(val_1 <= this.currentActivePEList)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.GameObject val_2 = 2621443.gameObject;
            UnityEngine.Object.Destroy(obj:  2621443);
        }
        
        val_8 = 5;
        label_6:
        val_9 = this.currentActivePEList;
        if(val_9 == 0)
        {
            goto label_18;
        }
        
        if((val_8 - 4) < 2621443)
        {
            goto label_19;
        }
        
        label_8:
        val_9.Clear();
        label_5:
        int val_10 = this.TotalEffects;
        val_10 = val_10 - 1;
        if(this.CurrentParticleEffectIndex < val_10)
        {
                0 = this.CurrentParticleEffectIndex + 1;
        }
        
        this.CurrentParticleEffectIndex = 0;
        mem[1152921511435207060] = 0 + 1;
        UnityEngine.GameObject val_11 = this.ParticleEffectPrefabs[this.CurrentParticleEffectIndex];
        string val_5 = val_11.name;
        typeof(System.String[]).__il2cppRuntimeField_10 = val_11;
        typeof(System.String[]).__il2cppRuntimeField_14 = " (";
        string val_6 = mem[1152921511435207060].ToString();
        typeof(System.String[]).__il2cppRuntimeField_18 = 1152921511435207060;
        typeof(System.String[]).__il2cppRuntimeField_1C = " of ";
        string val_7 = val_10.ToString();
        typeof(System.String[]).__il2cppRuntimeField_20 = 1152921511435207052;
        typeof(System.String[]).__il2cppRuntimeField_24 = ")";
        string val_8 = +477709520;
        this.effectNameString = null;
    }
    public void SpawnParticleEffect(UnityEngine.Vector3 positionInWorldToSpawn)
    {
        int val_10;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -4.385339E-25f, y = positionInWorldToSpawn.x, z = positionInWorldToSpawn.y}, b:  new UnityEngine.Vector3() {x = positionInWorldToSpawn.z, y = mem[this.ParticleEffectSpawnOffsets[((this.CurrentParticleEffectIndex + (this.CurrentParticleEffectIndex) << 1)) << 2][0x10] + (0)], z = mem[this.ParticleEffectSpawnOffsets[((this.CurrentParticleEffectIndex + (this.CurrentParticleEffectIndex) << 1)) << 2][0x10] + (4)]});
        UnityEngine.GameObject val_9 = this.ParticleEffectPrefabs[this.CurrentParticleEffectIndex];
        UnityEngine.Transform val_3 = this.ParticleEffectPrefabs[this.CurrentParticleEffectIndex].transform;
        UnityEngine.Quaternion val_4 = rotation;
        UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_9, position:  new UnityEngine.Vector3() {x = this.spawnPosition, y = positionInWorldToSpawn.y, z = positionInWorldToSpawn.x}, rotation:  new UnityEngine.Quaternion());
        string val_6 = -1761236672(-1761236672) + this.ParticleEffectPrefabs[this.CurrentParticleEffectIndex];
        val_9.name = -1761236672;
        float val_12 = this.ParticleEffectLifetimes[this.CurrentParticleEffectIndex];
        if(val_9 == this.CurrentParticleEffectIndex)
        {
                UnityEngine.Transform val_7 = val_9.transform;
            this.currentActivePEList.Add(item:  val_9);
        }
        
        UnityEngine.Transform val_8 = val_9.transform;
        this.currentActivePEList.Add(item:  val_9);
        val_10 = this.CurrentParticleEffectIndex;
        if(this.currentActivePEList == val_10)
        {
                return;
        }
        
        val_10 = this.CurrentParticleEffectIndex;
        float val_14 = this.ParticleEffectLifetimes[val_10];
        UnityEngine.Object.Destroy(obj:  val_9, t:  this.ParticleEffectLifetimes[val_10]);
    }
    public ParticleEffectsLibrary()
    {
        this.effectNameString = "";
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
    }

}
