using UnrealBuildTool;

public class DIG280_FPSClientTarget : TargetRules
{
	public DIG280_FPSClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("DIG280_FPS");
	}
}
