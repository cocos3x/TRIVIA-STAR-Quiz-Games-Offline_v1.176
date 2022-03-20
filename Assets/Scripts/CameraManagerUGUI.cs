using UnityEngine;
public class CameraManagerUGUI : MonoSingletonSelfGenerating<CameraManagerUGUI>
{
    // Fields
    private System.Collections.Generic.Dictionary<int, CameraOperatorUGUI> guidsToCameras;
    private System.Collections.Generic.Stack<System.Collections.Generic.Dictionary<int, bool>> cameraSnapshotQueue;
    
    // Methods
    public void AddCamera(CameraOperatorUGUI cam)
    {
        UnityEngine.Object val_7;
        int val_8;
        val_7 = 35626773;
        val_8 = 1152921504765685760;
        if(cam == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = cam.gameObject;
        val_7 = cam;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = this.guidsToCameras;
        val_8 = cam.GetInstanceID();
        if((val_7.ContainsKey(key:  val_8)) != false)
        {
                return;
        }
        
        this.guidsToCameras.Add(key:  cam.GetInstanceID(), value:  cam);
    }
    public void RemoveCamera(CameraOperatorUGUI cam)
    {
        var val_6;
        var val_7;
        int val_8;
        var val_6 = 29001905;
        val_6 = 6624988 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(App.isQuitting == true)
        {
                return;
        }
        
        if(R4 == 0)
        {
                return;
        }
        
        val_7 = mem[R5 + 12];
        val_7 = R5 + 12;
        val_8 = R4.GetInstanceID();
        if((val_7.ContainsKey(key:  val_8)) == false)
        {
                return;
        }
        
        bool val_5 = R5 + 12.Remove(key:  R4.GetInstanceID());
    }
    public void TakeCameraStateSnapshot()
    {
        var val_14;
        var val_15;
        System.Collections.Generic.Dictionary<System.Int32, CameraOperatorUGUI> val_16;
        var val_15 = 29001457;
        val_15 = 6625436 + val_15;
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        if(App.isQuitting == true)
        {
                return;
        }
        
        Dictionary.ValueCollection<TKey, TValue> val_2 = this.guidsToCameras.Values;
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Object>(source:  this.guidsToCameras);
        val_15 = 4;
        goto label_8;
        label_32:
        if(this.guidsToCameras <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_4 = UnityEngine.Object.op_Equality(x:  public static System.Collections.Generic.List<TSource> System.Linq.Enumerable::ToList<CameraOperatorUGUI>(System.Collections.Generic.IEnumerable<TSource> source).__il2cppRuntimeField_10, y:  0);
        if(val_4 == true)
        {
            goto label_12;
        }
        
        if(val_4 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_5 = 2621443.gameObject;
        bool val_6 = UnityEngine.Object.op_Equality(x:  2621443, y:  0);
        if(val_6 == false)
        {
            goto label_17;
        }
        
        label_12:
        if(val_6 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_8 = 2621443.GetInstanceID().ToString();
        string val_9 = -2010338560(-2010338560) + -2010316104(-2010316104) + -2010338448(-2010338448);
        UnityEngine.Debug.LogError(message:  -2010338560);
        val_16 = this.guidsToCameras;
        if("Trying to remove " <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_11 = val_16.Remove(key:  2621443.GetInstanceID());
        goto label_25;
        label_17:
        if(val_6 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_12 = 2621443.GetInstanceID();
        val_16 = val_12;
        if(val_12 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        Add(key:  val_16, value:  2621443.IsCameraActive());
        label_25:
        val_15 = 5;
        label_8:
        if((val_15 - 4) < (new System.Collections.Generic.Dictionary<System.Int32, System.Boolean>()))
        {
            goto label_32;
        }
        
        this.cameraSnapshotQueue.Push(item:  78753792);
    }
    public void RestoreCameraStateSnapshot()
    {
        var val_17;
        var val_19;
        var val_17 = 29000353;
        val_17 = 6626540 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_17 = null;
        val_17 = null;
        if(App.isQuitting != false)
        {
                return;
        }
        
        if(App.isQuitting == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Boolean> val_1 = this.cameraSnapshotQueue.Pop();
        if(this.cameraSnapshotQueue == 0)
        {
                return;
        }
        
        if(this.cameraSnapshotQueue.Count < 1)
        {
                return;
        }
        
        Dictionary.ValueCollection<TKey, TValue> val_3 = this.guidsToCameras.Values;
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Object>(source:  this.guidsToCameras);
        var val_18 = 4;
        label_31:
        if(0 >= this.guidsToCameras)
        {
                return;
        }
        
        if(this.guidsToCameras <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_5 = UnityEngine.Object.op_Equality(x:  public static System.Collections.Generic.List<TSource> System.Linq.Enumerable::ToList<CameraOperatorUGUI>(System.Collections.Generic.IEnumerable<TSource> source).__il2cppRuntimeField_10, y:  0);
        if(val_5 == true)
        {
            goto label_18;
        }
        
        if(val_5 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_6 = 2621443.gameObject;
        bool val_7 = UnityEngine.Object.op_Equality(x:  2621443, y:  0);
        if(val_7 == false)
        {
            goto label_23;
        }
        
        label_18:
        if(val_7 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_9 = 2621443.GetInstanceID().ToString();
        string val_10 = -2010338560(-2010338560) + -2010171336(-2010171336) + -2010338448(-2010338448);
        UnityEngine.Debug.LogError(message:  -2010338560);
        if("Trying to remove " <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_12 = this.guidsToCameras.Remove(key:  2621443.GetInstanceID());
        label_39:
        val_18 = val_18 + 1;
        goto label_31;
        label_23:
        if(val_7 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_14 = this.cameraSnapshotQueue.ContainsKey(key:  2621443.GetInstanceID());
        if(val_14 == false)
        {
            goto label_39;
        }
        
        if(val_14 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = val_13 + 16;
        if(0 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_19 = 2621443;
        }
        
        val_13 + 16.SetCameraState(active:  this.cameraSnapshotQueue.Item[val_19.GetInstanceID()]);
        goto label_39;
    }
    public void DisableSnapshottedCameras()
    {
        if(0 == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Boolean> val_1 = this.cameraSnapshotQueue.Peek();
        if(this.cameraSnapshotQueue == 0)
        {
                return;
        }
        
        if(this.cameraSnapshotQueue.Count < 1)
        {
                return;
        }
        
        Dictionary.ValueCollection<TKey, TValue> val_3 = this.guidsToCameras.Values;
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Object>(source:  this.guidsToCameras);
        var val_15 = 4;
        label_25:
        if(0 >= this.guidsToCameras)
        {
                return;
        }
        
        if(this.guidsToCameras <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_5 = UnityEngine.Object.op_Equality(x:  public static System.Collections.Generic.List<TSource> System.Linq.Enumerable::ToList<CameraOperatorUGUI>(System.Collections.Generic.IEnumerable<TSource> source).__il2cppRuntimeField_10, y:  0);
        if(val_5 == true)
        {
            goto label_12;
        }
        
        if(val_5 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_6 = 2621443.gameObject;
        bool val_7 = UnityEngine.Object.op_Equality(x:  2621443, y:  0);
        if(val_7 == false)
        {
            goto label_17;
        }
        
        label_12:
        if(val_7 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_9 = 2621443.GetInstanceID().ToString();
        string val_10 = -2010338560(-2010338560) + -2010025544(-2010025544) + -2010338448(-2010338448);
        UnityEngine.Debug.LogError(message:  -2010338560);
        if("Trying to remove " <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_12 = this.guidsToCameras.Remove(key:  2621443.GetInstanceID());
        label_31:
        val_15 = val_15 + 1;
        goto label_25;
        label_17:
        if(val_7 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_14 = this.cameraSnapshotQueue.ContainsKey(key:  2621443.GetInstanceID());
        if(val_14 == false)
        {
            goto label_31;
        }
        
        if(val_14 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.SetCameraState(active:  false);
        goto label_31;
    }
    public CameraManagerUGUI()
    {
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.guidsToCameras = null;
        System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_2 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
        this.cameraSnapshotQueue = null;
    }

}
