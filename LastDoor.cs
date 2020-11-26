using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastDoor : MonoBehaviour
{
    public GameObject Door;
    public int open = 0;

    public GameObject UI;
    public string timerTime = "";
    public Text connectionInfoText;

    System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

    // Start is called before the first frame update
    void Start()
    {
        watch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (GameObject.Find("ClockArea").GetComponent<ClockScript>().keyTime == 1 && open == 0)
            {
                Door.transform.Rotate(new Vector3(0, -90, 0));
                Invoke("ShowUI", 2);
                open = 1;
            }
        }
    }

    void ShowUI()
    {
        UI.SetActive(true);
        timerTime = watch.Elapsed.ToString().Substring(0, 8);
        connectionInfoText.GetComponent<Text>().text = "소요시간: " + timerTime;
    }
}
