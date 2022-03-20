using UnityEngine;
private sealed class BingoEventPopup.<>c__DisplayClass42_2
{
    // Fields
    public BingoCell cell;
    public BingoEventPopup.<>c__DisplayClass42_1 CS$<>8__locals2;
    
    // Methods
    public BingoEventPopup.<>c__DisplayClass42_2()
    {
    
    }
    internal void <CollectBallsAnimation>b__0()
    {
        int val_2;
        decimal val_1 = System.Decimal.op_Implicit(value:  -1526064080);
        this.CS$<>8__locals2.CS$<>8__locals1.<>4__this.prizeText.CountUp(endValue:  new System.Decimal() {mid = val_2}, seconds:  null);
        this.CS$<>8__locals2.goBall.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.cell.cellImage.gameObject;
        this.cell.cellImage.SetActive(value:  true);
        this.cell.cellImage.sprite = this.CS$<>8__locals2.CS$<>8__locals1.<>4__this.bingoBaubSprite;
    }

}
