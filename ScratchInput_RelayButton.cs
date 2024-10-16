using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ScratchInput_RelayButton : MonoBehaviour
{

    public InputActionReference m_inputSource;
    public float m_trueThreshold = 0.5f;
    public bool m_value;
    public UnityEvent<bool> m_onValueChanged;
    public void OnEnable()
    {
        m_inputSource.action.Enable();
        m_inputSource.action.canceled += OnPerformed;
        m_inputSource.action.performed += OnPerformed;
    }
    public void OnDisable()
    {
        m_inputSource.action.canceled -= OnPerformed;
        m_inputSource.action.performed -= OnPerformed;
    }

    private void OnPerformed(InputAction.CallbackContext context)
    {
        bool value = context.ReadValue<float>() > m_trueThreshold ;
        if (value != m_value)
        {
            m_value = value;
            m_onValueChanged.Invoke(m_value);
        }

    }
}


