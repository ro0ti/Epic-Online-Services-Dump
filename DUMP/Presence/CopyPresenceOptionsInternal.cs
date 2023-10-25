using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	internal struct CopyPresenceOptionsInternal : ISettable<CopyPresenceOptions>, IDisposable
	{
		// Token: 0x170004D7 RID: 1239
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004D7")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600128A")]
			[Address(RVA = "0x4EE990", Offset = "0x4ECF90", VA = "0x1804EE990")]
			set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004D8")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600128B")]
			[Address(RVA = "0x4EE9F0", Offset = "0x4ECFF0", VA = "0x1804EE9F0")]
			set
			{
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x4EE8D0", Offset = "0x4ECED0", VA = "0x1804EE8D0", Slot = "4")]
		public void Set(ref CopyPresenceOptions other)
		{
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x4EE7C0", Offset = "0x4ECDC0", VA = "0x1804EE7C0", Slot = "5")]
		public void Set(ref CopyPresenceOptions? other)
		{
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x4EE760", Offset = "0x4ECD60", VA = "0x1804EE760", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
