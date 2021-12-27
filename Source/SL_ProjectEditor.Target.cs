// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SL_ProjectEditorTarget : TargetRules
{
	public SL_ProjectEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("SL_Project");
		ExtraModuleNames.Add("LHW");
		ExtraModuleNames.Add("LSH");
	}
}
