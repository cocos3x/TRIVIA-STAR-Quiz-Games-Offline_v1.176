using UnityEngine;
public class WGPuzzleCompletePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image puzzleImage;
    private UnityEngine.UI.Button collectButton;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private UnityEngine.GameObject rewardCoinObject;
    private UnityEngine.UI.Text reward;
    private UnityEngine.GameObject rewardBonusGameObject;
    private UnityEngine.UI.Text rewardBonusGameLabel;
    private UnityEngine.UI.Image rewardBonusGameIcon;
    private UnityEngine.Sprite bonusIconWheel;
    private UnityEngine.Sprite bonusIconSlots;
    private const string FREE_COIN_SOURCE = "Puzzle Collect Reward";
    private const string NON_COIN_SOURCE_ID = "Puzzle Collection";
    private UnityEngine.Sprite tempSprite;
    private string puzzleImagePath;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  28123744, method:  new IntPtr(28093600));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        System.Action val_2 = new System.Action(object:  28123744, method:  new IntPtr(28098720));
        this.coinsAnimControl.OnCompleteCallback = null;
    }
    private void OnEnable()
    {
        string val_9;
        if(this.puzzleImage != 0)
        {
                string val_2 = PuzzleCollectionHandler.CurrentPuzzleName;
            if((System.String.op_Equality(a:  null, b:  28228128)) != false)
        {
                val_9 = "game/WordAddict/Events/PuzzleCollection/academy";
            object val_4 = UnityEngine.Resources.Load<System.Object>(path:  28228224);
        }
        else
        {
                string val_5 = UnityEngine.Application.temporaryCachePath;
            string val_6 = PuzzleCollectionHandler.LastPuzzleName;
            val_9 = 0;
            string val_7 = null + 1115175264 + null + 1975550080;
            this.puzzleImagePath = val_9;
            UnityEngine.Sprite val_8 = ImageLoadingController.GetSprite(path:  null);
        }
        
            this.tempSprite = val_9;
            this.puzzleImage.sprite = 0;
        }
        
        this.UpdateRewardInfo();
    }
    private void OnDisable()
    {
        string val_1 = PuzzleCollectionHandler.CurrentPuzzleName;
        if((System.String.op_Inequality(a:  null, b:  28228128)) == false)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  R4 + 52);
    }
    private void UpdateRewardInfo()
    {
        UnityEngine.Sprite val_6;
        UnityEngine.UI.Image val_7;
        var val_6 = 0;
        GameEventRewardType val_1 = PuzzleCollectionHandler.RewardType;
        if(val_6 == 1)
        {
                this.rewardCoinObject.SetActive(value:  true);
            this.rewardBonusGameObject.SetActive(value:  false);
            string val_3 = PuzzleCollectionHandler.RewardValue.ToString();
            if(this.reward != 0)
        {
                return;
        }
        
            return;
        }
        
        val_6 = val_6;
        val_6 = val_6 - 3;
        if(val_6 > 1)
        {
                return;
        }
        
        this.rewardCoinObject.SetActive(value:  false);
        this.rewardBonusGameObject.SetActive(value:  true);
        if(val_6 == 3)
        {
                string val_4 = Localization.Localize(key:  -1505638896, defaultValue:  -1505638992, useSingularKey:  false);
            val_7 = this.rewardBonusGameIcon;
            val_6 = this.bonusIconWheel;
        }
        else
        {
                string val_5 = Localization.Localize(key:  -1505604896, defaultValue:  -1505604992, useSingularKey:  false);
            val_7 = this.rewardBonusGameIcon;
            val_6 = this.bonusIconSlots;
        }
        
        val_7.sprite = val_6;
    }
    private void OnClicked_Collect()
    {
        int val_5;
        int val_12;
        GridCoinCollectAnimationInstantiator val_14;
        float val_15;
        string val_16;
        string val_17;
        System.Action val_18;
        var val_19;
        this.collectButton.interactable = false;
        GameEventRewardType val_1 = PuzzleCollectionHandler.RewardType;
        if(0 == 4)
        {
            goto label_2;
        }
        
        if(0 == 3)
        {
            goto label_3;
        }
        
        if(0 != 1)
        {
                return;
        }
        
        val_14 = 1152921504892043264;
        Player val_2 = App.Player;
        int val_3 = PuzzleCollectionHandler.RewardValue;
        val_15 = 1152921504617017344;
        val_16 = 0;
        decimal val_4 = System.Decimal.op_Implicit(value:  28693196);
        val_17 = "Puzzle Collect Reward";
        0.AddCredits(amount:  new System.Decimal() {mid = val_5}, source:  val_17, subSource:  val_16, externalParams:  val_16, doTrack:  true);
        this.MarkRewarded();
        if(this.coinsAnimControl == 0)
        {
                return;
        }
        
        val_14 = this.coinsAnimControl;
        Player val_7 = App.Player;
        int val_8 = PuzzleCollectionHandler.RewardValue;
        decimal val_9 = System.Decimal.op_Implicit(value:  28693196);
        decimal val_10 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 28693180, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {});
        Player val_11 = App.Player;
        val_14.Play(fromValue:  new System.Decimal() {mid = val_12}, toValue:  new System.Decimal() {hi = val_17, lo = val_16, mid = val_15}, textTickTime:  null, delayBeforeComplete:  null);
        return;
        label_2:
        val_18 = null;
        val_19 = 1152921513225460768;
        goto label_20;
        label_3:
        val_18 = null;
        val_19 = 1152921513225461792;
        label_20:
        val_18 = new System.Action(object:  28705248, method:  new IntPtr(28680224));
        this.Close(onClose:  7454720);
    }
    private void MarkRewarded()
    {
        PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.MarkRewarded();
    }
    private void OnCoinsAnimFinished()
    {
        var val_2;
        System.Action val_4;
        val_2 = null;
        val_2 = null;
        val_4 = WGPuzzleCompletePopup.<>c.<>9__20_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Action(object:  WGPuzzleCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(28917536));
            WGPuzzleCompletePopup.<>c.<>9__20_0 = val_4;
        }
        
        this.Close(onClose:  7454720);
    }
    private void Close(System.Action onClose)
    {
        System.Action val_6 = onClose;
        if(val_6 == 0)
        {
            goto label_1;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        if(this != 0)
        {
                System.Delegate val_3 = System.Delegate.Combine(a:  this.coinsAnimControl, b:  val_6 = onClose);
            val_6 = this.coinsAnimControl;
        }
        else
        {
                System.Delegate val_4 = System.Delegate.Combine(a:  this.coinsAnimControl, b:  val_6);
            val_6 = this.coinsAnimControl;
        }
        
        if(val_6 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_6 = 0;
        label_6:
        this.coinsAnimControl = val_6;
        label_1:
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  29066848, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGPuzzleCompletePopup()
    {
    
    }
    private void <OnClicked_Collect>b__18_0()
    {
        System.Action val_5;
        var val_6;
        System.Action val_8;
        GameBehavior val_1 = App.getBehavior;
        val_5 = null;
        val_5 = new System.Action(object:  29305184, method:  new IntPtr(29279136));
        if(0 != 0)
        {
                mem[16] = val_5;
        }
        else
        {
                mem[16] = val_5;
        }
        
        mem[12] = "PuzzleCollection";
        val_6 = null;
        val_6 = null;
        val_8 = WGPuzzleCompletePopup.<>c.<>9__18_2;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  WGPuzzleCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(29280160));
            WGPuzzleCompletePopup.<>c.<>9__18_2 = val_8;
        }
        
        0.SetOnClose(onClose:  7454720);
    }
    private void <OnClicked_Collect>b__18_1()
    {
        System.Action val_5;
        var val_6;
        System.Action val_8;
        GameBehavior val_1 = App.getBehavior;
        val_5 = null;
        val_5 = new System.Action(object:  29418208, method:  new IntPtr(29279136));
        if(0 != 0)
        {
                mem[68] = val_5;
        }
        else
        {
                mem[68] = val_5;
        }
        
        mem[64] = "PuzzleCollection";
        val_6 = null;
        val_6 = null;
        val_8 = WGPuzzleCompletePopup.<>c.<>9__18_3;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  WGPuzzleCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(29393184));
            WGPuzzleCompletePopup.<>c.<>9__18_3 = val_8;
        }
        
        0.SetOnClose(onClose:  7454720);
    }

}
