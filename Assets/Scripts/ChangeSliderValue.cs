using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ChangeSliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Image _fillImage;
    [SerializeField] private Color _fullColor;
    [SerializeField] private Color _emptyColor;

    public void ChangeValue(float delta)
    {
        float newValue = Mathf.Max(_slider.minValue, Mathf.Min(_slider.maxValue, _slider.value + delta));

        _slider.DOValue(newValue, 0.3f).SetEase(Ease.OutBack);
        _fillImage.DOColor(Color.Lerp(_emptyColor, _fullColor, (newValue - _slider.minValue) / (_slider.maxValue - _slider.minValue)), 0.3f);
    }
}
