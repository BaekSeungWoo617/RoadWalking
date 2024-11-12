using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 10f; // ������ �ӵ�
    Vector3 direction = new Vector3(0,0,-1);
    // �� �����Ӹ��� ȣ��Ǵ� �Լ�
    void Update()
    {
        // ������ ���� �ӵ��� ������ �̵���Ŵ
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
