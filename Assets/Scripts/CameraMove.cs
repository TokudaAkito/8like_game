using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] float _scrolls;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        var scroll = Input.mouseScrollDelta.y;
        _camera.transform.position += -_camera.transform.up * scroll * _scrolls; 
    }
}
