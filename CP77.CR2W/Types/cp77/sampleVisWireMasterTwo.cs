using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleVisWireMasterTwo : gameObject
	{
		[Ordinal(40)] [RED("dependableEntities")] public CArray<NodeRef> DependableEntities { get; set; }

		public sampleVisWireMasterTwo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}