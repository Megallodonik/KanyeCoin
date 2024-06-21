using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canye_but : MonoBehaviour
{
    [SerializeField] GameObject MainObj;
   
    [SerializeField] public AudioSource Source;
    Main MainScr;
    void Start()
    {
         MainScr = MainObj.GetComponent<Main>();
    }

    public void Canye()
    {
        MainScr.count += 1;
        Source.Play();
    }

    void Update()
    {
        
    }
}
