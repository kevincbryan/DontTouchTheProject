using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultAI : MonoBehaviour
{
    public Person agent;
    Decision behavior;
    public IntReference dissatisfaction;
    public IntReference lowDissatisfaction;
    public IntReference highDissatisfaction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


class adultLow : Decision // condition
{
    IntReference low;
    IntReference current;
    public adultLow() { }
    public adultLow(IntReference low, IntReference current)
    {
        this.low = low;
        this.current = current;
    }
    public override Result execute(Person agent)
    {
        foreach (Decision child in childBehaviours)
        {
            if (current.Value < low.Value)
                return Result.Success;
        }
        return Result.Failure;
    }
}

class adultMedium : Decision // condition
{
    IntReference low;
    IntReference high;
    IntReference current;
    public adultMedium() { }
    public adultMedium(IntReference low, IntReference high, IntReference current)
    {
        this.low = low;
        this.high = high;
        this.current = current;
    }
    public override Result execute(Person agent)
    {
        foreach (Decision child in childBehaviours)
        {
            if (current.Value > low.Value && current.Value < high.Value)
                return Result.Success;
        }
        return Result.Failure;
    }
}

class adultHigh : Decision // condition
{
    IntReference high;
    IntReference current;
    public adultHigh() { }
    public adultHigh(IntReference high, IntReference current)
    {
        this.high = high;
        this.current = current;
    }
    public override Result execute(Person agent)
    {
        foreach (Decision child in childBehaviours)
        {
            if (current.Value > high.Value)
                return Result.Success;
        }
        return Result.Failure;
    }
}