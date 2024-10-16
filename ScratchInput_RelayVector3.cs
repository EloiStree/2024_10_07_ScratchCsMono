using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ScratchInput_RelayVector3 : MonoBehaviour
{

    public InputActionReference m_inputSource;
    public Vector3 m_value;
    public UnityEvent<Vector3> m_onValueChanged;
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
        Vector3 value = context.ReadValue<Vector3>();
        if (value.y != m_value.y || value.x != m_value.x || value.z != m_value.z)
        {

            m_value = value;
            m_onValueChanged.Invoke(m_value);
        }

    }
}


