using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetNodeDefinition : questAICommandNodeBase
	{
		private CHandle<questUniversalRef> _entityReference;
		private CHandle<questTeleportPuppetParamsV1> _params;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public CHandle<questUniversalRef> EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CHandle<questTeleportPuppetParamsV1> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questTeleportPuppetNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
