using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChildren : MonoBehaviour
{
    public IntReference numChildren;
    public IntReference maxChildren;
    public FloatReference spawnDelay;
    private float mTime;
    private float mMaxChildren;
    public IntReference disatisfaction;
    public IntReference maxDisat;
    private float lerpableDisatisfaction;
    public IntReference lowDis;
    public IntReference highDis;
    public Spawner mSpawner;
    

    // Start is called before the first frame update
    void Start()
    {
        numChildren.Value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Figuring out max Children
        if (maxDisat.Value != 0)lerpableDisatisfaction = disatisfaction.Value / maxDisat.Value;
        mMaxChildren = Mathf.Lerp(0, maxChildren.Value, lerpableDisatisfaction);


        mTime = Time.deltaTime;
        
    }
}
