using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReplaceText : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {

        }
    }
}
