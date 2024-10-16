using UnityEngine;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/36
/// </summary>
public class ScratchCsMono_SizeTwoPoint: ScratchCsMono_AbstractGenericValueFetchMono<float>
{

    public Transform m_from;
    public Transform m_to;

    private void Reset()
    {
        m_from = transform;
        m_to = transform;
    }



    public override void GetValueCode(out float value)
    {
        value = Vector3.Distance(m_from.position, m_to.position);
    }
}



