using UnrealBuildTool;

public class DIG280_FPSServerTarget : TargetRules
{
	public DIG280_FPSServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("DIG280_FPS");
	}
}
