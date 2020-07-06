using UnityEngine;
using UnityEngine.UI;
using System;
public class AngleUpdate : MonoBehaviour
{
    public Transform solarPanel;
    public Text scoreText;

    void Update()
    {
        scoreText.text = Math.Round(solarPanel.eulerAngles.x).ToString();
    }

}
