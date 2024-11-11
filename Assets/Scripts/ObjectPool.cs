using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // 풀에 저장할 오브젝트의 기본 Prefab
    public GameObject objectPrefab;

    // 풀에 보관할 오브젝트의 리스트
    private List<GameObject> objectPool = new List<GameObject>();

    // 오브젝트 풀의 초기 크기
    public int initialPoolSize = 10;

    // 오브젝트를 활성화하여 반환하는 함수
    public GameObject GetObject()
    {
        // 풀에 반환 가능한 오브젝트가 있다면 그 오브젝트를 반환
        foreach (var obj in objectPool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        // 풀에 반환 가능한 오브젝트가 없다면, 새로운 오브젝트를 생성하여 반환
        GameObject newObject = Instantiate(objectPrefab);
        objectPool.Add(newObject);
        return newObject;
    }

    // 오브젝트를 비활성화하여 풀에 반환하는 함수
    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    // 풀의 초기화
    private void Start()
    {
        // 미리 오브젝트를 풀에 초기화
        for (int i = 0; i < initialPoolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false); // 초기에는 비활성화 상태로 풀에 추가
            objectPool.Add(obj);
        }
    }
}