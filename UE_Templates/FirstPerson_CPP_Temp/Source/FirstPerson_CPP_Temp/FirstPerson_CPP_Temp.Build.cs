// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FirstPerson_CPP_Temp : ModuleRules
{
	public FirstPerson_CPP_Temp(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"FirstPerson_CPP_Temp",
			"FirstPerson_CPP_Temp/Variant_Horror",
			"FirstPerson_CPP_Temp/Variant_Horror/UI",
			"FirstPerson_CPP_Temp/Variant_Shooter",
			"FirstPerson_CPP_Temp/Variant_Shooter/AI",
			"FirstPerson_CPP_Temp/Variant_Shooter/UI",
			"FirstPerson_CPP_Temp/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
