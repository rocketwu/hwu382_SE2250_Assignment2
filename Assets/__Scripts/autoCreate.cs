using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoCreate : MonoBehaviour {

    public GameObject objToCreate;
	// Use this for initialization
	void Start () {
        //Instantiate(objToCreate).GetComponent<pickupProperty>().initObject(1, Color.red);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject create()
    {
        return Instantiate(objToCreate);
    }
}
