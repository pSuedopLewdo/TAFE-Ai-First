using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InBasket : MonoBehaviour
{
    public Text basketText;
    public int basketScore;

    void Start()
    {
        basketScore = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        basketScore++;
    }

    void Update()
    {
        basketText.text = ("Basket Score: " + basketScore);
    }
}
