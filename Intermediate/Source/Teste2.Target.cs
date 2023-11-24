using UnrealBuildTool;

public class Teste2Target : TargetRules
{
	public Teste2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Teste2");
	}
}
