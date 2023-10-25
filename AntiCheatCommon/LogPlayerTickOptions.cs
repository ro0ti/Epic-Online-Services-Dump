using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006D2 RID: 1746
	[Token(Token = "0x20006D2")]
	public struct LogPlayerTickOptions
	{
		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x0000B654 File Offset: 0x00009854
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D35")]
		public IntPtr PlayerHandle
		{
			[Token(Token = "0x6002CAA")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002CAB")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x0000B66C File Offset: 0x0000986C
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D36")]
		public Vec3f? PlayerPosition
		{
			[Token(Token = "0x6002CAC")]
			[Address(RVA = "0x4EC7F0", Offset = "0x4EADF0", VA = "0x1804EC7F0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002CAD")]
			[Address(RVA = "0x575F60", Offset = "0x574560", VA = "0x180575F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x0000B684 File Offset: 0x00009884
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D37")]
		public Quat? PlayerViewRotation
		{
			[Token(Token = "0x6002CAE")]
			[Address(RVA = "0x575E30", Offset = "0x574430", VA = "0x180575E30")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002CAF")]
			[Address(RVA = "0x575F70", Offset = "0x574570", VA = "0x180575F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x0000B69C File Offset: 0x0000989C
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D38")]
		public bool IsPlayerViewZoomed
		{
			[Token(Token = "0x6002CB0")]
			[Address(RVA = "0x4F5200", Offset = "0x4F3800", VA = "0x1804F5200")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CB1")]
			[Address(RVA = "0x4F5220", Offset = "0x4F3820", VA = "0x1804F5220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x0000B6B4 File Offset: 0x000098B4
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D39")]
		public float PlayerHealth
		{
			[Token(Token = "0x6002CB2")]
			[Address(RVA = "0x3D4800", Offset = "0x3D2E00", VA = "0x1803D4800")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6002CB3")]
			[Address(RVA = "0x4AFB00", Offset = "0x4AE100", VA = "0x1804AFB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x0000B6CC File Offset: 0x000098CC
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D3A")]
		public AntiCheatCommonPlayerMovementState PlayerMovementState
		{
			[Token(Token = "0x6002CB4")]
			[Address(RVA = "0x3D65E0", Offset = "0x3D4BE0", VA = "0x1803D65E0")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonPlayerMovementState.None;
			}
			[Token(Token = "0x6002CB5")]
			[Address(RVA = "0x3D76F0", Offset = "0x3D5CF0", VA = "0x1803D76F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
