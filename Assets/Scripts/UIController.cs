using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIController : MonoBehaviour
{
    [System.Serializable]
    public class StringEvent : UnityEvent<string> { }
    public StringEvent OnCurrentSpeedTextChanged;


    private void OnEnable()
    {
        Player.OnCurrentSpeedChanged += Player_OnCurrentSpeedChanged;
    }

    private void OnDisable()
    {
        Player.OnCurrentSpeedChanged -= Player_OnCurrentSpeedChanged;
    }


    private void Player_OnCurrentSpeedChanged(float obj)
    {
        OnCurrentSpeedTextChanged?.Invoke(obj.ToString("F2"));
    }

}
