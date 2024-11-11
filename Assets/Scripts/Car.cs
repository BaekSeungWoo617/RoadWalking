using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public ObjectPool carPool;

    void OnCollisionEnter(Collision collision)
    {
        // 총알이 다른 오브젝트와 충돌하면 총알을 비활성화하고 풀로 반환
        carPool.ReturnObject(gameObject);
    }
}
