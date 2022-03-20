using UnityEngine;
public class FPHPiggyBankPopup : PiggyBankPopup
{
    // Methods
    public override void SetupPreview()
    {
        string val_1 = Localization.Localize(key:  -1134286144, defaultValue:  -1134286320, useSingularKey:  false);
        string val_2 = System.String.Format(format:  -1134286144, arg0:  13152256);
        UnityEngine.GameObject val_3 = this.gameObject;
        if(this.activeInHierarchy != false)
        {
                this.Play();
            return;
        }
        
        mem[1152921512062519680] = 1;
    }
    protected override void AnimateParticleAttraction()
    {
        object val_1 = static_value_021FA33F.GetComponent<System.Object>();
        if(static_value_021FA33F == 0)
        {
                return;
        }
        
        object val_3 = static_value_021FA33F.GetComponent<System.Object>();
        UnityEngine.Transform val_4 = this.transform;
        mem2[0] = this;
    }
    protected override void DoOnPurchaseAnimation()
    {
        int val_8;
        int val_9;
        int val_10;
        int val_11;
        System.Action val_1 = new System.Action(object:  -1134035984, method:  new IntPtr(3160906288));
        mem2[0] = null;
        Player val_2 = App.Player;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1134048032);
        decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1134048048}, d2:  new System.Decimal() {flags = ???, hi = val_3.flags});
        Player val_6 = App.Player;
        decimal val_7 = System.Decimal.op_Implicit(value:  -1134048064);
        R8.Play(fromValue:  System.Decimal.op_Explicit(value:  new System.Decimal()), toValue:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_8}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  1069547520);
    }
    public FPHPiggyBankPopup()
    {
    
    }

}
