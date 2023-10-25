using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public struct CopyExternalUserInfoByIndexOptions
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060003CA RID: 970 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003C")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003D")]
		public uint Index
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
