using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowArea : MonoBehaviour
{
    public GameObject Hammer;
    public int state = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(state == 1)
        {
            if(Input.GetKeyDown(KeyCode.L) || OVRInput.GetDown(OVRInput.Button.Two)){
                Hammer.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(GameObject.FindWithTag("Player").GetComponent<Inventory>().Hammer == 1)
            //Hammer.SetActive(true);
            state = 1;
    }

    void OnTriggerExit(Collider other)
    {
        if (GameObject.FindWithTag("Player").GetComponent<Inventory>().Hammer == 1)
            //Hammer.SetActive(true);
            state = 0;
    }

}
