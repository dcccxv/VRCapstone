using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartsMove : MonoBehaviour
{
    public int CollisonCheck = 0;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(CollisonCheck == 0){
            transform.Translate(Vector3.forward * 6f * Time.deltaTime);
            //rb.AddForce(transform.forward * 500f * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        CollisonCheck = 1;
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();
        if (null != rigidbody)
        {
            Destroy(rigidbody);
        }
        Debug.Log(col.gameObject.name);
    }
    void OnCollisionEnter(Collision col)
    {
        CollisonCheck = 1;
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();
        if (null != rigidbody)
        {
            Destroy(rigidbody);
        }
        Debug.Log(col.gameObject.name);
    }
}
