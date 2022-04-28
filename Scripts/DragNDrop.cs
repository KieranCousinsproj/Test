using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
    private Vector3 _dragOffset;
    private Camera _cam;

    [SerializeField] private float _speed;

    void Awake()
    {
        _cam = Camera.main;
    }

    void OnMouseDown()
    {
        Debug.Log(GetMousePos());
        _dragOffset = transform.position - GetMousePos();
    }

    void OnMouseDrag()
    {
        Debug.Log(GetMousePos());
        transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + _dragOffset, _speed * Time.deltaTime);
    }

    Vector3 GetMousePos()
    {
        Debug.Log(Input.mousePosition);
        Vector3 screenPosDepth = Input.mousePosition;
        // Give it a depth. Maybe a raycast depth, maybe a clipping plane...
        screenPosDepth.z = 697.78f;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(screenPosDepth);
        mousePos.z = 0;
        return mousePos;
    }
}
