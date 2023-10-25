using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20002D2")]
	internal struct SetPresenceOptionsInternal : ISettable<SetPresenceOptions>, IDisposable
	{
		// Token: 0x1700052D RID: 1325
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700052D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60013A2")]
			[Address(RVA = "0x5030D0", Offset = "0x5016D0", VA = "0x1805030D0")]
			set
			{
			}
		}

		// Token: 0x1700052E RID: 1326
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700052E")]
		public PresenceModification PresenceModificationHandle
		{
			[Token(Token = "0x60013A3")]
			[Address(RVA = "0x503130", Offset = "0x501730", VA = "0x180503130")]
			set
			{
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x503010", Offset = "0x501610", VA = "0x180503010", Slot = "4")]
		public void Set(ref SetPresenceOptions other)
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x502F00", Offset = "0x501500", VA = "0x180502F00", Slot = "5")]
		public void Set(ref SetPresenceOptions? other)
		{
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x502EA0", Offset = "0x5014A0", VA = "0x180502EA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_PresenceModificationHandle;
	}
}
