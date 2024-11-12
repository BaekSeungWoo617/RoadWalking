using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // 생성할 오브젝트들의 Prefab (리소스 폴더에서 불러오기)
    private GameObject ambulPrefab;
    private GameObject treePrefab;
    private GameObject roadPrefab;
    private GameObject grassPrefab;

    private void Awake()
    {
        // Resources 폴더에서 Prefab을 동적으로 불러오기
        ambulPrefab = Resources.Load<GameObject>("Prefabs/Ambulance");
        treePrefab = Resources.Load<GameObject>("Prefabs/Tree");
        roadPrefab = Resources.Load<GameObject>("Prefabs/Road");
        grassPrefab = Resources.Load<GameObject>("Prefabs/Grass");
        
    }
    void Start()
    {
        for(int i=0;i<10;i++)
        {
            for (int j=0;j<10;j++)
            {
                SpawnObject(roadPrefab, new Vector3(20 * i, 0, 20 * j));

            }
        }
    }

    // 자동차 생성
    void SpawnObject(GameObject gamePrefab, Vector3 position)
    {
        if (gamePrefab != null)
        {
            GameObject thisPrefab = Instantiate(gamePrefab, position, Quaternion.identity);
            GameManager.instance.carObjects.Add(thisPrefab);  // 생성된 자동차를 리스트에 추가
        }
    }
}
