using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZookeeperAI : MonoBehaviour
{
    public Person agent;
    Decision behaviour;
    public IntReference dissatisfaction;
    public IntReference lowDissatisfaction;
    public IntReference highDissatisfaction;
    // Start is called before the first frame update
    void Start()
    {
        behaviour = new zooLow(lowDissatisfaction, dissatisfaction);
    }

    // Update is called once per frame
    void Update()
    {
        behaviour.execute(agent);
    }
}

class zooDissatisfaction
{
    Decision behaviour;
    public IntReference current;
    public IntReference low;
    public IntReference high;
    public zooDissatisfaction() { }

    public zooDissatisfaction(Decision behaviour, IntReference low, IntReference high, IntReference current)
    {
        this.behaviour = behaviour;
        this.low = low;
        this.high = high;
        this.current = current;
    }

    public void Set()
    {

    }
}

class zooLow : Decision // condition
{
    IntReference low;
    IntReference current;
    public zooLow() { }
    public zooLow(IntReference low, IntReference current)
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

class zooMedium : Decision // condition
{
    IntReference low;
    IntReference high;
    IntReference current;
    public zooMedium() { }
    public zooMedium(IntReference low, IntReference high, IntReference current)
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

class zooHigh : Decision // condition
{
    IntReference high;
    IntReference current;
    public zooHigh() { }
    public zooHigh(IntReference high, IntReference current)
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