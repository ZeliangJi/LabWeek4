using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj; 

   
    void Start()
    {
       
        Vector3 redPosition = new Vector3(2f, 0f, 0f);
        Quaternion redRotation = Quaternion.identity;
        Instantiate(redObj, redPosition, redRotation);

       
        Vector3 bluePosition = new Vector3(-2f, 0f, 0f);
        Quaternion blueRotation = Quaternion.identity;
        Instantiate(blueObj, bluePosition, blueRotation);

       
        Application.targetFrameRate = 60;
    }

  
    void Update()
    {
        
    }
}

