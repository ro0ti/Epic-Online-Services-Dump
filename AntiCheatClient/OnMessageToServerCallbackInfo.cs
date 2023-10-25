using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000709 RID: 1801
	[Token(Token = "0x2000709")]
	public struct OnMessageToServerCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002DF5 RID: 11765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DA1")]
		public object ClientData
		{
			[Token(Token = "0x6002DF4")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002DF5")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x0000BE34 File Offset: 0x0000A034
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DA2")]
		public ArraySegment<byte> MessageData
		{
			[Token(Token = "0x6002DF6")]
			[Address(RVA = "0x4EC7F0", Offset = "0x4EADF0", VA = "0x1804EC7F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x6002DF7")]
			[Address(RVA = "0x5790E0", Offset = "0x5776E0", VA = "0x1805790E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x0000BE4C File Offset: 0x0000A04C
		[Token(Token = "0x6002DF8")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0x578FF0", Offset = "0x5775F0", VA = "0x180578FF0")]
		internal void Set(ref OnMessageToServerCallbackInfoInternal other)
		{
		}
	}
}
