using UnityEngine;

public abstract class ScratchCsMono_AbstractGenericValueFetchMono<T> : MonoBehaviour
{
    public T m_lastValueFetch;

    public void GetValue(out T value)
    {
        GetValueCode(out value);
        m_lastValueFetch = value;
    }
    public abstract void GetValueCode(out T value);

}

public class ScratchCsMono_DisplayFetchValue<T> : MonoBehaviour
{ 

    public ScratchCsMono_AbstractGenericValueFetchMono<T> m_whatToFetch;
    public T m_lastValueFetch;

    public void GetValue(out T value)
    {
        m_whatToFetch.GetValue(out value);
        m_lastValueFetch = value;
    }
    public void GetValueCode(out T value)
    {
        m_whatToFetch.GetValueCode(out value);
        m_lastValueFetch = value;
    }

    public void RefreshValue() { 
    
        GetValue(out m_lastValueFetch);
    }
    public void Update()
    {
        RefreshValue();
    }
    
}



