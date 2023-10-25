using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public struct CopyBestDisplayNameWithPlatformOptions
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000029")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002A")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000260C File Offset: 0x0000080C
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002B")]
		public uint TargetPlatformType
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
