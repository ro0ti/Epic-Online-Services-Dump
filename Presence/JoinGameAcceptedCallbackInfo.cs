using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	public struct JoinGameAcceptedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F9")]
		public object ClientData
		{
			[Token(Token = "0x60012DD")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60012DE")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004FA")]
		public Utf8String JoinInfo
		{
			[Token(Token = "0x60012DF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60012E0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004FB")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60012E1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60012E2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004FC")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60012E3")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60012E4")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x000058AC File Offset: 0x00003AAC
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004FD")]
		public ulong UiEventId
		{
			[Token(Token = "0x60012E5")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x60012E6")]
			[Address(RVA = "0x4F4050", Offset = "0x4F2650", VA = "0x1804F4050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000058C4 File Offset: 0x00003AC4
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x4F4060", Offset = "0x4F2660", VA = "0x1804F4060")]
		internal void Set(ref JoinGameAcceptedCallbackInfoInternal other)
		{
		}
	}
}
