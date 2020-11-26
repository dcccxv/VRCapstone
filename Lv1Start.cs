using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1Start : MonoBehaviour
{

    protected float TimeCount = 10;


    void Update()
    {
        TimeCount -= Time.deltaTime;
        if (TimeCount < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
