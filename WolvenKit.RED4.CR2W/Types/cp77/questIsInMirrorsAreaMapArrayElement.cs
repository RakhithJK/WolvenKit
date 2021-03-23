using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIsInMirrorsAreaMapArrayElement : CVariable
	{
		private NodeRef _objectRef;
		private CBool _isInMirrorsArea;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("isInMirrorsArea")] 
		public CBool IsInMirrorsArea
		{
			get => GetProperty(ref _isInMirrorsArea);
			set => SetProperty(ref _isInMirrorsArea, value);
		}

		public questIsInMirrorsAreaMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}