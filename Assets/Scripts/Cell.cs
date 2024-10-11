using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public static Cell Intance { get; set; }
    private TextMeshPro _textMeshPro;
    private void Awake()
    {
        Intance = this;
    }

    private void Start()
    {
        _textMeshPro = GetComponent<TextMeshPro>();
    }

    public Vector2 GetPosition()
    {
        return transform.position;
    }

    public void SetStep(int step)
    {
        _textMeshPro.text = step.ToString();
    }
}
