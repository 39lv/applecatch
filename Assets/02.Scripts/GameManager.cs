using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TimeText;
    public Text pointText;
    float time = 30f;
    int point = 0;

    GameObject generator;

    public void GetApple()
    {
        point += 100;
    }
    public void GetBomb()
    {
        point /= 2;
    }

    void Start()
    {

        generator = GameObject.Find("ItemGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if(this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<ItemGenerator>().SetParameter(10000f, 0, 0);
        }
        else if(0 <= this.time && this.time < 5)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.7f, -0.04f, 3);
        }
        else if (5 <= this.time && this.time < 12)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.5f, -0.05f, 6);
        }
        else if (12 <= this.time && this.time < 23)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.8f, -0.04f, 4);
        }
        else if (23 <= this.time && this.time < 30)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(1f, -0.03f, 2);
        }

        TimeText.GetComponent<Text>().text = time.ToString();
        pointText.text = point.ToString() + "point";
    }
}
