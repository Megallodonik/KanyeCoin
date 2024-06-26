using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    [SerializeField] GameObject MainObj;
    [SerializeField] GameObject ShopScreen;
    [SerializeField] GameObject WhiteHoodieSoldOut;
    [SerializeField] GameObject WhiteHoodie;
    Main MainScr;
    [SerializeField] bool isWhiteHoodie = false;
    void Start()
    {
        MainScr = MainObj.GetComponent<Main>();
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
    public void white_hoodie()
    {
        if (MainScr.count >= 300 && isWhiteHoodie == false)
        {
            MainScr.count -= 300;
            MainScr.countper_sec += 100;
            isWhiteHoodie = true;
            WhiteHoodieSoldOut.SetActive(true);
            WhiteHoodie.SetActive(false);
        }
    }
}
