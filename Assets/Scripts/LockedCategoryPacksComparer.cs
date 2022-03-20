using UnityEngine;
public class LockedCategoryPacksComparer : IComparer<CategoryPackInfo>
{
    // Methods
    public int Compare(CategoryPackInfo a, CategoryPackInfo b)
    {
        decimal val_7;
        int val_8;
        int val_9;
        int val_10;
        decimal val_11;
        int val_12;
        int val_15;
        var val_16;
        decimal val_17;
        int val_18;
        int val_19;
        int val_20;
        CategoryPackInfo val_1 = a + 40;
        val_7 = a.cost;
        if(b == 0)
        {
                val_10 = mem[(a + 40) + (8)];
            val_9 = mem[(a + 40) + (4)];
            val_8 = mem[(a + 40) + (0)];
        }
        
        val_11 = b.cost;
        val_15 = IP;
        val_10 = val_10;
        val_12 = val_15;
        val_9 = val_9;
        val_8 = val_8;
        val_16 = 0;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_9, mid = val_10}, d2:  new System.Decimal() {flags = val_11, hi = val_12, lo = mem[(a + 40) + (8)], mid = mem[(a + 40) + (0)]})) == true)
        {
                return (int)val_16;
        }
        
        CategoryPackInfo val_3 = a + 40;
        val_11 = b.cost;
        val_17 = a.cost;
        val_7 = mem[(a + 40) + (8)];
        val_19 = mem[(a + 40) + (4)];
        val_20 = val_7;
        val_18 = mem[(a + 40) + (0)];
        val_17 = val_17;
        val_16 = 1;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_17, hi = val_18, lo = val_19, mid = val_20}, d2:  new System.Decimal() {flags = val_11, hi = mem[(a + 40) + (0)], lo = val_15, mid = mem[(a + 40) + (8)]})) != false)
        {
                return (int)val_16;
        }
        
        string val_5 = a.FullTitle;
        string val_6 = b.FullTitle;
        return System.String.Compare(strA:  a, strB:  b, comparisonType:  2);
    }
    public LockedCategoryPacksComparer()
    {
    
    }

}
