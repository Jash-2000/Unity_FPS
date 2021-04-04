using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    Rigidbody player;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
    	    player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
    	float hori = Input.GetAxis("Horizontal");
    	float verti = Input.GetAxis("Vertical");

    	Vector3 movement = new Vector3 (hori,0.0f,verti); // This is to define a new datatype for directions.
    	player.AddForce(movement * speed);
    }
}
