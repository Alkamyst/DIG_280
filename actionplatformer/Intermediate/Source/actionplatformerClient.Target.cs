using UnrealBuildTool;

public class actionplatformerClientTarget : TargetRules
{
	public actionplatformerClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("actionplatformer");
	}
}
