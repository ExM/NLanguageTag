using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyLS.Globalization
{
	[Flags]
	public enum LanguageTagField: byte
	{
		None = 0x00,
		Language = 0x01,
		Script = 0x02,
		Region = 0x04,
		Variant = 0x08,
		Extension = 0x10,
		PrivateUse = 0x20
	}
}
