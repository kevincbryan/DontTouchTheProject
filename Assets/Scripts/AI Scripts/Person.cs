using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "new Person", menuName = "Person")]
public class Person : ScriptableObject
{
    public NavMeshAgent agent;
    public IntReference score;
    public bool handEaten;
    public IntReference timer;
}
