using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMove : MonoBehaviour
{
    private RectTransform _rt;
    private float         _timer;
    public  float         _speed = 1f;

    void Start()
    {
        _rt = (RectTransform) transform;
    }

    void Update()
    {
        var angle = 2f * Mathf.PI * _timer * _speed;
        _rt.anchoredPosition =  new Vector2(10f * Mathf.Cos(angle), 10f * Mathf.Sin(angle));
        _timer               = Mathf.Repeat(_timer +Time.deltaTime, 1f);
        
    }
}