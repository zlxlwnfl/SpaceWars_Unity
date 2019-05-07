using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ori_ene_spawn : MonoBehaviour {
    public bool enableSpawn = false;
    public GameObject EnemyObject; //Prefab을 받을 public 변수 입니다.
    int i = 0;

    void SpawnEnemy()
    {

        if (i < 10)
        {
            float randomX = Random.Range(-5f, 5f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
            if (enableSpawn)
            {
                GameObject enemy = (GameObject)Instantiate(EnemyObject, new Vector3(randomX, 7f, 0f), Quaternion.identity); //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
            }
            i++;
        }
    }
    void Start()
    {

        InvokeRepeating("SpawnEnemy", 1, 3); //3초후 부터, SpawnEnemy함수를 1초마다 반복해서 실행 시킵니다.

    }
    void Update()
    {

    }
}
