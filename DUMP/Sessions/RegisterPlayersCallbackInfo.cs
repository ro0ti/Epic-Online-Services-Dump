using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public struct RegisterPlayersCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00003AAC File Offset: 0x00001CAC
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000208")]
		public Result ResultCode
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000209")]
		public object ClientData
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700020A")]
		public ProductUserId[] RegisteredPlayers
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700020B")]
		public ProductUserId[] SanctionedPlayers
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x4C5290", Offset = "0x4C3890", VA = "0x1804C5290", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x4C52E0", Offset = "0x4C38E0", VA = "0x1804C52E0")]
		internal void Set(ref RegisterPlayersCallbackInfoInternal other)
		{
		}
	}
}
