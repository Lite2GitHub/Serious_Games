using UnrealBuildTool;

public class Serious_GamesTarget : TargetRules
{
	public Serious_GamesTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Serious_Games");
	}
}
