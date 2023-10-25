using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Metrics
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	[StructLayout(2)]
	internal struct BeginPlayerSessionOptionsAccountIdInternal : IGettable<BeginPlayerSessionOptionsAccountId>, ISettable<BeginPlayerSessionOptionsAccountId>, IDisposable
	{
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006AC")]
		public EpicAccountId Epic
		{
			[Token(Token = "0x6001829")]
			[Address(RVA = "0x507870", Offset = "0x505E70", VA = "0x180507870")]
			get
			{
				return null;
			}
			[Token(Token = "0x600182A")]
			[Address(RVA = "0x507990", Offset = "0x505F90", VA = "0x180507990")]
			set
			{
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006AD")]
		public Utf8String External
		{
			[Token(Token = "0x600182B")]
			[Address(RVA = "0x507900", Offset = "0x505F00", VA = "0x180507900")]
			get
			{
				return null;
			}
			[Token(Token = "0x600182C")]
			[Address(RVA = "0x507A50", Offset = "0x506050", VA = "0x180507A50")]
			set
			{
			}
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600182D")]
		[Address(RVA = "0x5076B0", Offset = "0x505CB0", VA = "0x1805076B0", Slot = "5")]
		public void Set(ref BeginPlayerSessionOptionsAccountId other)
		{
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600182E")]
		[Address(RVA = "0x507700", Offset = "0x505D00", VA = "0x180507700", Slot = "6")]
		public void Set(ref BeginPlayerSessionOptionsAccountId? other)
		{
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600182F")]
		[Address(RVA = "0x5075D0", Offset = "0x505BD0", VA = "0x1805075D0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001830")]
		[Address(RVA = "0x507650", Offset = "0x505C50", VA = "0x180507650", Slot = "4")]
		public void Get(out BeginPlayerSessionOptionsAccountId output)
		{
		}

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MetricsAccountIdType m_AccountIdType;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private IntPtr m_Epic;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private IntPtr m_External;
	}
}
