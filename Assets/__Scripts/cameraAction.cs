using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAction : MonoBehaviour {

    public GameObject target;
    private Vector3 deltaP;

    // Use this for initialization
    private void Start()
    {
        deltaP = transform.position - target.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = deltaP + target.transform.position;
    }


}
