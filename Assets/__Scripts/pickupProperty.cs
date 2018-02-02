using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupProperty : MonoBehaviour {
    static Color[] scoreToColor = new Color[] { new Color(150, 240, 150), new Color(75, 170, 220), new Color(250, 170, 155) };

    public float rotateSpeed = 40f;
    public float amplitude = 1f;
    public int Score
    {
        get { return score; }
        set { if (value > 0 && value < 4)
                { score = value; }
              else { score = 1; }
            }
    }

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

    public void initObject(int score)
    {
        this.score = score;
        this.color = scoreToColor[score-1];
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
