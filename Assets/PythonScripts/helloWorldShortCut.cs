using UnityEditor;
using UnityEditor.Scripting.Python;

public class MenuItem_HelloWorld_Class
{
   [MenuItem("Python Scripts/HelloWorld")]
   public static void HelloWorld()
   {
       PythonRunner.RunFile("Assets/PythonScripts/helloWorldShortCut.py");
       }
};
