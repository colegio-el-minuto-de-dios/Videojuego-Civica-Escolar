using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ThirdPersonCamera : MonoBehaviour {
    [SerializeField]
    private Vector2 cameraSensitivity = Vector2.one;
 
    [SerializeField]
    private float zoomSensitivity = 10.0f;
 
    [SerializeField]
    private float pitchClamp = 85.0f;
 
    [SerializeField]
    private Vector2 zoomClamp = new Vector2(0.5f, 25.0f);
 
    [SerializeField]
    private float zoomDamp = 0.05f;
 
    [SerializeField]
    private float cameraRadius = 0.5f;
 
    private float pitch = 0.0f, yaw = 0.0f;
    private float targetZoom = 5.0f, zoom = 5.0f;
    private float zoomVelocity = 0.0f;
 
    private void Update()
    {
        Rotate();
        Zoom();
    }
 
    private void Rotate()
    {
        if (Input.GetMouseButton(1))
        {
            pitch -= Input.GetAxis("Mouse Y") * cameraSensitivity.y;
            yaw += Input.GetAxis("Mouse X") * cameraSensitivity.x;
        }
        pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp);
        transform.parent.rotation = Quaternion.Euler(pitch, yaw, 0.0f);
    }
 
    private void Zoom()
    {
        targetZoom += Input.GetAxis("Mouse ScrollWheel") * zoomSensitivity;
        targetZoom = Mathf.Clamp(targetZoom, zoomClamp.x, zoomClamp.y);
 
        Ray ray = new Ray(transform.parent.position, -transform.parent.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, targetZoom))
        {
            zoom = Mathf.SmoothDamp(zoom, hit.distance, ref zoomVelocity, zoomDamp);
            zoom -= cameraRadius;
        }
        else
        {
            zoom = Mathf.SmoothDamp(zoom, targetZoom, ref zoomVelocity, zoomDamp);
        }
        zoom = Mathf.Clamp(zoom, zoomClamp.x, zoomClamp.y);
        transform.localPosition = Vector3.back * zoom;
 
    }
}