using System;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x020004F9 RID: 1273
	[Token(Token = "0x20004F9")]
	internal struct AcceptInviteOptionsInternal : ISettable<AcceptInviteOptions>, IDisposable
	{
		// Token: 0x1700094D RID: 2381
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700094D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020B7")]
			[Address(RVA = "0x539300", Offset = "0x537900", VA = "0x180539300")]
			set
			{
			}
		}

		// Token: 0x1700094E RID: 2382
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700094E")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60020B8")]
			[Address(RVA = "0x539360", Offset = "0x537960", VA = "0x180539360")]
			set
			{
			}
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x539240", Offset = "0x537840", VA = "0x180539240", Slot = "4")]
		public void Set(ref AcceptInviteOptions other)
		{
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x539130", Offset = "0x537730", VA = "0x180539130", Slot = "5")]
		public void Set(ref AcceptInviteOptions? other)
		{
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0x5390D0", Offset = "0x5376D0", VA = "0x1805390D0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4000E73")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E74 RID: 3700
		[Token(Token = "0x4000E74")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000E75")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
