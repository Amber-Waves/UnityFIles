using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class Child : MonoBehaviour
{

    public int speed;

    public bool move = false;

    private Transform target;


    // Start is called before the first frame update
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("attractor").GetComponent<Transform>();
        speed = Random.Range(1, 6);
    }

    
    public void SetMove(bool mov)
    {
        move = mov;
    }
    // Update is called once per frame
    void Update()
    {
        if (move){
            
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); 
        }
       else {
            transform.position = Vector2.MoveTowards(transform.position, target.position, 0 * Time.deltaTime);
	    }
    }


}
