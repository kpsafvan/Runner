using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_1 : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //target.transform.position =  new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime;
        transform.position= Vector3.MoveTowards(transform.position,target.position,step);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("VanishObject"))
        {
            // Destroy the collided object
            Destroy(gameObject);
        }
    }
}
