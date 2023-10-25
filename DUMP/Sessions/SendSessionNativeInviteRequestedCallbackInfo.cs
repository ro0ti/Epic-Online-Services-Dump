using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	public struct SendSessionNativeInviteRequestedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000229")]
		public object ClientData
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00003BCC File Offset: 0x00001DCC
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700022A")]
		public ulong UiEventId
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700022B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700022C")]
		public Utf8String TargetNativeAccountType
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700022D")]
		public Utf8String TargetUserNativeAccountId
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700022E")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x4C6C00", Offset = "0x4C5200", VA = "0x1804C6C00")]
		internal void Set(ref SendSessionNativeInviteRequestedCallbackInfoInternal other)
		{
		}
	}
}
