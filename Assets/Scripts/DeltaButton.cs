using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeltaButton : MonoBehaviour
{
    [SerializeField] private float _delta;
    [SerializeField] private Text _buttonText;
    [SerializeField] private ChangeSliderValue _changeSliderValue;

    public void OnClicked()
    {
        _changeSliderValue.ChangeValue(_delta);
    }

    private void Awake()
    {
        _buttonText.text = (_delta > 0 ? "+" : "") + _delta;
    }
}
