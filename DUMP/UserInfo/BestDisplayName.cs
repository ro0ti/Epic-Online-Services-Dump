using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public struct BestDisplayName
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001B")]
		public EpicAccountId UserId
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000384 RID: 900 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001C")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000386 RID: 902 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001D")]
		public Utf8String DisplayNameSanitized
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001E")]
		public Utf8String Nickname
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000025DC File Offset: 0x000007DC
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001F")]
		public uint PlatformType
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x488010", Offset = "0x486610", VA = "0x180488010")]
		internal void Set(ref BestDisplayNameInternal other)
		{
		}
	}
}
