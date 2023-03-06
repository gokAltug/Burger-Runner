using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player Instance;

    


    public Animator playerAnimator;
    Rigidbody rb;
    // SerializedField attribute allows us to see and adjust parameters in the editor without making them public
    [SerializeField] float forwardSpeed;
    [SerializeField] Vector3 speed;
    [SerializeField] float sideSpeed;
    [SerializeField] float bound;

    private void Awake()
    {
        Instance = this;
    }


    void Start()
    {
        // Caching References for performance reasons.
        rb = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        // Getting value from keyboard Input. It's the old input system but works fine :)
        var horizontal = Input.GetAxis("Horizontal");

        // Check if game is started
        if(GameManager.instance.isGameStarted)
        {
            // Time.deltaTime makes the game frame-rate/hardware independent.
            //transform.position += new Vector3(horizontal * sideSpeed, 0, forwardSpeed) * Time.deltaTime;
            transform.position += new Vector3(horizontal * sideSpeed, 0, 0) * Time.deltaTime;
            rb.velocity = speed;
            BoundsCheck();
        }

        playerAnimator.SetFloat("Speed", rb.velocity.z);

    }


    void OnTriggerEnter(Collider other)
    {
        var otherObject = other.gameObject;
        if(otherObject != null)
        {
            otherObject.GetComponent<IInteractable>().Interact();
        }
    }

    void BoundsCheck()
    {
        if (transform.position.x >= 2)
        {
            transform.position = new Vector3(bound, transform.position.y, transform.position.z);
        }

        else if (transform.position.x <= -2)
        {
            transform.position = new Vector3(-bound, transform.position.y, transform.position.z);
        }
    }
}
