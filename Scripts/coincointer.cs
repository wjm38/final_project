using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coincointer : MonoBehaviour
{
    Text coinText;
    public static int coinAmount;
    void Start ()
    {
        coinText = GetComponent<Text>();
    }
    void Update()
    {
        coinText.text = coinAmount.ToString();
    }
}
