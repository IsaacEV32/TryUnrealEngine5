// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Pruebas : ModuleRules
{
	public Pruebas(ReadOnlyTargetRules Target) : base(Target)
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
			"Pruebas",
			"Pruebas/Variant_Platforming",
			"Pruebas/Variant_Platforming/Animation",
			"Pruebas/Variant_Combat",
			"Pruebas/Variant_Combat/AI",
			"Pruebas/Variant_Combat/Animation",
			"Pruebas/Variant_Combat/Gameplay",
			"Pruebas/Variant_Combat/Interfaces",
			"Pruebas/Variant_Combat/UI",
			"Pruebas/Variant_SideScrolling",
			"Pruebas/Variant_SideScrolling/AI",
			"Pruebas/Variant_SideScrolling/Gameplay",
			"Pruebas/Variant_SideScrolling/Interfaces",
			"Pruebas/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
