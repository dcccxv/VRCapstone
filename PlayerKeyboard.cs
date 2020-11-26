using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboard : MonoBehaviour
{
    protected bool pressed; //키보드 카운터 변수, 한번 누르면 이미지가 화면에 보이도록 하고 다시 누르면 이미지가 화면에서 없어진다.
    public GameObject Sheet;
    void Start()
    {
        Sheet.SetActive(false);
        pressed = true; //true로 초기화.

    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "SheetObject") //raycast에 충돌한 오브젝트의 태그가 SheetObject인지 확인
                {
                    if (pressed == true) //true의 상태면 이미지 출력
                    {
                        Sheet.SetActive(true); //이미지 보이도록.
                    }
                    else if (pressed == false) //false의 상태면 이미지 삭제
                    {
                        Sheet.SetActive(false); //이미지 안 보이도록.
                    }
                }
            }
            pressed = !pressed; //키보드 카운터 변수 바꿈
        }
    }
}
