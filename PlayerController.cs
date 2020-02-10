using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int count;
    private int countGoods;
    public Text countText;
    public Text winText;

    public ChuckMainInstance inst;

    private void SetCountText()
    {
        countText.text = "Points: " + count.ToString();
        if(countGoods == 13)
        {
            winText.text = "You win with: " + count.ToString();
        }
    }

    private void Start()
    {
        count = 0;
        countGoods = 0;
        SetCountText();
        winText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("good"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            countGoods += 1;
            inst.RunFile("pickup.ck");
        }
        else if (other.gameObject.CompareTag("bad"))
        {
            other.gameObject.SetActive(false);
            count -= 1;
        }
        SetCountText();
    }
}