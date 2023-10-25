using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005E4 RID: 1508
	[Token(Token = "0x20005E4")]
	public struct SendRequestToJoinOptions
	{
		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026CC RID: 9932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B44")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60026CB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60026CC")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B45")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60026CD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60026CE")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
