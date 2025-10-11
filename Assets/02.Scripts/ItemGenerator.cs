using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;   // 스폰되는 시간
    float delta = 0f;
    public int ratio = 2;  // 2는 20%를 나타냄.
    float speed = -0.03f;  // 떨어지는 스피드값

    public void SetParameter(float span, float speed, int ratio)
    {
        this.span = span;
        this.speed = speed;
        this.ratio = ratio;
    }

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0f;
            GameObject item;
            int dice = Random.Range(1, 11);
            if (dice <= ratio)
            {
                item = Instantiate(bombPrefab);
            }
            else
            {
                item = Instantiate(applePrefab);
            }

            int x = Random.Range(-1, 2);
            int z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x,4,z);
            item.GetComponent<ItemController>().dropSpeed = speed;
        }
    }

}
