using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelect : MonoBehaviour
{
    private Animator animator;

    void Update()
    {
        //Ray ray = new Ray(transform.position, transform.forward);
        //Debug.DrawRay(ray.origin, ray.direction * 5, Color.red);
        if (Input.GetMouseButtonDown(1) || OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger)!=0)
        {
            Debug.Log("입력");
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hitInfo;
            float Distance = 15.0f;

            if (Physics.Raycast(ray, out hitInfo, Distance))
            {
                Debug.Log(hitInfo.collider.gameObject.name);
    

                if (hitInfo.collider.tag == "DartHidden") { 
                    Destroy(hitInfo.transform.gameObject);
                    GameObject.Find("Player").GetComponent<Inventory>().Dart =1;
                    GameObject.Find("Player").GetComponent<Inventory>().DartCount++;
                    GameObject.Find("Player").GetComponent<Inventory>().DartRemain++;
                }

                if (hitInfo.collider.tag == "Hammer")
                {
                    Destroy(hitInfo.transform.gameObject);
                    GameObject.Find("Player").GetComponent<Inventory>().Hammer = 1;
                }

                if (hitInfo.collider.name == "Cable")
                {
                    Destroy(hitInfo.transform.gameObject);
                    GameObject.Find("Player").GetComponent<Inventory>().Cable = 1;
                }

                if (hitInfo.collider.name == "Key")
                {
                    Destroy(hitInfo.transform.gameObject);
                    GameObject.Find("Player").GetComponent<Inventory>().Key = 1;
                }

                //장농
                if (hitInfo.collider.tag == "Wardrobe")
                {
                    animator = hitInfo.transform.gameObject.GetComponent<Animator>();
                    if (animator.GetBool("open"))
                    {
                        animator.SetBool("open", false);
                    }
                    else
                    {
                        animator.SetBool("open", true);
                    }
                }
                /*
                if (hitInfo.collider.tag == "Drawer1" || hitInfo.collider.tag == "Drawer2" || hitInfo.collider.tag == "Drawer3")
                {
                    animator = hitInfo.transform.parent.gameObject.GetComponent<Animator>();
                    if (animator.GetBool("drawer1") || (animator.GetBool("drawer2")) || (animator.GetBool("drawer3"))){
                        animator.SetBool("drawer1", false);
                        animator.SetBool("drawer2", false);
                        animator.SetBool("drawer3", false);
                    }
                    else{
                        if (animator.GetBool("drawer1"))
                        {
                            animator.SetBool("drawer1", true);
                        }
                        else if (animator.GetBool("drawer2"))
                        {
                            animator.SetBool("drawer2", true);
                        }
                        else if (animator.GetBool("drawer3"))
                        {
                            animator.SetBool("drawer3", true);
                        }
                    }
                }*/
                
                    //서랍
                if (hitInfo.collider.tag == "Drawer1")
                {
                    animator = hitInfo.transform.parent.gameObject.GetComponent<Animator>();
                    if (animator.GetBool("drawer1"))
                    {
                        animator.SetBool("drawer1", false);
                    }
                    else
                    {
                        animator.SetBool("drawer1", true);
                    }
                }
                if (hitInfo.collider.tag == "Drawer2")
                {
                    animator = hitInfo.transform.parent.gameObject.GetComponent<Animator>();
                    if (animator.GetBool("drawer2"))
                    {
                        animator.SetBool("drawer2", false);
                    }
                    else
                    {
                        animator.SetBool("drawer2", true);
                    }
                }
                if (hitInfo.collider.tag == "Drawer3")
                {
                    animator = hitInfo.transform.parent.gameObject.GetComponent<Animator>();
                    if (animator.GetBool("drawer3"))
                    {
                        animator.SetBool("drawer3", false);
                    }
                    else
                    {
                        animator.SetBool("drawer3", true);
                    }
                }
            }
        }
    }
}
