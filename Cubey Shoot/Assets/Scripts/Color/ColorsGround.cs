using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsGround : MonoBehaviour
{

    public Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", Color.green);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
