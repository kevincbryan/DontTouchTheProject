using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Enemy { child, parent, zookeeper };

public class Spawner : MonoBehaviour
{
    public Transform[] spawnLoc;
    public GameObject child;
    public GameObject parent;
    public GameObject zookeeper;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn (Enemy.zookeeper, 0);
    }

    public void Spawn (Enemy mSpawn, int location)
    {
        GameObject toSpawn;

        if (mSpawn == Enemy.zookeeper) toSpawn = zookeeper;
        else if (mSpawn == Enemy.parent) toSpawn = parent;
        else toSpawn = child;
        

        if (location >= spawnLoc.Length)
        {
            location = spawnLoc.Length -1; 
        }

        Instantiate(toSpawn, spawnLoc[location].position, Quaternion.identity);
        
    }
}
