using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canye_but : MonoBehaviour
{
    [SerializeField] GameObject Main;
   
    [SerializeField] public AudioSource Source;
    void Start()
    {
        
    }

    public void Canye()
    {
        Main.GetComponent<Main>().count += 1;
        Source.Play();
    }
    void Update()
    {
        
    }
}
