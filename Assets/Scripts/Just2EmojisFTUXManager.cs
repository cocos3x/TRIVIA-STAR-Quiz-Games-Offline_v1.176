using UnityEngine;
public class Just2EmojisFTUXManager : MonoSingleton<Just2EmojisFTUXManager>
{
    // Fields
    private UnityEngine.UI.Text FTUXText;
    private UnityEngine.GameObject hintButton;
    private UnityEngine.UI.Text hintText;
    private UnityEngine.UI.Image hintImage;
    private UnityEngine.UI.Text coinText;
    private UnityEngine.UI.Image coinImage;
    private UnityEngine.GameObject FTUXHand;
    public bool ftux;
    public bool checkedFTUX;
    private float timer;
    public bool counting;
    
    // Methods
    private void Start()
    {
        this.timer = 3f;
        this.checkedFTUX = false;
        this.FTUXHand.SetActive(value:  false);
        this.FTUXText.enabled = false;
    }
    private void Update()
    {
        if(this.counting != false)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            uint val_4 = 0;
            val_4 = this.timer + val_4;
            this.timer = val_4;
            if(this.counting < false)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_3 = FTUXNewLetterPosition();
            this.ShowHand(t:  -1743617136);
            this.counting = false;
            this.timer = false;
            return;
        }
        
        this.timer = 0f;
    }
    public void ResetFTUXTimer()
    {
        this.timer = 0f;
    }
    public void StartFTUX()
    {
        this.FTUXHand.SetActive(value:  false);
        this.FTUXText.enabled = false;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetAnswersInteractable(on:  false);
        object val_2 = this.hintButton.GetComponent<System.Object>();
        this.hintButton.interactable = false;
        object val_3 = this.hintButton.GetComponent<System.Object>();
        this.hintButton.enabled = false;
        this.hintText.enabled = false;
        this.hintImage.enabled = false;
        this.coinText.enabled = false;
        this.coinImage.enabled = false;
        System.Collections.IEnumerator val_4 = this.ShowFTUXElements();
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -1743335344);
    }
    private System.Collections.IEnumerator ShowFTUXElements()
    {
        object val_1 = new System.Object();
        typeof(Just2EmojisFTUXManager.<ShowFTUXElements>d__15).__il2cppRuntimeField_8 = 0;
        typeof(Just2EmojisFTUXManager.<ShowFTUXElements>d__15).__il2cppRuntimeField_10 = this;
    }
    public void HideHand()
    {
        this.FTUXHand.SetActive(value:  false);
        this.counting = true;
    }
    public void ShowHand(UnityEngine.Transform t)
    {
        bool val_7;
        if(t == 0)
        {
                val_7 = "Transform is null, ftux is set to ";
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_7;
            string val_2 = this.ftux.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.ftux;
            typeof(System.Object[]).__il2cppRuntimeField_18 = " with player lvl ";
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            string val_4 = +472754880;
            UnityEngine.Debug.LogError(message:  472754880);
            return;
        }
        
        UnityEngine.Transform val_5 = this.FTUXHand.transform;
        UnityEngine.Vector3 val_6 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60.position;
        this.FTUXHand.position = new UnityEngine.Vector3() {x = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60};
        val_7 = false;
        this.FTUXHand.SetActive(value:  true);
        this.counting = val_7;
    }
    public void EndFTUX()
    {
        this.ftux = true;
        this.checkedFTUX = true;
        this.FTUXText.enabled = false;
        System.Collections.IEnumerator val_1 = this.DelayEnablingHintButton();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1742817456);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        FTUXUnhighlight();
    }
    private System.Collections.IEnumerator DelayEnablingHintButton()
    {
        object val_1 = new System.Object();
        typeof(Just2EmojisFTUXManager.<DelayEnablingHintButton>d__19).__il2cppRuntimeField_8 = 0;
        typeof(Just2EmojisFTUXManager.<DelayEnablingHintButton>d__19).__il2cppRuntimeField_10 = this;
    }
    public Just2EmojisFTUXManager()
    {
    
    }

}
