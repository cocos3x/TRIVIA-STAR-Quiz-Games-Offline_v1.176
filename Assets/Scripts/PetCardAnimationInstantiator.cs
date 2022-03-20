using UnityEngine;
public class PetCardAnimationInstantiator : MonoBehaviour
{
    // Fields
    public int maxCardsPerRow;
    public UnityEngine.GameObject background;
    public UnityEngine.UI.HorizontalLayoutGroup rowLayout;
    public UnityEngine.UI.VerticalLayoutGroup verticalLayout;
    public UnityEngine.GameObject petCardPrefab;
    private System.Collections.Generic.List<PetCardAnimationInstantiator.PetCardReward> petCards;
    private System.Collections.Generic.List<GiftRewardUI_PetCard> petCardsUI;
    private System.Collections.Generic.List<UnityEngine.UI.HorizontalLayoutGroup> hrows;
    public System.Action OnCompleteCallback;
    private const float CardFadeDuration = 0.5;
    
    // Methods
    private void Awake()
    {
        this.hrows.Add(item:  this.rowLayout);
        UnityEngine.GameObject val_1 = this.verticalLayout.gameObject;
        this.verticalLayout.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.background.gameObject;
        this.background.SetActive(value:  false);
    }
    public void AddCard(WADPets.WADPet pet, decimal startBalance, decimal endBalance)
    {
        int val_1;
        int val_2;
        int val_3;
        val_1 = endBalance.mid;
        val_2 = endBalance.lo;
        val_3 = endBalance.hi;
        if(this.petCards == 0)
        {
                val_3 = endBalance.hi;
            val_2 = endBalance.lo;
            val_1 = endBalance.mid;
        }
        
        this.petCards.Add(item:  new PetCardReward() {pet = pet, startBalance = new System.Decimal() {flags = startBalance.flags, hi = startBalance.hi, lo = startBalance.lo, mid = startBalance.mid}, endBalance = new System.Decimal() {flags = endBalance.flags, hi = val_3, lo = val_2, mid = val_1}});
    }
    public void Play(System.Collections.Generic.List<PetCardAnimationInstantiator.PetCardReward> petCards)
    {
        this.petCards = petCards;
        this.Play();
    }
    public void Play()
    {
        if(this.petCards == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.verticalLayout.gameObject;
        this.verticalLayout.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.background.gameObject;
        this.background.SetActive(value:  true);
        float val_6 = (float)this.maxCardsPerRow;
        val_6 = (float)this.petCards / val_6;
        int val_3 = UnityEngine.Mathf.CeilToInt(f:  val_6);
        this.InstantiateRows(totalRows:  val_3);
        this.InstantiateCardUI(totalRows:  val_3);
        System.Collections.IEnumerator val_4 = this.PlayCollect();
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -982460640);
    }
    private System.Collections.IEnumerator PlayCollect()
    {
        object val_1 = new System.Object();
        typeof(PetCardAnimationInstantiator.<PlayCollect>d__15).__il2cppRuntimeField_8 = 0;
        typeof(PetCardAnimationInstantiator.<PlayCollect>d__15).__il2cppRuntimeField_10 = this;
    }
    private void HideAndClear()
    {
        var val_9;
        PetCardAnimationInstantiator val_10;
        var val_11;
        var val_12;
        UnityEngine.Object val_13;
        var val_14;
        var val_15;
        mem[1152921512214563392].Clear();
        mem[1152921512214563396].Clear();
        UnityEngine.GameObject val_1 = mem[1152921512214563384].gameObject;
        mem[1152921512214563384].SetActive(value:  false);
        UnityEngine.GameObject val_2 = mem[1152921512214563376].gameObject;
        mem[1152921512214563376].SetActive(value:  false);
        val_9 = 0;
        val_10 = this;
        label_43:
        if(mem[1152921512214563400] == 0)
        {
                val_9 = val_9;
            val_10 = this;
        }
        
        if(val_9 >= (mem[1152921512214563400] + 12))
        {
                return;
        }
        
        if(mem[1152921512214563400] == 0)
        {
                val_9 = val_9;
        }
        
        if((mem[1152921512214563400] + 12) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = val_9;
        }
        
        var val_9 = mem[1152921512214563400] + 8;
        val_9 = val_9 + 0;
        UnityEngine.Transform val_3 = (mem[1152921512214563400] + 8 + 0) + 16.transform;
        System.Collections.IEnumerator val_4 = (mem[1152921512214563400] + 8 + 0) + 16.GetEnumerator();
        label_34:
        var val_11 = (mem[1152921512214563400] + 8 + 0) + 16;
        if(((mem[1152921512214563400] + 8 + 0) + 16 + 178) == 0)
        {
            goto label_14;
        }
        
        var val_10 = 0;
        label_16:
        if(((mem[1152921512214563400] + 8 + 0) + 16 + 88 + 0) == null)
        {
            goto label_15;
        }
        
        val_10 = val_10 + 1;
        if(((uint)val_10 & 65535) < ((mem[1152921512214563400] + 8 + 0) + 16 + 178))
        {
            goto label_16;
        }
        
        label_14:
        val_11 = (mem[1152921512214563400] + 8 + 0) + 16;
        goto label_17;
        label_15:
        var val_5 = ((mem[1152921512214563400] + 8 + 0) + 16 + 88) + 0;
        val_11 = val_11 + ((((mem[1152921512214563400] + 8 + 0) + 16 + 88 + 0) + 4) << 3);
        val_11 = val_11 + 188;
        label_17:
        if(((mem[1152921512214563400] + 8 + 0) + 16) == 0)
        {
            goto label_18;
        }
        
        var val_13 = (mem[1152921512214563400] + 8 + 0) + 16;
        if(((mem[1152921512214563400] + 8 + 0) + 16 + 178) == 0)
        {
            goto label_20;
        }
        
        var val_12 = 0;
        label_22:
        if(((mem[1152921512214563400] + 8 + 0) + 16 + 88 + 0) == null)
        {
            goto label_21;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < ((mem[1152921512214563400] + 8 + 0) + 16 + 178))
        {
            goto label_22;
        }
        
        label_20:
        val_12 = (mem[1152921512214563400] + 8 + 0) + 16;
        goto label_23;
        label_21:
        var val_6 = ((mem[1152921512214563400] + 8 + 0) + 16 + 88) + 0;
        val_13 = val_13 + ((((mem[1152921512214563400] + 8 + 0) + 16 + 88 + 0) + 4) << 3);
        val_12 = val_13 + 196;
        label_23:
        if(((mem[1152921512214563400] + 8 + 0) + 16) != 0)
        {
                val_13 = 0;
        }
        else
        {
                val_13 = 0;
        }
        
        UnityEngine.GameObject val_7 = gameObject;
        UnityEngine.Object.Destroy(obj:  null);
        goto label_34;
        label_18:
        var val_14 = 0;
        val_14 = 0;
        val_14 = val_14 + 1;
        if(((mem[1152921512214563400] + 8 + 0) + 16) == 0)
        {
            goto label_35;
        }
        
        var val_16 = (mem[1152921512214563400] + 8 + 0) + 16;
        if(((mem[1152921512214563400] + 8 + 0) + 16 + 178) == 0)
        {
            goto label_36;
        }
        
        var val_15 = 0;
        label_38:
        if(((mem[1152921512214563400] + 8 + 0) + 16 + 88 + 0) == null)
        {
            goto label_37;
        }
        
        val_15 = val_15 + 1;
        if(((uint)val_15 & 65535) < ((mem[1152921512214563400] + 8 + 0) + 16 + 178))
        {
            goto label_38;
        }
        
        label_36:
        val_15 = (mem[1152921512214563400] + 8 + 0) + 16;
        goto label_39;
        label_37:
        var val_8 = ((mem[1152921512214563400] + 8 + 0) + 16 + 88) + 0;
        val_16 = val_16 + ((((mem[1152921512214563400] + 8 + 0) + 16 + 88 + 0) + 4) << 3);
        val_15 = val_16 + 188;
        label_39:
        val_14 = val_14;
        label_35:
        var val_18 = val_14;
        if(val_18 != 1)
        {
                var val_17 = val_18 >> 31;
            val_18 = val_18 + (~(val_18 >> 31));
        }
        
        var val_19 = val_9;
        val_19 = val_19 + 1;
        goto label_43;
    }
    private void InstantiateRows(int totalRows)
    {
        var val_7;
        if(true < totalRows)
        {
                int val_1 = totalRows - true;
            do
        {
            UnityEngine.GameObject val_2 = this.rowLayout.gameObject;
            UnityEngine.Transform val_3 = this.verticalLayout.transform;
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.rowLayout, parent:  this.verticalLayout);
            object val_5 = this.rowLayout.GetComponent<System.Object>();
            this.hrows.Add(item:  this.rowLayout);
            val_1 = val_1 - 1;
        }
        while(this.hrows != 0);
        
        }
        
