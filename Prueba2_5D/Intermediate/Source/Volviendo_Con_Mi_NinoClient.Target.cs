using UnrealBuildTool;

public class Volviendo_Con_Mi_NinoClientTarget : TargetRules
{
	public Volviendo_Con_Mi_NinoClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Volviendo_Con_Mi_Nino");
	}
}
