// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GrapplingHookShooter : ModuleRules
{
	public GrapplingHookShooter(ReadOnlyTargetRules Target) : base(Target)
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
			"GrapplingHookShooter",
			"GrapplingHookShooter/Variant_Platforming",
			"GrapplingHookShooter/Variant_Platforming/Animation",
			"GrapplingHookShooter/Variant_Combat",
			"GrapplingHookShooter/Variant_Combat/AI",
			"GrapplingHookShooter/Variant_Combat/Animation",
			"GrapplingHookShooter/Variant_Combat/Gameplay",
			"GrapplingHookShooter/Variant_Combat/Interfaces",
			"GrapplingHookShooter/Variant_Combat/UI",
			"GrapplingHookShooter/Variant_SideScrolling",
			"GrapplingHookShooter/Variant_SideScrolling/AI",
			"GrapplingHookShooter/Variant_SideScrolling/Gameplay",
			"GrapplingHookShooter/Variant_SideScrolling/Interfaces",
			"GrapplingHookShooter/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
