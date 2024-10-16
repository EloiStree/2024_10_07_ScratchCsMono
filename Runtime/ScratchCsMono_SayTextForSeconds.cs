using System.Collections;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// https://github.com/EloiStree/HelloScratchToUnity/issues/17
/// https://github.com/EloiStree/HelloScratchToUnity/issues/19
/// </summary>
public class ScratchCsMono_SayTextForSeconds : MonoBehaviour
{
    public string m_textToSay;
    public float m_secondsToSay;
    public UnityEvent<string> m_onTextEmitted;
    public bool m_useDebugLog = false;

    [ContextMenu("Say Text for seconds")]
    public void SayTextForSeconds()
    {
        StartCoroutine(Coroutine_SayTextForSeconds());
    }
    public IEnumerator Coroutine_SayTextForSeconds()
    {

        if (m_useDebugLog)
            Debug.Log(m_textToSay);
        m_onTextEmitted.Invoke(m_textToSay);
        yield return new WaitForSeconds(m_secondsToSay);

        m_onTextEmitted.Invoke("");
    }
}





