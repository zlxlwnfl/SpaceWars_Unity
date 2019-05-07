using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bose1_spawn : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject EnemyObject; //Prefab을 받을 public 변수 입니다.
    int i = 0;

    void SpawnEnemy()
    {

        if (i <15)
        {
            if(i==11)
            {
                if (enableSpawn)
                {
                    GameObject enemy = (GameObject)Instantiate(EnemyObject, new Vector3(0f, 7f, 0f), Quaternion.identity); //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
                }
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
