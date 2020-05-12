using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    private float attraction;

    // Getters
    public float getAttraction()
    {
        return attraction;
    }

    // Setters
    public void setAttractor(Sprite sprite, float attract)
    {

        this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
        attraction = attract;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
