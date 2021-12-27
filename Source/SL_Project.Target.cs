// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SL_ProjectTarget : TargetRules
{
	public SL_ProjectTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("SL_Project");
		ExtraModuleNames.Add("LHW"); 
		ExtraModuleNames.Add("LSH");
	}
}
