using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public int open = 0;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (GameObject.FindWithTag("Player").GetComponent<Inventory>().Key == 1 && open == 0)
            {
                Door.transform.Rotate(new Vector3(0, 90, 0));
                open = 1;
            }
        }
    }
}
