using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200046A RID: 1130
	[Token(Token = "0x200046A")]
	public struct RejectInviteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0000803C File Offset: 0x0000623C
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000826")]
		public Result ResultCode
		{
			[Token(Token = "0x6001D35")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001D36")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000827")]
		public object ClientData
		{
			[Token(Token = "0x6001D37")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D38")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000828")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6001D39")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D3A")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00008054 File Offset: 0x00006254
		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x5355C0", Offset = "0x533BC0", VA = "0x1805355C0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x535610", Offset = "0x533C10", VA = "0x180535610")]
		internal void Set(ref RejectInviteCallbackInfoInternal other)
		{
		}
	}
}
