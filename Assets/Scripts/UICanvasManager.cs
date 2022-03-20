using UnityEngine;
public class UICanvasManager : MonoBehaviour
{
    // Fields
    public static UICanvasManager GlobalAccess;
    public bool MouseOverButton;
    public UnityEngine.UI.Text PENameText;
    public UnityEngine.UI.Text ToolTipText;
    private UnityEngine.RaycastHit rayHit;
    
    // Methods
    private void Awake()
    {
        UICanvasManager.GlobalAccess = this;
    }
    private void Start()
    {
        if(this.PENameText == 0)
        {
                return;
        }
        
        string val_2 = ParticleEffectsLibrary.GlobalAccess.GetCurrentPENameString();
        if((R4 + 16) == 0)
        {
            
        }
    
    }
    private void Update()
    {
        if(this.MouseOverButton != true)
        {
                bool val_1 = UnityEngine.Input.GetMouseButtonUp(button:  0);
            if(val_1 == true)
        {
                val_1 = this;
            this.SpawnCurrentParticleEffect();
        }
        
        }
        
        bool val_2 = UnityEngine.Input.GetKeyUp(key:  97);
        if(val_2 == true)
        {
                val_2 = this;
            this.SelectPreviousPE();
        }
        
        if((UnityEngine.Input.GetKeyUp(key:  100)) == false)
        {
                return;
        }
        
        R4.SelectNextPE();
    }
    public void UpdateToolTip(ButtonTypes toolTipType)
    {
        UnityEngine.UI.Text val_2;
        var val_4;
        if(this.ToolTipText == 0)
        {
                return;
        }
        
        if(toolTipType != 2)
        {
                if(toolTipType != 1)
        {
                return;
        }
        
            val_2 = this.ToolTipText;
            val_4 = "Select Previous Particle Effect";
        }
        else
        {
                val_2 = this.ToolTipText;
            val_4 = "Select Next Particle Effect";
        }
    
    }
    public void ClearToolTip()
    {
        if(this.ToolTipText == 0)
        {
                return;
        }
        
        if((R4 + 20) == 0)
        {
            
        }
    
    }
    private void SelectPreviousPE()
    {
        var val_4 = 1152921504903065600;
        ParticleEffectsLibrary.GlobalAccess.PreviousParticleEffect();
        if(this.PENameText == 0)
        {
                return;
        }
        
        string val_2 = ParticleEffectsLibrary.GlobalAccess.GetCurrentPENameString();
        if(this.PENameText == 0)
        {
            
        }
    
    }
    private void SelectNextPE()
    {
        var val_4 = 1152921504903065600;
        ParticleEffectsLibrary.GlobalAccess.NextParticleEffect();
        if(this.PENameText == 0)
        {
                return;
        }
        
        string val_2 = ParticleEffectsLibrary.GlobalAccess.GetCurrentPENameString();
        if(this.PENameText == 0)
        {
            
        }
    
    }
    private void SpawnCurrentParticleEffect()
    {
        float val_4;
        float val_5;
        var val_9;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Ray val_6 = ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_5});
        val_6.m_Direction.y = val_6.m_Direction.y + 24;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_6.m_Direction.y, y = 0f}, m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()})) == false)
        {
                return;
        }
        
        val_9 = 0;
        UnityEngine.Vector3 val_8 = point;
        ParticleEffectsLibrary.GlobalAccess.SpawnParticleEffect(positionInWorldToSpawn:  new UnityEngine.Vector3());
    }
    public void UIButtonClick(ButtonTypes buttonTypeClicked)
    {
        if(buttonTypeClicked != 2)
        {
                if(buttonTypeClicked != 1)
        {
                return;
        }
        
            this.SelectPreviousPE();
            return;
        }
        
        this.SelectNextPE();
    }
    public UICanvasManager()
    {
    
    }

}
