using UnityEngine;
public class WADPetCardItem : MyButton
{
    // Fields
    private UnityEngine.UI.Image bg;
    private UnityEngine.Sprite unselectedSp;
    private UnityEngine.Sprite selectedSp;
    private UnityEngine.GameObject thinkBubble;
    private UnityEngine.UI.Image petImage;
    private Spine.Unity.SkeletonGraphic petAnim;
    private UnityEngine.GameObject levelGroup;
    private UnityEngine.UI.Text level;
    private UnityEngine.UI.Image progressBar;
    private UnityEngine.UI.Image progressFill;
    private UnityEngine.Sprite progressFillSp;
    private UnityEngine.Sprite upgradeFillSp;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.GameObject upgradeArrow;
    private WADPets.WADPet thisPet;
    private bool isHighlighted;
    
    // Methods
    public void Setup(WADPets.WADPet pet, bool highlight = False)
    {
        this.ResetUI();
        this.isHighlighted = highlight;
        this.thisPet = pet;
        this.UpdateProgress(pet:  pet);
        this.UpdateBackground(highlight:  highlight);
        this.UpdatePet(pet:  pet);
    }
    public void UpdateCard(WADPets.WADPet highlightedPet)
    {
        this.ResetUI();
        WADPets.WADPet val_1 = this.thisPet - highlightedPet;
        val_1 = val_1 >> 5;
        this.isHighlighted = val_1;
        this.UpdateProgress(pet:  this.thisPet);
        this.UpdateBackground(highlight:  this.isHighlighted);
        this.UpdatePet(pet:  this.thisPet);
    }
    public override void OnButtonClick()
    {
        this.OnButtonClick();
        if(this.isHighlighted == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Refresh(highlightPet:  R4 + 76);
        R4 + 20.sprite = R4 + 28;
    }
    private void ResetUI()
    {
        this.bg.sprite = this.unselectedSp;
        this.thinkBubble.SetActive(value:  false);
        this.levelGroup.SetActive(value:  false);
        UnityEngine.GameObject val_1 = this.petImage.gameObject;
        this.petImage.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.petAnim.gameObject;
        this.petAnim.SetActive(value:  false);
    }
    private void UpdateProgress(WADPets.WADPet pet)
    {
        int val_12;
        float val_13;
        var val_14;
        string val_1 = pet.LevelIndex.ToString();
        UnityEngine.GameObject val_2 = this.level.gameObject;
        if(pet.LevelIndex > 0)
        {
                0 = 1;
        }
        
        this.level.SetActive(value:  true);
        WADPets.WADPetUpgradeRequirement val_3 = WADPetsManager.GetUpgradeRequirement(levelIndex:  pet.LevelIndex);
        val_12 = pet.LevelIndex;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPetMaxLevel(pet:  pet)) != false)
        {
                val_13 = 0f;
        }
        else
        {
                float val_12 = (float)pet.LevelIndex + 8;
            val_12 = (float)pet.Cards / val_12;
            float val_6 = UnityEngine.Mathf.Min(a:  val_12, b:  null);
            val_12 = val_12;
            val_13 = val_12;
        }
        
        this.progressBar.fillAmount = val_6;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPetMaxLevel(pet:  pet)) != false)
        {
                val_14 = "MAX";
        }
        else
        {
                string val_9 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            val_14 = "{0}/{1}";
        }
        
        this.upgradeArrow.SetActive(value:  this.progressBar.m_FillAmount.Equals(obj:  val_6));
        if((this.progressBar.m_FillAmount.Equals(obj:  val_6)) == true)
        {
                60 = 64;
        }
        
        this.progressFill.sprite = this.upgradeFillSp;
    }
    private void UpdateBackground(bool highlight)
    {
        if(highlight == true)
        {
                24 = 28;
        }
        
        this.bg.sprite = this.selectedSp;
    }
    private void UpdatePet(WADPets.WADPet pet)
    {
        Spine.Unity.SkeletonGraphic val_9;
        Spine.Unity.SkeletonGraphic val_11;
        if(pet.IsUnlocked == false)
        {
            goto label_2;
        }
        
        if(pet.IsActive() == false)
        {
            goto label_3;
        }
        
        UnityEngine.GameObject val_2 = this.petAnim.gameObject;
        this.petAnim.SetActive(value:  true);
        this.petAnim.skeletonDataAsset = pet.Info.AnimIdleSkeletonDataAsset;
        this.petAnim.Initialize(overwrite:  true);
        this.petAnim.startingAnimation = "Idle";
        val_9 = this.petAnim;
        if(this.petAnim != 0)
        {
            goto label_10;
        }
        
        val_9 = this.petAnim;
        if(val_9 == 0)
        {
            goto label_26;
        }
        
        label_10:
        Spine.TrackEntry val_3 = this.petAnim.state.SetAnimation(trackIndex:  0, animationName:  this.petAnim.startingAnimation, loop:  true);
        this.petAnim.skeleton.SetSlotsToSetupPose();
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.petAnim.color = new UnityEngine.Color() {a = ???};
        this.petAnim.freeze = false;
        this.levelGroup.SetActive(value:  true);
        return;
        label_2:
        UnityEngine.GameObject val_5 = this.petAnim.gameObject;
        this.petAnim.SetActive(value:  true);
        this.petAnim.skeletonDataAsset = pet.Info.AnimIdleSkeletonDataAsset;
        this.petAnim.Initialize(overwrite:  true);
        this.petAnim.startingAnimation = "Idle";
        val_11 = this.petAnim;
        if(this.petAnim != 0)
        {
            goto label_25;
        }
        
        val_11 = this.petAnim;
        if(val_11 == 0)
        {
            goto label_26;
        }
        
        label_25:
        Spine.TrackEntry val_6 = this.petAnim.state.SetAnimation(trackIndex:  0, animationName:  this.petAnim.startingAnimation, loop:  false);
        this.petAnim.skeleton.SetSlotsToSetupPose();
        UnityEngine.Color val_7 = UnityEngine.Color.black;
        this.petAnim.color = new UnityEngine.Color() {a = ???};
        this.petAnim.freeze = true;
        return;
        label_3:
        this.petImage.sprite = pet.Info.SadFaceIcon;
        UnityEngine.GameObject val_8 = this.petImage.gameObject;
        this.petImage.SetActive(value:  true);
        this.thinkBubble.SetActive(value:  true);
        this.levelGroup.SetActive(value:  true);
        return;
        label_26:
    }
    public WADPetCardItem()
    {
    
    }

}
