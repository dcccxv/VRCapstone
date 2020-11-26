using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darts : MonoBehaviour
{
    public GameObject cDarts;
    public Transform DartsPos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || OVRInput.GetDown(OVRInput.Button.Two))
        {
            if (GameObject.Find("Player").GetComponent<Inventory>().Dart == 1 && GameObject.Find("Player").GetComponent<Inventory>().DartRemain > 0)
                //복제한다. //'Bullet'을 'FirePos.transform.position' 위치에 'FirePos.transform.rotation' 회전값으로.
                Instantiate(cDarts, DartsPos.transform.position, DartsPos.transform.rotation);
            GameObject.Find("Player").GetComponent<Inventory>().DartRemain--;
        }

        if (Input.GetKeyDown(KeyCode.R) || OVRInput.GetDown(OVRInput.Button.One))
        {
            if(GameObject.Find("Player").GetComponent<Inventory>().Dart == 1)
            {
                GameObject[] objects = GameObject.FindGameObjectsWithTag("Dart");
                for (int i = 0; i < objects.Length; i++)
                    Destroy(objects[i]);
                GameObject.Find("Player").GetComponent<Inventory>().DartRemain = GameObject.Find("Player").GetComponent<Inventory>().DartCount;
                GameObject.Find("Target").GetComponent<Score>().finalScore = 0;
            }
        }
    }
}
