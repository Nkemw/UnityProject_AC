using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSprite : MonoBehaviour
{
    [SerializeField] private float scrollspeed = 3f;

    [SerializeField] private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * scrollspeed * Time.deltaTime;

        if (transform.position.y < -12.6f)
        {
            transform.position = startPos;
        }
    }
}
