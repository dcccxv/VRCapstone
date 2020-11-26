using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofferOpen : MonoBehaviour
{
    public int check = 0;
    private Animator animator;
    public int open = 0;
    public GameObject Key;

    // Start is called before the first frame update
    void Start()
    {
        animator = transform.gameObject.GetComponent<Animator>();
        check = 0;
        open = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(open == 1 && check ==0){
            animator.SetBool("open", true);
            Destroy(Key,3);
            GameObject.Find("Player").GetComponent<Inventory>().Key = 1;
            check = 1;
        }

    }
}
