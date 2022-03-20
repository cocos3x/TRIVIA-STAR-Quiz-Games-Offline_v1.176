using UnityEngine;
public class WordDropFTUXManager : MonoSingleton<WordDropFTUXManager>
{
    // Fields
    private WordDropUIController wordDropUIController;
    private WordDropController wordDropController;
    private UnityEngine.UI.Text FTUXText1;
    private UnityEngine.UI.Text FTUXText2;
    private UnityEngine.GameObject FTUXswipe;
    public bool ftux;
    
    // Methods
    private void Start()
    {
        this.ftux = false;
        this.FirstLevelFTUX();
    }
    private void FirstLevelFTUX()
    {
        this.wordDropController.BeginDrops();
        this.FTUXText1.enabled = true;
        this.FTUXText2.enabled = false;
    }
    public void SecondLevelFTUX()
    {
        this.FTUXText1.enabled = false;
        this.FTUXText2.enabled = true;
    }
    public void EndFTUX()
    {
        this.ftux = true;
        this.FTUXText1.enabled = false;
        this.FTUXText2.enabled = false;
        this.FTUXswipe.SetActive(value:  false);
    }
    public void RestartFTUX()
    {
        this.ftux = false;
        this.wordDropController.ResetDrops();
    }
    public WordDropFTUXManager()
    {
    
    }

}
