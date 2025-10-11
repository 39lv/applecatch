using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float dropSpeed;

    void Update()
    {
        transform.Translate(0, dropSpeed, 0);

        if(transform.position.y < -1f)
        {
            Destroy(gameObject);
        }
    }
}
