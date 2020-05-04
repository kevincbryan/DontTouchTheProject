using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HumanAI : MonoBehaviour
{
    public Person agent;
    public UnityEngine.Behaviour root;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Behaviour currentDecision = root;
        while (currentDecision != null)
        {
            //currentDecision = currentDecision.makeDecision();
        }
    }
}
