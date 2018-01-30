using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    public float speed = 1f;
    public float maxVelocity=10f;

    //private bool ability = true;
    private Rigidbody rigidbody;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        m = GetComponent<Material>();
    }
	
	// Update is called once per frame
	void Update () {

        if (rigidbody == null) { return; }

        float v = Input.GetAxis("Horizontal");
        float h = Input.GetAxis("Vertical");

        //rigidbody.AddForce(v * speed, 0, h * speed, ForceMode.VelocityChange);
        //if (rigidbody.velocity.magnitude>maxVelocity)
        //{
        //    rigidbody.velocity *= maxVelocity / rigidbody.velocity.magnitude;
        //}
        if (rigidbody.velocity.magnitude<=maxVelocity)
        {
            rigidbody.AddForce(v * speed, 0, h * speed, ForceMode.Impulse);
        }
        else
        {
            rigidbody.velocity *= maxVelocity / rigidbody.velocity.magnitude;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale *= 2f;
            
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale *= 0.5f;
        }

        
        

    }
}
