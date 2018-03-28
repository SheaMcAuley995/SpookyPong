using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmemyMove : MonoBehaviour {

    public GameObject ball;
    private Vector3 ballPos;
    public int moveSpeed = 20;

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
     
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
    }

    private void Move()
    {
        ballPos = ball.transform.localPosition;

        if(transform.localPosition.z > -7 && ballPos.z < transform.localPosition.z)
        {
            transform.localPosition += new Vector3(0, 0, -moveSpeed * Time.deltaTime);
        }
        if(transform.localPosition.z < 7 && ballPos.z > transform.localPosition.z)
        {
            transform.localPosition += new Vector3(0, 0, moveSpeed * Time.deltaTime);
        }
        //GetComponent<Rigidbody>().velocity = Vector3.up * speed;
        //transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
    }
        //Vector3 movement = new Vector3(0, 0, speed);
        //rb.AddForce(movement, ForceMode.Force);
    
}
