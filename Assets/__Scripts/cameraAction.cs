using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAction : MonoBehaviour {

    public GameObject target;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
        if (target == null) return;
        gameObject.transform.LookAt(target.transform.position);
        
	}


}
