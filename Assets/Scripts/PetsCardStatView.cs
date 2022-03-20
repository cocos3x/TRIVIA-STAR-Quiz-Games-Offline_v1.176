using UnityEngine;
public class PetsCardStatView : CurrencyStatView
{
    // Fields
    public const string PETS_CARD_STAT_UPDATE = "PetsCardStatViewUpdate";
    private UnityEngine.UI.Text cardName;
    private UnityEngine.UI.Image petCardIcon;
    private UnityEngine.UI.Image progressBar;
    private UnityEngine.UI.Image upgradeFill;
    private UnityEngine.Sprite upgradeSp;
    private UnityEngine.Sprite inProgressSp;
    private UnityEngine.UI.Text upgradeProgress;
    private UnityEngine.GameObject upgradeArrow;
    private UnityEngine.GameObject levelGroup;
    private UnityEngine.UI.Text level;
    
    // Methods
    private void OnDiceRollsBalanceUpdated(Notification notif)
    {
        if(notif.data != 0)
        {
                string val_1 = notif.data.ToString();
            bool val_3 = (System.Boolean.Parse(value:  notif.data)) ^ 1;
        }
    
    }
    protected override decimal GetCountUpBalance()
    {
        var val_6;
        var val_7;
        float val_6 = 4.026346E-38f;
        val_6 = 12870700 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
            goto label_2;
        }
        
        var val_1 = R1 + 36;
        val_6 = null;
        val_6 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = mem[(R1 + 36) + (0)], hi = mem[(R1 + 36) + (4)], lo = mem[(R1 + 36) + (8)], mid = mem[(R1 + 36) + (12)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_5;
        }
        
        var val_3 = R1 + 36;
        return new System.Decimal() {flags = -1013834912, hi = mem[(R1 + 36) + (4)], lo = mem[(R1 + 36) + (8)], mid = mem[(R1 + 36) + (12)]};
        label_2:
        val_7 = null;
        val_7 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
        label_5:
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_4 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceBalance();
        decimal val_5 = System.Decimal.op_Implicit(value:  -1013834912);
        return new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid};
    }
    protected override string GetBalanceUpdateNotificationName()
    {
    
    }
    protected override void OnTouchAreaClicked()
    {
    
    }
    public void Setup(WADPets.WADPet pet, decimal progressStartBalance, WADPets.WADPetUpgradeRequirement upgradeRequirement)
    {
        WADPets.WADPet val_16;
        var val_17;
        int val_18;
        float val_19;
        int val_20;
        float val_21;
        val_16 = pet;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPetMaxLevel(pet:  val_16)) != false)
        {
                val_17 = "MAX";
        }
        else
        {
                string val_3 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            val_17 = "{0}/{1}";
        }
        
        if(val_16 != 0)
        {
                val_18 = pet.Cards;
        }
        else
        {
                val_18 = 1;
        }
        
        WADPets.WADPetUpgradeRequirement val_4 = WADPetsManager.GetUpgradeRequirement(levelIndex:  pet.LevelIndex);
        float val_15 = (float)pet.LevelIndex + 8;
        val_15 = 1f / val_15;
        float val_5 = UnityEngine.Mathf.Min(a:  val_15, b:  null);
        val_19 = 0.999f;
        if(this.upgradeArrow > 0)
        {
                0 = 1;
        }
        
        this.upgradeArrow.SetActive(value:  true);
        if(pet.IsUnlocked == true)
        {
                pet.IsUnlocked = 1;
        }
        
        this.levelGroup.SetActive(value:  true);
        string val_6 = pet + 12.ToString();
        this.petCardIcon.sprite = pet.Info.CardIcon;
        string val_7 = val_16.GetPrettyName();
        string val_8 = Localization.Localize(key:  -1013481840, defaultValue:  -1050421328, useSingularKey:  false);
        string val_9 = System.String.Format(format:  1592589744, arg0:  val_16, arg1:  -1013481840);
        val_20 = "{0} {1}";
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPetMaxLevel(pet:  val_16)) != false)
        {
                val_21 = 0f;
        }
        else
        {
                val_20 = progressStartBalance.mid;
            val_16 = progressStartBalance.lo;
            float val_12 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = progressStartBalance.flags, hi = progressStartBalance.hi, lo = val_16, mid = val_20});
            float val_16 = (float)upgradeRequirement.Cards;
            val_16 = progressStartBalance.flags / val_16;
            float val_13 = UnityEngine.Mathf.Min(a:  val_16, b:  null);
            val_21 = val_16;
        }
        
        this.progressBar.fillAmount = val_13;
        if((this.progressBar.m_FillAmount.Equals(obj:  val_13)) == true)
        {
                84 = 80;
        }
        
        this.upgradeFill.sprite = this.upgradeSp;
    }
    public void OnPetCardRewardAction(WADPets.WADPet pet, float endProgressValue, WADPets.WADPetUpgradeRequirement upgradeRequirement)
    {
        WADPets.WADPet val_13;
        var val_14;
        val_13 = pet;
        if(new System.Object() != 0)
        {
                typeof(PetsCardStatView.<>c__DisplayClass16_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        typeof(PetsCardStatView.<>c__DisplayClass16_0).__il2cppRuntimeField_10 = upgradeRequirement;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPetMaxLevel(pet:  val_13)) != false)
        {
                val_14 = "MAX";
        }
        else
        {
                val_13 = 1152921504619999232;
            string val_4 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            val_14 = "{0}/{1}";
        }
        
        if((this.progressBar.m_FillAmount.Equals(obj:  endProgressValue)) == true)
        {
                84 = 80;
        }
        
        this.upgradeFill.sprite = this.upgradeSp;
        typeof(PetsCardStatView.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = this.progressBar.m_FillAmount;
        DG.Tweening.Core.DOSetter<System.Single> val_6 = new DG.Tweening.Core.DOSetter<System.Single>(object:  333438976, method:  new IntPtr(3281699952));
        DG.Tweening.Tweener val_7 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  endProgressValue, endValue:  null, duration:  null);
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
        DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  333438976, method:  new IntPtr(3281705072));
        object val_10 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
        DG.Tweening.TweenCallback val_11 = new DG.Tweening.TweenCallback(object:  333438976, method:  new IntPtr(3281706096));
        object val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198881280, action:  190734336);
    }
    public PetsCardStatView()
    {
    
    }

}
