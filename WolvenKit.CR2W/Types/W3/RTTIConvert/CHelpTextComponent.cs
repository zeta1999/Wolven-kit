using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHelpTextComponent : CComponent
	{
		[RED("text")] 		public CString Text { get; set;}

		[RED("textColor")] 		public CColor TextColor { get; set;}

		[RED("backgroundColor")] 		public CColor BackgroundColor { get; set;}

		[RED("drawBackground")] 		public CBool DrawBackground { get; set;}

		public CHelpTextComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHelpTextComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}