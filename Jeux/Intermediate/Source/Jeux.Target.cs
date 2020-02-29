using UnrealBuildTool;

public class JeuxTarget : TargetRules
{
	public JeuxTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Jeux");
	}
}
