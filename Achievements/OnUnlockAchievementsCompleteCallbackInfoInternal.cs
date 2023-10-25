using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000770 RID: 1904
	[Token(Token = "0x2000770")]
	internal struct OnUnlockAchievementsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnUnlockAchievementsCompleteCallbackInfo>, ISettable<OnUnlockAchievementsCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EB0")]
		public Result ResultCode
		{
			[Token(Token = "0x60030E6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60030E7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030E9 RID: 12521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EB1")]
		public object ClientData
		{
			[Token(Token = "0x60030E8")]
			[Address(RVA = "0x58A580", Offset = "0x588B80", VA = "0x18058A580")]
			get
			{
				return null;
			}
			[Token(Token = "0x60030E9")]
			[Address(RVA = "0x58A670", Offset = "0x588C70", VA = "0x18058A670")]
			set
			{
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x0000C9BC File Offset: 0x0000ABBC
		[Token(Token = "0x17000EB2")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60030EA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030EC RID: 12524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EB3")]
		public ProductUserId UserId
		{
			[Token(Token = "0x60030EB")]
			[Address(RVA = "0x58A5F0", Offset = "0x588BF0", VA = "0x18058A5F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60030EC")]
			[Address(RVA = "0x58A6D0", Offset = "0x588CD0", VA = "0x18058A6D0")]
			set
			{
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		// (set) Token: 0x060030EE RID: 12526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EB4")]
		public uint AchievementsCount
		{
			[Token(Token = "0x60030ED")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60030EE")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030EF")]
		[Address(RVA = "0x58A4B0", Offset = "0x588AB0", VA = "0x18058A4B0", Slot = "6")]
		public void Set(ref OnUnlockAchievementsCompleteCallbackInfo other)
		{
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030F0")]
		[Address(RVA = "0x58A370", Offset = "0x588970", VA = "0x18058A370", Slot = "7")]
		public void Set(ref OnUnlockAchievementsCompleteCallbackInfo? other)
		{
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030F1")]
		[Address(RVA = "0x58A2F0", Offset = "0x5888F0", VA = "0x18058A2F0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030F2")]
		[Address(RVA = "0x58A350", Offset = "0x588950", VA = "0x18058A350", Slot = "5")]
		public void Get(out OnUnlockAchievementsCompleteCallbackInfo output)
		{
		}

		// Token: 0x040015F5 RID: 5621
		[Token(Token = "0x40015F5")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040015F6 RID: 5622
		[Token(Token = "0x40015F6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_UserId;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x18")]
		private uint m_AchievementsCount;
	}
}
