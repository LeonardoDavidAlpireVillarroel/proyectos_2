using UnrealBuildTool;

public class Volviendo_Con_Mi_NinoTarget : TargetRules
{
	public Volviendo_Con_Mi_NinoTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Volviendo_Con_Mi_Nino");
	}
}
