using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] AudioClip mi2;
    [SerializeField] TMP_Text count_Txt;
    [SerializeField] GameObject CanyeBut;
    [SerializeField] TMP_Text countPerSec_Txt;
    [SerializeField] public int count;
    [SerializeField] public int countper_sec;
    // Start is called before the first frame update
    void Start()
    {
        startcount();
        Debug.Log("start");
    }

    void startcount()
    {
        StartCoroutine(Counter());
    }
    void Update()
    {
        count_Txt.text = count.ToString();
        countPerSec_Txt.text = countper_sec.ToString();
        Debug.Log(count);
    }
    IEnumerator Counter()
    {
        Debug.Log("корутина");
        count += countper_sec;
        if (count >= 200)
        {
            CanyeBut.GetComponent<AudioSource>().clip = mi2;
        }
        yield return new WaitForSeconds(1);
        startcount();
    }
}
