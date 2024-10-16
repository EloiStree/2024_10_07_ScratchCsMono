using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/9
/// </summary>
public class ScratchCsMono_ChangeOfXYZ : MonoBehaviour
{
    public Transform m_whatToMove;
    public float m_step = 1;
    public Space m_space = Space.World;
    public Axis m_axis = Axis.X;
    public enum Axis
    {
        X,
        Y,
        Z
    }


    private void Reset()
    {
        m_whatToMove = transform;
    }

    public void ChangeOfXYZ()
    {
        Vector3 step = Vector3.zero;
        switch (m_axis)
        {
            case Axis.X:
                step = Vector3.right * m_step;
                break;
            case Axis.Y:
                step = Vector3.up * m_step;
                break;
            case Axis.Z:
                step = Vector3.forward * m_step;
                break;
        }
        m_whatToMove.Translate(step, m_space);
    }

}


/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/9
/// </summary>
public class ScratchCsMono_SetOfXYZ : MonoBehaviour
{
    public Transform m_whatToMove;
    public float m_step = 1;
    public Space m_space = Space.World;
    public Axis m_axis = Axis.X;
    public enum Axis
    {
        X,
        Y,
        Z
    }



    private void Reset()
    {
        m_whatToMove = transform;
    }

    public void SetOfXYZ() { 
    
        Vector3 step = Vector3.zero;
        switch (m_axis)
        {
            case Axis.X:
                step = Vector3.right * m_step;
                break;
            case Axis.Y:
                step = Vector3.up * m_step;
                break;
            case Axis.Z:
                step = Vector3.forward * m_step;
                break;
        }
        if(m_space == Space.World)
            m_whatToMove.position = step;
        else
            m_whatToMove.localPosition = step;
    }

}
