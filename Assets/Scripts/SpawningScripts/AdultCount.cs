using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultCount : MonoBehaviour
{
    public IntReference numAdults;
    // Start is called before the first frame update
    private void Awake()
    {
        numAdults.Value++;
    }

    private void OnDestroy()
    {
        numAdults.Value--;
    }
}
