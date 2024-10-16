using UnityEditor.Experimental.GraphView;
using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/15
/// </summary>
public class ScratchCsMono_WorldPositionZ: ScratchCsMono_TransformFloatValue
{
    public override void GetValueCode(out float value)
    {
        if(Space == Space.World)
            value = m_whatToObserve.position.z;
        else
            value = m_whatToObserve.localPosition.z;
    }
}



