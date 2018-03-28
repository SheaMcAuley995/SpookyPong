using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float moveSpeed = 0.5f;
    //Transform trans;
    Rigidbody rb;
    //private float rbZ;

    //public static void Move(ref Rigidbody Player_rb, float speed)
    //{
    //    Vector3 movement = new Vector3(0, 0, speed);
    //    Player_rb.AddForce(Player_rb.velocity, ForceMode.Force);
    //}
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        var vel = rb.velocity;


        float h = Input.GetAxis("Vertical");
        Move(moveSpeed * h);

        if (!Input.anyKey)
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        Vector3 pos = transform.position;
        pos.z = Mathf.Clamp(pos.z, -5, 5f);
        transform.position = pos;
    }

    private void FixedUpdate()
    {
        
    }

    private void Move(float speed)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
    }
        //Vector3 movement = new Vector3(0, 0, speed);
        //rb.AddForce(movement, ForceMode.Force);
    
}
