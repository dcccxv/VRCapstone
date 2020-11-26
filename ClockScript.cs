using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    public int check = 0;
    public float time = 0;
    public int keyTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (check == 1) { 
            if (Input.GetKey(KeyCode.H) || OVRInput.Get(OVRInput.Button.Two))
            {
                time += 60 * Time.deltaTime;
                GameObject.FindWithTag("clocks").GetComponent<Clock>().minutes = (int)time;
            }
            if (Input.GetKey(KeyCode.J) || OVRInput.Get(OVRInput.Button.One))
            {
                time -= 60 * Time.deltaTime;
                GameObject.FindWithTag("clocks").GetComponent<Clock>().minutes = (int)time;
            }

            if (Input.GetKeyDown(KeyCode.K) || OVRInput.GetDown(OVRInput.Button.Four))
            {
                time++;
                GameObject.FindWithTag("clocks").GetComponent<Clock>().minutes++;
            }
            if (Input.GetKeyDown(KeyCode.L) || OVRInput.GetDown(OVRInput.Button.Three))
            {
                time--;
                GameObject.FindWithTag("clocks").GetComponent<Clock>().minutes--;
            }
        }
    }

    void ClockControl()
    {
        if (check == 1)
        {
            GameObject.FindWithTag("clocks").GetComponent<Clock>().minutes++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindWithTag("clocks").GetComponent<Clock>().clockSpeed = 0;
            check = 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //GameObject.FindWithTag("clocks").GetComponent<Clock>().clockSpeed = 1;
        if(GameObject.FindWithTag("clocks").GetComponent<Clock>().minutes%720 == 266 || GameObject.FindWithTag("clocks").GetComponent<Clock>().minutes*-1 % 720 == 454)
        {
            keyTime = 1;
        }
        else
        {
            keyTime = 0;
        }
        check = 0;
    }
}
