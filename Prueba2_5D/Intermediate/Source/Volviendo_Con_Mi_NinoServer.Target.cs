using UnrealBuildTool;

public class Volviendo_Con_Mi_NinoServerTarget : TargetRules
{
	public Volviendo_Con_Mi_NinoServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Volviendo_Con_Mi_Nino");
	}
}
