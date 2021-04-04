using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody Jash;
    public float speed;
    bool shooting = false;
    
    // Start is called before the first frame update
    void Start()
    {
    	Jash = GetComponent<Rigidbody>();	
    }

    // Update is called once per framefloat forwardSpeed = Input.GetAxis("Vertical");
    void Update()
    {
        // Rotation

        float playerside = Input.GetAxis("Rotate");
        transform.Rotate(0, playerside ,0);
		
		float cameraup = Input.GetAxis("Float");
        Camera.main.transform.Rotate(cameraup,0,0);

    	// Movement
        float forward = Input.GetAxis("Vertical");
        float side = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(side,0,forward);
    	Jash.AddForce(movement * speed);
    
    	//Shooting 
    	if(Input.GetButton("Shoot"))
    		shooting = true;

    }

    void FixedUpdate()
    {
    	if(shooting)
        {
            shooting = false;

            RaycastHit hit;

            if(Physics.Raycast(transform.position, transform.forward, out hits ))
            {
                
                    Destroy (hit.transform.gameObject);

            }
        }    
    }
}
