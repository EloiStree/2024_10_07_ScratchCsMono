using UnityEngine;

/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/4
/// </summary>
public class ScratchCsMono_GoToRandomPosition : MonoBehaviour
{
    public Transform m_whatToMove;
    public AbstractRandomPositionMono m_randomPosition;
    

    private void Reset()
    {
        m_whatToMove = transform;
    }

    [ContextMenu("Go To Random Position")]
    public void GoToRandomPosition()
    {
        m_whatToMove.position = m_randomPosition.GetRandomPosition();
    }
}


