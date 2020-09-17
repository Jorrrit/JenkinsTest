﻿using UnityEditor;
namespace Assets.Editor
{
	public static class BuildProcessor
	{
		/// <summary>
		/// Function is intended to be run from command line
		/// </summary>
        
		[MenuItem("BuildProcessor/Build VR Driver")]
		static void BuildJenkinsTest()
		{
			BuildPipeline.BuildPlayer
                (
				new EditorBuildSettingsScene[] { new EditorBuildSettingsScene("Assets/Scenes/SampleScene.unity", true) },
				"c:/outdir/",
				 BuildTarget.StandaloneWindows,
				 BuildOptions.None
				);
		}
	}
}