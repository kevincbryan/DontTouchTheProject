using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Result { Success, Failure}
public interface Behaviour
{
    Result execute(Person agent);
}

public class ChildAI : MonoBehaviour
{
    public IntReference dissatisfaction;
    public IntReference lowDissatisfaction;
    public IntReference highDissatisfaction;
    public Person agent;
    Behaviour behavior;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        behavior.execute(agent);
    }
}

class childDissatisfaction : Behaviour
{

    public Result execute(Person agent)
    {

        if ()
        {

        }

    }
}
