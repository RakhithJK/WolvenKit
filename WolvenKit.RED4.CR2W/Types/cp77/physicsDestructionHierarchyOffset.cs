using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsDestructionHierarchyOffset : CVariable
	{
		private CUInt32 _combined;

		[Ordinal(0)] 
		[RED("combined")] 
		public CUInt32 Combined
		{
			get => GetProperty(ref _combined);
			set => SetProperty(ref _combined, value);
		}

		public physicsDestructionHierarchyOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}