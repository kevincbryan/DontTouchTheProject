using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FloatReference moveSpeed;
    public FloatReference currentSpeed;
    
    public Rigidbody rb;
    public GameObject player;
    public bool movable = true;
    public bool isMoving;

    private Vector3 movement;
    public Animator animator;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        if (movable)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.z = Input.GetAxisRaw("Vertical");
            movement.y = 0;
            movement = movement.normalized;
        }
        else
        {
            movement.x = 0;
            movement.y = 0;
            movement.z = 0;
        }

        if (movement.x != 0 || movement.z != 0) // Checks if there is movement input
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (isMoving == true)
        {
            if (audioSource)
            {
                if (audioSource.isPlaying != true) //Checks if footsteps are already playing
                {
                    //Debug.Log ("Footsteps should play" + audioSource);
                    audioSource.Play();
                }
            }
        }
        else
        {
            if (audioSource) //stops audio if footsteps are stopped
            {
                audioSource.Stop();
            }
        }



    }

    void FixedUpdate()
    {
        if (movable)
        {
            rb.MovePosition(rb.position + movement * moveSpeed.Value * Time.fixedDeltaTime);
            //Debug.Log("Moving towards position " + (rb.position + movement));
        }

    }
}
