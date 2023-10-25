using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	public struct LobbyUpdateReceivedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001C24 RID: 7204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000801")]
		public object ClientData
		{
			[Token(Token = "0x6001C23")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001C24")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001C26 RID: 7206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000802")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001C26")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00007E8C File Offset: 0x0000608C
		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x52D140", Offset = "0x52B740", VA = "0x18052D140")]
		internal void Set(ref LobbyUpdateReceivedCallbackInfoInternal other)
		{
		}
	}
}
