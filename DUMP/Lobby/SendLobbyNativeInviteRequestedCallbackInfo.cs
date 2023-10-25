using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000474 RID: 1140
	[Token(Token = "0x2000474")]
	public struct SendLobbyNativeInviteRequestedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000849")]
		public object ClientData
		{
			[Token(Token = "0x6001D8B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D8C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0000818C File Offset: 0x0000638C
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700084A")]
		public ulong UiEventId
		{
			[Token(Token = "0x6001D8D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D8E")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700084B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D8F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D90")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700084C")]
		public Utf8String TargetNativeAccountType
		{
			[Token(Token = "0x6001D91")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D92")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700084D")]
		public Utf8String TargetUserNativeAccountId
		{
			[Token(Token = "0x6001D93")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D94")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700084E")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001D95")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D96")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000081A4 File Offset: 0x000063A4
		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x537360", Offset = "0x535960", VA = "0x180537360")]
		internal void Set(ref SendLobbyNativeInviteRequestedCallbackInfoInternal other)
		{
		}
	}
}
