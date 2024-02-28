using UnityEditor;
using UnityEditor.Scripting.Python;
using UnityEngine;

public class MenuItem_HelloWorld_Class
{
   [MenuItem("Python Scripts/HelloWorld")]
   public static void HelloWorld()
   {
      PythonRunner.RunFile("Assets/PythonScripts/helloWorldShortCut.py");
   }
   public static void RunPythonFile(string fileName)
   {
      PythonRunner.RunFile($"{Application.dataPath}/PythonScripts/{fileName}.py");
   }
};
