using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 0.3f;
    float delta = 0f;
    public int ratio = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            delta = 0f;
            GameObject item;
            int dice = Random.Range(1, 11);
            if(dice <= ratio)
            {
                item = Instantiate(applePrefab);
            }
            else
            {
                item = Instantiate(bombPrefab);
            }
                
            int x = Random.Range(-1, 2);
            int z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 4, z);
        }
    }
}
