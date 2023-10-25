using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	public struct HardMuteMemberOptions
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700071F")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001973")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001974")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000720")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001975")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001976")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000721")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001977")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001978")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x0000728C File Offset: 0x0000548C
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000722")]
		public bool HardMute
		{
			[Token(Token = "0x6001979")]
			[Address(RVA = "0x4BED50", Offset = "0x4BD350", VA = "0x1804BED50")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600197A")]
			[Address(RVA = "0x4BED60", Offset = "0x4BD360", VA = "0x1804BED60")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
