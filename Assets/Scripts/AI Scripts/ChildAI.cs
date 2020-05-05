using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Decision
{
    Decision makeDecision();
}

public class ChildAI : MonoBehaviour
{
    public Person agent;
    Decision root;
    // Start is called before the first frame update
    void Start()
    {
        root = new dissatisfactionLevel(agent, 
                    new lowMedium(agent, 
                        new childLow(agent), 
                        new childMedium(agent)),
                    new childHigh(agent));
    }

    // Update is called once per frame
    void Update()
    {
        Decision currentDecision = root;
        while (currentDecision != null)
        {
            currentDecision = currentDecision.makeDecision();
        }
    }
}

class dissatisfactionLevel : Decision // question // meter at or below high
{
    Person agent;
    Decision lowMed;
    Decision high;

    public dissatisfactionLevel() { }
    public dissatisfactionLevel(Person agent, Decision lowMedium, Decision high)
    {
        this.agent = agent;
        lowMed = lowMedium;
        this.high = high;
    }

    public Decision makeDecision()
    {
        if (agent.dissatisfaction.Value < agent.lowDissatisfaction.Value)
        {
            return lowMed;
        }
        else
            return high;
    }
}

class lowMedium : Decision // question // medium or low
{
    Person agent;
    Decision low;
    Decision medium;
    public lowMedium() { }
    public lowMedium(Person agent, Decision low, Decision medium)
    {
        this.agent = agent;
        this.low = low;
        this.medium = medium;
    }
    public Decision makeDecision()
    {
        if (agent.dissatisfaction.Value > agent.lowDissatisfaction.Value && agent.lowDissatisfaction.Value < agent.highDissatisfaction.Value)
        {
            return medium;
        }
        else
            return low;
    }
}

class childLow : Decision // a lot of children
{
    Person agent;
    public childLow() { }
    public childLow(Person agent)
    {
        this.agent = agent;
    }
    public Decision makeDecision()
    {
        return null;
    }
}

class childMedium : Decision // less children
{
    Person agent;
    public childMedium() { }
    public childMedium(Person agent)
    {
        this.agent = agent;
    }
    public Decision makeDecision()
    {
        return null;
    }
}

class childHigh : Decision // little to no children
{
    Person agent;
    public childHigh() { }
    public childHigh(Person agent)
    {
        this.agent = agent;
    }
    public Decision makeDecision()
    {
        return null;
    }
}