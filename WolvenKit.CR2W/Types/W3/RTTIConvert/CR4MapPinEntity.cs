using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MapPinEntity : CGameplayEntity
	{
		[RED("entityName")] 		public CName EntityName { get; set;}

		[RED("customName")] 		public LocalizedString CustomName { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("ignoreWhenExportingMapPins")] 		public CBool IgnoreWhenExportingMapPins { get; set;}

		public CR4MapPinEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MapPinEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}