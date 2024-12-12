using UnrealBuildTool;

public class actionplatformerTarget : TargetRules
{
	public actionplatformerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("actionplatformer");
	}
}
