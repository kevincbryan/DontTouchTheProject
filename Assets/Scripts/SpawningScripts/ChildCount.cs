using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCount : MonoBehaviour
{
    public IntReference numChildren;
    // Start is called before the first frame update
    private void Awake() 
    {
        numChildren.Value++;
    }

    private void OnDestroy() 
    {
        numChildren.Value--;
    }

  
}
