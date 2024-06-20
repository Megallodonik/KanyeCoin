using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] GameObject Main;
    [SerializeField] GameObject ShopScreen;

    void Start()
    {
        
    }
    public void OpenShop()
    {
        ShopScreen.SetActive(true);
    }
    public void CloseShop()
    {
        ShopScreen.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
