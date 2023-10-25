using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	internal struct UnregisterPlayersOptionsInternal : ISettable<UnregisterPlayersOptions>, IDisposable
	{
		// Token: 0x170002B2 RID: 690
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B2")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x4E74D0", Offset = "0x4E5AD0", VA = "0x1804E74D0")]
			set
			{
			}
		}

		// Token: 0x170002B3 RID: 691
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B3")]
		public ProductUserId[] PlayersToUnregister
		{
			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x4E7450", Offset = "0x4E5A50", VA = "0x1804E7450")]
			set
			{
			}
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x4E72E0", Offset = "0x4E58E0", VA = "0x1804E72E0", Slot = "4")]
		public void Set(ref UnregisterPlayersOptions other)
		{
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x4E7370", Offset = "0x4E5970", VA = "0x1804E7370", Slot = "5")]
		public void Set(ref UnregisterPlayersOptions? other)
		{
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x4E7280", Offset = "0x4E5880", VA = "0x1804E7280", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_PlayersToUnregister;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x18")]
		private uint m_PlayersToUnregisterCount;
	}
}
