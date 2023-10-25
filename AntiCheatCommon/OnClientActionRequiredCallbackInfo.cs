using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006DA RID: 1754
	[Token(Token = "0x20006DA")]
	public struct OnClientActionRequiredCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D57")]
		public object ClientData
		{
			[Token(Token = "0x6002CF1")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002CF2")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x0000B84C File Offset: 0x00009A4C
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D58")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002CF3")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002CF4")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x0000B864 File Offset: 0x00009A64
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D59")]
		public AntiCheatCommonClientAction ClientAction
		{
			[Token(Token = "0x6002CF5")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonClientAction.Invalid;
			}
			[Token(Token = "0x6002CF6")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x0000B87C File Offset: 0x00009A7C
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D5A")]
		public AntiCheatCommonClientActionReason ActionReasonCode
		{
			[Token(Token = "0x6002CF7")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonClientActionReason.Invalid;
			}
			[Token(Token = "0x6002CF8")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D5B")]
		public Utf8String ActionReasonDetailsString
		{
			[Token(Token = "0x6002CF9")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002CFA")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x0000B894 File Offset: 0x00009A94
		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x5777A0", Offset = "0x575DA0", VA = "0x1805777A0")]
		internal void Set(ref OnClientActionRequiredCallbackInfoInternal other)
		{
		}
	}
}
