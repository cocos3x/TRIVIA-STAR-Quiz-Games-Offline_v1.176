using UnityEngine;
public class DailyAverageCalculator
{
    // Fields
    private DailyEventComponent dailyComponent;
    private AverageEventCalculator averageCalculator;
    
    // Properties
    public float Average { get; }
    public bool IsTracked { get; }
    
    // Methods
    public float get_Average()
    {
        if(this.averageCalculator != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public bool get_IsTracked()
    {
        if(this.dailyComponent != 0)
        {
                return this.dailyComponent.IsTracked();
        }
        
        return this.dailyComponent.IsTracked();
    }
    public DailyAverageCalculator(string name)
    {
        this.dailyComponent = new DailyEventComponent(name:  name);
        this.averageCalculator = new AverageEventCalculator(name:  name);
    }
    public void Calculate(float newValue)
    {
        if(this.dailyComponent.IsTracked() != false)
        {
                return;
        }
        
        this.averageCalculator.Calculate(valueToAdd:  newValue);
        this.dailyComponent.Reset();
    }

}
