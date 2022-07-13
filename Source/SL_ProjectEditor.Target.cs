// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SL_ProjectEditorTarget : TargetRules
{
	public SL_ProjectEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange(new string[]
			{ 
			"SL_Project" ,
			"LHW",
			"LSH"
			}
		);
	}
}
