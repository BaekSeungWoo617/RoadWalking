using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 10f; // 차량의 속도
    Vector3 direction = new Vector3(0,0,-1);
    // 매 프레임마다 호출되는 함수
    void Update()
    {
        // 차량을 일정 속도로 앞으로 이동시킴
        transform.Translate(direction * speed * Time.deltaTime);
        if(this.transform.position.z <-20)
        {
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.life -= 1;
            GameManager.instance.CheakGameOver();

        }
    }
}
