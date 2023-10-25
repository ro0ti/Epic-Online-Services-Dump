using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000367 RID: 871
	[Token(Token = "0x2000367")]
	public struct InstallModCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x00006A94 File Offset: 0x00004C94
		// (set) Token: 0x0600175A RID: 5978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000668")]
		public Result ResultCode
		{
			[Token(Token = "0x6001759")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600175A")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600175C RID: 5980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000669")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600175B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600175C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700066A")]
		public object ClientData
		{
			[Token(Token = "0x600175D")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600175E")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x00006AAC File Offset: 0x00004CAC
		// (set) Token: 0x06001760 RID: 5984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700066B")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x600175F")]
			[Address(RVA = "0x50D620", Offset = "0x50BC20", VA = "0x18050D620")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001760")]
			[Address(RVA = "0x50D640", Offset = "0x50BC40", VA = "0x18050D640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00006AC4 File Offset: 0x00004CC4
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x50D4A0", Offset = "0x50BAA0", VA = "0x18050D4A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001762")]
		[Address(RVA = "0x50D4F0", Offset = "0x50BAF0", VA = "0x18050D4F0")]
		internal void Set(ref InstallModCallbackInfoInternal other)
		{
		}
	}
}
