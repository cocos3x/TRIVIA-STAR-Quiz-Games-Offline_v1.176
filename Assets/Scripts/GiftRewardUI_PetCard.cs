using UnityEngine;
public class GiftRewardUI_PetCard : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text cardName;
    private UnityEngine.UI.Image petCardIcon;
    private UnityEngine.GameObject levelGroup;
    private UnityEngine.UI.Text level;
    private UnityEngine.UI.Image progressBar;
    private UnityEngine.UI.Image upgradeFill;
    private UnityEngine.Sprite upgradeSp;
    private UnityEngine.Sprite inProgressSp;
    private UnityEngine.UI.Text upgradeProgress;
    private UnityEngine.GameObject upgradeArrow;
    
    // Methods
    public void Setup(WADPets.WADPet pet, decimal progressStartBalance, WADPets.WADPetUpgradeRequirement upgradeRequirement)
    {
        object val_10;
        float val_11;
        val_10 = pet;
        this.ResetUI();
        if(pet.IsUnlocked == true)
        {
                pet.IsUnlocked = 1;
        }
        
        this.levelGroup.SetActive(value:  true);
        string val_1 = pet.LevelIndex.ToString();
        this.petCardIcon.sprite = pet.Info.CardIcon;
        string val_2 = val_10.GetPrettyName();
        string val_3 = Localization.Localize(key:  -1013481840, defaultValue:  -1050421328, useSingularKey:  false);
        string val_4 = System.String.Format(format:  1592589744, arg0:  val_10, arg1:  -1013481840);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPetMaxLevel(pet:  val_10)) != false)
        {
                val_11 = 0f;
        }
        else
        {
                val_10 = upgradeRequirement;
            float val_7 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = progressStartBalance.flags, hi = progressStartBalance.hi, lo = progressStartBalance.lo, mid = progressStartBalance.mid});
            float val_10 = (float)upgradeRequirement.Cards;
            val_10 = progressStartBalance.flags / val_10;
            float val_8 = UnityEngine.Mathf.Min(a:  val_10, b:  null);
            val_11 = val_10;
        }
        
        this.progressBar.fillAmount = val_8;
        if((this.progressBar.m_FillAmount.Equals(obj:  val_8)) == true)
        {
                40 = 36;
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
                typeof(GiftRewardUI_PetCard.<>c__DisplayClass11_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        typeof(GiftRewardUI_PetCard.<>c__DisplayClass11_0).__il2cppRuntimeField_10 = upgradeRequirement;
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
                40 = 36;
        }
        
        this.upgradeFill.sprite = this.upgradeSp;
        typeof(GiftRewardUI_PetCard.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = this.progressBar.m_FillAmount;
        DG.Tweening.Core.DOSetter<System.Single> val_6 = new DG.Tweening.Core.DOSetter<System.Single>(object:  376037376, method:  new IntPtr(4033611728));
        DG.Tweening.Tweener val_7 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  endProgressValue, endValue:  null, duration:  null);
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
        DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  376037376, method:  new IntPtr(4033616848));
        object val_10 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
        DG.Tweening.TweenCallback val_11 = new DG.Tweening.TweenCallback(object:  376037376, method:  new IntPtr(4033617872));
        object val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198881280, action:  190734336);
    }
    private void ResetUI()
    {
        this.upgradeArrow.SetActive(value:  false);
        if(this.upgradeProgress == 0)
        {
            
        }
    
    }
    public GiftRewardUI_PetCard()
    {
    
    }

}
