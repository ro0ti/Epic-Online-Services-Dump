using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000602 RID: 1538
	[Token(Token = "0x2000602")]
	internal struct CredentialsInternal : IGettable<Credentials>, ISettable<Credentials>, IDisposable
	{
		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B73")]
		public Utf8String Token
		{
			[Token(Token = "0x6002773")]
			[Address(RVA = "0x559550", Offset = "0x557B50", VA = "0x180559550")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002774")]
			[Address(RVA = "0x559690", Offset = "0x557C90", VA = "0x180559690")]
			set
			{
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x0000A094 File Offset: 0x00008294
		// (set) Token: 0x06002776 RID: 10102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B74")]
		public ExternalCredentialType Type
		{
			[Token(Token = "0x6002775")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return ExternalCredentialType.Epic;
			}
			[Token(Token = "0x6002776")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x559230", Offset = "0x557830", VA = "0x180559230", Slot = "5")]
		public void Set(ref Credentials other)
		{
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002778")]
		[Address(RVA = "0x559160", Offset = "0x557760", VA = "0x180559160", Slot = "6")]
		public void Set(ref Credentials? other)
		{
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002779")]
		[Address(RVA = "0x559050", Offset = "0x557650", VA = "0x180559050", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x559110", Offset = "0x557710", VA = "0x180559110", Slot = "4")]
		public void Get(out Credentials output)
		{
		}

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Token;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x10")]
		private ExternalCredentialType m_Type;
	}
}
