using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScoreboardEntityLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		public ScoreboardEntityLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
