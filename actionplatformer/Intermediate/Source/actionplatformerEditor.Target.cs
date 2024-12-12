using UnrealBuildTool;

public class actionplatformerEditorTarget : TargetRules
{
	public actionplatformerEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("actionplatformer");
	}
}
