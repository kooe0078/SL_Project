// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LHW : ModuleRules
{
	public LHW(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
					
			}
            );

        PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"Core", 
				"CoreUObject",
				"Engine", 
				"InputCore", 
				"UMG",
				"Niagara", 
				"AIModule",
			}
			);
		PublicIncludePathModuleNames.Add("LSH");
		PublicDependencyModuleNames.Add("LSH");
		CircularlyReferencedDependentModules.Add("LSH");
		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}