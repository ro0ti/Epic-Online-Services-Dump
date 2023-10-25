using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Metrics
{
	// Token: 0x02000386 RID: 902
	[Token(Token = "0x2000386")]
	internal struct EndPlayerSessionOptionsInternal : ISettable<EndPlayerSessionOptions>, IDisposable
	{
		// Token: 0x170006AF RID: 1711
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006AF")]
		public EndPlayerSessionOptionsAccountId AccountId
		{
			[Token(Token = "0x6001833")]
			[Address(RVA = "0x50B140", Offset = "0x509740", VA = "0x18050B140")]
			set
			{
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001834")]
		[Address(RVA = "0x50B0C0", Offset = "0x5096C0", VA = "0x18050B0C0", Slot = "4")]
		public void Set(ref EndPlayerSessionOptions other)
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x50AFF0", Offset = "0x5095F0", VA = "0x18050AFF0", Slot = "5")]
		public void Set(ref EndPlayerSessionOptions? other)
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x50AF90", Offset = "0x509590", VA = "0x18050AF90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x4")]
		private EndPlayerSessionOptionsAccountIdInternal m_AccountId;
	}
}
