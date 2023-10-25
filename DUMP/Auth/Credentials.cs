using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000654 RID: 1620
	[Token(Token = "0x2000654")]
	public struct Credentials
	{
		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C0A")]
		public Utf8String Id
		{
			[Token(Token = "0x6002975")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002976")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C0B")]
		public Utf8String Token
		{
			[Token(Token = "0x6002977")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002978")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x0000A64C File Offset: 0x0000884C
		// (set) Token: 0x0600297A RID: 10618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C0C")]
		public LoginCredentialType Type
		{
			[Token(Token = "0x6002979")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return LoginCredentialType.Password;
			}
			[Token(Token = "0x600297A")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x0000A664 File Offset: 0x00008864
		// (set) Token: 0x0600297C RID: 10620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C0D")]
		public IntPtr SystemAuthCredentialsOptions
		{
			[Token(Token = "0x600297B")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x600297C")]
			[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x0000A67C File Offset: 0x0000887C
		// (set) Token: 0x0600297E RID: 10622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C0E")]
		public ExternalCredentialType ExternalType
		{
			[Token(Token = "0x600297D")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalCredentialType.Epic;
			}
			[Token(Token = "0x600297E")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600297F")]
		[Address(RVA = "0x559750", Offset = "0x557D50", VA = "0x180559750")]
		internal void Set(ref CredentialsInternal other)
		{
		}
	}
}
