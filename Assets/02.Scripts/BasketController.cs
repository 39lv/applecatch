using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{

    public AudioClip appleSE;   // 사과 효과음
    public AudioClip bombSE;    // 폭탄 효과음
    AudioSource aud;   // 소리를 관리할 Audiosource 컴포넌트
    public GameObject GameManager;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            GameManager.GetComponent<GameManager>().GetApple();
            //Debug.Log("Tag : Apple");
            aud.PlayOneShot(appleSE);
        }
        else
        {
            GameManager.GetComponent<GameManager>().GetBomb();
            //Debug.Log("Tag : Bomb");
            aud.PlayOneShot(bombSE);
        }
        Destroy(other.gameObject);
    }
}
