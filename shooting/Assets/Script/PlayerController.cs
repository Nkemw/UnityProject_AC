using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector2 clampMin;
    [SerializeField] private Vector2 clampMax;

    private bool isMove;

    public bool MoveInput
    {
        set
        {
            isMove = value;
        }
    }

   
    // Start is called before the first frame update
    void Start()
    {

    }

    private Vector3 pos;
    
    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.x = Mathf.Clamp(pos.x, clampMin.x, clampMax.x);
            pos.y = Mathf.Clamp(pos.y, clampMin.y, clampMax.y);
            pos.z = transform.position.z;

            transform.position = pos;

           
        }
        else
        {

        }
    }
}
