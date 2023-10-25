using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000703 RID: 1795
	[Token(Token = "0x2000703")]
	public struct OnClientIntegrityViolatedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D9A")]
		public object ClientData
		{
			[Token(Token = "0x6002DD1")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002DD2")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x0000BDD4 File Offset: 0x00009FD4
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D9B")]
		public AntiCheatClientViolationType ViolationType
		{
			[Token(Token = "0x6002DD3")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatClientViolationType.Invalid;
			}
			[Token(Token = "0x6002DD4")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002DD6 RID: 11734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D9C")]
		public Utf8String ViolationMessage
		{
			[Token(Token = "0x6002DD5")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002DD6")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x0000BDEC File Offset: 0x00009FEC
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x578210", Offset = "0x576810", VA = "0x180578210")]
		internal void Set(ref OnClientIntegrityViolatedCallbackInfoInternal other)
		{
		}
	}
}
