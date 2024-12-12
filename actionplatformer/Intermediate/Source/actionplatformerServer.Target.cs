using UnrealBuildTool;

public class actionplatformerServerTarget : TargetRules
{
	public actionplatformerServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("actionplatformer");
	}
}
