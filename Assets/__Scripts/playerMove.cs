using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    public float speed = 5f;
    public float maxVelocity=5f;

    //private bool ability = true;
    private Rigidbody rigidbody;
    private MeshRenderer meshRenderer;
    private Color orColor;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        orColor = meshRenderer.material.color;
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
            //rigidbody.AddForce(v * speed, 0, h * speed, ForceMode.Impulse);
            rigidbody.AddForce(v * speed, 0, h * speed);
        }
        else
        {
            rigidbody.velocity *= maxVelocity / rigidbody.velocity.magnitude;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale *= 2f;
            meshRenderer.material.color = new Color(0,0,0);
            
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.localScale *= 0.5f;
            meshRenderer.material.color = orColor;
        }

        
        

    }
}
