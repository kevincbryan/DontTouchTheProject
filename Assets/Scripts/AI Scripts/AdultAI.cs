using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultAI : MonoBehaviour
{
    public Person agent;
    Decision root;
    public IntReference dissatisfaction;
    public IntReference lowDissatisfaction;
    public IntReference highDissatisfaction;
    // Start is called before the first frame update
    void Start()
    {
        root = new dissatisfactionLevel(agent,
                    new lowMedium(agent,
                        new adultLow(agent),
                        new adultMedium(agent)),
                    new adultHigh(agent));
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

class adultLow : Decision // a lot of adult
{
    Person agent;
    public adultLow() { }
    public adultLow(Person agent)
    {
        this.agent = agent;
    }
    public Decision makeDecision()
    {
        return null;
    }
}

class adultMedium : Decision // less adult
{
    Person agent;
    public adultMedium() { }
    public adultMedium(Person agent)
    {
        this.agent = agent;
    }
    public Decision makeDecision()
    {
        return null;
    }
}

class adultHigh : Decision // little to no adults
{
    Person agent;
    public adultHigh() { }
    public adultHigh(Person agent)
    {
        this.agent = agent;
    }
    public Decision makeDecision()
    {
        return null;
    }
}