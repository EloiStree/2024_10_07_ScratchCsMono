using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/8
/// </summary>
public class Scratch_PointTowardMousePosition : MonoBehaviour
{

    public Transform m_whatToTurn;
    public Vector2 m_screenPosition;
    public Camera m_camera;
    public Vector3 m_eulerAdjustment;


    private void Reset()
    {
        m_whatToTurn = transform;
        m_camera = Camera.main;
    }
    public void SetScreenPosition(Vector2 screenPosition)
    {
        m_screenPosition = screenPosition;
    }

    [ContextMenu("Point Toward Mouse Position")]
    public void PointTowardMousePosition() { 
    
        if (m_camera == null)
            m_camera = Camera.main;
        if (m_camera == null)
            return;
        if (m_whatToTurn == null)
            m_whatToTurn = transform;

        Vector3 mouseWorldPosition = m_camera.ScreenToWorldPoint(new Vector3(m_screenPosition.x, m_screenPosition.y, m_camera.nearClipPlane));
        Vector3 direction = mouseWorldPosition - m_whatToTurn.position;
        m_whatToTurn.rotation = Quaternion.LookRotation(direction, Vector3.up);
        m_whatToTurn.Rotate(m_eulerAdjustment);

        Debug.DrawLine(m_whatToTurn.position, mouseWorldPosition, Color.red, 0.1f);
    }
}


