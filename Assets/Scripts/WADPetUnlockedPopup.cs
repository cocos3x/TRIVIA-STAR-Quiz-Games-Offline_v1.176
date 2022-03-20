using UnityEngine;
public class WADPetUnlockedPopup : MonoBehaviour
{
    // Fields
    private Spine.Unity.SkeletonGraphic skeletonGraphic;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Button meetPetButton;
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.UI.Button closeButton;
    
    // Methods
    public void Setup(WADPets.WADPet pet)
    {
        WADPets.WADPet val_13;
        object val_14;
        var val_15;
        Spine.Unity.SkeletonGraphic val_16;
        Spine.Unity.SkeletonGraphic val_17;
        val_13 = pet;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_14 = val_1;
            val_15 = this;
            typeof(WADPetUnlockedPopup.<>c__DisplayClass5_0).__il2cppRuntimeField_C = val_13;
            WADPetUnlockedPopup.<>c__DisplayClass5_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = this;
            val_16 = this.skeletonGraphic;
        }
        else
        {
                mem[8] = this;
            val_14 = 12;
            val_15 = this;
            mem[12] = val_13;
            val_16 = this.skeletonGraphic;
            val_13 = mem[12];
        }
        
        this.skeletonGraphic.skeletonDataAsset = pet + 8 + 32;
        val_16.Initialize(overwrite:  true);
        if(val_16.IsValid == false)
        {
            goto label_8;
        }
        
        this.skeletonGraphic.startingAnimation = "Idle";
        val_17 = val_16;
        if(val_16 != 0)
        {
            goto label_10;
        }
        
        val_17 = val_16;
        if(val_17 == 0)
        {
            goto label_11;
        }
        
        label_10:
        Spine.TrackEntry val_3 = this.skeletonGraphic.state.SetAnimation(trackIndex:  0, animationName:  this.skeletonGraphic.startingAnimation, loop:  true);
        this.skeletonGraphic.skeleton.SetSlotsToSetupPose();
        label_8:
        string val_4 = Localization.Localize(key:  -146892880, defaultValue:  -146893040, useSingularKey:  false);
        string val_5 = val_14.GetPrettyName();
        string val_6 = System.String.Format(format:  -146892880, arg0:  val_14);
        string val_7 = Localization.Localize(key:  -146884496, defaultValue:  -146884576, useSingularKey:  false);
        var val_8 = (pet + 8) + 8;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        string val_9 = ToUpper();
        string val_10 = System.String.Format(format:  1592589744, arg0:  -146884496, arg1:  431575040);
        UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  383438848, method:  new IntPtr(4148091088));
        this.meetPetButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_12 = new UnityEngine.Events.UnityAction(object:  -146841968, method:  new IntPtr(4148100304));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        return;
        label_11:
    }
    private void OnClick_MeetPet(WADPets.WADPet pet)
    {
        null = null;
        PetsScreenMain.HighlightPet = pet;
        WADPetsScreenUI.ShowMainScreen();
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -146676720, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -146560624, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WADPetUnlockedPopup()
    {
    
    }

}
