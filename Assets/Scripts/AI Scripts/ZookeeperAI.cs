using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZookeeperAI : MonoBehaviour
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
                        new zooLow(agent),
                        new zooMedium(agent)),
                    new zooHigh(agent));
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

class zooLow : Decision // no zookeeper
{
    Person agent;
    public zooLow() { }
    public zooLow(Person agent)
    {
        this.agent = agent;
    }
    public Decision makeDecision()
    {
        return null;
    }
}

class zooMedium : Decision // zookeeper starts patroling
{
    Person agent;
    public zooMedium() { }
    public zooMedium(Person agent)
    {
        this.agent = agent;
    }
    public Decision makeDecision()
    {
        return null;
    }
}

class zooHigh : Decision // more zookeeper
{
    Person agent;
    public zooHigh() { }
    public zooHigh(Person agent)
    {
        this.agent = agent;
    }
    public Decision makeDecision()
    {
        return null;
    }
}