using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChildren : MonoBehaviour
{
    public IntReference numChildren;
    public IntReference maxChildren;
    public FloatReference spawnDelay;
    private float mTime;
    public float mMaxChildren;
    public IntReference disatisfaction;
    public IntReference maxDisat;
    private float lerpableDisatisfaction;
    //public IntReference lowDis;
    //public IntReference highDis;
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
        lerpableDisatisfaction = 1 - ((float)disatisfaction.Value / (float)maxDisat.Value);
        mMaxChildren = Mathf.Lerp(0, maxChildren.Value, lerpableDisatisfaction);
        if (mMaxChildren < 2f) mMaxChildren = 2f;

        //updating the time
        mTime += Time.deltaTime;
        

        if (numChildren.Value < mMaxChildren && mTime >= spawnDelay.Value)
        {
            //If not at my Max Children and past spawn delay, spawn child and reset time
            mSpawner.Spawn(Enemy.child, Random.Range (0, 2) );
            mTime = 0;
        }
        
    }
}
