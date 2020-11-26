using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public int Score;
    public int Mscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Dart")
        {
            GameObject.Find("Target").GetComponent<Score>().score += (Score-Mscore);
        }
        /*
        if (col.gameObject.tag == "Score20")
        {
            GameObject.Find("Target").GetComponent<Score>().score += 20;
        }
        else if (col.gameObject.tag == "Score10")
        {
            GameObject.Find("Target").GetComponent<Score>().score += 10;
        }
        else if (col.gameObject.tag == "Score5")
        {
            GameObject.Find("Target").GetComponent<Score>().score += 5;
        }*/
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Dart")
        {
            GameObject.Find("Target").GetComponent<Score>().score += (Score - Mscore);
        }
    }
}
