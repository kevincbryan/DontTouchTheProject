using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAdults : MonoBehaviour
{
    public IntReference numAdults;
    public IntReference maxAdults;
    public FloatReference spawnDelay;
    private float mTime;
    public float mMaxAdults;
    public IntReference disatisfaction;
    public IntReference maxDisat;
    private float lerpableDisatisfaction;
    //public IntReference lowDis;
    //public IntReference highDis;
    public Spawner mSpawner;
    // Start is called before the first frame update
    void Start()
    {
        numAdults.Value = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //Figuring out max Adults
        lerpableDisatisfaction = 1 - ((float)disatisfaction.Value / (float)maxDisat.Value);
        mMaxAdults = Mathf.Lerp(0, maxAdults.Value, lerpableDisatisfaction);
        if (mMaxAdults < 1f) mMaxAdults = 1f;

        //updating the time
        mTime += Time.deltaTime;


        if (numAdults.Value < mMaxAdults && mTime >= spawnDelay.Value)
        {
            //If not at my Max Adults and past spawn delay, spawn child and reset time
            mSpawner.Spawn(Enemy.parent, Random.Range(0, 2));
            mTime = 0;
        }
    }
}
