using UnityEngine;

public class Player_Movement : MonoBehaviour {

    // this is a reference to rigidbody component called "rb"
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb.useGravity = true;
	}

    public float ForwardForce = 2000f;
    public float SidewaysForce = 500f;
    // We marked this as "FixedUpdate" because we
    // are using it to mess with physics
	// Update is called once per frame
	void FixedUpdate () {
        // Add a ForwardForce
        //rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
       /*if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -ForwardForce * Time.deltaTime);
        }*/
    }
}
