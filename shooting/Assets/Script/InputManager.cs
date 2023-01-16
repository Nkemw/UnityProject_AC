using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if(controller == null)
        {
            Debug.Log("플레이어를 찾지 못했습니다");
        }
    }

    private void OnMouseDown()
    {
        controller.MoveInput = true;
    }

    private void OnMouseUp()
    {
        controller.MoveInput = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
