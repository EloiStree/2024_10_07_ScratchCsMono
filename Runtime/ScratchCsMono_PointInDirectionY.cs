using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/6
/// </summary>
public class ScratchCsMono_PointInDirectionY: MonoBehaviour
{
    public Transform m_whatToMove;
    public float m_angle = 0;
    public Space m_space = Space.World;

    private void Reset()
    {
        m_whatToMove = transform;
    }

    [ContextMenu("Point In Direction")]
    public void PointInDirection()
    {
        if (m_space== Space.World)
        {
            m_whatToMove.rotation = Quaternion.Euler(0, m_angle, 0);
            
        }
        else
        {
            m_whatToMove.localRotation = Quaternion.Euler(0, m_angle, 0);
        }
    }
}
