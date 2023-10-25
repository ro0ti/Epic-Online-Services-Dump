using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	public struct AudioInputStateCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000315")]
		public object ClientData
		{
			[Token(Token = "0x6000CF0")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000316")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CF3")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000317")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000CF4")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00004724 File Offset: 0x00002924
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000318")]
		public RTCAudioInputStatus Status
		{
			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return RTCAudioInputStatus.Idle;
			}
			[Token(Token = "0x6000CF7")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x4D6AA0", Offset = "0x4D50A0", VA = "0x1804D6AA0")]
		internal void Set(ref AudioInputStateCallbackInfoInternal other)
		{
		}
	}
}
