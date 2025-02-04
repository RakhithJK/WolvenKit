using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MapPinEntity : CGameplayEntity
	{
		[Ordinal(1)] [RED("entityName")] 		public CName EntityName { get; set;}

		[Ordinal(2)] [RED("customName")] 		public LocalizedString CustomName { get; set;}

		[Ordinal(3)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(4)] [RED("ignoreWhenExportingMapPins")] 		public CBool IgnoreWhenExportingMapPins { get; set;}

		public CR4MapPinEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}