using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dial : MonoBehaviour
{
    public GameObject Dial1;
    public GameObject Dial2;
    public GameObject Dial3;
    public GameObject Dial4;
    public GameObject[] Dials;

    public GameObject Triangle1;
    public GameObject Triangle2;

    public int[] password;
    public int[] angle = { 0, 0, 0, 0 };

    public int dialCheck = 0;

    // Start is called before the first frame update
    void Start()
    {
        Dials = new GameObject[4];
        Dials[0] = Dial1;
        Dials[1] = Dial2;
        Dials[2] = Dial3;
        Dials[3] = Dial4;

        password = new int[4] { 0, 0, 0, 0 };
        angle = new int[4] { 0, 0, 0, 0 };
    }

    // Update is called once per frame
    void Update()
    {
        if (password[0] == 3 && password[1] == 6 && password[2] == 2 && password[3] == 6)
        {
            GameObject.FindWithTag("Dial").GetComponent<CofferOpen>().open = 1;
            Destroy(gameObject,1);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.L) || OVRInput.GetDown(OVRInput.Button.Two))
            {
                dialCheck++;
                Triangle1.transform.Translate(new Vector3(-0.06f, 0, 0));
                Triangle2.transform.Translate(new Vector3(0.06f, 0, 0));
                if (dialCheck == 4)
                {
                    dialCheck = 0;
                    Triangle1.transform.Translate(new Vector3(0.24f, 0, 0));
                    Triangle2.transform.Translate(new Vector3(-0.24f, 0, 0));
                }
            }
            if (Input.GetKeyDown(KeyCode.K) || OVRInput.GetDown(OVRInput.Button.One))
            {
                dialCheck--;
                Triangle1.transform.Translate(new Vector3(0.06f, 0, 0));
                Triangle2.transform.Translate(new Vector3(-0.06f, 0, 0));
                if (dialCheck == -1)
                {
                    dialCheck = 3;
                    Triangle1.transform.Translate(new Vector3(-0.24f, 0, 0));
                    Triangle2.transform.Translate(new Vector3(0.24f, 0, 0));
                }
            }

            if (Input.GetKeyDown(KeyCode.H) || OVRInput.GetDown(OVRInput.Button.Four))
            {
                angle[dialCheck] += 36;
                Dials[dialCheck].transform.localEulerAngles = new Vector3(angle[dialCheck], 0, 0);
                password[dialCheck] += 1;
                if (password[dialCheck] == 10)
                {
                    password[dialCheck] -= 10;
                }
            }
            if (Input.GetKeyDown(KeyCode.J) || OVRInput.GetDown(OVRInput.Button.Three))
            {
                angle[dialCheck] -= 36;
                Dials[dialCheck].transform.localEulerAngles = new Vector3(angle[dialCheck], 0, 0);
                password[dialCheck]--; ;
                if (password[dialCheck] == -1)
                {
                    password[dialCheck] += 10;
                }
            }
        }
    }
}
