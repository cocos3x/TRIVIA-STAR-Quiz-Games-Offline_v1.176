using UnityEngine;
public class TRVStarChampionshipEventPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject popupHolder;
    private UnityEngine.UI.Text description_top;
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.UI.Button button;
    private UnityEngine.UI.Button closeButton;
    private TRVStarChampionshipProgressBar progressBar;
    private UnityEngine.UI.Text description_bottom;
    private UnityEngine.GameObject rewardGroup;
    private UnityEngine.UI.Text rewardText;
    private GemsCollectAnimationInstantiator gemAnim;
    private System.Action onEnableAction;
    
    // Methods
    private void OnEnable()
    {
        if(this.onEnableAction != 0)
        {
                this.onEnableAction.Invoke();
        }
        
        this.onEnableAction = 0;
    }
    public void ShowRewardPopup(TRVStarChampionshipRewardUIParam param)
    {
        if(new System.Object() != 0)
        {
                typeof(TRVStarChampionshipEventPopup.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(TRVStarChampionshipEventPopup.<>c__DisplayClass12_0).__il2cppRuntimeField_C = param;
        UnityEngine.GameObject val_2 = this.gameObject;
        if(this.activeSelf != false)
        {
                System.Collections.IEnumerator val_4 = this.DelayShowingRewardPopup(param:  typeof(TRVStarChampionshipEventPopup.<>c__DisplayClass12_0).__il2cppRuntimeField_C);
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -411287504);
            return;
        }
        
        System.Action val_6 = new System.Action(object:  365121536, method:  new IntPtr(3883654768));
        this.onEnableAction = null;
    }
    public void ShowProgressPopup(TRVStarChampionshipProgressUIParam param)
    {
        UnityEngine.GameObject val_1 = this.description_bottom.gameObject;
        this.description_bottom.SetActive(value:  true);
        this.progressBar.UpdateProgressBar(progress:  null, tier:  S16);
        this.rewardGroup.SetActive(value:  false);
        string val_2 = Localization.Localize(key:  -1468908784, defaultValue:  -1621736080, useSingularKey:  false);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -411117136, method:  new IntPtr(3883812848));
        this.button.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_4 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -411117136, method:  new IntPtr(3883812848));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private System.Collections.IEnumerator DelayShowingRewardPopup(TRVStarChampionshipRewardUIParam param)
    {
        typeof(TRVStarChampionshipEventPopup.<DelayShowingRewardPopup>d__14).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TRVStarChampionshipEventPopup.<DelayShowingRewardPopup>d__14).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(TRVStarChampionshipEventPopup.<DelayShowingRewardPopup>d__14).__il2cppRuntimeField_14 = param;
    }
    private void CollectReward(int reward, int tier)
    {
        int val_11;
        int val_12;
        int val_13;
        int val_14;
        this.button.interactable = false;
        Player val_1 = App.Player;
        0.AddGems(amount:  reward, source:  -410851600, subsource:  null);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        int val_3 = tier + 1;
        string val_4 = System.String.Format(format:  -410851472, arg0:  13152256);
        Add(key:  -410851472, value:  13152256);
        Player val_5 = App.Player;
        string val_6 = reward.ToString();
        0.TrackNonCoinReward(source:  -410851344, subSource:  null, rewardType:  -1668821072, rewardAmount:  reward, additionalParams:  null);
        System.Action val_7 = new System.Action(object:  -410819040, method:  new IntPtr(3883812848));
        mem2[0] = null;
        Player val_8 = App.Player;
        Player val_9 = App.Player;
        decimal val_10 = System.Decimal.op_Implicit(value:  -410831100);
        this.gemAnim.Play(fromValue:  0 - reward, toValue:  new System.Decimal() {flags = val_13, hi = val_14, lo = val_12, mid = val_11}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDisable()
    {
        if((TRVStarChampionshipEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        TRVStarChampionshipEventHandler.<Instance>k__BackingField.OnMyEventPopupClosed();
    }
    public TRVStarChampionshipEventPopup()
    {
    
    }

}
