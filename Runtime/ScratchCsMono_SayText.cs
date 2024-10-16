using System.Collections;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/18
/// https://github.com/EloiStree/HelloScratchToUnity/issues/20
/// </summary>
public class ScratchCsMono_SayText : MonoBehaviour
{
    public string m_textToSay;
    public UnityEvent<string> m_onTextEmitted;
    public bool m_useDebugLog = false;

    [ContextMenu("Say Text")]

    public void SayText()
    {
        if (m_useDebugLog)
            Debug.Log(m_textToSay);
        m_onTextEmitted.Invoke(m_textToSay);

    }
}


/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/31
/// </summary>
public class ScratchCsMono_Hide : MonoBehaviour {

    public GameObject m_toAffect;
    public void Reset()
    {
        m_toAffect = gameObject;
    }
    public void Hide()
    {
        m_toAffect.SetActive(false);
    }
}

/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/30
/// </summary>
public class ScratchCsMono_Show : MonoBehaviour
{
    public GameObject m_toAffect;
    public void Reset()
    {
        m_toAffect = gameObject;
    }
    public void Show()
    {
        m_toAffect.SetActive(true);
    }
}



/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/56
/// </summary>
public class ScratchCsMono_Forever : MonoBehaviour
{
    public UnityEvent m_actionToDo;

    public Coroutine m_coroutine;
    [ContextMenu("Start Forever")]
    public void StartForever()
    {
        if(m_coroutine!=null)
            StopCoroutine(m_coroutine);
        m_coroutine = StartCoroutine(Coroutine_Forever());
    }
    public IEnumerator Coroutine_Forever()
    {
        while (true)
        {
            m_actionToDo.Invoke();
            yield return new WaitForEndOfFrame();
        }
    }
}







