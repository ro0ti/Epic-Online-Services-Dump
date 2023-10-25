using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	internal struct RegisterPlayersCallbackInfoInternal : ICallbackInfoInternal, IGettable<RegisterPlayersCallbackInfo>, ISettable<RegisterPlayersCallbackInfo>, IDisposable
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00003ADC File Offset: 0x00001CDC
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700020C")]
		public Result ResultCode
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700020D")]
		public object ClientData
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x4C4FA0", Offset = "0x4C35A0", VA = "0x1804C4FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x4C5130", Offset = "0x4C3730", VA = "0x1804C5130")]
			set
			{
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x1700020E")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700020F")]
		public ProductUserId[] RegisteredPlayers
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x4C5010", Offset = "0x4C3610", VA = "0x1804C5010")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x4C5190", Offset = "0x4C3790", VA = "0x1804C5190")]
			set
			{
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000210")]
		public ProductUserId[] SanctionedPlayers
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x4C50A0", Offset = "0x4C36A0", VA = "0x1804C50A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x4C5210", Offset = "0x4C3810", VA = "0x1804C5210")]
			set
			{
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x4C4DF0", Offset = "0x4C33F0", VA = "0x1804C4DF0", Slot = "6")]
		public void Set(ref RegisterPlayersCallbackInfo other)
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x4C4E90", Offset = "0x4C3490", VA = "0x1804C4E90", Slot = "7")]
		public void Set(ref RegisterPlayersCallbackInfo? other)
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x4C4D60", Offset = "0x4C3360", VA = "0x1804C4D60", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x4C4DD0", Offset = "0x4C33D0", VA = "0x1804C4DD0", Slot = "5")]
		public void Get(out RegisterPlayersCallbackInfo output)
		{
		}

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RegisteredPlayers;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x18")]
		private uint m_RegisteredPlayersCount;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_SanctionedPlayers;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x28")]
		private uint m_SanctionedPlayersCount;
	}
}
