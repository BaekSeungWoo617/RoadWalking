using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public ObjectPool carPool;

    void OnCollisionEnter(Collision collision)
    {
        // �Ѿ��� �ٸ� ������Ʈ�� �浹�ϸ� �Ѿ��� ��Ȱ��ȭ�ϰ� Ǯ�� ��ȯ
        carPool.ReturnObject(gameObject);
    }
}
