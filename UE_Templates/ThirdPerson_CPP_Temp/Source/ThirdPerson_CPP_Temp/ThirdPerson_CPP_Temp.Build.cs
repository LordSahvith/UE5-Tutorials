// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ThirdPerson_CPP_Temp : ModuleRules
{
	public ThirdPerson_CPP_Temp(ReadOnlyTargetRules Target) : base(Target)
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
			"ThirdPerson_CPP_Temp",
			"ThirdPerson_CPP_Temp/Variant_Platforming",
			"ThirdPerson_CPP_Temp/Variant_Platforming/Animation",
			"ThirdPerson_CPP_Temp/Variant_Combat",
			"ThirdPerson_CPP_Temp/Variant_Combat/AI",
			"ThirdPerson_CPP_Temp/Variant_Combat/Animation",
			"ThirdPerson_CPP_Temp/Variant_Combat/Gameplay",
			"ThirdPerson_CPP_Temp/Variant_Combat/Interfaces",
			"ThirdPerson_CPP_Temp/Variant_Combat/UI",
			"ThirdPerson_CPP_Temp/Variant_SideScrolling",
			"ThirdPerson_CPP_Temp/Variant_SideScrolling/AI",
			"ThirdPerson_CPP_Temp/Variant_SideScrolling/Gameplay",
			"ThirdPerson_CPP_Temp/Variant_SideScrolling/Interfaces",
			"ThirdPerson_CPP_Temp/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
