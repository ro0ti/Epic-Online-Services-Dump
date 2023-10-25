using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	internal struct PresenceModificationDataRecordIdInternal : IGettable<PresenceModificationDataRecordId>, ISettable<PresenceModificationDataRecordId>, IDisposable
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700050C")]
		public Utf8String Key
		{
			[Token(Token = "0x600133F")]
			[Address(RVA = "0x4FBF60", Offset = "0x4FA560", VA = "0x1804FBF60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001340")]
			[Address(RVA = "0x4FBFD0", Offset = "0x4FA5D0", VA = "0x1804FBFD0")]
			set
			{
			}
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x4FBF00", Offset = "0x4FA500", VA = "0x1804FBF00", Slot = "5")]
		public void Set(ref PresenceModificationDataRecordId other)
		{
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001342")]
		[Address(RVA = "0x4FBE60", Offset = "0x4FA460", VA = "0x1804FBE60", Slot = "6")]
		public void Set(ref PresenceModificationDataRecordId? other)
		{
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001343")]
		[Address(RVA = "0x4FBDF0", Offset = "0x4FA3F0", VA = "0x1804FBDF0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x4FBE40", Offset = "0x4FA440", VA = "0x1804FBE40", Slot = "4")]
		public void Get(out PresenceModificationDataRecordId output)
		{
		}

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400088E RID: 2190
		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;
	}
}
