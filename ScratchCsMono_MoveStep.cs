using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;


/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/2
/// </summary>
public class ScratchCsMono_MoveStep : MonoBehaviour
{
    public Transform m_whatToMove;
    public float m_step = 1;
    public Space m_space = Space.World;
    private void Reset()
    {
        m_whatToMove = transform;
    }

    [ContextMenu("Move Forward")]
    public void MoveForward()
    {
        m_whatToMove.Translate(Vector3.forward * m_step, m_space);
    }
    [ContextMenu("Move Backward")]
    public void MoveBackward()
    {
        m_whatToMove.Translate(Vector3.back * m_step, m_space);
    }
    [ContextMenu("Move Left")]
    public void MoveLeft()
    {
        m_whatToMove.Translate(Vector3.left * m_step, m_space);
    }
    [ContextMenu("Move Right")]
    public void MoveRight()
    {
        m_whatToMove.Translate(Vector3.right * m_step, m_space);
    }
    [ContextMenu("Move Up")]
    public void MoveUp()
    {
        m_whatToMove.Translate(Vector3.up * m_step, m_space);
    }
    [ContextMenu("Move Down")]
    public void MoveDown()
    {
        m_whatToMove.Translate(Vector3.down * m_step, m_space);
    }
}
