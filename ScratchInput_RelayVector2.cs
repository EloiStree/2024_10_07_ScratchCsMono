using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ScratchInput_RelayVector2 : MonoBehaviour {

    public InputActionReference m_inputSource;
    public Vector2 m_value;
    public UnityEvent<Vector2> m_onValueChanged;
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
        Vector2 value = context.ReadValue<Vector2>();
        if (value.y != m_value.y || value.x != m_value.x) { 
        
            m_value = value;
            m_onValueChanged.Invoke(m_value);
        }

    }
}


