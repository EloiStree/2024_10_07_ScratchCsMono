using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/36
/// </summary>
public class ScratchCsMono_SizeFromX: ScratchCsMono_TransformFloatValue
{
    public override void GetValueCode(out float value)
    {
        if(Space==Space.World)
            value = m_whatToObserve.lossyScale.x;
        else
            value = m_whatToObserve.localScale.x;

    }
   
}



