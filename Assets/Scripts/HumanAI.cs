using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public interface Decision
{
    Decision makeDecision();
}

public class HumanAI : MonoBehaviour
{
    public Person agent;
    public Decision root;
    // Start is called before the first frame update
    void Start()
    {
        root = new a(agent,
                    new b(agent),
                    new c(agent));
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

public class a : Decision // condition node
{
    Person agent;
    Decision b;
    Decision c;

    public a() { }

    public a(Person agent, Decision b, Decision c)
    {
        this.agent = agent;
        this.b = b;
        this.c = c;
    }

    public Decision makeDecision()
    {
        if (true)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}

public class b : Decision // condition node
{
    Person agent;

    public b() { }

    public b(Person agent)
    {
        this.agent = agent;
    }

    public Decision makeDecision()
    {

        return null;
    }
}

public class c : Decision // condition node
{
    Person agent;

    public c() { }

    public c(Person agent)
    {
        this.agent = agent;
    }

    public Decision makeDecision()
    {

        return null;
    }
}