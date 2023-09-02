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
        if (gameObject.CompareTag("Red") && frameNumber == 100)
        {
            gameObject.SetActive(false); 
        }

        if (gameObject.CompareTag("Blue") && frameNumber == Random.Range(150, 251))
        {
            Renderer rend = GetComponent<Renderer>();
            if (rend != null)
            {
                rend.enabled = false;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        frameNumber++;
        Debug.Log(gameObject.name + ":" + frameNumber);
    }
}
