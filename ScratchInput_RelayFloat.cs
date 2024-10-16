using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ScratchInput_RelayFloat : MonoBehaviour
{

    public InputActionReference m_inputSource;
    public float m_value;
    public UnityEvent<float> m_onValueChanged;
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
        float value = context.ReadValue<float>();
        if (value!= m_value)
        {
            m_value = value;
            m_onValueChanged.Invoke(m_value);
        }

    }
}


