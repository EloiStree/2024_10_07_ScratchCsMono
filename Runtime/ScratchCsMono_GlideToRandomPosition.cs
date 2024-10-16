using System;
using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/6
/// </summary>
public class ScratchCsMono_GlideToRandomPosition : MonoBehaviour
{
    public AbstractRandomPositionMono m_randomPosition;
    public Vector3 m_goToPosition;

    public Transform m_whatToMove;
    public float m_duration = 1;

    public DateTime m_start;
    public DateTime m_end;
    public Vector3 m_startPosition;
    public Vector3 m_endPosition;
    public bool m_reach=true;

    [ContextMenu("Glide to random position")]
    public void GlideToRandomPosition()
    {
        m_goToPosition= m_randomPosition.GetRandomPosition();
        GlideToPosition();
    }

    [ContextMenu("Glide to position")]
    public void GlideToPosition() { 
    
        m_reach = false;
        m_startPosition = m_whatToMove.position;
        m_endPosition = m_goToPosition;
        m_start = DateTime.Now;
        m_end = m_start.AddSeconds(m_duration);
    }

    public void Update()
    {
        if (m_reach)
            return;
        if (m_start == null || m_end == null)
            return;

        if (DateTime.Now > m_end)
        {
            m_reach = true;
            m_whatToMove.position = m_endPosition;
            return;
        }

        float ratio = (float)(DateTime.Now - m_start).TotalSeconds / m_duration;
        m_whatToMove.position = Vector3.Lerp(m_startPosition, m_endPosition, Mathf.Clamp01(ratio));
        
    }
}
