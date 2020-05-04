using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public FloatVariable myTime;
    public FloatVariable maxTime;
    public bool gameEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        myTime.Value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        myTime.Value += Time.deltaTime;

        if (myTime.Value > maxTime.Value)
        {
            gameEnd = true;
        }

    }
}
