using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	internal struct DataRecordInternal : IGettable<DataRecord>, ISettable<DataRecord>, IDisposable
	{
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004DD")]
		public Utf8String Key
		{
			[Token(Token = "0x600129A")]
			[Address(RVA = "0x4EEE50", Offset = "0x4ED450", VA = "0x1804EEE50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600129B")]
			[Address(RVA = "0x4EEF30", Offset = "0x4ED530", VA = "0x1804EEF30")]
			set
			{
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004DE")]
		public Utf8String Value
		{
			[Token(Token = "0x600129C")]
			[Address(RVA = "0x4EEEC0", Offset = "0x4ED4C0", VA = "0x1804EEEC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600129D")]
			[Address(RVA = "0x4EEF90", Offset = "0x4ED590", VA = "0x1804EEF90")]
			set
			{
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x4EED90", Offset = "0x4ED390", VA = "0x1804EED90", Slot = "5")]
		public void Set(ref DataRecord other)
		{
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x4EEC80", Offset = "0x4ED280", VA = "0x1804EEC80", Slot = "6")]
		public void Set(ref DataRecord? other)
		{
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x4EEC00", Offset = "0x4ED200", VA = "0x1804EEC00", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x4EEC60", Offset = "0x4ED260", VA = "0x1804EEC60", Slot = "4")]
		public void Get(out DataRecord output)
		{
		}

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Value;
	}
}
