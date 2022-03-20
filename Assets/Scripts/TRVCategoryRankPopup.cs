using UnityEngine;
public class TRVCategoryRankPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image categoryIcon;
    private UnityEngine.UI.Text rank;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Text reward;
    private UnityEngine.UI.Button collectButton;
    private GridCoinCollectAnimationInstantiator coinAnim;
    private int currentRank;
    private int rewardAmount;
    
    // Methods
    private void OnEnable()
    {
        System.Collections.IEnumerator val_1 = this.AnimateRankup();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -555055424);
    }
    public void Init(UnityEngine.Sprite categorySp, int currentRank, int nextProgressGoal, int rewardAmount)
    {
        UnityEngine.UI.Text val_7;
        var val_8;
        val_7 = this.rank;
        this.currentRank = currentRank;
        this.rewardAmount = rewardAmount;
        string val_1 = currentRank.ToString();
        this.categoryIcon.sprite = categorySp;
        if(nextProgressGoal != 0)
        {
                string val_2 = Localization.Localize(key:  -554950896, defaultValue:  -554951040, useSingularKey:  false);
            val_7 = "trv_category_increase";
            val_8 = val_7;
            string val_3 = System.String.Format(format:  -554950896, arg0:  13152256);
        }
        else
        {
                val_8 = "congratulations";
            string val_4 = Localization.Localize(key:  -554950672, defaultValue:  -554950784, useSingularKey:  false);
        }
        
        string val_5 = rewardAmount.ToString();
        this.collectButton.interactable = true;
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -554909152, method:  new IntPtr(3740033120));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    private System.Collections.IEnumerator AnimateRankup()
    {
        object val_1 = new System.Object();
        typeof(TRVCategoryRankPopup.<AnimateRankup>d__10).__il2cppRuntimeField_8 = 0;
        typeof(TRVCategoryRankPopup.<AnimateRankup>d__10).__il2cppRuntimeField_10 = this;
    }
    private void CollectReward()
    {
        int val_6;
        TRVCategoryRankController.CollectReward(reward:  this.rewardAmount);
        System.Action val_1 = new System.Action(object:  -554639072, method:  new IntPtr(3740295008));
        this.coinAnim.OnCompleteCallback = null;
        Player val_2 = App.Player;
        decimal val_3 = System.Decimal.op_Implicit(value:  -554651124);
        decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -554651140, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_5 = App.Player;
        this.coinAnim.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
        this.collectButton.interactable = false;
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -554514784, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVCategoryRankPopup()
    {
    
    }

}
