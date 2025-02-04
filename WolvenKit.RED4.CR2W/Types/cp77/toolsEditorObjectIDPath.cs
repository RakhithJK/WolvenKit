using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsEditorObjectIDPath : CVariable
	{
		private CArray<EditorObjectID> _elements;

		[Ordinal(0)] 
		[RED("elements")] 
		public CArray<EditorObjectID> Elements
		{
			get => GetProperty(ref _elements);
			set => SetProperty(ref _elements, value);
		}

		public toolsEditorObjectIDPath(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
