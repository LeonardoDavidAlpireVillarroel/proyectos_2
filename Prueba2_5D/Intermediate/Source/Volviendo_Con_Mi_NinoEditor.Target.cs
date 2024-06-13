using UnrealBuildTool;

public class Volviendo_Con_Mi_NinoEditorTarget : TargetRules
{
	public Volviendo_Con_Mi_NinoEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Volviendo_Con_Mi_Nino");
	}
}
