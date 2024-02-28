 
using TMPro;
using UnityEditor.Scripting.Python;
using UnityEngine;

public class PythonRunnerTest : MonoBehaviour
{
    public TextMeshProUGUI output;
        
    public void RunPython(string fileName)
    {
        PythonRunner.RunFile($"Assets/PythonScripts/{fileName}.py");
    }
        
}