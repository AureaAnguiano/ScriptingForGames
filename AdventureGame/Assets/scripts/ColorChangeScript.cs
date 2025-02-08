using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    public Color newColor = Color.yellow;

    private void OnCollisionEnter(Collision collision)
    {
        //change the object's color upon callision with another GameObject
        GetComponent<Renderer>().material.color = newColor;

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
