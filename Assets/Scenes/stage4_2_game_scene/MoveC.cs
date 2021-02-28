using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveC : MonoBehaviour
{
    private float camHalfWidth;
    private float camHalfHeight;

    private Vector2 minBound;
    private Vector2 maxBound;

    private Camera cam;

    public BoxCollider2D box2d;

    void Start()
    {
        camHalfHeight = cam.orthographicSize;
        camHalfWidth = camHalfHeight * Screen.width / Screen.height;
        cam = GetComponent<Camera>();

        minBound = box2d.bounds.min;
        maxBound = box2d.bounds.max;
    }

    void Update()
    {
      
        float clampX = Mathf.Clamp(transform.position.x, minBound.x + camHalfWidth, maxBound.x - camHalfWidth);
        float clampY = Mathf.Clamp(transform.position.y, minBound.y + camHalfHeight, maxBound.y - camHalfHeight);

        this.transform.position = new Vector3(clampX, clampY, this.transform.position.z);
    }

}
