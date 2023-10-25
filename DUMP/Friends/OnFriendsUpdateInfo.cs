using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	public struct OnFriendsUpdateInfo : ICallbackInfo
	{
		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000968")]
		public object ClientData
		{
			[Token(Token = "0x600212D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600212E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000969")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600212F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002130")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700096A")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6002131")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002132")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x00008D8C File Offset: 0x00006F8C
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700096B")]
		public FriendsStatus PreviousStatus
		{
			[Token(Token = "0x6002133")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return FriendsStatus.NotFriends;
			}
			[Token(Token = "0x6002134")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x00008DA4 File Offset: 0x00006FA4
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700096C")]
		public FriendsStatus CurrentStatus
		{
			[Token(Token = "0x6002135")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			[CompilerGenerated]
			readonly get
			{
				return FriendsStatus.NotFriends;
			}
			[Token(Token = "0x6002136")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00008DBC File Offset: 0x00006FBC
		[Token(Token = "0x6002137")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002138")]
		[Address(RVA = "0x54A0B0", Offset = "0x5486B0", VA = "0x18054A0B0")]
		internal void Set(ref OnFriendsUpdateInfoInternal other)
		{
		}
	}
}
