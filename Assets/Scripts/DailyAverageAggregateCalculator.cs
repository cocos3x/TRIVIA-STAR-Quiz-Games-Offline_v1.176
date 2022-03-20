using UnityEngine;
public class DailyAverageAggregateCalculator
{
    // Fields
    private DailyEventComponent dailyComponent;
    private AverageEventCalculator averageCalculator;
    private AggregateEventCalculator aggregateCalculator;
    
    // Properties
    public float Average { get; }
    
    // Methods
    public float get_Average()
    {
        if(this.averageCalculator != 0)
        {
                return this.averageCalculator.CalculateCurrent(valueToAdd:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.aggregateCalculator.aggregate + (0)], hi = mem[this.aggregateCalculator.aggregate + (4)], lo = mem[this.aggregateCalculator.aggregate + (8)], mid = this.aggregateCalculator}));
        }
        
        return this.averageCalculator.CalculateCurrent(valueToAdd:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.aggregateCalculator.aggregate + (0)], hi = mem[this.aggregateCalculator.aggregate + (4)], lo = mem[this.aggregateCalculator.aggregate + (8)], mid = this.aggregateCalculator}));
    }
    public DailyAverageAggregateCalculator(string name)
    {
        this.dailyComponent = new DailyEventComponent(name:  name);
        this.averageCalculator = new AverageEventCalculator(name:  name);
        this.aggregateCalculator = new AggregateEventCalculator(name:  name);
    }
    public void Calculate(decimal valueToAggregate)
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        AggregateEventCalculator val_8;
        val_4 = valueToAggregate.mid;
        val_5 = valueToAggregate.lo;
        val_6 = valueToAggregate.hi;
        val_7 = valueToAggregate.flags;
        if(this.dailyComponent.IsTracked() != false)
        {
                val_8 = this.aggregateCalculator;
        }
        else
        {
                val_8 = this;
            this.averageCalculator.Calculate(valueToAdd:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.aggregateCalculator.aggregate + (0)], hi = mem[this.aggregateCalculator.aggregate + (4)], lo = mem[this.aggregateCalculator.aggregate + (8)], mid = mem[this.aggregateCalculator.aggregate + (12)]}));
            val_6 = val_6;
            val_7 = val_7;
            val_4 = val_4;
            null.Flush();
            val_5 = val_5;
            this.dailyComponent.Reset();
        }
        
        null.Calculate(valueToAggregate:  new System.Decimal() {flags = val_7, hi = val_6, lo = val_5, mid = val_4}, autoFlush:  false);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }

}
