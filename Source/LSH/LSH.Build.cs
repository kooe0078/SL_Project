// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LSH : ModuleRules
{
	public LSH(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[]
        {
			
		});


        PrivateDependencyModuleNames.AddRange(new string[] 
		{
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"AIModule",
			"GameplayTasks",
			"NavigationSystem",
			"UMG",
			"Niagara",
			"ApexDestruction"
		}
		);

		PublicIncludePathModuleNames.Add("LHW");
		PublicDependencyModuleNames.Add("LHW");
		CircularlyReferencedDependentModules.Add("LHW");

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
