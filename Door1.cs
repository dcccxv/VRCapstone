using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public int open = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Target").GetComponent<Score>().finalScore >= 50 && open == 0)
        {
            this.transform.Rotate(new Vector3(0, -90, 0));
            GameObject.Find("Player").GetComponent<Inventory>().Dart = 0;
            open = 1;
        }
    }
}
