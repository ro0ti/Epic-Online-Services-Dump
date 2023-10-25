using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003FC RID: 1020
	[Token(Token = "0x20003FC")]
	public struct LobbyInviteAcceptedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A5")]
		public object ClientData
		{
			[Token(Token = "0x6001B0E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B0F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A6")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6001B10")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B11")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001B12")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B13")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A8")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B14")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B15")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007A9")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001B16")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B17")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00007A6C File Offset: 0x00005C6C
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x527FB0", Offset = "0x5265B0", VA = "0x180527FB0")]
		internal void Set(ref LobbyInviteAcceptedCallbackInfoInternal other)
		{
		}
	}
}
