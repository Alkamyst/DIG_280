using UnrealBuildTool;

public class DIG280_FPSEditorTarget : TargetRules
{
	public DIG280_FPSEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("DIG280_FPS");
	}
}
