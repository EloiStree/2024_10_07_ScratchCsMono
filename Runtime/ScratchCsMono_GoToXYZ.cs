using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/5
/// </summary>
public class ScratchCsMono_GoToXYZ : MonoBehaviour { 

    public Transform m_whatToMove;
    public Vector3 m_position = Vector3.zero;
    public Space m_space = Space.World;
    private void Reset()
    {
        m_whatToMove = transform;
    }

    [ContextMenu("Go To Position")]
    public void GoToPosition()
    {
        if(m_space == Space.World)  
            m_whatToMove.position = m_position;
        else 
            m_whatToMove.localPosition = m_position;

    }
}
