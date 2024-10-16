using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.WebRequestMethods;

public class ScratchCsMono_GitHubDocumentation : MonoBehaviour
{
    public string m_url= "https://github.com/EloiStree/HelloScratchToUnity/issues/1";

    [ContextMenu("Open GitHub Issue")]
    public void OpenGitHubIssue()
    {
        Application.OpenURL(m_url);
    }
}
