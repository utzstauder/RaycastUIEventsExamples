using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SpeedUIController : MonoBehaviour
{
    private Text textComponent;

    private void Awake()
    {
        textComponent = GetComponent<Text>();
        textComponent.text = "0.00";
    }

    private void OnEnable()
    {
        Player.OnCurrentSpeedChanged += Player_OnCurrentSpeedChanged;
    }

    private void OnDisable()
    {
        Player.OnCurrentSpeedChanged -= Player_OnCurrentSpeedChanged;
    }

    private void Player_OnCurrentSpeedChanged(float currentSpeed)
    {
        SetText(currentSpeed.ToString("F2", CultureInfo.CreateSpecificCulture("en-US")));
    }

    private void SetText(string text)
    {
        textComponent.text = text;
    }
}
