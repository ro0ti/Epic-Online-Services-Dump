using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Metrics
{
	// Token: 0x02000381 RID: 897
	[Token(Token = "0x2000381")]
	public struct BeginPlayerSessionOptions
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00006CEC File Offset: 0x00004EEC
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700069F")]
		public BeginPlayerSessionOptionsAccountId AccountId
		{
			[Token(Token = "0x600180D")]
			[Address(RVA = "0x5083F0", Offset = "0x5069F0", VA = "0x1805083F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(BeginPlayerSessionOptionsAccountId);
			}
			[Token(Token = "0x600180E")]
			[Address(RVA = "0x508410", Offset = "0x506A10", VA = "0x180508410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A0")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x600180F")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001810")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x00006D04 File Offset: 0x00004F04
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A1")]
		public UserControllerType ControllerType
		{
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			[CompilerGenerated]
			readonly get
			{
				return UserControllerType.Unknown;
			}
			[Token(Token = "0x6001812")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A2")]
		public Utf8String ServerIp
		{
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001814")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006A3")]
		public Utf8String GameSessionId
		{
			[Token(Token = "0x6001815")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001816")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
