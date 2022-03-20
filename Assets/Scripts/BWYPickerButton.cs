using UnityEngine;
public class BWYPickerButton : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject ChooseCellGroup;
    private UnityEngine.GameObject ChooseShapeGroup;
    private UnityEngine.Transform chosenCell;
    
    // Methods
    public void Click()
    {
        this.OpenCellGroup();
        this.ChooseShapeGroup.SetActive(value:  false);
    }
    private void OpenCellGroup()
    {
        var val_10;
        this.ChooseCellGroup.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = 0;
    }
    private void OpenShapeGroup()
    {
        var val_7;
        var val_12;
        var val_13;
        this.ChooseCellGroup.SetActive(value:  false);
        this.ChooseShapeGroup.SetActive(value:  true);
        BlockPuzzleMagic.GameReferenceData val_1 = BlockPuzzleMagic.GameReferenceData.Instance;
        val_12 = 0;
        UnityEngine.Transform val_2 = this.ChooseShapeGroup.transform;
        if(this.ChooseShapeGroup.childCount != 0)
        {
                return;
        }
        
        List.Enumerator<T> val_4 = GetEnumerator();
        label_19:
        if(MoveNext() == false)
        {
            goto label_9;
        }
        
        if(new System.Object() != 0)
        {
                typeof(BWYPickerButton.<>c__DisplayClass5_0).__il2cppRuntimeField_C = this;
            val_13 = 1152921504882192392;
            typeof(BWYPickerButton.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = val_7;
        }
        else
        {
                mem[12] = this;
            val_13 = 8;
            mem[8] = val_7;
        }
        
        UnityEngine.Transform val_8 = this.ChooseShapeGroup.transform;
        object val_9 = UnityEngine.Object.Instantiate<System.Object>(original:  val_7 + 12, parent:  this.ChooseShapeGroup);
        object val_10 = val_7 + 12.AddComponent<System.Object>();
        UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  275345408, method:  new IntPtr(2130823072));
        val_7 + 12 + 172.AddListener(call:  162246656);
        goto label_19;
        label_9:
        Dispose();
    }
    public void PickShape(BlockPuzzleMagic.ShapeBlockSpawn shape)
    {
        if(this.chosenCell.childCount >= 1)
        {
                MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.chosenCell);
        }
        
        UnityEngine.GameObject val_2 = this.ChooseShapeGroup.gameObject;
        this.ChooseShapeGroup.SetActive(value:  false);
    }
    public void PickCell(UnityEngine.Transform cell)
    {
        UnityEngine.Object val_10;
        var val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static BlockPuzzleMagic.BlockShapeSpawner MonoSingleton<BlockPuzzleMagic.BlockShapeSpawner>::get_Instance();
        val_11 = 0;
        mem[1152921511032947828] = cell;
        this.OpenShapeGroup();
    }
    public BWYPickerButton()
    {
    
    }

}
