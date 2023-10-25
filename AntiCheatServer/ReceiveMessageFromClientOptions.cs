using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006A8 RID: 1704
	[Token(Token = "0x20006A8")]
	public struct ReceiveMessageFromClientOptions
	{
		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x0000B03C File Offset: 0x0000923C
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC6")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BC2")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002BC3")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x0000B054 File Offset: 0x00009254
		// (set) Token: 0x06002BC5 RID: 11205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CC7")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002BC4")]
			[Address(RVA = "0x4EC7F0", Offset = "0x4EADF0", VA = "0x1804EC7F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x6002BC5")]
			[Address(RVA = "0x5790E0", Offset = "0x5776E0", VA = "0x1805790E0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
