using UnityEngine;
public class ScrollIndexCallback1 : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Text text;
    
    // Methods
    private void ScrollCellIndex(int idx)
    {
        var val_7;
        UnityEngine.UI.Image val_8;
        string val_1 = idx.ToString();
        string val_2 = -2007574656(-2007574656) + -2007546228(-2007546228);
        val_7 = 1152921504765685760;
        bool val_3 = UnityEngine.Object.op_Inequality(x:  this.text, y:  0);
        val_8 = this.image;
        if(val_8 != 0)
        {
                float val_7 = (float)idx;
            val_8 = this.image;
            val_7 = val_7 / 50f;
            UnityEngine.Color val_5 = ScrollIndexCallback1.Rainbow(progress:  val_7);
            val_8.color = new UnityEngine.Color() {a = ???};
        }
        
        UnityEngine.GameObject val_6 = this.gameObject;
        this.name = -2007574656;
    }
    public static UnityEngine.Color Rainbow(float progress)
    {
        float val_6;
        float val_7;
        float val_8;
        float val_1 = UnityEngine.Mathf.Clamp01(value:  progress);
        float val_6 = 6f;
        val_6 = R1 * val_6;
        if(2139095038 <= 5)
        {
                val_6 = 0f;
            var val_4 = 7757584 + mem[4269170440];
            if(2139095038 == 5)
        {
                mem[4269170440] = mem[4269170440] & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
            mem[4269170440] = mem[4269170440] & ((R8) << (mem[4269170440] & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )));
            mem[4269170440] = mem[4269170440] & (0 >> mem[4269170440]);
            mem[4269170440] = mem[4269170440] & 0;
            mem[4269170440] = mem[4269170440] & (0 >> mem[4269170440]);
            mem[4269170440] = mem[4269170440] & (((0) << (32-as. 
            
        
        
        
        
        
           
        )) | ((0) << as. 
            
        
        
        
        
        
           
        ));
        }
        
            val_7 = 1f;
            val_8 = 1f - (val_6 - (2.139095E+09f));
        }
        else
        {
                val_6 = 0f;
            val_7 = 0;
            val_8 = 0;
        }
        
        0 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        return new UnityEngine.Color() {};
    }
    public ScrollIndexCallback1()
    {
    
    }

}
