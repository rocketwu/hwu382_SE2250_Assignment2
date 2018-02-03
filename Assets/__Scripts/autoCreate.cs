using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoCreate : MonoBehaviour {

    public GameObject objToCreate;

    //private float timer=0;
    //private float createTime=3f;
	// Use this for initialization
	void Start () {

        if (objToCreate == null) return;
        transform.position = new Vector3(5, 1, 0);
        for (int i=0; i<8;i++)
        {
            Instantiate(objToCreate,transform.position,objToCreate.transform.rotation).GetComponent<pickupProperty>().initObject(i%3+1);
            transform.RotateAround(Vector3.zero, Vector3.up, 45);
        }
        transform.position = new Vector3(0, 1, 0);

    }

    // Update is called once per frame
    void Update () {
        //if (objToCreate == null) return;
        //timer += Time.deltaTime;
        //if (timer>=createTime)
        //{
        //    float x = Random.Range(-7, 7);
        //    float z = Random.Range(-7, 7);
        //    int score = Random.Range(1, 3);
        //    Instantiate(objToCreate, new Vector3(x, 1, z), objToCreate.transform.rotation).GetComponent<pickupProperty>().initObject(score);
        //    timer = 0;
        //    createTime = Random.Range(3, 7);
        //}
    }


}
