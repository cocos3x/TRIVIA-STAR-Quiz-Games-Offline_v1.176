using UnityEngine;
public class KeyToRichesChest : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject glowingKeyGO;
    private UnityEngine.UI.Image glowingKey;
    private UnityEngine.UI.Image rewardImage;
    private UnityEngine.UI.Text rewardText;
    private UnityEngine.UI.Button chestButton;
    private UnityEngine.Animator animator;
    private float keyMoveDuration;
    private float rewardParticleDelay;
    private UnityEngine.UI.Text hackText;
    private KeyToRichesEventHandler.Reward currentReward;
    private KeyToRichesPopup popup;
    private UnityEngine.Transform keyPosOrigin;
    private int index;
    
    // Methods
    private void OnCollect()
    {
        Reward val_4 = this.currentReward;
        if(val_4 == 0)
        {
                return;
        }
        
        val_4 = this.currentReward;
        if((KeyToRichesEventHandler._Instance.OpenChest(reward:  val_4)) == false)
        {
                return;
        }
        
        this.chestButton.interactable = false;
        System.Collections.IEnumerator val_2 = this.RewardSequence();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -1362604656);
        this.popup.OnCollect(index:  this.index);
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1362467056, method:  new IntPtr(2932475216));
        this.chestButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.hackText.gameObject;
        this.hackText.SetActive(value:  false);
    }
    public void SetupDefault()
    {
        this.chestButton.interactable = false;
        this.glowingKeyGO.SetActive(value:  false);
        this.ToggleChestContent(show:  KeyToRichesEventHandler._Instance.showChestContent);
    }
    public void SetupReward(KeyToRichesPopup keyToRichesPopup, int i, KeyToRichesEventHandler.Reward reward, UnityEngine.Sprite rewardSprite, int rewardAmount, UnityEngine.Transform keyPos)
    {
        this.index = i;
        this.currentReward = reward;
        this.popup = keyToRichesPopup;
        this.rewardImage.sprite = rewardSprite;
        string val_1 = rewardAmount.ToString();
        this.keyPosOrigin = keyPos;
        this.chestButton.interactable = true;
        this.glowingKeyGO.SetActive(value:  false);
        this.ToggleChestContent(show:  KeyToRichesEventHandler._Instance.showChestContent);
    }
    public void RevealReward()
    {
        System.Collections.IEnumerator val_1 = this.RevealSequence();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1361920752);
    }
    private System.Collections.IEnumerator RewardSequence()
    {
        object val_1 = new System.Object();
        typeof(KeyToRichesChest.<RewardSequence>d__19).__il2cppRuntimeField_8 = 0;
        typeof(KeyToRichesChest.<RewardSequence>d__19).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator RevealSequence()
    {
        object val_1 = new System.Object();
        typeof(KeyToRichesChest.<RevealSequence>d__20).__il2cppRuntimeField_8 = 0;
        typeof(KeyToRichesChest.<RevealSequence>d__20).__il2cppRuntimeField_10 = this;
    }
    public void ToggleChestContent(bool show)
    {
        var val_2;
        UnityEngine.GameObject val_1 = this.hackText.gameObject;
        this.hackText.SetActive(value:  show);
        if(show == false)
        {
                return;
        }
        
        if(this.currentReward != 0)
        {
                val_2 = this.currentReward;
        }
        else
        {
                val_2 = "empty";
        }
        
        if(this.hackText == 0)
        {
            
        }
    
    }
    public KeyToRichesChest()
    {
        this.keyMoveDuration = 0.8f;
        this.rewardParticleDelay = 1.2f;
    }

}
