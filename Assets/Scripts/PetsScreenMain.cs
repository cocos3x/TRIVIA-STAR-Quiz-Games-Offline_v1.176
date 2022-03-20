using UnityEngine;
public class PetsScreenMain : MonoSingleton<PetsScreenMain>
{
    // Fields
    public static WADPets.WADPet HighlightPet;
    private UnityEngine.UI.Button buttonExit;
    private UnityEngine.UI.Button buttonInfo;
    private WADPetProfile petProfile;
    private UnityEngine.RectTransform petsContainer;
    private UnityEngine.GameObject petCardItemPrefab;
    private bool initialized;
    
    // Methods
    public override void InitMonoSingleton()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -980893408, method:  new IntPtr(3314039648));
        this.buttonExit.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -980893408, method:  new IntPtr(3314048864));
        this.buttonInfo.m_OnClick.AddListener(call:  162246656);
    }
    public void Start()
    {
        this.Refresh(highlightPet:  0);
    }
    public void Refresh(WADPets.WADPet highlightPet)
    {
        WADPets.WADPet val_2;
        var val_3;
        WADPets.WADPet val_4;
        val_2 = highlightPet;
        if(this.initialized != true)
        {
                this.InitializePets();
            this.initialized = true;
        }
        
        if(val_2 == 0)
        {
                val_3 = null;
            val_3 = null;
            if(PetsScreenMain.HighlightPet != 0)
        {
                val_3 = null;
        }
        else
        {
                System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.GetAllPetsCollection();
            if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_3 = null;
            val_4 = 0 + 16;
        }
        
            val_2 = mem[(0 + 16)];
            val_2 = val_4;
            val_3 = null;
            PetsScreenMain.HighlightPet = 0;
        }
        
        this.petProfile.Setup(pet:  val_2);
        this.UpdateCardsCollection(highlightPet:  val_2);
    }
    private void Initialize()
    {
        this.InitializePets();
        this.initialized = true;
    }
    private void InitializePets()
    {
        WADPets.WADPet val_4;
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.GetAllPetsCollection();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_13:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((val_4 + 8 + 12) == 3)
        {
                if(Alphabet2Manager.IsAvailable == false)
        {
            goto label_13;
        }
        
        }
        
        object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  this.petCardItemPrefab, parent:  this.petsContainer);
        object val_7 = this.petCardItemPrefab.GetComponent<System.Object>();
        this.petCardItemPrefab.Setup(pet:  val_4, highlight:  false);
        goto label_13;
        label_2:
        Dispose();
    }
    private void UpdateCardsCollection(WADPets.WADPet highlightPet)
    {
        var val_3;
        T[] val_1 = this.petsContainer.GetComponentsInChildren<System.Object>();
        UnityEngine.RectTransform val_2 = this.petsContainer + 16;
        val_3 = 0;
        goto label_2;
        label_6:
        1152921504767283200.UpdateCard(highlightedPet:  highlightPet);
        val_3 = 1;
        label_2:
        if(val_3 < 1152921504767283200)
        {
            goto label_6;
        }
    
    }
    private void OnClick_PetsInfo()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void BackToLobby()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BackButtonPressed();
    }
    public PetsScreenMain()
    {
    
    }
    private static PetsScreenMain()
    {
    
    }

}
