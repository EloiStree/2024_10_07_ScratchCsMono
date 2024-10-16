using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/6
/// </summary>
public class ScratchCsMono_PointInDirectionEuler : MonoBehaviour { 

    public Transform m_whatToMove;
    public Vector3 m_eulerAngle = Vector3.zero;
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
            m_whatToMove.rotation = Quaternion.Euler(m_eulerAngle);
            
        }
        else
        {
            m_whatToMove.localRotation = Quaternion.Euler(m_eulerAngle);
        }
    }

}
