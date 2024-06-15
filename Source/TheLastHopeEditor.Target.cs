// Copyright Syntax Games

using UnrealBuildTool;
using System.Collections.Generic;

public class TheLastHopeEditorTarget : TargetRules
{
	public TheLastHopeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "TheLastHope" } );
	}
}
