using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005B2 RID: 1458
	[Token(Token = "0x20005B2")]
	internal struct FinalizeInviteOptionsInternal : ISettable<FinalizeInviteOptions>, IDisposable
	{
		// Token: 0x17000ADC RID: 2780
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ADC")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002568")]
			[Address(RVA = "0x55ADF0", Offset = "0x5593F0", VA = "0x18055ADF0")]
			set
			{
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ADD")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002569")]
			[Address(RVA = "0x55AD90", Offset = "0x559390", VA = "0x18055AD90")]
			set
			{
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ADE")]
		public Utf8String CustomInviteId
		{
			[Token(Token = "0x600256A")]
			[Address(RVA = "0x55AD30", Offset = "0x559330", VA = "0x18055AD30")]
			set
			{
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ADF")]
		public Result ProcessingResult
		{
			[Token(Token = "0x600256B")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600256C")]
		[Address(RVA = "0x55AAA0", Offset = "0x5590A0", VA = "0x18055AAA0", Slot = "4")]
		public void Set(ref FinalizeInviteOptions other)
		{
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x55ABB0", Offset = "0x5591B0", VA = "0x18055ABB0", Slot = "5")]
		public void Set(ref FinalizeInviteOptions? other)
		{
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x55AA30", Offset = "0x559030", VA = "0x18055AA30", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x04001097 RID: 4247
		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001098 RID: 4248
		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_CustomInviteId;

		// Token: 0x04001099 RID: 4249
		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0x20")]
		private Result m_ProcessingResult;
	}
}
