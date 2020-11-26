using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV : MonoBehaviour
{
    public GameObject CCTV1;
    public GameObject CCTV2;
    public GameObject CCTV3;
    public int select = 1;
    public int view = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (view == 1)
        {
            if (Input.GetKeyDown(KeyCode.H) || OVRInput.GetDown(OVRInput.Button.Two))
            {
                select++;
                if (select == 4) select = 1;
            }
            if (Input.GetKeyDown(KeyCode.J) || OVRInput.GetDown(OVRInput.Button.One))
            {
                select--;
                if (select == 0) select = 3;
            }
            CCTVView();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("Player").GetComponent<Inventory>().Cable == 1)
        {
            view = 1;
        }
    }



    void OnTriggerExit(Collider other)
    {
        CCTV1.SetActive(false);
        CCTV2.SetActive(false);
        CCTV3.SetActive(false);
        view = 0;
    }

    void CCTVView()
    {
        if (view == 1)
        {
            if (select == 1)
            {
                CCTV2.SetActive(false);
                CCTV3.SetActive(false);
                CCTV1.SetActive(true);
            }
            else if (select == 2)
            {
                CCTV2.SetActive(true);
                CCTV3.SetActive(false);
                CCTV1.SetActive(false);
            }
            else if (select == 3)
            {
                CCTV2.SetActive(false);
                CCTV3.SetActive(true);
                CCTV1.SetActive(false);
            }
        }
    }
}
