using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class moveBall : MonoBehaviour {

    public Transform hitPrefab;
    public Transform TrailPrefab;

    public Transform ExplosionPreFab;

    public float ballSpeed = 30;
    //public Vector3 vel;
    //Rigidbody rb;

    float hitPoint(Vector3 ballPos, Vector3 playerPos, float PlayLength)
    {
        return (ballPos.z - playerPos.z) / PlayLength;
    }

	// Use this for initialization
	void Start () {
        
       
        Invoke("StartBall", 5);
	}


    private void Update()
    {
        //vel = rb.velocity;
        //float signX = Mathf.Sign(vel.x);
        //float signZ = Mathf.Sign(vel.z);
        //if (Mathf.Abs(vel.z) < 3)
        //{
        //    vel.z += 5 * signZ;
        //}
        //if (Mathf.Abs(vel.x) < 3)
        //{
        //    vel.x += 5 * signX;
        //}
    }
    
    void FixedUpdate ()
    {

        //rb.velocity = vel;
        
    }

    void StartBall()
    {
        GetComponent<Rigidbody>().velocity = Vector3.right * ballSpeed;


    }

    private void OnCollisionEnter(Collision collision)
    {
        Transform hit = this.transform;



        if (collision.collider.CompareTag("Enemy"))
        {
            CameraShaker.Instance.ShakeOnce(3f, 3f, .1f, 1f);

            Effect(hit.position, Vector3.RotateTowards(hit.position,transform.position,0,0));

            float z = hitPoint(transform.position, collision.transform.position, collision.collider.bounds.size.z);

            Vector3 dir = new Vector3(-1, 0, z).normalized;

            GetComponent<Rigidbody>().velocity = dir * ballSpeed;
        }
        if (collision.collider.CompareTag("Player"))
        {
            CameraShaker.Instance.ShakeOnce(3f, 3f, .1f, 1f);

            Effect(hit.position, Vector3.up);

            float z = hitPoint(transform.position, collision.transform.position, collision.collider.bounds.size.z);

            Vector3 dir = new Vector3(1, 0, z).normalized;

            GetComponent<Rigidbody>().velocity = dir * ballSpeed;
        }
        if(collision.collider.CompareTag("Top"))
        {
            //float x = hitPoint(transform.position, collision.transform.position, collision.collider.bounds.size.z);

            

            Vector3 dir = new Vector3(GetComponent<Rigidbody>().velocity.x, 0, 1).normalized;

            GetComponent<Rigidbody>().velocity = dir * ballSpeed;
        }
        if (collision.collider.CompareTag("Bottom"))
        {
            //float x = hitPoint(transform.position, collision.transform.position, collision.collider.bounds.size.z);

            

            Vector3 dir = new Vector3(GetComponent<Rigidbody>().velocity.x, 0, -1).normalized;

            GetComponent<Rigidbody>().velocity = dir * ballSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Transform hit = this.transform;
        if (other.CompareTag("PlayerScore"))
        {
            CameraShaker.Instance.ShakeOnce(6f, 6f, .1f, 1f);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = new Vector3(0, 0, 0);
            //ExplodeEffect(this.transform.position, Vector3.RotateTowards(hit.position, transform.position, 0, 0));
            Invoke("StartBall", 3);
        }
        if (other.CompareTag("EnemyScore"))
        {
            CameraShaker.Instance.ShakeOnce(6f, 6f, .1f, 1f);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            //ExplodeEffect(this.transform.position, Vector3.RotateTowards(hit.position, transform.position, 0, 0));
            transform.position = new Vector3(0, 0, 0);
            Invoke("StartBall", 3);
        }
    }

    void Effect(Vector3 hitPos, Vector3 dir)
    {
            Transform hitParticle = Instantiate(hitPrefab, hitPos, Quaternion.FromToRotation(Vector3.right, dir)) as Transform;
            Destroy(hitParticle.gameObject, 1f);
    }
    
}
