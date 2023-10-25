using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003DD RID: 989
	[Token(Token = "0x20003DD")]
	public struct LeaveLobbyRequestedCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A24 RID: 6692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700076C")]
		public object ClientData
		{
			[Token(Token = "0x6001A23")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A24")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700076D")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001A25")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A26")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700076E")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001A27")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001A28")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00007514 File Offset: 0x00005714
		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x5110C0", Offset = "0x50F6C0", VA = "0x1805110C0")]
		internal void Set(ref LeaveLobbyRequestedCallbackInfoInternal other)
		{
		}
	}
}
