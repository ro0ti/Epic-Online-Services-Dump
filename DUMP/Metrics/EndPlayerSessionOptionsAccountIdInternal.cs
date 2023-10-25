using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Metrics
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	[StructLayout(2)]
	internal struct EndPlayerSessionOptionsAccountIdInternal : IGettable<EndPlayerSessionOptionsAccountId>, ISettable<EndPlayerSessionOptionsAccountId>, IDisposable
	{
		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B3")]
		public EpicAccountId Epic
		{
			[Token(Token = "0x6001841")]
			[Address(RVA = "0x50A9B0", Offset = "0x508FB0", VA = "0x18050A9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001842")]
			[Address(RVA = "0x50AAD0", Offset = "0x5090D0", VA = "0x18050AAD0")]
			set
			{
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B4")]
		public Utf8String External
		{
			[Token(Token = "0x6001843")]
			[Address(RVA = "0x50AA40", Offset = "0x509040", VA = "0x18050AA40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001844")]
			[Address(RVA = "0x50AB90", Offset = "0x509190", VA = "0x18050AB90")]
			set
			{
			}
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x50A960", Offset = "0x508F60", VA = "0x18050A960", Slot = "5")]
		public void Set(ref EndPlayerSessionOptionsAccountId other)
		{
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x50A7F0", Offset = "0x508DF0", VA = "0x18050A7F0", Slot = "6")]
		public void Set(ref EndPlayerSessionOptionsAccountId? other)
		{
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x50A710", Offset = "0x508D10", VA = "0x18050A710", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x50A790", Offset = "0x508D90", VA = "0x18050A790", Slot = "4")]
		public void Get(out EndPlayerSessionOptionsAccountId output)
		{
		}

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MetricsAccountIdType m_AccountIdType;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private IntPtr m_Epic;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private IntPtr m_External;
	}
}
