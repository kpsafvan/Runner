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
        if(time>2){
            x=Random.Range(0,2);
            time=0;
            if(x==0){
            Instantiate(Obstacle_1, new Vector3(0f,20f,-10),  Quaternion.Euler(0, 0, 90));
            }
            else{
            Instantiate(Obstacle_2, new Vector3(0f,20f,-10),  Quaternion.Euler(0, 0, 90));
            }

        }
    }
}
