using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialArea : MonoBehaviour
{
    public GameObject DialWheel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        DialWheel.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        DialWheel.SetActive(false);
    }
}
