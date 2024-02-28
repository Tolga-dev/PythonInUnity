using UnityEngine;
using UnityEditor.Scripting.Python;

namespace DefaultNamespace
{
    public class PythonRunner : MonoBehaviour
    {
        public void RunPython(string fileName)
        {
            MenuItem_HelloWorld_Class.RunPythonFile(fileName);
        }
        
    }
}