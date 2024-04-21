using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterBarManager : MonoBehaviour
{
    [SerializeField] Image _image;
    int maxHealth = 10;
    int _healthToRemove = 2;
    [SerializeField] AnimationCurve _tweenCurve;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            print("connard");
            OnHealthChanged(maxHealth - _healthToRemove);
            _healthToRemove += 2;
        }
    }

    void OnHealthChanged(int newHealth)
    {
        float targetFillAmount = Mathf.InverseLerp(0, maxHealth, newHealth);
        _image.DOFillAmount(targetFillAmount, 1).SetEase(_tweenCurve);
        print(_image.fillAmount);
    }
}
