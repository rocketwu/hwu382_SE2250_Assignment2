using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupProperty : MonoBehaviour {

    public float rotateSpeed = 40f;
    public float amplitude = 1f;


    private int score = 1;
    private Color color;

    // Use this for initialization
    //void Start () {

    //}

    private void Update()
    {
        selfRotate();
        vibration();
    }

    public void initObject(int score, Color color)
    {
        this.score = score;
        this.color = color;
        gameObject.GetComponent<MeshRenderer>().material.color = this.color;
        GetComponentInChildren<Light>().color = this.color;

    }

    public int getScore()
    {
        return this.score;
    }

    private void selfRotate ()
    {
        transform.Rotate(new Vector3(1,1,-1), rotateSpeed * Time.deltaTime);
    }

    private void vibration ()
    {
        transform.position += (Vector3.up) * amplitude/1000 * Mathf.Cos(Time.time);
    }


    //next version, add trace and absorb effect.

}
