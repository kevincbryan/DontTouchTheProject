using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disatisfaction : MonoBehaviour
{
    public IntReference disatisfaction;
    public IntReference minDis;
    public IntReference maxDis;
    public BoolReference gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        disatisfaction.Value = minDis.Value;
        gameOver.Value = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (disatisfaction.Value < minDis.Value) disatisfaction.Value = minDis.Value;

        if (disatisfaction.Value > maxDis.Value) gameOver.Value = true;
    }
}
