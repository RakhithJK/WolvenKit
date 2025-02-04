using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneUID : CVariable
	{
		private CUInt64 _nodeRefHash;
		private CUInt16 _laneNumber;
		private CUInt16 _seqNumber;
		private CBool _isReversed;

		[Ordinal(0)] 
		[RED("nodeRefHash")] 
		public CUInt64 NodeRefHash
		{
			get => GetProperty(ref _nodeRefHash);
			set => SetProperty(ref _nodeRefHash, value);
		}

		[Ordinal(1)] 
		[RED("laneNumber")] 
		public CUInt16 LaneNumber
		{
			get => GetProperty(ref _laneNumber);
			set => SetProperty(ref _laneNumber, value);
		}

		[Ordinal(2)] 
		[RED("seqNumber")] 
		public CUInt16 SeqNumber
		{
			get => GetProperty(ref _seqNumber);
			set => SetProperty(ref _seqNumber, value);
		}

		[Ordinal(3)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get => GetProperty(ref _isReversed);
			set => SetProperty(ref _isReversed, value);
		}

		public worldTrafficLaneUID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
