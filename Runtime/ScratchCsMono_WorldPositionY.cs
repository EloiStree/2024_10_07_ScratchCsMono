using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/15
/// </summary>
public class ScratchCsMono_WorldPositionY : ScratchCsMono_TransformFloatValue
{
    public override void GetValueCode(out float value)
    {
        if(Space == Space.World)
            value = m_whatToObserve.position.y;
        else
            value = m_whatToObserve.localPosition.y;
    }
}




