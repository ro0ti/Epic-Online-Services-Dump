using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200035B RID: 859
	[Token(Token = "0x200035B")]
	public struct SetPortRangeOptions
	{
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x0000698C File Offset: 0x00004B8C
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700064F")]
		public ushort Port
		{
			[Token(Token = "0x6001718")]
			[Address(RVA = "0x51FB00", Offset = "0x51E100", VA = "0x18051FB00")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6001719")]
			[Address(RVA = "0x51FB20", Offset = "0x51E120", VA = "0x18051FB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x000069A4 File Offset: 0x00004BA4
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000650")]
		public ushort MaxAdditionalPortsToTry
		{
			[Token(Token = "0x600171A")]
			[Address(RVA = "0x51FAF0", Offset = "0x51E0F0", VA = "0x18051FAF0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x600171B")]
			[Address(RVA = "0x51FB10", Offset = "0x51E110", VA = "0x18051FB10")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
