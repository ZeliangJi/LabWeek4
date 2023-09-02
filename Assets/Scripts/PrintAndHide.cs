using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int frameNumber = 3;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frameNumber++;
        Debug.Log(gameObject.name + ":" + frameNumber);
    }
}
