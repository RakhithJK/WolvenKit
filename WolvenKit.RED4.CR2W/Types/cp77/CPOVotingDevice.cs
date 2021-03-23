using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CPOVotingDevice : CPOMissionDevice
	{
		private CName _deviceName;

		[Ordinal(45)] 
		[RED("deviceName")] 
		public CName DeviceName
		{
			get => GetProperty(ref _deviceName);
			set => SetProperty(ref _deviceName, value);
		}

		public CPOVotingDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}