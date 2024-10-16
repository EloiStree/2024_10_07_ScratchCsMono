using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/16
/// </summary>
public class ScratchCsMono_DirectionY: ScratchCsMono_TransformFloatValue
{
    
    public override void GetValueCode(out float value)
    {

        if (Space == Space.World || m_whatToObserve.parent==null) { 
            Vector3 dir = m_whatToObserve.forward;
            dir.y = 0;
            value = Vector3.SignedAngle(Vector3.forward, dir, Vector3.up);
        }
        else
        {
            Vector3 dir = m_whatToObserve.forward;
            dir = Quaternion.Inverse(m_whatToObserve.parent.rotation) * dir;
            dir.y = 0;
            value = Vector3.SignedAngle(Vector3.forward, dir, Vector3.up);
        }

    }
}



