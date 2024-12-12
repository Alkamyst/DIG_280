using UnrealBuildTool;

public class DIG280_FPSTarget : TargetRules
{
	public DIG280_FPSTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("DIG280_FPS");
	}
}
