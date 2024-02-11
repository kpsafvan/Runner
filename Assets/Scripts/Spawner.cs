using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Obstacle_1;
    public GameObject Obstacle_2;
    public float time = 0f;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        if(time>1){ 
            time=0; 
            int spawnPoint = Random.Range(0, 8);
            time = 0; 
            float spawnX = 0f;
            float spawnZ = -10f; 
            switch (spawnPoint)
            {
                case 0:
                    spawnX = -5f;
                    break;
                case 1:
                    spawnX = 0f;
                    break;
                case 2:
                    spawnX = 5f;
                    break;
                case 3:
                    spawnZ = -5f;
                    break;
                case 4:
                    spawnZ = 0f;
                    break;
                case 5:
                    spawnZ = 5f;
                    break;
                case 6:
                    spawnX = -5f;
                    spawnZ = -5f;
                    break;
                case 7:
                    spawnX = 5f;
                    spawnZ = -5f;
                    break;
            }
            Instantiate(Obstacle_1, new Vector3(spawnX,1f,spawnZ),  Quaternion.Euler(0, 0, 0)); 
        }
    }
}
