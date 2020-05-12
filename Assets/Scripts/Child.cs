using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class Child : MonoBehaviour
{

    private bool move = false;
    private int speed, decisions, counter;
    private float attraction;

    private Transform target;
    private Vector2 current;

    // Getters
    public float getAttraction()
    {
        return attraction;
    }

    // Setters
    public void SetMove(bool mov)
    {
        move = mov;
    }

    // Start is called before the first frame update
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("attractor").GetComponent<Transform>();
        speed = Random.Range(3, 6);
        decisions = Random.Range(300, 500);
        attraction = Random.Range((float).4, (float).8);
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float distance;

        Vector2 movement = movement = new Vector2(
            transform.position.x + (Random.Range(-1, 2) * 1000),
            transform.position.y + (Random.Range(-1, 2) * 1000));

        if (move){
            if (counter % decisions != 0)
            {
                movement = current;
            }
            else if ((Random.Range((float)0, (float)1) <= attraction) && (counter >= 3 * decisions))
            {
                movement = target.position;
            }

            distance = speed * Time.deltaTime;
        }
        else
        {
            movement = transform.position;
            distance = 0 * Time.deltaTime;
	    }

        transform.position = Vector2.MoveTowards(transform.position, movement, distance);
        current = movement;

        counter++;
        if (counter == 1000 * decisions)
        {
            counter = 3 * decisions;
        }
    }
}
