using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupAction : MonoBehaviour {

    public Text text;
    private int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickup"))
        {
            pickupProperty pP = other.GetComponent<pickupProperty>();
            updateScore(pP.getScore());
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

        }
    }

    private void updateScore (int score)
    {
        this.score += score;
        text.text = "Score: " + this.score;
    }

}
