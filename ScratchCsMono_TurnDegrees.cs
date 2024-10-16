using UnityEngine;

/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/3
/// </summary>
public class ScratchCsMono_TurnDegrees : MonoBehaviour { 

    public Transform m_whatToTurn;
    public float m_degrees = 15;
    public Space m_space = Space.World;
    private void Reset()
    {
        m_whatToTurn = transform;    
    }
    [ContextMenu("Turn Left")]
    public void TurnLeft()
    {
        m_whatToTurn.Rotate(Vector3.up, -m_degrees, m_space);
    }
    [ContextMenu("Turn Right")]
    public void TurnRight()
    {
        m_whatToTurn.Rotate(Vector3.up, m_degrees, m_space);
    }

    [ContextMenu("Turn Up")]
    public void TurnUp()
    {
        m_whatToTurn.Rotate(Vector3.right, -m_degrees, m_space);
    }
    [ContextMenu("Turn Down")]
    public void TurnDown()
    {
        m_whatToTurn.Rotate(Vector3.right, m_degrees, m_space);
    }
    [ContextMenu("Turn Front Z Clockwise")]
    public void TurnClockwise()
    {
        m_whatToTurn.Rotate(Vector3.forward, -m_degrees, m_space);
    }
    [ContextMenu("Turn Front Z CounterClockwise")]
    public void TurnCounterClockwise()
    {
        m_whatToTurn.Rotate(Vector3.forward, m_degrees, m_space);
    }

}
