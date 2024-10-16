using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ScratchCsMono_GitHubDocumentation))]
public class ScratchCsMono_GitHubDocumentatoinEditor : Editor { 

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        ScratchCsMono_GitHubDocumentation myScript = (ScratchCsMono_GitHubDocumentation)target;
        if (GUILayout.Button("Open GitHub Issue"))
        {
            myScript.OpenGitHubIssue();
        }
    }

}