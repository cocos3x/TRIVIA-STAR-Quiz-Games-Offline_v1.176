using UnityEngine;
public class ETFXSceneManager : MonoBehaviour
{
    // Fields
    public bool GUIHide;
    public bool GUIHide2;
    public bool GUIHide3;
    public bool GUIHide4;
    
    // Methods
    public void LoadScene2DDemo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1766783856);
    }
    public void LoadSceneCards()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1766671760);
    }
    public void LoadSceneCombat()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1766559664);
    }
    public void LoadSceneDecals()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1766447568);
    }
    public void LoadSceneDecals2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1766335472);
    }
    public void LoadSceneEmojis()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1766223376);
    }
    public void LoadSceneEmojis2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1766111280);
    }
    public void LoadSceneExplosions()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1765999184);
    }
    public void LoadSceneExplosions2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1765887072);
    }
    public void LoadSceneFire()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1765774960);
    }
    public void LoadSceneFire2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1765662864);
    }
    public void LoadSceneFire3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1765550768);
    }
    public void LoadSceneFireworks()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1765438672);
    }
    public void LoadSceneFlares()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1765326576);
    }
    public void LoadSceneMagic()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1765214480);
    }
    public void LoadSceneMagic2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1765102384);
    }
    public void LoadSceneMagic3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1764990288);
    }
    public void LoadSceneMainDemo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1764878192);
    }
    public void LoadSceneMissiles()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1764766096);
    }
    public void LoadScenePortals()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1764654000);
    }
    public void LoadScenePortals2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1764541904);
    }
    public void LoadScenePowerups()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1764429808);
    }
    public void LoadScenePowerups2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1764317712);
    }
    public void LoadSceneSparkles()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1764205616);
    }
    public void LoadSceneSwordCombat()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1764093520);
    }
    public void LoadSceneSwordCombat2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1763981408);
    }
    public void LoadSceneMoney()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1763869296);
    }
    public void LoadSceneHealing()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1763757200);
    }
    public void LoadSceneWind()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  -1763645104);
    }
    private void Update()
    {
        bool val_16;
        if((UnityEngine.Input.GetKeyDown(key:  108)) != false)
        {
                val_16 = this.GUIHide;
            this.GUIHide = val_16 ^ 1;
            UnityEngine.GameObject val_3 = UnityEngine.GameObject.Find(name:  -1763533008);
            object val_4 = GetComponent<System.Object>();
            if(val_16 == true)
        {
                public UnityEngine.Canvas UnityEngine.GameObject::GetComponent<UnityEngine.Canvas>() = 1;
        }
        
            if(val_16 == false)
        {
                public UnityEngine.Canvas UnityEngine.GameObject::GetComponent<UnityEngine.Canvas>() = 0;
        }
        
            enabled = false;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  106)) != false)
        {
                val_16 = this.GUIHide2;
            this.GUIHide2 = val_16 ^ 1;
            UnityEngine.GameObject val_7 = UnityEngine.GameObject.Find(name:  -1763532896);
            object val_8 = GetComponent<System.Object>();
            if(val_16 == true)
        {
                public UnityEngine.Canvas UnityEngine.GameObject::GetComponent<UnityEngine.Canvas>() = 1;
        }
        
            if(val_16 == false)
        {
                public UnityEngine.Canvas UnityEngine.GameObject::GetComponent<UnityEngine.Canvas>() = 0;
        }
        
            enabled = false;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  104)) != false)
        {
                val_16 = this.GUIHide3;
            this.GUIHide3 = val_16 ^ 1;
            UnityEngine.GameObject val_11 = UnityEngine.GameObject.Find(name:  -1763532816);
            object val_12 = GetComponent<System.Object>();
            if(val_16 == true)
        {
                public UnityEngine.Canvas UnityEngine.GameObject::GetComponent<UnityEngine.Canvas>() = 1;
        }
        
            if(val_16 == false)
        {
                public UnityEngine.Canvas UnityEngine.GameObject::GetComponent<UnityEngine.Canvas>() = 0;
        }
        
            enabled = false;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  107)) == false)
        {
                return;
        }
        
        bool val_16 = this.GUIHide4;
        val_16 = val_16 ^ 1;
        this.GUIHide4 = val_16;
        UnityEngine.GameObject val_14 = UnityEngine.GameObject.Find(name:  -1763532688);
        object val_15 = GetComponent<System.Object>();
        if(this.GUIHide3 == true)
        {
                public UnityEngine.Canvas UnityEngine.GameObject::GetComponent<UnityEngine.Canvas>() = 0;
        }
        
        if(this.GUIHide3 == false)
        {
                public UnityEngine.Canvas UnityEngine.GameObject::GetComponent<UnityEngine.Canvas>() = 1;
        }
        
        enabled = true;
    }
    public ETFXSceneManager()
    {
    
    }

}
