using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsToggleStealthMappinVisibilityEvent : redEvent
	{
		[Ordinal(0)] [RED("show")] public CBool Show { get; set; }

		public gameeventsToggleStealthMappinVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}