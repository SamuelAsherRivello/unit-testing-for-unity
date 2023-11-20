using UnityEditor;
using UnityEngine;

public class BuildScript
{
    public static void PerformBuild()
    {
        string[] defaultScene =
        {
            "Assets/Unit Testing For Unity/Shared/Scenes/KeepThisSceneInBuildSettingsForCloudBuild.unity"
        }; 
        BuildPipeline.BuildPlayer(defaultScene, 
            "Build/AutomatedBuild.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}