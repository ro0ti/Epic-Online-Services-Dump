using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200027B RID: 635
	[Token(Token = "0x200027B")]
	internal struct ParticipantMetadataInternal : IGettable<ParticipantMetadata>, ISettable<ParticipantMetadata>, IDisposable
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000484")]
		public Utf8String Key
		{
			[Token(Token = "0x6001182")]
			[Address(RVA = "0x4F7F50", Offset = "0x4F6550", VA = "0x1804F7F50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001183")]
			[Address(RVA = "0x4F8030", Offset = "0x4F6630", VA = "0x1804F8030")]
			set
			{
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001185 RID: 4485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000485")]
		public Utf8String Value
		{
			[Token(Token = "0x6001184")]
			[Address(RVA = "0x4F7FC0", Offset = "0x4F65C0", VA = "0x1804F7FC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001185")]
			[Address(RVA = "0x4F8090", Offset = "0x4F6690", VA = "0x1804F8090")]
			set
			{
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001186")]
		[Address(RVA = "0x4F7E90", Offset = "0x4F6490", VA = "0x1804F7E90", Slot = "5")]
		public void Set(ref ParticipantMetadata other)
		{
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001187")]
		[Address(RVA = "0x4F7D80", Offset = "0x4F6380", VA = "0x1804F7D80", Slot = "6")]
		public void Set(ref ParticipantMetadata? other)
		{
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001188")]
		[Address(RVA = "0x4F7D00", Offset = "0x4F6300", VA = "0x1804F7D00", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x4F7D60", Offset = "0x4F6360", VA = "0x1804F7D60", Slot = "4")]
		public void Get(out ParticipantMetadata output)
		{
		}

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Value;
	}
}
