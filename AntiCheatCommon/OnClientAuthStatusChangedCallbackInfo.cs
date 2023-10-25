using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006DC RID: 1756
	[Token(Token = "0x20006DC")]
	public struct OnClientAuthStatusChangedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D62")]
		public object ClientData
		{
			[Token(Token = "0x6002D0C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002D0D")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x0000B90C File Offset: 0x00009B0C
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D63")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002D0E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002D0F")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x0000B924 File Offset: 0x00009B24
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D64")]
		public AntiCheatCommonClientAuthStatus ClientAuthStatus
		{
			[Token(Token = "0x6002D10")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonClientAuthStatus.Invalid;
			}
			[Token(Token = "0x6002D11")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x0000B93C File Offset: 0x00009B3C
		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x577C70", Offset = "0x576270", VA = "0x180577C70")]
		internal void Set(ref OnClientAuthStatusChangedCallbackInfoInternal other)
		{
		}
	}
}
