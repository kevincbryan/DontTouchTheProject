using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CompositeBehaviour : Behaviour
{
    List<Behaviour> childBehaviours;

    Result execute(Person agent);
}

public class ZookeeperAI : MonoBehaviour
{
    public Person agent;
    Behaviour behaviour;
    public IntReference dissatisfaction;
    public IntReference lowDissatisfaction;
    public IntReference highDissatisfaction;
    // Start is called before the first frame update
    void Start()
    {
        behaviour.execute(agent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class zooDissatisfaction : Behaviour // condition
{
    IntReference low;
    IntReference high;
    zooDissatisfaction() { }
    zooDissatisfaction(IntReference low, IntReference high)
    {
        this.low = low;
        this.high = high;
    }
    public Result execute(Person agent)
    {

    }
}
