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
    private bool isJumping;
    public float jumpAmount = 5f;
    private float mTime;

    private Vector3 movement;
    public Animator animator;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        movement.y =  0;
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        if (movable)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.z = Input.GetAxisRaw("Vertical");
            //movement.y = 0;
            movement = movement.normalized;
        }
        else
        {
            movement.x = 0;
            movement.y = 0;
            movement.z = 0;
        }

        if (movable && isJumping == false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(new Vector3(0, jumpAmount, 0), ForceMode.Impulse);
                isJumping = true;
                Invoke("Jump", 1f);
            }
        }

        if (movement.x != 0 || movement.z != 0 || isJumping == true) // Checks if there is movement input
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

    void Jump()
    {
        Debug.Log ("jump is run");
        isJumping = false;
        
    }

  
}
