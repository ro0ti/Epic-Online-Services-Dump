using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200050E RID: 1294
	[Token(Token = "0x200050E")]
	public struct OnBlockedUsersUpdateInfo : ICallbackInfo
	{
		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700095F")]
		public object ClientData
		{
			[Token(Token = "0x600210E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600210F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000960")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002110")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002111")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000961")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6002112")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002113")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x00008D2C File Offset: 0x00006F2C
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000962")]
		public bool Blocked
		{
			[Token(Token = "0x6002114")]
			[Address(RVA = "0x4BED50", Offset = "0x4BD350", VA = "0x1804BED50")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002115")]
			[Address(RVA = "0x4BED60", Offset = "0x4BD360", VA = "0x1804BED60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00008D44 File Offset: 0x00006F44
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x5497A0", Offset = "0x547DA0", VA = "0x1805497A0")]
		internal void Set(ref OnBlockedUsersUpdateInfoInternal other)
		{
		}
	}
}
