using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // 생성된 오브젝트들을 추적할 리스트
    public List<GameObject> roadObjects = new List<GameObject>();
    public List<GameObject> treeObjects = new List<GameObject>();
    public List<GameObject> carObjects = new List<GameObject>();

    public Vector3 playerStartPosition = new Vector3(0f, 1f, 0f);


    void Awake()
    {
        if (instance == null) // 싱글턴 설정
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject); // 중복된 인스턴스를 삭제
            return;
        }

        // 플레이어 오브젝트 생성
        CreatePlayer();
    }

    // 플레이어 생성 함수
    void CreatePlayer()
    {
        // Resources 폴더에서 Player 프리팹 로드
        GameObject playerPrefab = Resources.Load<GameObject>("Prefabs/Player");

        // 프리팹이 로드되었는지 확인
        if (playerPrefab != null)
        {
            // 플레이어 오브젝트를 동적으로 생성
            Instantiate(playerPrefab, playerStartPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Player Prefab is not found in Resources/Prefabs folder!");
        }
    }
}
