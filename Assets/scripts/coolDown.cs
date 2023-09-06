using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coolDown : MonoBehaviour
{
    public TMP_Text TemperatureText;
    public int currentTemp;

    // Start is called before the first frame update
    void Start()
    {
        //UpdateTemperatureText();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateTemperatureText();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            currentTemp--;
            UpdateTemperatureText();
        }
    }


    void UpdateTemperatureText()
    {
        string tempString = currentTemp.ToString();
        TemperatureText.text = tempString;
    }
}