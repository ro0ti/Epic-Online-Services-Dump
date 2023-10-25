using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public struct UserInfoData
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000080")]
		public EpicAccountId UserId
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000081")]
		public Utf8String Country
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000082")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000083")]
		public Utf8String PreferredLanguage
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000084")]
		public Utf8String Nickname
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000085")]
		public Utf8String DisplayNameSanitized
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x4B5710", Offset = "0x4B3D10", VA = "0x1804B5710")]
		internal void Set(ref UserInfoDataInternal other)
		{
		}
	}
}