        val_7 = 0;
        goto label_10;
        label_16:
        if(this.hrows <= val_7)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + 0;
        UnityEngine.GameObject val_6 = (0 + 0) + 16.gameObject;
        if(val_7 < totalRows)
        {
                0 = 1;
        }
        
        (0 + 0) + 16.SetActive(value:  true);
        val_7 = 1;
        label_10:
        if(val_7 < ((0 + 0) + 16))
        {
            goto label_16;
        }
    
    }
    private void InstantiateCardUI(int totalRows)
    {
        int val_7;
        int val_8;
        GiftRewardUI_PetCard val_9;
        if(totalRows < 1)
        {
                return;
        }
        
        var val_8 = 0;
        do
        {
            val_7 = this.maxCardsPerRow;
            val_8 = val_7;
            if(this.petCards == 0)
        {
                val_8 = this.maxCardsPerRow;
        }
        
            int val_1 = UnityEngine.Mathf.Min(a:  val_7, b:  UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished);
            if(val_1 >= 1)
        {
                do
        {
            UnityEngine.GameObject val_2 = this.petCardPrefab.gameObject;
            if(this.petCardPrefab <= val_8)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = val_7 + 0;
            UnityEngine.Transform val_3 = (0 + 0) + 16.transform;
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.petCardPrefab, parent:  (0 + 0) + 16);
            object val_5 = this.petCardPrefab.GetComponent<System.Object>();
            this.petCardPrefab.alpha = null;
            object val_6 = this.petCardPrefab.GetComponent<System.Object>();
            val_9 = this.petCardPrefab;
            this.petCardsUI.Add(item:  val_9);
            val_7 = val_1 - 1;
        }
        while(this.petCardsUI != 0);
        
        }
        
            val_8 = val_8 + 1;
        }
        while(val_8 != totalRows);
    
    }
    public PetCardAnimationInstantiator()
    {
        System.Collections.Generic.List<PetCardReward> val_1 = new System.Collections.Generic.List<PetCardReward>();
        this.petCards = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.petCardsUI = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.hrows = null;
    }

}
