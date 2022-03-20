using UnityEngine;
public class TRVExpertProficiencyDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image profImage;
    private System.Collections.Generic.List<UnityEngine.UI.Image> starBGs;
    private System.Collections.Generic.List<UnityEngine.UI.Image> stars;
    
    // Methods
    public void DisplayProf(TRVCategoryProficiencies data)
    {
        var val_5;
        var val_6;
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        UnityEngine.Sprite val_2 = GetCategoryIcon(category:  data.subCat);
        val_6 = public static TRVUtils MonoSingleton<TRVUtils>::get_Instance();
        this.profImage.sprite = -612557856;
        goto label_6;
        label_12:
        if(this.profImage <= val_5)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 0;
        UnityEngine.GameObject val_3 = (0 + 0) + 16.gameObject;
        val_6 = (0 + 0) + 16;
        if(val_5 < data.maxPotential)
        {
                0 = 1;
        }
        
        val_6.SetActive(value:  true);
        val_5 = 1;
        label_6:
        if(val_5 < val_6)
        {
            goto label_12;
        }
        
        val_7 = 0;
        goto label_13;
        label_19:
        if(val_6 <= val_7)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 0;
        UnityEngine.GameObject val_4 = (0 + 0) + 16.gameObject;
        val_6 = (0 + 0) + 16;
        if(val_7 < data.currentPotential)
        {
                0 = 1;
        }
        
        val_6.SetActive(value:  true);
        val_7 = 1;
        label_13:
        if(val_7 < val_6)
        {
            goto label_19;
        }
    
    }
    public void UpdateProf(TRVCategoryProficiencies data)
    {
        goto label_1;
        label_20:
        if(R7 < data.currentPotential)
        {
                if(data.currentPotential <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.GameObject val_1 = 2621443.gameObject;
            bool val_2 = 2621443.activeSelf;
            if(val_2 != true)
        {
                if(val_2 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.GameObject val_3 = 2621443.gameObject;
            2621443.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static WGSFXController MonoSingleton<WGSFXController>::get_Instance()) <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            object val_5 = 2621443.GetComponent<System.Object>();
            UnityEngine.ParticleSystem val_6 = PlaySFX(reqType:  3, parent:  2621443, playImmediate:  true);
        }
        
        }
        
        4 = 5;
        label_1:
        if((4 - 4) < (public static WGSFXController MonoSingleton<WGSFXController>::get_Instance()))
        {
            goto label_20;
        }
    
    }
    public TRVExpertProficiencyDisplay()
    {
    
    }

}
