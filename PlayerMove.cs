using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public Camera cam;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dirx = 0;
        float dirz = 0;
        MoveLookAt();
        //이동
        //if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick)){
            Vector2 coord = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
            var absX = Mathf.Abs(coord.x);
            var absY = Mathf.Abs(coord.y);
            
            if(Input.GetKey(KeyCode.D) || (absX > absY && coord.x > 0))
            {
                //dirx = 1;
                transform.Translate(transform.right * 3.0f * Time.deltaTime);
                //this.transform.position += (this.transform.right * 3.0f * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A) || (absX > absY && coord.x < 0))
            {
                //dirx = -1;
                transform.Translate(transform.right * -3.0f * Time.deltaTime);
                //this.transform.position += (this.transform.right * -3.0f * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S) || (absX < absY && coord.y < 0))
            {
                //dirz = 1;
                transform.Translate(transform.forward * -3.0f * Time.deltaTime);
                //this.transform.position += (this.transform.forward * 3.0f * Time.deltaTime);
                //Rigidbody.AddForce(new Vector3(transform.forward * 3.0f * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.W) || (absX < absY && coord.y > 0))
            {
                //dirz = -1;
                transform.Translate(transform.forward * 3.0f * Time.deltaTime);
                //this.transform.position += (this.transform.forward * -3.0f * Time.deltaTime);
            }
            //Vector3 moveDir = new Vector3(dirx * 3, 0, dirz * 3);
            //transform.Translate(moveDir * Time.smoothDeltaTime);
        //}
        /*
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * 3.0f * Time.deltaTime);
            //this.transform.position += (this.transform.right * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -3.0f * Time.deltaTime);
            //this.transform.position += (this.transform.right * -3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * 3.0f * Time.deltaTime);
            //this.transform.position += (this.transform.forward * 3.0f * Time.deltaTime);
            //Rigidbody.AddForce(new Vector3(transform.forward * 3.0f * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -3.0f * Time.deltaTime);
            //this.transform.position += (this.transform.forward * -3.0f * Time.deltaTime);
        }*/
        /*
        //앉기
        if (Input.GetKey(KeyCode.Z) || OVRInput.Get(OVRInput.Button.Two))
        {
            transform.position = new Vector3(transform.position.x, -1.0f, transform.position.z);
        }
        if (Input.GetKeyUp(KeyCode.Z) || OVRInput.Get(OVRInput.Button.Four))
        {
            transform.position = new Vector3(transform.position.x, 1.0f, transform.position.z);
        }

        //점프
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.position = new Vector3(transform.position.x, 2.0f, transform.position.z);
        }
        else
        {
            //transform.position = new Vector3(transform.position.x, 1.0f, transform.position.z);
        }*/
    }
    void MoveLookAt()
    {
        Vector3 dir = cam.transform.localRotation * Vector3.forward;
        transform.localRotation = cam.transform.localRotation;
        transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);
    }
}
