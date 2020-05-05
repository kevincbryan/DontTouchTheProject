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
                new childLow(agent),
                new childMedium(agent),
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

class dissatisfactionLevel : Decision // question
{
    Person agent;
    Decision lowMed;
    Decision current;

    public dissatisfactionLevel() { }
    public dissatisfactionLevel(Person agent, Decision lowMedium, Decision current)
    {
        this.agent = agent;
        lowMed = lowMedium;
        this.current = current;
    }

    public Decision makeDecision()
    {
        if (agent.dissatisfaction.Value < agent.lowDissatisfaction.Value)
        {
            return lowMed;
        }
        else
            return current;
    }
}

class childLow : Decision // condition
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

class childMedium : Decision // condition
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

class childHigh : Decision // condition
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