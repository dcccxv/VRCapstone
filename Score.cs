using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text connectionInfoText;
    public int score = 0;
    public int finalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 2000)
        {
            finalScore += 20;
            score =0;
        }
        else if (score >= 100)
        {
            finalScore += 10;
            score = 0;
        }
        else if (score >= 5)
        {
            finalScore += 5;
            score = 0;
        }

        connectionInfoText.GetComponent<Text>().text = finalScore.ToString();
        
    }
}
